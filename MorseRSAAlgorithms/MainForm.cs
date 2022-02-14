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
    public partial class MainForm : Form
    {
        int p;
        int q;
        Tuple<int, int> pub_keys;
        Tuple<int, int> pri_keys;
        string encrypted_message;
        string decrypted_message;

        static char ch(int v)
        {
            return Convert.ToChar(v);
        }
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
