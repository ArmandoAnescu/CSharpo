using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RipassoVerifica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Banca banca= new Banca("Intesa");
            string[] opzioni = { "Inserimento", "Visualizza","Versamento","Prelievo","Esci" };
            Menu(banca, opzioni);
        }
        static void Menu(Banca banca,string [] opzioni) 
        {
            int scelta;
            do
            {
                Console.Clear();
                Console.WriteLine("===Banca===");
                for (int i = 0; i < opzioni.Length; i++)
                {
                    Console.WriteLine($"[{i + 1}] {opzioni[i]}");
                }
                do
                {

                } while (!int.TryParse(Console.ReadLine(), out scelta));
                if (scelta < opzioni.Length) 
                {
                    Opzioni(banca, scelta);
                }
            } while (scelta!= opzioni.Length);
        }
        static void Opzioni(Banca banca,int scelta) 
        {
            ContoCorrente conto=new ContoCorrente();
            int codice;
            switch (scelta) 
            {
                case 1:
                    do
                    {
                        Console.WriteLine("Inserisci il nome dell'utente");
                    } while (String.IsNullOrEmpty(conto.Nome=Console.ReadLine()));
                    do
                    {
                        Console.WriteLine("Inserisci il cognome dell'utente");
                    } while (String.IsNullOrEmpty(conto.Cognome = Console.ReadLine()));                    
                    conto.Conto=10;
                    banca.AggiungiConto(conto);
                    break;
                case 2:
                    banca.RitornaLista().ForEach(x => Console.WriteLine(x.ToString()));
                    Console.ReadLine();
                    break;
                case 3:
                    banca.Versamento();
                    break;
                case 4:
                    banca.Prelievo();
                    break;
               
            }
        }
    }
}
