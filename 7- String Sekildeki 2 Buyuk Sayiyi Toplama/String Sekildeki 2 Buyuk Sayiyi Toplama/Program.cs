using System;
using System.Diagnostics.CodeAnalysis;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string val1 = "99999999999999999999999999999999999999999999999999999999999999";
            string val2 = "999999999999999999999999999999999999999999999999999";
            Console.WriteLine(Sum(val1, val2));
        }



        public static string Sum(string val1, string val2)
        {
            if (val2.Length > val1.Length)
            {
                string val = val1;
                val1 = val2;
                val2 = val;
            }

            int[] valBir = new int[val1.Length];
            int[] valIki = new int[val2.Length];
            string result = "";
            for (int i = 0; i < val1.Length; i++)
            {
                string c = val1[i].ToString();
                valBir[i] = Convert.ToInt32(c);
            }
            for (int i = 0; i < val2.Length; i++)
            {
                string c = val2[i].ToString();
                valIki[i] = Convert.ToInt32(c);
            }

            int fark = val1.Length - val2.Length;
            for (int i = val2.Length - 1; i >= 0; i--)
            {
                if (valBir[i + fark] + valIki[i] < 10)
                    valBir[i + fark] = valIki[i] + valBir[i + fark];
                else if (valBir[i + fark] + valIki[i] > 10)
                {
                    valBir[i + fark] = (valIki[i] + valBir[i + fark]) % 10;
                    valBir[i + fark - 1] += 1;
                }
            }
            foreach (var num in valBir)
            {
                result += num.ToString();
            }
            return result;



        }
    }
}