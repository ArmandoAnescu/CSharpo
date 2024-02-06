using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RipassoItinere
{
    static class Authorization
    {
        public static string autorizzazione = "";
        public static Random randf = new Random();

        public static string CalcolaAutorita()
        {
            int k = 0;
            string vocali = "AEIOU";
            for (int i = 0; i < 6; i++)
            {
                if (i < 5)
                {
                    autorizzazione += randf.Next(0, 10);
                }
                
            }
            autorizzazione += vocali[randf.Next(0, vocali.Length + 1)];
            return autorizzazione;
        }
    }
}

