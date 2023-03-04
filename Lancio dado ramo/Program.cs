using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace eslancio_dadi
{
    class Program
    {
        static void Main(string[] args)
        {
            Random casuale = new Random();


            int numeroF = 0;
            int valoreDado = 1;
            int centery = Console.WindowHeight / 2;
            int centerx = Console.WindowWidth / 2;
            numeroF = casuale.Next(1, 7);
            for (int i = 1; i < 8; i++)
            {
                Console.SetCursorPosition(centerx - 7, centery);
                Console.WriteLine("=======");
                if (i == 7)
                {
                    i = numeroF;
                }
                if (i == 1 )
                {
                    Console.SetCursorPosition(centerx - 7, centery + 1);
                    Console.WriteLine("=     =");
                    Console.SetCursorPosition(centerx - 7, centery + 2);
                    Console.WriteLine("=  0  =");
                    Console.SetCursorPosition(centerx - 7, centery + 3);
                    Console.WriteLine("=     =");
                    Console.SetCursorPosition(centerx - 7, centery + 4);
                }
                if (i == 2 )
                {
                    Console.SetCursorPosition(centerx - 7, centery + 1);
                    Console.WriteLine("=0    =");
                    Console.SetCursorPosition(centerx - 7, centery + 2);
                    Console.WriteLine("=     =");
                    Console.SetCursorPosition(centerx - 7, centery + 3);
                    Console.WriteLine("=    0=");
                }
                if (i ==3 )
                {
                    Console.SetCursorPosition(centerx - 7, centery + 1);
                    Console.WriteLine("=0    =");
                    Console.SetCursorPosition(centerx - 7, centery + 2);
                    Console.WriteLine("=  0  =");
                    Console.SetCursorPosition(centerx - 7, centery + 3);
                    Console.WriteLine("=    0=");
                }
                if (i == 4 )
                {
                    Console.SetCursorPosition(centerx - 7, centery + 1);
                    Console.WriteLine("=0   0=");
                    Console.SetCursorPosition(centerx - 7, centery + 2);
                    Console.WriteLine("=     =");
                    Console.SetCursorPosition(centerx - 7, centery + 3);
                    Console.WriteLine("=0   0=");
                }
                if (i == 5 )
                {
                    Console.SetCursorPosition(centerx - 7, centery + 1);
                    Console.WriteLine("=0   0=");
                    Console.SetCursorPosition(centerx - 7, centery + 2);
                    Console.WriteLine("=  0  =");
                    Console.SetCursorPosition(centerx - 7, centery + 3);
                    Console.WriteLine("=0   0=");
                }
                if (i == 6 )
                {
                    Console.SetCursorPosition(centerx - 7, centery + 1);
                    Console.WriteLine("=0   0=");
                    Console.SetCursorPosition(centerx - 7, centery + 2);
                    Console.WriteLine("=0   0=");
                    Console.SetCursorPosition(centerx - 7, centery + 3);
                    Console.WriteLine("=0   0=");
                }
                Console.SetCursorPosition(centerx - 7, centery + 4);
                Console.WriteLine("=======");
                Thread.Sleep(1000);
            }
            Console.ReadLine();
        }
    }
}
