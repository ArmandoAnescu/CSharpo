using System;

namespace RipassoItinere
{
    static class Targa
    {

        //static Targa() 
        //{
        //    targa = CalcolaTarga();
        //}
        public static string _Targa
        {
            get { return CalcolaTarga(); }
        }

        private static string CalcolaTarga()
        {
            Random randf = new Random();
            string targa = "";
            for (int i = 0; i < 7; i++)
            {
                if (i < 2 || i > 4)
                {
                    targa += (char)randf.Next('A', 'Z' + 1);
                }
                else
                {
                    targa += randf.Next(0, 10);
                }
            }
            return targa;
        }
    }
}
