using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DaLinkO
{
   
    public class Broadcast
    {

        public string name { get; set; }
        private string CInfo;// 0 = USB, 1 = Wireless
        public Trigger trigger;
        public DeviceConnection connection;
        public Transmission transmission;

        //USB parameters

        public bool autoConnect;
        private string ConnectionStatusText; //
        public bool isSelected; //when selected is true it allows reporting to the main windows tbConsole
        public Form1 form1;
        
        private bool TransmitCheck; //allows transmission or not
        private string buttonConnectText; //text for the connect/disconnect button
        
        public Broadcast(Form1 f)
        {
            form1 = f;
            //form1.activeBeans.BeansAreUpdated += new ActiveBeansUpdatedHandler(BroadcastTrigger);
            ButtonConnectText="Connect";
            ConnectionStatusText = "disconnected";
            isSelected = true;
            transmitCheck = true;
            transmission = new Transmission();
        }

        //Actionable get-sets

        public string status  
        {
            get
            {
                return ConnectionStatusText;
            }
            set
            {
                ConnectionStatusText = value;
                form1.updateBroadcastsDGV();
            }
        }//when set, updates form1's broadcast datagridview with the status of the connection
        public string connectionInfo
        {
            get{

            if (connection.connectionType == 0)
            {
             CInfo = "USB, Port:" + connection.port + ", Baud:" + connection.baud ;
            }
            else if (connection.connectionType == 1)
            {
                CInfo = "Wireless";
            }
            else
            {
                CInfo = "unknown";
            }
                return CInfo;
            }
            
            set
            {
                CInfo = value;
            }

        }  //when get - creates a human readable string about the connection info.
        public string ButtonConnectText { 
                        get
            {
                return buttonConnectText;
            }
            set
            {
                buttonConnectText = value;
                form1.updateBroadcastsDGV();
            }
        } //returns the text to shon on form 1 btnConnect 
        public bool transmitCheck
        {
            get
            { return TransmitCheck; }
            set
            {
                TransmitCheck = value;
                form1.updateBroadcastsDGV();
            }
        }  //when true allows transmissions to occur


        //Methods
        public void BroadcastTrigger()
        {
            if (connection != null)
            {
                connection.TriggeredSendThings(transmission.ProvideTransmission); // + form1.activeBeans.bActive.Bean[0].BeanElement[0].Value);//force sending this element just for testing purposes.
            }
        } //triggers transmission of data to microcontroller
        public void btnConnectClick()
        {
            if (buttonConnectText == "Connect")
            {
                status = "Connecting";
                connection.Connect();
            }
            else
            {
                connection.Disconnect();
                status = "disconnected";
            }
            form1.updateBroadcastsDGV();
        }   //starts or stops the connection
        public void transmitClick()
        {
            if (transmitCheck == true)
            {
                transmitCheck = false;
            }
            else
            {
                transmitCheck = true;
            }
            
        } //when the SEND CHECKBOX on the main for is clicked
        public void forceSendString(string outgoing)
        {
            
            connection.ForceSendThings(CVRT.getBytes(outgoing));
            form1.updateConsole("sent:" + outgoing+Environment.NewLine);
        }//For sending console commands
        public void DeleteBroadcast()  //not sure if this is enough, maybe need to force dispsal?
        {
            form1.activePacks.packsAreUpdated -= new ActiveBeansUpdatedHandler(BroadcastTrigger);
            //connection.Disconnect(); //shouldn't need now that it is disposed
            trigger.Dispose();
            connection.Dispose();
            
        }
        public void EnterEditMode()
        {
            connection.Disconnect();
        }

    }

    public class Trigger : IDisposable
    {

        public int triggerType;
        private Broadcast parentBroadcast;
        public int interval { get; set; }
        Timer TriggerIntervalTimer;
        private bool _disposed;

        public Trigger(Broadcast pBroadcast, int trigType,int tick)
        {
            parentBroadcast=pBroadcast;

            triggerType = trigType;
            interval = tick;
            SetupTrigger();
            _disposed = false;
        }

        public void SetupTrigger()
        {
            if (triggerType == 0)//when data recieved - the hard one!
            {
                parentBroadcast.form1.activePacks.packsAreUpdated += new ActiveBeansUpdatedHandler(parentBroadcast.BroadcastTrigger);
                    
                //add event listener, compare by name bytes to the new bytes? probably have to re-tool the 
                //bean manager to allow either special triggers per each new type of data or else ill have to
                //individually log changes and have a bool that gets reset when the data read
                //MessageBox.Show("trigger type 0 -on data recieved- not yet working");
            }
            else if (triggerType == 1)//on an inteval timer
            {
                TriggerIntervalTimer = new Timer();
                TriggerIntervalTimer.Interval = interval;
                TriggerIntervalTimer.Tick += new EventHandler(this.TriggerIntervalTimer_Tick);
                TriggerIntervalTimer.Enabled = true;
                TriggerIntervalTimer.Start();

            }
            else
            { MessageBox.Show("trigger type 2- on clock- is not yet working"); }
        }

        private void TriggerIntervalTimer_Tick(object sender, EventArgs e)
        {
            parentBroadcast.BroadcastTrigger();
        }
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
                    if (TriggerIntervalTimer != null)
                    {
                        TriggerIntervalTimer.Dispose();
                    }
                    if (triggerType == 0)
                    {
                        parentBroadcast.form1.activePacks.packsAreUpdated -= new ActiveBeansUpdatedHandler(parentBroadcast.BroadcastTrigger);
                    }
                }

                // Free unmanaged resources.

                // Indicate that the instance has been disposed.
                _disposed = true;
            }
        }


    }
}
