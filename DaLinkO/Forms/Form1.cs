using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DaLinkO
{

    public delegate void NewDataHandler();  //when new data is recieved by the server
    public delegate void ActiveBeansUpdatedHandler(); //when the active bean manager has updated the master list
    public delegate void NewSourceAddedHandler(); //When a new data source has been added
    

    public partial class Form1 : Form
    {

        public DataManager activePacks = new DataManager();
        PipeServer myPipeServer;
        
        BindingList<Broadcast> broadcasts = new BindingList<Broadcast>();
        BindingSource PackBind;
        BindingSource ItemBind;
        Broadcast selectedBroadcast;

        public Form1()
        {
            
            
            activePacks.newSourceData += new NewSourceAddedHandler(updateSourceDGV); 
            InitializeComponent();

            myPipeServer = new PipeServer(activePacks,this);
            timerUiRoughRefresh.Interval = 3000;
            timerUiRoughRefresh.Start();
            myPipeServer.PipeName = "dpipe";
            myPipeServer.Run();

            //setup combobox presets for the dbug tab
            cbTransmissionVersionExample.Items.Add("TV:1.00");
            cbTransmissionVersionExample.SelectedIndex = 0;

            //setting up source box bindings
            PackBind = new BindingSource();
            ItemBind = new BindingSource();


            //setting up dgv broadcast list
            dgvBroadcastList.AutoGenerateColumns = false;
            dgvSourceLiveData.AutoGenerateColumns = false;
            dgvSourceLog.AutoGenerateColumns = false;
            dgvBeanElementsLive.AutoGenerateColumns = false;
        }

        //Methods

        public void updateSourceDGV()  //updates the source dgv, mainly doing this to get the status to update every 3 seconds rather than live feed
        {
            this.Invoke((MethodInvoker)delegate()
            {
                PackBind.DataSource = activePacks.bActive.dataPacks;
                this.dgvSourceLog.DataSource= PackBind;
                PackBind.ResetBindings(false);
            });

        }
        public void reportToDebugTexbox(string p)
        {
            this.Invoke((MethodInvoker)delegate()
            {
                if (myPipeServer.debugMods == true)
                {
                    textBoxDebugMode.Text = p;
                }
            });
        }
        private void switchToModDebugMode()
        {
            myPipeServer.debugMods = true;
            myPipeServer.Run();
            activePacks.packsAreUpdated -= new ActiveBeansUpdatedHandler(refreshLiveData);
            timerUiFineRefresh.Stop();
        }
        private void switchToNormalMode()
        {
            myPipeServer.debugMods = false;
            myPipeServer.Run();
            buttonPauseDebug.Text = "Pause";
            updateSourceDGV();
            activePacks.packsAreUpdated -= new ActiveBeansUpdatedHandler(refreshLiveData);
            timerUiFineRefresh.Stop();
        }
        private void switchToLiveDataView()
        {
            myPipeServer.debugMods = false;
            myPipeServer.Run();

            PackBind.DataSource= activePacks.bActive.dataPacks;
            this.dgvSourceLiveData.DataSource = PackBind;


            if (dgvSourceLog.Rows.Count != 0)
            {
                DP SelectedBean = dgvSourceLog.Rows[0].DataBoundItem as DP;
                foreach (DataGridViewRow liveRow in dgvSourceLiveData.Rows)
                    if (liveRow.DataBoundItem == SelectedBean)
                    {
                        int i = liveRow.Index;
                        dgvSourceLiveData.Rows[i].Selected = true;
                    }
                ItemBind.DataSource = SelectedBean.dataElement;
                dgvBeanElementsLive.DataSource = ItemBind;

            }
            PackBind.ResetBindings(true);
            ItemBind.ResetBindings(true);
            timerUiFineRefresh.Start();
            //activePacks.packsAreUpdated += new ActiveBeansUpdatedHandler(refreshLiveData);
        }
        public void refreshLiveData()
        {
            this.Invoke((MethodInvoker)delegate()
            {
                if (dgvSourceLiveData.Rows.Count != 0)
                {

                    foreach (DataGridViewRow liveRow in dgvSourceLiveData.Rows)
                        if (liveRow.Selected == true)
                        {
                            DP hold = liveRow.DataBoundItem as DP;
                            ItemBind.DataSource = hold.dataElement;
                        }
                }
                dgvSourceLiveData.Refresh();
                dgvBeanElementsLive.Refresh();
            });
        }
        public void addBroadcast(Broadcast newBroadcast)
        {
            this.broadcasts.Add(newBroadcast);
            this.dgvBroadcastList.DataSource = broadcasts;

        }
        public void updateBroadcastsDGV()
        {
            //this is triggered when you save a broadcast after editing it in order to update the main list

            this.Invoke((MethodInvoker)delegate()
            {
                this.dgvBroadcastList.Refresh();
            });

        }
        public void updateConsole(string incoming)
        {
            this.Invoke((MethodInvoker)delegate()
            {
                textBoxConsole.AppendText(incoming);
                while (textBoxConsole.Lines.Count() > 3000)
                {
                    textBoxConsole.Text = textBoxConsole.Text.Remove(0, 1500);
                }

            });
        }

        //Button and control methods
        private void buttonClearVisibleSources_Click(object sender, EventArgs e)
        {
            //dgvSourceLog.Rows.Clear();
            dgvSourceLiveData.Rows.Clear();
            dgvBeanElementsLive.Rows.Clear();
            textBoxConsole.Text = null;
            //activeBeans.ClearBeans();
        }
        private void buttonCreateNewBroadcast_Click(object sender, EventArgs e)
        {
            using (Form CreatingNew = new Broadcast_Connection_Settings(this))
            {
            CreatingNew.ShowDialog();
            }
        }
        private void tabModes_Selected(object sender, TabControlEventArgs e)
        {
            if (tabModes.SelectedIndex == 0) //Normal tab is selected, switch to normal mode and activate stuff
            {
                switchToNormalMode();
                fileToolStripMenuItem.Enabled = true;
                editToolStripMenuItem.Enabled = true;
            }
            else if (tabModes.SelectedIndex == 1)
            {
                switchToModDebugMode();
                fileToolStripMenuItem.Enabled = false;
                editToolStripMenuItem.Enabled = false;

            }
            else
            {
                switchToLiveDataView();
                fileToolStripMenuItem.Enabled = false;
                editToolStripMenuItem.Enabled = false;
            }

        }
        private void cbTransmissionVersionExample_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedVersion = (string)cbTransmissionVersionExample.SelectedItem;
            if (selectedVersion == "TV:1.00")
            {
                textBoxBeanVersionExample.Text = Definitions.transmissionVersion01_00;
            }
        }
        private void buttonPauseDebug_Click(object sender, EventArgs e)
        {
            if (buttonPauseDebug.Text == "Pause")
            {
                myPipeServer.Stop();
                buttonPauseDebug.Text = "Resume";
            }
            else
            {
                myPipeServer.Run();
                buttonPauseDebug.Text = "Pause";
            }
        }
        private void menuAbout_Click(object sender, EventArgs e)
        {
            Form about = new About();
            about.Show();
        }
        private void dgvSourceLog_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //switches user to live data view with the selected datasource highlighted and reading out in the right column
            if (e.RowIndex != -1)
            {
                tabModes.SelectTab(2);
                switchToLiveDataView();
            }

        }
        private void btnEditBroadcast_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvBroadcastList.SelectedRows)
            {
                Broadcast selectedBroadcast = row.DataBoundItem as Broadcast;
                if (selectedBroadcast != null)
                {
                    Form EditSelected = new Broadcast_Connection_Settings(this, selectedBroadcast);
                    EditSelected.ShowDialog();
                }
            }
        }
        private void btnDeleteBroadcast_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvBroadcastList.SelectedRows)
            {
                Broadcast selectedBroadcast = row.DataBoundItem as Broadcast;
                if (selectedBroadcast != null)
                {
                    broadcasts.Remove(selectedBroadcast);
                    selectedBroadcast.DeleteBroadcast();
                    updateBroadcastsDGV();
                    textBoxConsole.Clear();
                }
            }

        }
        private void dgvSourceLiveData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                ItemBind.DataSource = activePacks.bActive.dataPacks[e.RowIndex].dataElement;
                this.dgvBeanElementsLive.DataSource = ItemBind;
                ItemBind.ResetBindings(false);
            }
        }
        private void dgvBroadcastList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 ) return; 
            if (selectedBroadcast == null)
            {
                textBoxConsole.Clear();
                selectedBroadcast = dgvBroadcastList.Rows[e.RowIndex].DataBoundItem as Broadcast;
                selectedBroadcast.isSelected = true;
            }
            else if(selectedBroadcast != dgvBroadcastList.Rows[e.RowIndex].DataBoundItem as Broadcast)
            {
                selectedBroadcast.isSelected = false;
                textBoxConsole.Clear();
                selectedBroadcast = dgvBroadcastList.Rows[e.RowIndex].DataBoundItem as Broadcast;
                selectedBroadcast.isSelected = true;
            }

            //If cell clicked is the button then do the button thing
            if (e.ColumnIndex ==
                dgvBroadcastList.Columns["ConnectionButton"].Index)
            {

                Broadcast clicked = dgvBroadcastList.Rows[e.RowIndex].DataBoundItem as Broadcast;
                clicked.btnConnectClick();
            
            }else if (e.ColumnIndex == dgvBroadcastList.Columns["Transmit"].Index)
            {
                Broadcast clicked = dgvBroadcastList.Rows[e.RowIndex].DataBoundItem as Broadcast;
                clicked.transmitClick();
            }
        }
        private void btnGenerateSketch_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvBroadcastList.SelectedRows)
            {
                Broadcast selectedBroadcast = row.DataBoundItem as Broadcast;
                if (selectedBroadcast != null)
                {
                    Form generateCode = new CodeGenerator(selectedBroadcast);
                    generateCode.Show();
                }
            }
        }

        //Events and timer ticks
        private void Form1_FormClosing(object sender, System.ComponentModel.CancelEventArgs e)
        {
         //   if (MessageBox.Show("Do you want to save your active profile?", "BeanCaster",
         //MessageBoxButtons.YesNo) == DialogResult.Yes)
         //   {
         //       // Cancel the Closing event from closing the form.
         //       e.Cancel = true;
         //       // Call method to save file...
         //   }
         //   else
         //   {
                Environment.Exit(0);
         //   }
        }
        private void timerUiRoughRefresh_Tick(object sender, EventArgs e)
        {
            Thread sourceDGVUpdate = new Thread(updateSourceDGV);
            sourceDGVUpdate.Start();
            //Thread brdcstUp = new Thread(UpdateBroadcastsDGV);
            //brdcstUp.Start();
            
        }
        private void tbConsoleInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (selectedBroadcast != null)
                {
                    selectedBroadcast.forceSendString(tbConsoleInput.Text);

                    tbConsoleInput.Clear();

                }
            }
        }
        private void timerUiFineRefresh_Tick(object sender, EventArgs e)
        {
            refreshLiveData();
        }









    }
}
