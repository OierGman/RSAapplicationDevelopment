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

            // Days contributed to python RSA:
            // 7.2.22, 8.2.22, 9.2.22, 10.2.22, 11.2.22
            // Total commits:
            // 20

            // https://github.com/OierGman/RSAencyption
            
            
            // RSA - Repeated squaring algorithm
            // Python solution to be converted to C#


            /*
            def gcd(x, y):
                while y != 0:
                    remainder = x % y
                    x = y
                    y = remainder
                return x


            def crypto(key, char):
                x, y = key
                expo = pow(ord(char), x)
                return int(expo % y)


            def string_to_list(string):
                new_list = []
                for i in string:
                    if i.isdigit():
                        new_list.append(i)
                return new_list


            def no_leading_zero(binary_list):
                while binary_list[0] == '0':
                    binary_list.remove(binary_list[0])
                return binary_list


            def remove_index_zero(a_list):
                a_list.remove(a_list[0])
                return a_list


            def exponent_algorithm(private_key, encrypted_char):
                exponential, n = private_key
                binary_list = remove_index_zero(no_leading_zero(string_to_list(bin(exponential))))
                x = encrypted_char
                for z in binary_list:
                    if z == '1':
                        i = x ** 2
                        x = (i * encrypted_char) % n
                    else:
                        x = pow(x, 2) % n
                return chr(x)
             */




            // Steps to RSA encryption in C#


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
