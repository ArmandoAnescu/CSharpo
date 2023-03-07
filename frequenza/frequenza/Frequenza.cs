using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frequenza
{
    class Program
    {
        static void Main(string[] args)
        {
            int tasto;
            string frase = " ", lettera = " ";
            int[] alfabeto = new int [28];
            Console.WriteLine("Inserisci una frase");
            do
            {
                tasto = Convert.ToInt32(Console.Read());
                frase = Convert.ToString(tasto);
                if (tasto >= 65 && tasto <= 90)
                {
                    for (int i = 0; i < alfabeto.Length - 2; i++)
                    {
                        if (tasto == 65 + i)
                        {
                            alfabeto[i]++;
                        }
                    }
                }
                else if (tasto >= 48 || tasto <= 57)
                {
                    alfabeto[26]++;
                    
                }
            } while (tasto != 13);
            for (int i = 0; i < alfabeto.Length-1; i++)
            {
                if (alfabeto[i] != 0)
                {
                    lettera = Convert.ToString(tasto);
                    Console.WriteLine($"La lettera {Convert.ToChar(65 + i)} compare: {alfabeto[i]} volte");
                }
                
            }
            Console.ReadLine();
            Console.ReadLine();
        }
    }
}
