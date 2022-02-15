using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseRSAAlgorithms
{
    public class RSAencrypt
    {
        static int GCD(int a, int b)
        {
            int Remainder;

            while (b != 0)
            {
                Remainder = a % b;
                a = b;
                b = Remainder;
            }
            return a;
        }
        
        public static int crypto(Tuple<int, int> key, int character)
        {
            int expo = (int)Math.Pow(character, key.Item1);
            return expo % key.Item2;
        }
        
        static List<char> string_to_list(string s)
        {
            List<char> new_list = new List<char>();
            foreach (var i in s)
            { 
                new_list.Add(i);
            }
            return new_list;
        }

        static List<char> remove_index_zero(List<char> a_list)
        {
            a_list.Remove(a_list[0]);
            return a_list;
        }

        static string bin(int value)
        {
            return Convert.ToString(value, 2);
        }

        public static char exponent_algorithm(Tuple<int, int> key, double encrypted_char)
        {
            var binary_list = remove_index_zero(string_to_list(bin(key.Item1)));
            double x = encrypted_char;

            foreach (var z in binary_list)
            {
                if (z == '1')
                {
                    double i = Math.Pow(x, 2);
                    x = (i * encrypted_char) % key.Item2;
                }
                else
                {
                    x = Math.Pow(x, 2) % key.Item2;
                }
            }
            int unicode = Convert.ToInt32(x);
            return Convert.ToChar(unicode);
        }

        public static List<Tuple<int, int>> get_public_private_key(int p, int q)
        {
            int n = p * q;
            int T = (p - 1) * (q - 1);
            int e = 0;
            int d = 0;

            List<int> e_list = new List<int>();

            for (int j = 2; j < 50; j++)
            {
                if (GCD(j, T) == 1)
                {
                    e_list.Add(j);
                }
            }

            e = e_list[0];

            List<int> d_list = new List<int>();

            for (int i = 2; i < 1000000; i++)
            {
                if ((e * i) % T == 1)
                {
                    d_list.Add(i);
                }
            }

            d = d_list[1];

            Tuple<int, int> publicKey = new Tuple<int, int>(e, n);
            Tuple<int, int> privateKey = new Tuple<int, int>(d, n);

            List<Tuple<int, int>> keys = new List<Tuple<int, int>>()
            {
                publicKey,
                privateKey
            };

            return keys;
        }
    }
}
