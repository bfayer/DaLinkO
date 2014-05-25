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
    public partial class ConstantPicker : Form
    {
        //private bool editing;
        public TElement ConstantElement;

        public ConstantPicker(TElement t)
        {
            //editing = true;
            ConstantElement = t;
        }

        public ConstantPicker()
        {
            //editing = false;
            
            InitializeComponent();
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
            
            cbConstantType.Items.Add("int");
            cbConstantType.Items.Add("bool");
            cbConstantType.Items.Add("double");
            cbConstantType.Items.Add("sbyte");
            cbConstantType.Items.Add("short");
            cbConstantType.Items.Add("long");
            cbConstantType.Items.Add("byte");
            cbConstantType.Items.Add("ushort");
            cbConstantType.Items.Add("uint");
            cbConstantType.Items.Add("ulong");
            cbConstantType.Items.Add("char");


            cbConstantType.SelectedIndex = 0;
            

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //if (editing == false)
            //{
            //    //this.ConstantElement = new TElement_Constant(tbConstantName.Text, CVRT.GetBytes(tbCharacterInput.Text));

            //}
            //else
            //{
            //    //constantElement.elementName = tbConstantName.Text;
            //    //constantElement.elementBytes = CVRT.GetBytes(tbCharacterInput.Text);

            //}
            
            DE ConstantDataElement = new DE(tbConstantName.Text,cbConstantType.SelectedItem.ToString(),tbConstantValue.Text);
            
            this.ConstantElement = TElementFactory.TElementPicker(tbConstantName.Text, ConstantDataElement);
            

            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }


    }
}
