using System;

namespace VinaioScontrino
{
    internal class Vinaione
    {
        static void Main(string[] args)
        {
            double litriUtente, litriTot = 0, litriSconto = 0, costo, nBottiglioni, incassoTot = 0, scontoTot = 0, totSconto = 0, Domicilio = 0, importoTot=0, numScontrino, TotDomicilio = 0;
            string risp;
            double bottiglioniTot = 0,scontoFine=0;
            int scontrinoTot = 0;
            Boolean risposta = true, scontoScontrino = false;
            Random num = new Random();
            char rispDomicilio;
            const double sconto = 0.10;
            const int prezzoVino = 2;
            const int costoDomicilio = 3;
            do
            {
                Console.WriteLine("Benvenuto alla tana dei goti, quanti litri di vini vuole");
                litriUtente = Convert.ToDouble(Console.ReadLine());
                while (litriUtente == 0)
                {
                    Console.WriteLine("La quantità di litri non è valida inserire quanti litri si vogliono");
                    litriUtente = Convert.ToDouble(Console.ReadLine());
                    litriTot = litriTot + litriUtente;
                }
                litriTot = litriTot + litriUtente;
                if (litriUtente > 45)
                {
                    litriSconto = litriUtente;
                    scontoScontrino = true;
                }
                if (scontoScontrino == false)
                {
                    costo = litriUtente * prezzoVino;
                }
                else
                {
                    costo = (litriSconto * prezzoVino) - (litriSconto * prezzoVino) * sconto;
                    scontoFine = scontoFine + (litriSconto * prezzoVino) * sconto;
                    scontoTot = scontoTot + costo;
                }
                incassoTot = incassoTot + costo;
                nBottiglioni = litriUtente / 1.5;
                bottiglioniTot = bottiglioniTot + nBottiglioni;
                Console.WriteLine("Vuole la consegna a domicilio?(S/N)");
                rispDomicilio = Convert.ToChar(Console.ReadLine());
                if (rispDomicilio != 'N')
                {
                    Domicilio = costo + costoDomicilio;
                    TotDomicilio = TotDomicilio + Domicilio;
                }else 
                {
                    Domicilio = Domicilio + costo;
                }
                incassoTot = incassoTot + Domicilio;
                Console.WriteLine("(====================  Tana dei Goti  ====================");
                Console.WriteLine($"( Barbera il n°Bottiglioni e di litri sono: {nBottiglioni:#########.#} e {litriTot}. l'importo totale è {costo})");
                if (scontoScontrino == true)
                {
                    totSconto = costo;
                    Console.WriteLine("(Sconto 10%                                                                    )");
                }
                Console.WriteLine("(==================================================================================)");
                Console.WriteLine($"(Spesa di trasporto                                               {costoDomicilio})");
                Console.WriteLine("(==================================================================================)");
                Console.WriteLine($"(L'importo totale è                                                   {Domicilio})");
                Console.WriteLine("===================================================================================)");
                numScontrino = num.Next(200, 4096);
                Console.WriteLine($"(                                                       n°scontrino {numScontrino})");
                Console.WriteLine("(===========================   Arrivederci   ======================================)");
                Console.WriteLine("La giornata è finita? s/n");
                risp = Console.ReadLine();
                scontrinoTot++;
                if (risp == "s")
                {
                    risposta = false;

                }
            } while (risposta == true);
            Console.WriteLine("(===============  Tana dei Goti  ==============");
            Console.WriteLine("(===============  Chiusura Cassa ==============");
            Console.WriteLine($"(Barbera totale: {bottiglioniTot}{litriTot}L )");
            Console.WriteLine("(=============================================)");
            Console.WriteLine($"(Totale Sconto                   {scontoFine})");
            Console.WriteLine($"(Totale Incasso                  {incassoTot})");
            Console.WriteLine($"(Totale Domicilio              {TotDomicilio})");
            Console.WriteLine($"(n°scontrni emessi             {scontrinoTot})");
            Console.WriteLine("(=============    Arrivederci     =============");
            Console.ReadLine();
        }
    }
}
