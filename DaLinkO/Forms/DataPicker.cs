using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DaLinkO.Forms
{
    public partial class DataPicker : Form
    {
         BindingSource SourceBind;
         BindingSource ElementBind;
         DataManager activeBeans;
         public DE selectedDataElement;
         DP SelectedPack;
         public TElement dataElement { get; set; }

         private bool editing;


        public DataPicker(DataManager bm)
        {
            InitializeComponent();
            SourceBind = new BindingSource();
            ElementBind = new BindingSource();
            activeBeans = bm;
            editing = false;

            timerDataPickerRefresher.Interval = 50;
            timerDataPickerRefresher.Start();

            
            dgvElementList.AutoGenerateColumns = false;
            dgvSourceList.AutoGenerateColumns = false;

            SourceBind.DataSource = bm.bActive.dataPacks;
            this.dgvSourceList.DataSource = SourceBind;

            //pre-sets selections based on the first stuff at the top of the bean list
            selectNewPack();


            SourceBind.ResetBindings(true);
            ElementBind.ResetBindings(true);
            refreshLiveBeans();
            setName();

            //bm.BeansAreUpdated += new ActiveBeansUpdatedHandler(RefreshLiveBeans);

        }



        private void setName()
        {
            if (dgvElementList.Rows.Count != 0)
            {
                foreach (DataGridViewRow liveRow in dgvElementList.Rows)
                {
                    if (liveRow.Selected == true)
                    {
                        selectedDataElement = liveRow.DataBoundItem as DE;
                        tbDataName.Text = selectedDataElement.N;
                    }
                }
            }
        }

        public void refreshLiveBeans()
        {

                        SourceBind.DataSource = activeBeans.bActive.dataPacks;
                        this.dgvSourceList.DataSource = SourceBind;
                        SourceBind.ResetBindings(false);

                        if (dgvSourceList.Rows.Count != 0)
                        {
                            foreach (DataGridViewRow liveRow in dgvSourceList.Rows)
                                if (liveRow.Selected == true)
                                {
                                    DP highlightedBean = liveRow.DataBoundItem as DP;
                                    ElementBind.DataSource = highlightedBean.dataElement;
                                }
                        }
                        dgvElementList.Refresh();

        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (selectedDataElement == null)
            {
                this.DialogResult = DialogResult.Cancel;
            }
            else
            {


                if (editing == false)
                {
                    //C# Type	.Net type    	Signed? Bytes   Possible Values
                    //int	    System.Int32	Yes 	4	    -2147483648 to 2147483647
                    //bool	    System.Boolean	N/A	    1 / 2?	true or false, don'tknow when you would have 2 bytes though..
                    //double	System.Double	Yes	    8	    Approximately ±5.0 x 10-324 to ±1.7 x 10308 with 15 or 16 significant figures
                    //sbyte	    System.Sbyte	Yes	    1	    -128 to 127

                    //short	    System.Int16	Yes	    2	    -32768 to 32767
                    //long	    System.Int64	Yes	    8	    -9223372036854775808 to 9223372036854775807
                    //byte	    System.Byte	    No	    1	    0 to 255
                    //ushort	System.Uint16	No	    2   	0 to 65535
                    //uint	    System.UInt32	No  	4	    0 to 4294967295
                    //ulong	    System.Uint64	No	    8	    0 to 18446744073709551615
                    //float	    System.Single	Yes	    4	    Approximately ±1.5 x 10-45 to ±3.4 x 1038 with 7 significant figures
                    //decimal	System.Decimal	Yes	    12	    Approximately ±1.0 x 10-28 to ±7.9 x 1028 with 28 or 29 significant figures
                    //char	    System.Char	    N/A	    2	    Any Unicode character (16 bit)


                    if (selectedDataElement.T == "System.Int32")
                    {
                        this.dataElement = new TElement_Int32(tbDataName.Text, selectedDataElement);
                        this.dataElement.elementSourceName = SelectedPack.Src;
                        this.dataElement.modversion = SelectedPack.v;
                        this.DialogResult = DialogResult.OK;
                    }
                    else if (selectedDataElement.T == "System.Boolean")
                    {
                        this.dataElement = new TElement_Boolean(tbDataName.Text, selectedDataElement);
                        this.dataElement.elementSourceName = SelectedPack.Src;
                        this.dataElement.modversion = SelectedPack.v;
                        this.DialogResult = DialogResult.OK;
                    }
                    else if (selectedDataElement.T == "System.Double")
                    {
                        this.dataElement = new TElement_Double(tbDataName.Text, selectedDataElement);
                        this.dataElement.elementSourceName = SelectedPack.Src;
                        this.dataElement.modversion = SelectedPack.v;
                        this.DialogResult = DialogResult.OK;
                    }
                    else if (selectedDataElement.T == "System.SByte")
                    {
                        this.dataElement = new TElement_SByte(tbDataName.Text, selectedDataElement);
                        this.dataElement.elementSourceName = SelectedPack.Src;
                        this.dataElement.modversion = SelectedPack.v;
                        this.DialogResult = DialogResult.OK;
                    }
                        
                    else if (selectedDataElement.T == "System.Int16")
                    {
                        this.dataElement = new TElement_Int16(tbDataName.Text, selectedDataElement);
                        this.dataElement.elementSourceName = SelectedPack.Src;
                        this.dataElement.modversion = SelectedPack.v;
                        this.DialogResult = DialogResult.OK;
                    }
                    else if (selectedDataElement.T == "System.Int64")
                    {
                        this.dataElement = new TElement_Int64(tbDataName.Text, selectedDataElement);
                        this.dataElement.elementSourceName = SelectedPack.Src;
                        this.dataElement.modversion = SelectedPack.v;
                        this.DialogResult = DialogResult.OK;
                    }
                    else if (selectedDataElement.T == "System.Byte")
                    {
                        this.dataElement = new TElement_Byte(tbDataName.Text, selectedDataElement);
                        this.dataElement.elementSourceName = SelectedPack.Src;
                        this.dataElement.modversion = SelectedPack.v;
                        this.DialogResult = DialogResult.OK;
                    }
                    else if (selectedDataElement.T == "System.UInt16")
                    {
                        this.dataElement = new TElement_UInt16(tbDataName.Text, selectedDataElement);
                        this.dataElement.elementSourceName = SelectedPack.Src;
                        this.dataElement.modversion = SelectedPack.v;
                        this.DialogResult = DialogResult.OK;
                    }
                    else if (selectedDataElement.T == "System.UInt32")
                    {
                        this.dataElement = new TElement_UInt32(tbDataName.Text, selectedDataElement);
                        this.dataElement.elementSourceName = SelectedPack.Src;
                        this.dataElement.modversion = SelectedPack.v;
                        this.DialogResult = DialogResult.OK;
                    }
                    else if (selectedDataElement.T == "System.UInt64")
                    {
                        this.dataElement = new TElement_UInt64(tbDataName.Text, selectedDataElement);
                        this.dataElement.elementSourceName = SelectedPack.Src;
                        this.dataElement.modversion = SelectedPack.v;
                        this.DialogResult = DialogResult.OK;
                    }
                        // single and decimal don't seem to work out properly so for now I'm just going to leave them out.
                    //else if (selectedDataElement.T == "System.Single")
                    //{
                    //    this.dataElement = new TElement_Single(tbDataName.Text, selectedDataElement);
                    //    this.dataElement.elementSourceName = SelectedPack.Src;
                    //    this.dataElement.modversion = SelectedPack.v;
                    //    this.DialogResult = DialogResult.OK;
                    //}
                    //decimal??
                    else if (selectedDataElement.T == "System.Char")
                    {
                        this.dataElement = new TElement_Char(tbDataName.Text, selectedDataElement);
                        this.dataElement.elementSourceName = SelectedPack.Src;
                        this.dataElement.modversion = SelectedPack.v;
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("incompatible data type");
                    }

                }
                else
                {
                    dataElement.elementName = tbDataName.Text;
                    this.DialogResult = DialogResult.OK;
                }

                
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            
        }
        private void dgvElementList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            setName();
        }
        private void dgvSourceList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectNewPack();
        }

        private void selectNewPack()
        {
            if (dgvSourceList.Rows.Count != 0)
            {
                SelectedPack = dgvSourceList.Rows[0].DataBoundItem as DP;

                ElementBind.DataSource = SelectedPack.dataElement;
                dgvElementList.DataSource = ElementBind;
                if (dgvElementList.Rows.Count != 0)//pre-selects the first element at the top of the element list
                {
                    selectedDataElement = dgvElementList.Rows[0].DataBoundItem as DE;

                }

            }

            ElementBind.ResetBindings(true);
            refreshLiveBeans();
            if (dgvElementList.Rows.Count != 0)
            {
                dgvElementList.Rows[0].Selected = true;
            }
            setName();
        }

        private void btnRefreshList_Click(object sender, EventArgs e)
        {
            refreshLiveBeans();

        }

        private void timerDataPickerRefresher_Tick(object sender, EventArgs e)
        {
            dgvSourceList.Refresh();
            dgvElementList.Refresh();
        }


        
    }
}
