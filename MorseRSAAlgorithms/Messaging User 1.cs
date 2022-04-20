using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace MorseRSAAlgorithms
{
    public partial class Form1 : Form
    {
        public string comms;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSendUser1_Click(object sender, EventArgs e)
        {
            if (richTextBoxUser1.Text != "")
            { 
                listBoxUser1.Items.Add("User 1: " + richTextBoxUser1.Text);
                
                comms = richTextBoxUser1.Text;
                // this.ShowDialog = DialogResult.OK;
                // this.Hide();

                richTextBoxUser1.ResetText();
            }
        }
    }
}
