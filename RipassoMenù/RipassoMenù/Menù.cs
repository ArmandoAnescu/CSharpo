using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RipassoMenù
{
    class Program//comune dati carta d'intetità
    {
        struct Anagrafe 
        {
            public string nome;
            public string cognome;
            public string nascitaData;
            public string nascitaLuogo;
        }
        static void Main(string[] args)
        {
            const string TITOLO = "Ufficio Anagrafe";
            string[] opzioni = { "Inserimento", "Ricerca", "Visualizza ", "Modifica","Exit" };
            string[] vs = { "Maschio", "Femmina" };
            //Anagrafe[] dati = new Anagrafe[2];
            int scelta;
            do
            {
                Console.Clear();
                scelta = Menù(opzioni, TITOLO, 2, 3);
                switch (scelta)
                {
                    case 1:

                        break;
                    case 2:

                        break;
                    case 3:

                        break;
                    case 4:

                        break;
                }
            } while (scelta != 5);
            Console.ReadLine();
        }

        static int Menù(string[] vett, string intestazione, int x, int y) 
        {
            int opzione;
            do
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
                Console.SetCursorPosition(x, y-1);
                Console.WriteLine($"========={intestazione}=======");
                Console.SetCursorPosition(x, y++);
                Console.WriteLine($"[1] {vett[0]} ");
                Console.SetCursorPosition(x, y++);
                Console.WriteLine($"[2] {vett[1]} ");
                Console.SetCursorPosition(x, y++);
                Console.WriteLine($"[3] {vett[2]} ");
                Console.SetCursorPosition(x, y++);
                Console.WriteLine($"[4] {vett[3]} ");
                Console.SetCursorPosition(x, y++);
                Console.WriteLine($"[5] {vett[4]} ");
                Console.SetCursorPosition(x, y++);
                Console.WriteLine("================================");
                Console.SetCursorPosition(x, y++);
                Console.WriteLine("scegli la tua opzione");
                opzione = Convert.ToInt32(Console.ReadLine());
            } while (opzione < 1 || opzione > 5);
            return opzione;
        }
        static void Inserimento(Anagrafe[] dati) 
        {
            
        }
        static void Ricerca(Anagrafe[] dati)
        {

        }
        static void Visualizza(Anagrafe[] dati)
        {

        }
        static void Elimina(Anagrafe[] dati)
        {

        }
    }
}
