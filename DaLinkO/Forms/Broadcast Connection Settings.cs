using DaLinkO.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DaLinkO
{
    public partial class Broadcast_Connection_Settings : Form
    {
        private string name;
        private int connectionType; // 0 = USB, 1 = Wireless
        private int trigger; //0 = on new data, 1 = on set interval, 2 = on a schedule
        private int trigInterval;
        private int baud;
        private string port;
        private bool autoConnect;
        private bool newChecker; //checks whether it's a brand new broadcast or in edit mode.
        Broadcast broadcast;


        public Form1 form1;

        //constructor overloads
        public Broadcast_Connection_Settings(Form1 mf) // create new mode. will overload this for the edit mode.
        {
            InitializeComponent();

            timerTransmissionDGVUpdater.Interval = 50;
            timerTransmissionDGVUpdater.Start();

            //setup USB port boxes
            string[] serialPorts = System.IO.Ports.SerialPort.GetPortNames();
            cbUSBPort.Items.AddRange(serialPorts);
            cbUSBBaud.Items.Add(2400);
            cbUSBBaud.Items.Add(4800);
            cbUSBBaud.Items.Add(9600);
            cbUSBBaud.Items.Add(14400);
            cbUSBBaud.Items.Add(19200);
            cbUSBBaud.Items.Add(28800);
            cbUSBBaud.Items.Add(38400);
            cbUSBBaud.Items.Add(57600);
            cbUSBBaud.Items.Add(115200);

            //cbUSBPort.SelectedIndex = 0;
            cbUSBBaud.SelectedIndex = 8;

            form1 = mf;
            //setting defaults

            //connectionType = 0;
            //triggerCheck();
            newChecker = true;
            broadcast = new Broadcast(form1);
            TElement_Constant triggerElement = new TElement_Constant("trigger", CVRT.getBytes("#"));
            broadcast.transmission.AddTElement(triggerElement);
            dgvTransmission.AutoGenerateColumns = false;
            this.dgvTransmission.DataSource = broadcast.transmission.TElementList;
        }
        public Broadcast_Connection_Settings(Form1 mf, Broadcast brdIn) // edit an incoming broadcast
        {
            InitializeComponent();
            broadcast = brdIn;
            newChecker = false;
            broadcast.EnterEditMode();

            timerTransmissionDGVUpdater.Interval = 50;
            timerTransmissionDGVUpdater.Start();

            //setup USB port boxes
            string[] serialPorts = System.IO.Ports.SerialPort.GetPortNames();
            cbUSBPort.Items.AddRange(serialPorts);
            cbUSBBaud.Items.Add(2400);
            cbUSBBaud.Items.Add(4800);
            cbUSBBaud.Items.Add(9600);
            cbUSBBaud.Items.Add(14400);
            cbUSBBaud.Items.Add(19200);
            cbUSBBaud.Items.Add(28800);
            cbUSBBaud.Items.Add(38400);
            cbUSBBaud.Items.Add(57600);
            cbUSBBaud.Items.Add(115200);

            cbUSBPort.SelectedIndex = 0;
            cbUSBBaud.SelectedIndex = 8;

            form1 = mf;

            dgvTransmission.AutoGenerateColumns = false;
            //this.dgvTransmission.DataSource = broadcast.transmission.TElementList;
            setFormFromBroadcast();//has to occur after the datasource is bound
        }

        //sets up the form when in edit mode
        private void setFormFromBroadcast() 
        {
            //this takes the settings from an incoming broadcast and updates
            //the form controls to match

            //name text box
            name = broadcast.name;
            tbName.Text = name;

            //connection type
            if (broadcast.connection.connectionType == 0)
            { rbUSB.Checked = true;
            port = broadcast.connection.port;
            baud = broadcast.connection.baud;

            cbUSBPort.SelectedItem = port;
            cbUSBBaud.SelectedItem = baud;
            }
            else if (broadcast.connection.connectionType ==1)
            { rbWireless.Checked = true; }
            

            //trigger
            if (broadcast.trigger.triggerType == 0 )
            { rbTrigOnDataRecieved.Checked = true; }
            else if (broadcast.trigger.triggerType == 1)
            { rbTrigOnTimer.Checked = true;
            if (broadcast.trigger.interval < 1000000 && broadcast.trigger.interval > 49)
            {
                numUpDnTriggerInteval.Value = broadcast.trigger.interval;
            }
            }
            else if (broadcast.trigger.triggerType == 2)
            { rbTrigOnClock.Checked = true; }
            

            //autoconnect checkbox
            if (broadcast.autoConnect==true)
            {cbAutoCnctOnDataVis.Checked=true;}
            else { cbAutoCnctOnDataVis.Checked = false; }

            this.dgvTransmission.AutoGenerateColumns = false;
            this.dgvTransmission.DataSource = this.broadcast.transmission.TElementList;

        }

        //Checks and sets for variables and control states
        private void triggerCheck()
        {
            if (rbTrigOnDataRecieved.Checked == true)
            {
                trigger = 0;
            }
            else if (rbTrigOnTimer.Checked == true)
            {
                trigger = 1;
                trigInterval = (int)numUpDnTriggerInteval.Value;
            }
            else
            {
                trigger = 2;
            }
        }
        private void connectionCheck()
        {
            if (rbUSB.Checked == true) //get the connection type and set the info accordingly
            {
                connectionType = 0;
                baud = (int)cbUSBBaud.SelectedItem;
                if (cbUSBPort.SelectedItem != null)
                {

                    port = cbUSBPort.SelectedItem.ToString();
                }
            }
            else if (rbWireless.Checked == true)
            {
                connectionType = 1;
            }
            else
            {
                connectionType = 2;
            }

        }
        private void rbWireless_CheckedChanged(object sender, EventArgs e)
        {
                cbWireless.Enabled=true;
                cbUSBPort.Enabled = false;
                cbUSBBaud.Enabled = false;
                connectionType = 1;
        }
        private void rbUSB_CheckedChanged(object sender, EventArgs e)
        {
                cbWireless.Enabled = false;
                cbUSBPort.Enabled = true;
                cbUSBBaud.Enabled = true;
                connectionType = 0;
        }
        private void rbTrigOnTimer_CheckedChanged(object sender, EventArgs e)
        {
            numUpDnTriggerInteval.Enabled = true;
            btnConfigureClockTrigger.Enabled = false;
        }
        private void rbTrigOnClock_CheckedChanged(object sender, EventArgs e)
        {
            numUpDnTriggerInteval.Enabled = false;
            btnConfigureClockTrigger.Enabled = true;

        }
        private void rbTrigOnDataRecieved_CheckedChanged(object sender, EventArgs e)
        {
            numUpDnTriggerInteval.Enabled = false;
            btnConfigureClockTrigger.Enabled = false;
        }
        public void UpdateTransDGV()
        {

            //dgvTransmission.DataBindings

            this.Invoke((MethodInvoker)delegate()
            {
                this.dgvTransmission.Refresh();
            });

        }


        //Controls - Button clicks
        private void btnSave_Click(object sender, EventArgs e)
        {
            name = tbName.Text;

            //Creates a new trigger every time

            triggerCheck();
            


            if (name == "") //cancels the save op if there is no name
            {
                MessageBox.Show("Broadcasts must have names!");
            }
            else if (cbUSBPort.SelectedItem == null)
            {
                MessageBox.Show("Select a port");
            }
            else
            {
                broadcast.name = name;

                Trigger newTrigger = new Trigger(broadcast, trigger, trigInterval);
                //creates a new connection every time
                connectionCheck();

                DeviceConnection newConnection = new DeviceConnection(connectionType, port, baud, broadcast, form1);
                autoConnect = cbAutoCnctOnDataVis.Checked;


                if (newChecker == true)//For new broadcasts
                {
                    broadcast.trigger = newTrigger;
                    broadcast.connection = newConnection;
                    form1.addBroadcast(broadcast);
                }
                else //For editing existing broadcasts
                {
                    broadcast.trigger.Dispose(); //the form is setup per the old trigger but then it is disposed to get rid of any old timer events
                    broadcast.trigger = newTrigger;

                    broadcast.connection.Dispose();
                    broadcast.connection = newConnection;
                }


                form1.updateBroadcastsDGV();
                this.Close();
            }
        }
        private void btnFormatData_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in dgvTransmission.SelectedRows)
            {
                TElement_Constant selectedTE = row.DataBoundItem as TElement_Constant; //gets the selected element
                
                if (selectedTE != null) //not sure if this is necessary
                {

                    using (var form = new CharEntry(selectedTE))
                    {
                        form.ShowDialog();
                        this.UpdateTransDGV();

                    }
                }
            }
        }
        private void btnInsertConstant_Click(object sender, EventArgs e)
        {

            //using (var form = new CharEntry())
            using (var form = new ConstantPicker())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    TElement constant = form.ConstantElement;
                    broadcast.transmission.AddTElement(constant);
                    this.UpdateTransDGV();

                }
                else if (result == DialogResult.Cancel)
                {

                }
            }

        }
        private void btnClearAll_Click(object sender, EventArgs e)
        {
            broadcast.transmission.TElementList.Clear();
            this.UpdateTransDGV();
        }
        private void btnCheckTransmission_Click(object sender, EventArgs e)
        {
            MessageBox.Show(CVRT.getString(broadcast.transmission.ProvideTransmission));
            //MessageBox.Show(CVRT.GetIntAsString(broadcast.transmission.ProvideTransmission));
            this.UpdateTransDGV();
        }
        private void btnAddData_Click(object sender, EventArgs e)
        {
            using (var form = new DataPicker(form1.activePacks))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    TElement dataElement = form.dataElement;
                    broadcast.transmission.AddTElement(dataElement);
                    this.UpdateTransDGV();

                }
                else if (result == DialogResult.Cancel)
                {

                }
            }




        }
        private void btnMoveUp_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvTransmission.SelectedRows)
            {
                TElement selectedTE = row.DataBoundItem as TElement; //gets the selected element

                if (selectedTE != null) //not sure if this is necessary
                {
                    int indexOfElement = broadcast.transmission.TElementList.IndexOf(selectedTE);
                    if (indexOfElement > 0)
                    {

                        this.broadcast.transmission.TElementList.RemoveAt(indexOfElement);
                        this.broadcast.transmission.TElementList.Insert(indexOfElement - 1, selectedTE);
                        dgvTransmission.Rows[indexOfElement - 1].Selected = true;
                        this.UpdateTransDGV();
                    }
                    
                }
            }
        }
        private void btnMoveDown_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvTransmission.SelectedRows)
            {
                TElement selectedTE = row.DataBoundItem as TElement; //gets the selected element

                if (selectedTE != null) //not sure if this is necessary
                {
                    int indexOfElement = broadcast.transmission.TElementList.IndexOf(selectedTE);
                    if (indexOfElement +1 < this.broadcast.transmission.TElementList.Count)
                    {

                        this.broadcast.transmission.TElementList.RemoveAt(indexOfElement);
                        this.broadcast.transmission.TElementList.Insert(indexOfElement + 1, selectedTE);
                        dgvTransmission.Rows[indexOfElement + 1].Selected = true;
                        this.UpdateTransDGV();
                    }

                }
            }
        }
        private void btnRemoveData_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvTransmission.SelectedRows)
            {
                TElement selectedTE = row.DataBoundItem as TElement; //gets the selected element

                if (selectedTE != null) //not sure if this is necessary
                {
                    int indexOfElement = broadcast.transmission.TElementList.IndexOf(selectedTE);

                        this.broadcast.transmission.TElementList.RemoveAt(indexOfElement);
                        this.UpdateTransDGV();

                }
                
            }
        }


        //special stuff timers, delegates and such
        private void timerTransmissionDGVUpdater_Tick(object sender, EventArgs e)
        {
            this.dgvTransmission.SuspendLayout();
            dgvTransmission.Refresh();
            this.dgvTransmission.ResumeLayout();
            
        }
        private void dgvTransmission_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {

            this.dgvTransmission.Rows[e.RowIndex].Cells[0].Value
                 = (e.RowIndex + 1).ToString(); //creates an index number on the left hand column for referencing elements

            tbTotalBytes.Text = broadcast.transmission.GetByteCount().ToString();

        }

    }
}
