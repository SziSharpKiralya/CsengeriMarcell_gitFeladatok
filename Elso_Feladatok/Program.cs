using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Elso_Feladatok
{
    internal class Program
    {
        static void F01(int[] tomb)
        {
            Random random = new Random();
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = random.Next(1, 51);
            }
        }

        static int F02(int[] tomb)
        {
            int szamlalo = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i]%2 == 0)
                {
                    szamlalo++;
                }
            }
            
            return szamlalo;
        }

        static double F03(int[] tomb)
        {
            double atlag = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] % 2 == 0)
                {
                    atlag += tomb[i];
                }
            }

            return atlag/tomb.Length;
        }

        static int[] F04(int[] tomb)
        { 

            int[] paratlan = new int[10];
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] % 2 == 0)
                {
                    paratlan[i] = (tomb[i] +1);
                }
                else
                {
                    paratlan[i] = tomb[i];
                }
            }

            return paratlan;
        }

        static void Main(string[] args)
        {
            int[] tomb = new int[10];
            F01(tomb);
            Console.WriteLine(F02(tomb));
            Console.WriteLine(F03(tomb));
            for (int i = 0;i < F04(tomb).Length; i++)
            {
                Console.Write(F04(tomb)[i] + ",");
            }
        }
    }
}
