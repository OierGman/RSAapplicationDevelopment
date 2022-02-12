using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MorseRSAAlgorithms
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());

 
            // Steps to RSA encryption
            /*
            // Assigning private and public keys for RSA encryption/decryption
            int p = 13;
            int q = 11;
            var n = p * q;

            // Euler Totient
            var T = (p - 1) * (q - 1);

            // Rules for e
            // - e must be less that T (6)
            // - e must be coprime with T (6) and N (14)
            var e = 0;

            // Rules for d
            // Two numbers where e = encription and d = decription that meet the rule of (e * d) % T = 1
            // Solve for d
            var d = 0;

            // N and e will be published as public key 
            // N and d will be kept secret as this is the private key

            // Solving e
            e += 2;
            while (GCD(e, T) != 1)
            {
                e++;
            }

            // Solving d
            // (e * d) = 1 % T
            d += 300;
            while ((e * d) % T != 1)
            {
                d--;
            }

            // Tuple for public and private keys
            Tuple<int, int> publicKey = new Tuple<int, int>(e, n);
            Tuple<int, int> privateKey = new Tuple<int, int>(d, n);
             */
             
        }
    }
}
