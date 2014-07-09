using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DaLinkO
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            //string version; 

            
            this.label1.Text = "DaLinkO alpha v" + Assembly.GetExecutingAssembly().GetName().Version.ToString(); ;



            LinkLabel.Link link = new LinkLabel.Link();
            link.LinkData = "http://www.dalinko.com/";
            linkLabel1.Links.Add(link);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData as string);
        }
    }
}
