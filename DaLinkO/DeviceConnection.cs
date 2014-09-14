using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DaLinkO
{
    [Serializable]
    public class DeviceConnection :IDisposable
    {
        [NonSerialized]SerialPort _mySerialPort;
        public bool isConnected;
        [NonSerialized]public Form1 form1;
        string RxString;
        Broadcast parentBroadcast;
        public int connectionType;
        public string port;
        public int baud;
        private bool _disposed;


        public DeviceConnection(int ct, string Port, int Baud, Broadcast b)
        {
            isConnected = false;
            connectionType=ct;
            parentBroadcast = b;
            form1 = b.form1;
            port = Port;
            baud = Baud;
            SetupSerialPort();
            
            _disposed = false;
        } //USB connection constructor

        public void SetupSerialPort()
        {
            _mySerialPort = new SerialPort();

            _mySerialPort.PortName = port;
            _mySerialPort.BaudRate = baud;
        }

        //Primary public methods
        public void TriggeredSendThings(byte[] toSend)
        {
            if (isConnected == true && parentBroadcast.transmitCheck==true)
            {
                
                if (connectionType == 0)
                {
                    //byte[] bytesOut = CVRT.GetBytes(incoming);
                    USBwrite(toSend);
                }
            }
        } //sends the recieved string to the microcontroller via whatever connection is established
        public void ForceSendThings(byte[] toSend)
        {
            if (isConnected == true)
            {

                if (connectionType == 0)
                {
                    //byte[] bytesOut = CVRT.GetBytes(incoming);
                    USBwrite(toSend);
                }
            }
        }
        public void Connect()
        {
            if (connectionType == 0)
            {

                try
                {
                    _mySerialPort.Open();
                    _mySerialPort.DtrEnable = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                if (_mySerialPort.IsOpen)
                {
                    form1.updateConsole("port:" + _mySerialPort.PortName +
                    " is open" + Environment.NewLine);
                    isConnected = true;
                    parentBroadcast.status = "connected";
                    parentBroadcast.ButtonConnectText = "Disconnect";
                }
                _mySerialPort.DataReceived += new SerialDataReceivedEventHandler(_mySerialPort_DataReceived);
            }
            else
            {
                parentBroadcast.status = "connection not supported yet";
            }
        } //starts the connetion
        public void Disconnect()
        {
            if (connectionType == 0)
            {
                if (_mySerialPort.IsOpen)
                {
                    isConnected = false;
                    parentBroadcast.ButtonConnectText = "Connect";
                    _mySerialPort.DataReceived -= new SerialDataReceivedEventHandler(_mySerialPort_DataReceived);
                    //_mySerialPort.DtrEnable = false;
                    _mySerialPort.Close();

                }
            }

        }  //stops the connection
       
        //USB specific methods
        private void _mySerialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            
            
            if (parentBroadcast.isSelected == true)
            {
                try
                {
                    RxString = _mySerialPort.ReadExisting();
                    form1.updateConsole(RxString);
                }
                catch(Exception ex)
                    {
                        form1.updateConsole(ex.Message);
                    }
                
            }
            
        } //when in USB mode this listens to responses and manages the distribution of incoming data
        private void USBwrite(byte[] incoming)
        {
            if (_mySerialPort.IsOpen)
            {
                _mySerialPort.Write(incoming, 0, incoming.Length);
                
            }
        } //Handles USB writing.

        public void Dispose()
        {
            Dispose(true);

            // Call SupressFinalize in case a subclass implements a finalizer.
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                // If you need thread safety, use a lock around these  
                // operations, as well as in your methods that use the resource. 
                if (disposing)
                {
                    // Free the necessary managed disposable objects. 
                    _mySerialPort.Dispose();
                }

                // Free unmanaged resources.

                // Indicate that the instance has been disposed.
                _disposed = true;
            }
        }

    }
}
