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
    public partial class Form2 : Form
    {
        public string message;
        public string commsString
        {
            get { return message; }
            set { message = value; }
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonSendUser2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            listBoxUser2.Items.Add("User 1: " + message);
        }
    }
}
