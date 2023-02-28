using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenùScuola
{
    class MenùScuola
    {
        static void Main(string[] args)
        {
            int opzione, nAlunno = 0, posizionBambino = 0, ir = 1;
            string ricerca;
            const int maxOpzione = 9, nAlunni = 3;
            bool cerca = false, ricercaOk = false, modificaRegistro = false;
            int posizione = 0;
            string[] nomeAlunni = new string[nAlunni];
            string[] gita = new string[nAlunni];
            string risp = " ";
            //visualizzazione menù
            do
            {
                // scelta dell'opzione
                do
                {
                    Console.Clear();
                    Console.WriteLine("===Registro di classe===");
                    Console.WriteLine("[1] inserimento");
                    Console.WriteLine("[2] presenti");
                    Console.WriteLine("[3] ricerca");
                    Console.WriteLine("[4] ricerca posizione alunno/ registro");
                    Console.WriteLine("[5] informazioni studente");
                    Console.WriteLine("[6] gita");
                    Console.WriteLine("[7] registro gita");
                    Console.WriteLine("[8] assente gita(prima esegui la ricerca per la posizione)");
                    Console.WriteLine("[{0}] esci", maxOpzione);
                    opzione = Convert.ToInt32(Console.ReadLine());
                } while (opzione < 1 || opzione > maxOpzione);
                // verifica dell'opzione ed esecuzione
                switch (opzione)
                {
                    // inserimento nome alunni
                    case 1:
                        // verifico se classe al completo
                        if (nAlunni != nAlunno)
                        {
                            Console.WriteLine("inserire nome alunno");
                            nomeAlunni[nAlunno] = Console.ReadLine(); // inserimento nome
                            nAlunno++;
                        }
                        // se la classe è al completo
                        else
                        {
                            Console.WriteLine("La classe è al completo. Premere invio per continuare");
                            Console.ReadLine();
                        }

                        break;
                    // visualizzazione alunno
                    case 2:
                        // verifico se sono presente degli alunni
                        if (nAlunno != 0)
                        {
                            // stampa dei presenti
                            for (int i = 0; i < nAlunno; i++)
                            {
                                Console.WriteLine("{0} {1}", i + 1, nomeAlunni[i]);
                            }
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Non hai inserito nome degli alunni. Premere invio per continuare");
                            Console.ReadLine();
                        }
                        break;
                    // ricerca
                    case 3:
                        if (nAlunno != 0)
                        {
                            Console.WriteLine("Inserire nome dell'alunno da cercare");
                            ricerca = Console.ReadLine();
                            // ricerca del nome nell'array
                            bool trovato = false;
                            for (int i = 0; i < nAlunno && !trovato; i++)
                            {
                                /*if(ricerca == nomeAlunni[i])
                                {
                                    trovato = true;
                                }
                                */
                                // trovato se la condizione è soddisfatta
                                trovato = ricerca == nomeAlunni[i];
                            }
                            // verifico se c'è il nome in elenco
                            if (trovato)
                            {
                                Console.WriteLine("L'alunno {0} è presente", ricerca);
                            }
                            else
                            {
                                Console.WriteLine("L'alunno {0} è assente", ricerca);
                            }
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Non hai inserito nome degli alunni. Premere invio per continuare");
                            Console.ReadLine();
                        }
                        break;
                    case 4:
                        Console.WriteLine("Inserire nome dell'alunno di cui si vuole sapere la posizione");
                        ricerca = Console.ReadLine();
                        for (int i = 0; i < nAlunno; i++)
                        {
                            if (ricerca == nomeAlunni[i])
                            {
                                posizionBambino = i + 1;
                            }
                        }
                        Console.WriteLine("Il bambino si trova alla {0}", posizionBambino);
                        cerca = true;
                        ricercaOk = true;
                        Console.ReadLine();
                        break;
                    case 5:
                        if (cerca == true)
                        {
                            Console.WriteLine("Inserire il nome dell'alunno di cui si vuole sapere l'informazione");
                            ricerca = Console.ReadLine();
                            for (int i = 0; i < nAlunno; i++)
                            {
                                if (ricerca == nomeAlunni[i])
                                {
                                    posizione = i + 1;
                                }
                            }
                            Console.WriteLine($"L'alunno {nomeAlunni[posizione - 1]} si trova alla {posizione}° posizione");
                        }
                        else
                        {
                            Console.WriteLine("Non hai eseguito la ricerca");
                        }
                        Console.ReadLine();
                        break;
                    case 6:
                        for (int i = 0; i < nAlunno; i++)
                        {
                            modificaRegistro = false;
                            Console.WriteLine($"{nomeAlunni[i]} vuoi venire in gita? s/n");
                            risp = Console.ReadLine().ToLower();
                            if (risp == "s")
                            {
                                gita[i] = nomeAlunni[i];
                            }
                            else if (risp == "n")
                            {
                                gita[i] = "no";
                            }
                        }
                        Console.ReadLine();
                        break;
                    case 7:
                        if (modificaRegistro == false)
                        {
                            Console.WriteLine("Il registro di chi va in gita è:");
                            for (int i = 0; i < nAlunno; i++)
                            {
                                if (gita[i] != "no")
                                {
                                    Console.WriteLine("L'alunno {0} viene in gita ed è il {1}°", gita[i], ir++);
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Non puoi visuallizzare l'elenco");
                        }
                        Console.ReadLine();
                        break;
                    case 8:
                        if (ricercaOk)
                        {
                            if (posizionBambino != 0)
                            {
                                for (int i = posizionBambino - 1; i < nAlunni - 1; i++)
                                {
                                    nomeAlunni[i] = nomeAlunni[i + 1];
                                }
                                nAlunno--;
                                Console.WriteLine("Ho rimosso l'alunno");

                            }
                            else
                            {
                                Console.WriteLine("L'alunno è assente");
                            }
                            ricercaOk = ricercaOk;
                        }
                        else
                        {
                            Console.WriteLine("Non hai eseguito la ricerca la punto 4");
                        }
                        Console.ReadLine();
                        break;
                }
            } while (opzione != maxOpzione);     // ripete ciclo finché non esce     
        }
    }
}
