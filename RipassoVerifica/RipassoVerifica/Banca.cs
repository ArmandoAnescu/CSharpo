using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace RipassoVerifica
{
    internal class Banca
    {
        List<ContoCorrente> corrente;
        public string nome;
        static int n = 1;
        public Banca(string nome)
        {
            corrente = new List<ContoCorrente>();
            this.nome = nome;
        }
        public void AggiungiConto(ContoCorrente conto)
        {
            conto.nConto = n;
            n++;
            corrente.Add(conto);
        }
        public List<ContoCorrente> RitornaLista()
        {
            List<ContoCorrente> lista = corrente.ToList();
            return lista;
        }
        public void Versamento()
        {
            int codice;
            double versamento=0;
            do
            {
                Console.WriteLine("Inserisci il codice del conto dove versare");
            } while (!int.TryParse(Console.ReadLine(), out codice));
            if (corrente.Exists(a => a.nConto == codice))
            {
                do
                {
                    Console.WriteLine("Quanto vuoi versare?");
                } while (!Double.TryParse(Console.ReadLine(), out versamento));
                corrente[corrente.FindIndex(a => a.nConto == codice)].Conto += versamento;
            }
            else
            {
                Console.WriteLine("Conto non trovato");
                Console.ReadLine();
            }
            Log(versamento, corrente[corrente.FindIndex(a => a.nConto == codice)], false);
        }
        public void Prelievo()
        {
            int codice;
            double prelievo=0;
            do
            {
                Console.WriteLine("Inserisci il codice del conto dove prelevare");
            } while (!int.TryParse(Console.ReadLine(), out codice));
            if (corrente.Exists(a => a.nConto == codice))
            {
                do
                {
                    Console.WriteLine("Quanto vuoi prelevare?");
                } while (!Double.TryParse(Console.ReadLine(), out prelievo));
                if (corrente[corrente.FindIndex(a => a.nConto == codice)].Conto > prelievo)
                {
                    corrente[corrente.FindIndex(a => a.nConto == codice)].Conto -= prelievo;
                    Log(prelievo, corrente[corrente.FindIndex(a => a.nConto == codice)], true);
                }
                else
                {
                    Console.WriteLine("La quantità da prelevare è maggiore di quella nel conto");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("Conto non trovato");
                Console.ReadLine();
            }
        }
        public void Log(double prelievoVersamento, ContoCorrente conto, bool tipo)
        {
            StreamWriter sw = new StreamWriter(Environment.CurrentDirectory+"\\"+"Log.txt" , true);
            if (tipo)//prelievo se true false se versamento
            {
                sw.WriteLine(DateTime.Now + "," + conto.nConto + " " + conto.Cognome + " " + conto.Nome +"-"+ prelievoVersamento);

            }
            else
            {
                sw.WriteLine(DateTime.Now + "," + conto.nConto + " " + conto.Cognome + " " + conto.Nome + prelievoVersamento);
            }
            sw.Close();
        }
    }
}
