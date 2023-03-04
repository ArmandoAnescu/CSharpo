using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace LaTanaDeiGoti
{
    class Vinaio//se l >45 sconto un bottiglione da 1,5 l, costo al litro 2€, scoto 10%, consegna a domicilio 3€ in +
    {
        static void Main(string[] args)
        {
            double litriUtente, litriTot=0,litriSconto=0,costo, nBottiglioni, incassoTot = 0, scontoTot = 0;
            Boolean risposta = true,scontoScontrino=false;
            char rispDomicilio;
            const double sconto = 0.10;
            const int prezzoVino = 2;
            const int costoDomicilio = 3;
            do
            {
                Console.WriteLine("Benvenuto alla tana dei goti, quanti litri di vini vuole");
                litriUtente = Convert.ToDouble(Console.ReadLine());
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
                    costo = (litriSconto *prezzoVino)*sconto;
                    scontoTot = scontoTot + costo;
                }
                nBottiglioni = litriUtente/1.5;
                Console.WriteLine("Vuole la consegna a domicilio?(s/n)");
                rispDomicilio = Convert.ToChar(Console.ReadLine());
                if (rispDomicilio != 'n') 
                {
                    costo = costo + costoDomicilio;
                }
                incassoTot = incassoTot + costo;
                Console.WriteLine();
            } while (risposta == true);
        }
    }
}
