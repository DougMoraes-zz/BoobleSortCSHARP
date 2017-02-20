using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lista = new int[5];

            Program.geraLista(lista);

            Program.BubbleSort(lista);

            Console.WriteLine("Sua lista organizada é: [{0}]", string.Join(", ", lista));
            Console.ReadLine();
        }

        private static void geraLista(int[] array)
        {
            Random randNum = new Random();

            for (int i = 0; i < 5; i++)
            {
                array[i] = randNum.Next(70);
            }

            Console.WriteLine("Sua lista inicial é: [{0}]", string.Join(", ", array));
        }

        private static void BubbleSort(int[] array)
        {
            int posterior = 0;

            for (int a = 0; a < array.Length; a++)
            {
                for (int b = 1; b < array.Length; b++)
                {
                   if (array[b] < array[b-1])
                   {
                        posterior = array[b-1];
                        array[b-1] = array[b];
                        array[b] = posterior;
                   }
                }
            }
        }
    }
}
