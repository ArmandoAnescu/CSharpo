using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StampaNumeriAssenti
{
    internal class NumeriMancanti
    {
        static void Main(string[] args)
        {
            int [] nAssenti = new int[10];
            Random n = new Random();
            int Num = 0;
            
            for(int i=0; i<10; i++)
            {
                Num = n.Next(1,10);
                Console.WriteLine(Num);
                nAssenti[Num] = 1;
            }
            Console.WriteLine("I numeri assenti sono:");
            for(int i = 0; i < nAssenti.Length; i++)
            {
                if(nAssenti[i] == 0) 
                { 
                Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}
