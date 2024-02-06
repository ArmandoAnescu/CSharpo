using System;

namespace EsercizioVisuale
{
    public class Immagine
    {
        string path = Environment.CurrentDirectory + "\\";
        public Immagine()
        {

        }
        public string Mosca
        {
            get { return path + "mosca.gif"; }
        }
        public string MoscaX
        {
            get { return path + "moscaX.gif"; }
        }
        public string Ragno
        {
            get { return path + "ragno.gif"; }
        }
        public string RagnoX
        {
            get { return path + "ragnoX.gif"; }
        }
        public string Ape
        {
            get { return path + "ape.gif"; }
        }
        public string ApeX
        {
            get { return path + "apeX.gif"; }
        }
        public string Farfalla
        {
            get { return path + "farfalla.gif"; }
        }
        public string FarfallaX
        {
            get { return path + "farfallaX.gif"; }
        }
    }
}
