using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            for (int i = 0; i < T; i++)
            {

                string S = Console.ReadLine();
                LetsReview(S);
            }
            Console.ReadKey();
        }
        static void LetsReview(string S)
        {
            string evenStr = "";
            string oddStr = "";

            for (int i = 0; i < S.Length; i++)
            {
                if (i % 2 == 0)
                    evenStr += S[i];
                else
                    oddStr += S[i];
            }

            Console.WriteLine($"{evenStr} {oddStr}");
        }
    }
 }

