using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace MorseRSAAlgorithms
{
    public partial class MainForm : Form
    {
        #region Factual section
        #region Variables
        // RSA Variables
        int p;
        int q;
        Tuple<int, int> pub_keys;
        Tuple<int, int> pri_keys;
        List<int> encrypted_message = new List<int>();
        string encrypted_text;
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
            buttonEncryptDec.Enabled = textBoxP.Text != string.Empty && textBoxQ.Text != string.Empty;
            buttonEncryptSym.Enabled = textBoxP.Text != string.Empty && textBoxQ.Text != string.Empty;
            buttonDecrypt.Enabled = textBoxP.Text != string.Empty && textBoxQ.Text != string.Empty;
        }
        private void updateButtonApp()
        {
            buttonOpenApp.Enabled = textBoxDecrypted.Text != string.Empty;
        }
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        #endregion

        public MainForm()
        {
            InitializeComponent();
            updateButton();
            updateButtonApp();
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
                    labelAddKey.Text = "Your public key is: " + pub_keys + ", your private key is: " + pri_keys;
                    updateButton();
                    tabControlIntroduction.SelectTab(tabPage2);
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
        }

        private void buttonSaveFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            DialogResult result = saveFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string name = saveFileDialog1.FileName;
                File.WriteAllText(name, richTextBoxEncrypt.Text);
            }
        }


        #region Reset Buttons
        private void buttonSoftReset_Click(object sender, EventArgs e)
        {
            encrypted_message.Clear();
            encrypted_text = "";
            decrypted_message = "";
            text = "";
            morse = "";
            richTextBoxMain.ResetText();
            richTextBoxEncrypt.ResetText();
            textBoxDecrypted.ResetText();
        }

        private void buttonHardReset_Click(object sender, EventArgs e)
        {
            encrypted_message.Clear();
            encrypted_text = "";
            decrypted_message = "";
            text = "";
            morse = "";
            richTextBoxMain.ResetText();
            richTextBoxEncrypt.ResetText();
            textBoxDecrypted.ResetText();
            textBoxP.ResetText();
            textBoxQ.ResetText();
            labelKeySelect.Text = "";
            p = 0;
            q = 0;
            updateButton();
            tabControlIntroduction.SelectTab(tabPage1);
        }
        #endregion

        private void buttonEncryptDec_Click(object sender, EventArgs e)
        {
            richTextBoxEncrypt.ResetText();
            encrypted_message.Clear();

            foreach (char i in richTextBoxMain.Text)
            {
                var x = RSAencrypt.exponent_algorithm(pub_keys, i);
                encrypted_text += chr(RSAencrypt.exponent_algorithm(pub_keys, i));
                encrypted_message.Add(x);
            }

            foreach (int j in encrypted_message)
            {
                richTextBoxEncrypt.Text += j;
                richTextBoxEncrypt.Text += ' ';
            }
            
        }

        private void buttonEncryptSym_Click(object sender, EventArgs e)
        {
            richTextBoxEncrypt.ResetText();
            encrypted_text = "";

            foreach (char i in richTextBoxMain.Text)
            {
                encrypted_text += chr(RSAencrypt.exponent_algorithm(pub_keys, i));
            }
            richTextBoxEncrypt.Text += encrypted_text;
            
        }

        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            textBoxDecrypted.ResetText();
            decrypted_message = "";

            foreach (int i in encrypted_text)
            {
                decrypted_message += chr(RSAencrypt.exponent_algorithm(pri_keys, i));
            }
            textBoxDecrypted.Text = decrypted_message;
            updateButtonApp();
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            richTextBoxMain.Text = FileBrowse.fileImport();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBoxEncrypt.Text = FileBrowse.fileImport();
        }

        private void buttonToMorse_Click(object sender, EventArgs e)
        {
            richTextBoxEncrypt.Text = morseConverter.textToMorse(richTextBoxMain.Text, letters, morseLetters);
        }

        private void buttonToText_Click(object sender, EventArgs e)
        {
            textBoxDecrypted.Text = morseConverter.morseToText(richTextBoxEncrypt.Text, letters, morseLetters);
        }
        #endregion

        #region Messaging App
        #region variables
        string localPort = "20";
        string localIP;
        string remoteIp;
        string remotePort = "21";
        Socket sck;
        EndPoint epLocal, epRemote;
        byte[] buffer;
        RSACryptoServiceProvider RSA = new RSACryptoServiceProvider(1024);

        #endregion

        private string GetLocalIP()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return "127.0.0.1";
        }

        private void MessageCallBack(IAsyncResult aResult)
        {
            try
            {
                int size = sck.EndReceiveFrom(aResult, ref epRemote);
                if (size > 0)
                {
                    byte[] receivedData = new byte[128];

                    receivedData = (byte[])aResult.AsyncState;

                    ASCIIEncoding eEncoding = new ASCIIEncoding();
                    string receivedMessage = eEncoding.GetString(receivedData);

                    byte[] decryptedtext = RSAcryptoserviceprovider.Decryption(receivedData, RSA.ExportParameters(true), false);
                    string decryptString = Encoding.Default.GetString(decryptedtext);
                    listBoxMorse.Invoke(new Action(() => { listBoxMorse.Items.Add("User 1: " + morseConverter.textToMorse(decryptString, letters, morseLetters)); }));
                    listBoxRSA.Invoke(new Action(() => { listBoxRSA.Items.Add("User 1: " + receivedMessage); }));
                    listBoxRSA.Invoke(new Action(() => { listBoxRSA.Items.Add("      : " + decryptString); }));
                }
                buffer = new byte[128];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
        }

        private void buttonOpenApp_Click(object sender, EventArgs e)
        {
            mainTab.SelectTab(tabControlLogs);
            var user1 = new Form1();
            user1.passingRSA = RSA;
            user1.Show();

            sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            localIP = GetLocalIP();
            remoteIp = GetLocalIP();

            try
            {
                epLocal = new IPEndPoint(IPAddress.Parse(localIP), Convert.ToInt32(localPort));
                sck.Bind(epLocal);

                epRemote = new IPEndPoint(IPAddress.Parse(remoteIp), Convert.ToInt32(remotePort));
                sck.Connect(epRemote);

                buffer = new byte[128];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }
        #endregion
    }
}
