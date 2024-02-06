using System;
using System.Collections.Generic;
using System.IO;

namespace RipassoItinere
{
    internal class RipassoItinere
    {
        static void Main(string[] args)
        {
            Flotta macchine = new Flotta("McQueen");
            string path = Path.Combine("F:\\Anescu Armando 4F\\RipassoItinere\\RipassoItinere\\bin\\Debug\\file"+DateTime.Now.ToShortDateString().ToString().Replace('/','.')+"txt");
            string titolo = "=========Flotta=========";
            string[] opzioni = new string[] { "Inserimento", "Visualizza", "Elimina", "Ricerca Targa/codice", "Ricerca Auto N posti", "Lettura Log","Ordinamento Marca", "Esci" };
            Menu(opzioni, path, titolo, 10, 0, ConsoleColor.White, ConsoleColor.Green, ConsoleColor.Blue, macchine);

        }
        static void Menu(string[] opzioni, string path, string titolo, int x, int y, ConsoleColor coloreTitolo, ConsoleColor coloreTesto, ConsoleColor coloreSfondo, Flotta macchine)
        {
            int temp = y;
            int scelta;
            int prova;
            do
            {
                y = temp;
                Console.ForegroundColor = coloreTitolo;
                Console.BackgroundColor = coloreSfondo;
                Console.Clear();
                GiustificaOpzione(opzioni, ref x, ref y, titolo);
                do
                {
                    prova = Convert.ToInt32(Console.ReadLine());
                } while (prova < 1 || prova > opzioni.Length);
                if (prova != opzioni.Length)
                {
                    scelta = prova;
                    Opzione(scelta, macchine, path);
                }
            } while (prova != opzioni.Length);
        }
        static void GiustificaOpzione(string[] frase, ref int x, ref int y, string TITOLO)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(TITOLO);
            y++;
            for (int i = 0; i < frase.Length; i++)
            {
                Console.SetCursorPosition(x, y);
                Console.WriteLine($"[{i + 1}] {frase[i]} ");
                y++;
            }
        }
        static void Opzione(int scelta, Flotta macchine, string path)
        {
            int posti = 0;
            string ricerca = "";
            switch (scelta)
            {
                case 1:
                    Auto inserimento = new Auto();
                    Console.WriteLine("inserisci la marca");
                    inserimento.Marca = Console.ReadLine();
                    Console.WriteLine("inserisci il modello");
                    inserimento.Modello = Console.ReadLine();
                    do
                    {
                        Console.WriteLine("Quanti posti ha l'auto. [1] due [2]quattro [3] cinque [4] otto");
                        posti = Convert.ToInt32(Console.ReadLine());
                        switch (posti)
                        {
                            case 1:
                                inserimento.numeroPosti(Posti.due);
                                break;
                            case 2:
                                inserimento.numeroPosti(Posti.quattro);
                                break;
                            case 3:
                                inserimento.numeroPosti(Posti.cinque);
                                break;
                            case 4:
                                inserimento.numeroPosti(Posti.otto);
                                break;

                        }
                    } while (posti<1 ||posti>4);
                    macchine.SetAuto(inserimento);
                    break;
                case 2:
                    Visualizza(macchine);
                    break;
                case 3:
                    Console.WriteLine("Vuoi togliere l'auto usando il [1] codice o la [2]targa?");
                    posti = Convert.ToInt32(Console.ReadLine());
                    if (posti == 1)
                    {
                        Console.WriteLine("Inserisci Il codice");
                        ricerca = Console.ReadLine();
                        List<Auto> auto = macchine.GetAuto();
                        int i = auto.FindIndex(a => a.codice == Convert.ToInt32(ricerca));
                        auto.RemoveAt(i);
                        macchine.SetAuto(auto);
                    }
                    else
                    {
                        Console.WriteLine("Inserisci la targa");
                        ricerca = Console.ReadLine();
                        List<Auto> auto = macchine.GetAuto();
                        int i = auto.FindIndex(a => a.targa == ricerca);
                        auto.RemoveAt(i);
                        macchine.SetAuto(auto);
                    }
                    break;
                case 4:
                    Console.WriteLine("Vuoi cercare l'auto usando il [1] codice o la [2]targa?");
                    posti = Convert.ToInt32(Console.ReadLine());
                    if (posti == 1)
                    {
                        Console.WriteLine("Inserisci Il codice");
                        ricerca = Console.ReadLine();
                        List<Auto> auto = macchine.GetAuto();
                        Console.WriteLine(auto.Find(a => a.codice == Convert.ToInt32(ricerca)).ToString());
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Inserisci la targa");
                        ricerca = Console.ReadLine();
                        List<Auto> auto = macchine.GetAuto();
                        Console.WriteLine(auto.Find(a => a.targa == ricerca).ToString());
                        Console.ReadLine();
                    }
                    break;
                case 5:
                    int k = 0;
                    Posti n = new Posti();
                    Console.WriteLine("Inserisci il numero di posti per sapere quante auto hanno quei posti");
                    posti = Convert.ToInt32(Console.ReadLine());
                    switch (posti)
                    {
                        case 2:
                            n = Posti.due;
                            break;
                        case 4:
                            n = Posti.quattro;
                            break;
                        case 5:
                            n = Posti.cinque;
                            break;
                        case 8:
                            n = Posti.otto;
                            break;
                    }
                    List<Auto> autos = macchine.GetAuto();
                    for (int i = 0; i < autos.Count; i++)
                    {
                        if (autos[i].numeroPosti() == n)
                        {
                            k++;
                        }
                    }
                    Console.WriteLine($"Ci sono {k} auto con {n} posti");
                    Console.ReadLine();
                    break;

                case 6:
                    if (File.Exists(path))
                    {
                        LeggiLog(path, macchine);
                    }
                    else
                    {
                        Console.WriteLine("Il file non esite");
                    }
                    break;
                case 7:
                    List<Auto> macchina=macchine.GetAuto();
                    string[] marche = macchine.GetMarche();
                    int nAuto = 0;
                    for(int i = 0; i < marche.Length; i++) 
                    {
                        nAuto = 0;
                      for(int j = 0; j < macchina.Count; j++) 
                        {
                            if(macchina[j].Marca == marche[i]) 
                            {
                                nAuto++;
                            }
                        }
                        Console.WriteLine($"della marca {marche[i]} ci sono {nAuto} auto");
                    }
                    break;
            }
        }
        static void Visualizza(Flotta macchine)
        {
            Console.WriteLine(macchine.nome);
            Console.WriteLine("Autorizzazione: {0}", macchine.autorizzazione);
            macchine.automobili.ForEach(x => Console.WriteLine(x.ToString()));
            Console.ReadLine();
        }
        static string CostruisciLog(DateTime dataAttuale)
        {
            string data = dataAttuale.ToShortDateString();
            data = data.Replace("/", ".");
            return data;
        }
        static void ScriviLog(string path, Flotta log, string data)
        {
            StreamWriter sw;
            sw = new StreamWriter(path,false);
            sw.WriteLine(data + " " + log.nome + " "+"codice autorizzazione"+" " + log.autorizzazione);
            List<Auto> autos = log.GetAuto();
            for (int i = 0; i < autos.Count; i++)
            {
                sw.WriteLine(autos[i].ToString());
            }
            sw.Close();
        }
        static void LeggiLog(string path, Flotta macchine)
        {
            ScriviLog(path, macchine, CostruisciLog(DateTime.Now));
            StreamReader sr = File.OpenText(path);
            string lineaTesto;
            lineaTesto = sr.ReadLine();
            while (lineaTesto != null)
            {
                Console.WriteLine(lineaTesto);
                lineaTesto = sr.ReadLine();
            }
            Console.ReadLine();
            sr.Close();
        }
    }
}

