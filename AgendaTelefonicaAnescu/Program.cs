using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaTelefonicaAnescu
{
    class Program
    {
        static void Main(string[] args)
        {
            int opzione;
            const int maxOpzione = 3, maxNumeri = 5;
            string[] nomiRubrica = new string[5];
            long[] rubrica = new long[5];

            do
            {
                // scelta dell'opzione
                do
                {
                    Console.Clear();
                    Console.WriteLine("===Rubrica Telefonica===");
                    Console.WriteLine("[1] inserimento numeri");
                    Console.WriteLine("[2] Visualizza contatti");
                    Console.WriteLine("[{0}] esci", maxOpzione);
                    opzione = Convert.ToInt32(Console.ReadLine());
                } while (opzione < 1 || opzione > maxOpzione);
                switch (opzione)
                {
                    case 1:
                        int n = maxNumeri;
                        for (int j = 0; j < maxNumeri; j++)
                        {
                            Console.WriteLine("Puoi inseire ancora:{0} numeri", n);
                            Console.WriteLine("Inserisci il nome della persona da salvare in rubrica");
                            nomiRubrica[j] = Console.ReadLine();
                            Console.WriteLine("Inserisci il numero da inserire");
                            rubrica[j] = Convert.ToInt64(Console.ReadLine());
                            n--;
                            Console.Clear();
                        }
                        Console.ReadLine();
                        break;
                    case 2:
                        for (int i = 0; i < maxNumeri; i++)
                        {
                            Console.WriteLine($"il {i + 1}° è: {nomiRubrica[i]} con numero {rubrica[i]}");
                        }
                        Console.ReadLine();
                        break;
                }
            } while (opzione != maxOpzione);
        }
    }
}
