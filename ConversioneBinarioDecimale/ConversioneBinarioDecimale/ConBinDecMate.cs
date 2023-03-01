using System;

namespace ConversioneBinarioDecimale
{
    internal class ConBinDecMate
    {
        static void Main(string[] args)
        {
            int n, resto, posizione = 8, sommaBit = 0;
            //int y = Console.WindowHeight/2, x = Console.WindowWidth/2;
            //int x, y;
            do
            {
                Console.WriteLine("Inserire Un valore decimale nel range di 1 byte");
                n = Convert.ToInt32(Console.ReadLine());
                if (n < 0 || n > 255)
                {
                    Console.WriteLine("valore non valido, inserire un altro valore (premi invio)");
                    Console.ReadLine();
                    Console.Clear();
                }
            } while (n < 0 || n > 255);
            Console.Write("valore in base 2: ");
            //Console.WriteLine($"coordinata{x}");
            //Console.WriteLine($"coordinata{y}");
            //conversione da base 10 a base 2
            do
            {
                resto = n % 2;
                n = n / 2;
                sommaBit = (10 ^ posizione * resto);
                posizione--;
            } while (n != 0);
            Console.Write(sommaBit);
            for (int i = 0; i < 8 - posizione; i++)
            {
                Console.Write("0");
            }
            Console.ReadLine();

        }
    }
}
