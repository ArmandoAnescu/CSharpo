using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioSullaRead
{
    class Read
    {
        static void Main(string[] args)
        {
            char tasto;
            string parola = "", numeri = "",stringa=" ";
            string[] dizionario = new string[3];
            const int maxParole = 3;
            bool trovato = false;
            int contParola = 0;
            Console.WriteLine("inserire sequenza di caratteri");
            do
            {
                tasto = Convert.ToChar(Console.Read());
                if (Char.IsLetter(tasto))
                {
                    parola = parola + Convert.ToChar(tasto);
                }
                else if (tasto == ' ' || tasto == 13)
                {
                    Console.WriteLine(parola);
                    if (contParola == maxParole) 
                    {

                    }
                    else 
                    {
                        trovato = false;
                        for (int i = 0; i < dizionario.Length && !trovato; i++)
                        {
                            trovato = parola == dizionario[i];
                        }
                        if(!trovato)
                        {
                            dizionario[contParola] = parola;
                            contParola++;
                        }
                    }
                    parola = "";
                }

            } while (tasto != 13);
            for(int i = 0; i <contParola; i++) 
            {
                Console.WriteLine(dizionario[i]);
            }
            Console.ReadLine();
            Console.ReadLine();
        }
    }
}
//la mamma va al mercato 
//la 
// mamma
//va
//al
//mercato
