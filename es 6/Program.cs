using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es_6
{
    class Program
    {
        static void Main(string[] args)
        {
            float spesaToT = 0, spesaSconto5 = 0, spesaSconto6 = 0, spesaSconto7 = 0, spesaSconto10 = 0;
            string spesaStringa;
            Console.WriteLine("Sei arrivato in cassa. Inserisci l'importo totale da pagare");
            spesaStringa = Console.ReadLine();
            if (spesaStringa == " ")
            {
                Console.WriteLine("Hai premuto invio per erroe");
            }
            Console.WriteLine("Inserisci la tua spesa");
            spesaToT = Convert.ToSingle(Console.ReadLine());
            if (spesaToT == 0)
            {
                Console.WriteLine("Hai inserito un valore non valido");
            }
            else
            {
                if (spesaToT < 50)
                {
                    Console.WriteLine("Sconto del 5% applicato");
                    spesaSconto5 = spesaToT * 5 / 100;
                }
                else if (spesaToT < 65)
                {
                    Console.WriteLine("Sconto del 6% applicato");
                    spesaSconto6 = spesaToT * 6 / 100;
                }
                else if (spesaToT < 80)
                {
                    Console.WriteLine("Sconto del 7% applicato");
                    spesaSconto7 = spesaToT * 7 / 100;
                }
                else if (spesaToT > 80)
                {
                    Console.WriteLine("Sconto del 10% applicato");
                    spesaSconto10 = spesaToT * 10 / 100;
                }

            }
            Console.WriteLine($"La spesa totale è {spesaToT} e la spesa scontata del 5% è {spesaSconto5} la spesa scontata del 6% è {spesaSconto6} la spesa scontata del 7% è {spesaSconto7} la spesa scontata del 10% è {spesaSconto10}");
            Console.ReadLine();
        }
    }
}


