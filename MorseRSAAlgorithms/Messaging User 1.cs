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
using System.Security.Cryptography;

namespace MorseRSAAlgorithms
{
    public partial class Form1 : Form
    {
        string localPort = "21";
        string localIP;
        string remoteIp;
        string remotePort = "20";
        Socket sck;
        EndPoint epLocal, epRemote;
        byte[] encryptedtext;
        public RSACryptoServiceProvider RSA;

        public RSACryptoServiceProvider passingRSA
        {
            get { return RSA; }
            set { RSA = value; }
        }

        public Form1()
        {
            InitializeComponent();
        }

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

        private void Form1_Load(object sender, EventArgs e)
        {
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

                buttonSendUser1.Enabled = true;
                richTextBoxUser1.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonAddFileUser1_Click(object sender, EventArgs e)
        {
            richTextBoxUser1.Text = FileBrowse.fileImport();
        }

        private void listBoxUser1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonSendUser1_Click(object sender, EventArgs e)
        {
            try
            {
                System.Text.ASCIIEncoding enc = new System.Text.ASCIIEncoding();
                byte[] msg = new byte[128];
                msg = enc.GetBytes(richTextBoxUser1.Text);
                encryptedtext = RSAcryptoserviceprovider.Encryption(msg, RSA.ExportParameters(false), false);

                sck.Send(encryptedtext);
                listBoxUser1.Items.Add("You: " + richTextBoxUser1.Text);
                richTextBoxUser1.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
