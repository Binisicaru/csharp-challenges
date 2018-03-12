using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Challenges
{
    public class Exercise2
    {
        public Exercise2()
        {
            Console.WriteLine("abccba: " + IsCasiPalindromo("abccba"));
            Console.WriteLine("abccbx: " + IsCasiPalindromo("abccbx"));
            Console.WriteLine("abccfg: " + IsCasiPalindromo("abccfg"));
        }

        private bool IsCasiPalindromo(string cadena)
        {
            int mistakes = 0;
            bool isPalindromo = false;

            for (int i = 0; i < cadena.Length / 2; i++)
            {
                if (!cadena[i].Equals(cadena[cadena.Length - 1 - i]))
                {
                    mistakes++;
                }
            }

            if (mistakes == 0)
            {
                isPalindromo = true;
            }
            else if (mistakes == 1)
            {
                isPalindromo = true;
            }
            else
            {
                isPalindromo = false;
            }

            return isPalindromo;

        }

    }
}
