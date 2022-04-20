using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MorseRSAAlgorithms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSendUser1_Click(object sender, EventArgs e)
        {
            listBoxUser1.Items.Add("User 1: " + richTextBoxUser1.Text);
        }
    }
}
