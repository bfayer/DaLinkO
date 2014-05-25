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
    public partial class CharEntry : Form
    {
        public byte[] characters { get; set; }
        public string constName { get; set; }
        public TElement_Constant constantElement;
        private bool editing = false;

        public CharEntry()
        {
            InitializeComponent();
            editing = false;
        }

        public CharEntry(TElement_Constant te) //pass a character TElement to this to begin in edit mode
        {
            InitializeComponent();
            editing = true;

            if (te != null)
            {
                constantElement = te;
                characters = te.elementBytes;
                constName = te.elementName;
                this.tbCharacterInput.Text = te.elementTextBytes;
                this.tbConstantName.Text = te.elementName;
            }
            else
            {
                MessageBox.Show("te incoming was null");
            }
        }



        private void btnOK_Click(object sender, EventArgs e)
        {
            if (editing == false)
            {
                this.constantElement = new TElement_Constant(tbConstantName.Text,CVRT.GetBytes(tbCharacterInput.Text));

            }
            else
            {
                constantElement.elementName = tbConstantName.Text;
                constantElement.elementBytes = CVRT.GetBytes(tbCharacterInput.Text);
                //this.constName = tbConstantName.Text;
                //this.characters = CVRT.GetBytes(tbCharacterInput.Text);
            }

            this.DialogResult = DialogResult.OK;
        }

        private void tbCharacterInput_KeyPress(object sender, KeyPressEventArgs e)//prevents user from using blank spaces
        {

            if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }

        }

    }
}
