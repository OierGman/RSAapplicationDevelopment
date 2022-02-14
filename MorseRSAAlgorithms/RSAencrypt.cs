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
