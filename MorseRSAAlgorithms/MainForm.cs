using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MorseRSAAlgorithms
{
    public partial class MainForm : Form
    {
        #region Variables
        // RSA Variables
        int p;
        int q;
        Tuple<int, int> pub_keys;
        Tuple<int, int> pri_keys;
        string encrypted_message;
        string decrypted_message;

        // Morse Code Variables
        string text;
        string morse;
        char[] letters = { ' ', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u',
                'v', 'w', 'x', 'y', 'z', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
        string[] morseLetters = { "/", ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...",
                "-", "..-", "...-", ".--", "-..-", "-.--", "--..", ".----", "..---", "...--", "....-", ".....", "-....", "--...", "---..", "----.", "-----" };


        #endregion

        #region Quality of Life Methods

        public static bool checkPrime(int value)
        {
            if (value == 1) return false;
            if (value == 2) return true;
            if (value % 2 == 0) return false;

            var limit = Math.Ceiling(Math.Sqrt(value));

            for (int i = 3; i <= limit; i++)
                if (value % i == 0)
                    return false;

            return true;
        }
        static char chr(int v)
        {
            return Convert.ToChar(v);
        }

        private void updateButton()
        {
            //buttonEncrypt.Enabled = textBoxP.Text != string.Empty && textBoxQ.Text != string.Empty;
           // buttonDecrypt.Enabled = textBoxP.Text != string.Empty && textBoxQ.Text != string.Empty;
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        #endregion

        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a test");
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            bool pValue = Int32.TryParse(textBoxP.Text, out int tempIntP);

            if (pValue == true)
            {
                p = tempIntP;
            }

            bool qValue = Int32.TryParse(textBoxQ.Text, out int tempIntQ);

            if (qValue == true)
            {
                q = tempIntQ;
            }

            if ((p > 10 && q > 10) && (p < 200 && q < 200))
            {
                if (checkPrime(p) == true && checkPrime(q) == true)
                {
                    pub_keys = RSAencrypt.get_public_private_key(p, q)[0];
                    pri_keys = RSAencrypt.get_public_private_key(p, q)[1];
                    labelKeySelect.Text = "Your public key is: " + pub_keys + ", your private key is: " + pri_keys;
                }
                else
                {
                    labelKeySelect.Text = "FourOFour: P and Q integers are not both prime numbers";
                }
            }
            else
            {
                labelKeySelect.Text = "FourOFour: P and Q integers are not both in specified range";
            }
            updateButton();
        }
    }
}
