using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Challenges
{
    public class Exercise3
    {
        public Exercise3()
        {
            int[] arrNumbers = new int[] { 1, 4, 4, 4, 3, 3, 2, 2, 2, 5 };

            int numMostRepeated = NumMostRepeated(arrNumbers);

            Console.WriteLine("Most number repeats: {0}", numMostRepeated);
        }


        private int NumMostRepeated(int[] arrNumbers)
        {
            int[] numbers_unique = arrNumbers.Distinct().ToArray();

            int[,] numeros_repeats = new int[numbers_unique.Length, 2];

            for (int i = 0; i < numbers_unique.Length; i++)
            {
                numeros_repeats[i, 0] = numbers_unique[i];
                numeros_repeats[i, 1] = CountRepeats(arrNumbers, numbers_unique[i]);
            }

            return GetMostRepeated(numeros_repeats);

        }


        private int CountRepeats(int[] arreglo, int numero)
        {
            int count = 0;

            for (int i = 0; i < arreglo.Length; i++)
            {
                if (arreglo[i] == numero)
                {
                    count++;
                }
            }

            return count;
        }


        private int GetMostRepeated(int[,] arrNumbers)
        {
            int number_most_repeats = int.MaxValue;

            int value_most_repeats = 0;

            for (int i = 0; i < arrNumbers.GetLength(0); i++)
            {
                if (arrNumbers[i, 1] >= value_most_repeats)
                {
                    if (arrNumbers[i, 1] > value_most_repeats)
                    {
                        value_most_repeats = arrNumbers[i, 1];
                        number_most_repeats = arrNumbers[i, 0];
                    }
                    else
                    {
                        if (arrNumbers[i, 0] <= number_most_repeats)
                        {
                            value_most_repeats = arrNumbers[i, 1];
                            number_most_repeats = arrNumbers[i, 0];
                        }
                    }
                }
            }

            return number_most_repeats;

        }

    }
}
