using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es2_pag_129
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            numero = Convert.ToInt32(Console.ReadLine());
            float resto = numero % 5;
            if (resto==0)
            {
                Console.WriteLine(numero);
            }
            Console.ReadLine();
        } 

    }
}
