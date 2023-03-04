using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Lanciodadi2giocatori
{
    class Program
    {
        static void Main(string[] args)
        {
            int centerx;
            int centery;
            int facciaD1 = 0, facciaD2 = 0;
            string playerUno, playerDue;
            Boolean turno1 = true, round = true;
            Random facciaDado = new Random();

            Console.WriteLine("Inserisci il tuo nome giocatore uno");
            playerUno = Console.ReadLine();
            Console.WriteLine("Inserisci il tuo nome giocatore due");
            playerDue = Console.ReadLine();
            centery = Console.WindowHeight / 2;
            centerx = Console.WindowWidth / 2;
            Console.Clear();
            do
            {
                if (turno1 == true)
                {
                    Console.WriteLine($"{playerUno} premi invio per mostrare la faccia");
                    Console.ReadLine();
                    facciaD1 = facciaDado.Next(1, 6);
                    turno1 = false;
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine($"{playerDue} premi invio per mostrare la faccia");
                    Console.ReadLine();
                    facciaD2 = facciaDado.Next(1, 6);
                    round = false;
                    Console.Clear();
                }
                for (int i = 1; i < 7; i++)
                {
                    Console.SetCursorPosition(centerx - 7, centery);
                    Console.WriteLine("=======");

                    if (facciaD1 == 1 || facciaD2 == 1)
                    {
                        Console.SetCursorPosition(centerx - 7, centery + 1);
                        Console.WriteLine("=     =");
                        Console.SetCursorPosition(centerx - 7, centery + 2);
                        Console.WriteLine("=  *  =");
                        Console.SetCursorPosition(centerx - 7, centery + 3);
                        Console.WriteLine("=     =");
                        Console.SetCursorPosition(centerx - 7, centery + 4);
                    }

                    if (facciaD1 == 2 || facciaD2 == 2)
                    {
                        Console.SetCursorPosition(centerx - 7, centery + 1);
                        Console.WriteLine("=*    =");
                        Console.SetCursorPosition(centerx - 7, centery + 2);
                        Console.WriteLine("=     =");
                        Console.SetCursorPosition(centerx - 7, centery + 3);
                        Console.WriteLine("=    *=");
                    }

                    if (facciaD1 == 3 || facciaD2 == 3)
                    {
                        Console.SetCursorPosition(centerx - 7, centery + 1);
                        Console.WriteLine("=*    =");
                        Console.SetCursorPosition(centerx - 7, centery + 2);
                        Console.WriteLine("=  0  =");
                        Console.SetCursorPosition(centerx - 7, centery + 3);
                        Console.WriteLine("=    0=");
                    }

                    if (facciaD1 == 4 || facciaD2 == 4)
                    {
                        Console.SetCursorPosition(centerx - 7, centery + 1);
                        Console.WriteLine("=0   0=");
                        Console.SetCursorPosition(centerx - 7, centery + 2);
                        Console.WriteLine("=     =");
                        Console.SetCursorPosition(centerx - 7, centery + 3);
                        Console.WriteLine("=0   0=");
                    }

                    if (facciaD1 == 5 || facciaD2 == 5)
                    {
                        Console.SetCursorPosition(centerx - 7, centery + 1);
                        Console.WriteLine("=0   0=");
                        Console.SetCursorPosition(centerx - 7, centery + 2);
                        Console.WriteLine("=  0  =");
                        Console.SetCursorPosition(centerx - 7, centery + 3);
                        Console.WriteLine("=0   0=");
                    }

                    if (facciaD1 == 6 || facciaD2 == 6)
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
                    Thread.Sleep(500);
                    Console.Clear();
                    if (i == 6)
                    {
                        turno1 = false;
                    }
                }
            } while (round != false);
            Console.Clear();
            if (facciaD1 > facciaD2)
            {
                Console.WriteLine($"Ha vinto {playerUno}");
            }
            else if (facciaD1 == facciaD2)
            {
                Console.WriteLine("il gioco è finito in pareggio");            
            }
            else
            {
                Console.WriteLine($"Ha vinto {playerDue}");
            }
            Console.ReadLine();
        }
    }
}
