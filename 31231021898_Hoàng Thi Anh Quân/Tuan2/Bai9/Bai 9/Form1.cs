using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Add a link for Calculator in the first half of LinkLabel 
            linkLabel2.Links.Add(0, "Launch Calculator".Length, "calc.exe ");
            //Add a link for C: Drive in 
            linkLabel3.Links.Add(linkLabel3.Text.IndexOf(
            "Open C: Drive"), "Open C: Drive".Length, "c:\\");
            //Autosize the control based on its contents 
            linkLabel2.AutoSize = true;
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
 
            linkLabel1.LinkVisited = true;            
            //Go to Windows Forms Community Website 
            System.Diagnostics.Process.Start("msedge.exe", "http://www.windowsforms.net");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        { 
            System.Diagnostics.Process.Start(
            e.Link.LinkData.ToString());
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(
            e.Link.LinkData.ToString());
        }
    }
}
