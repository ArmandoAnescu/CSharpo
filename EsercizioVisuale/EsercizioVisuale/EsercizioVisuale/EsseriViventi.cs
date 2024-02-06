using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioVisuale
{
    internal class EsseriViventi
    {
        // Classe che contiene i percorsi per le varie immagini
        string _path;
        protected string _mobilità;

        // 1 - public EssereVivente(string specie,string path) 
        public EsseriViventi(string path) : this(path, "ll")
        {

        }
        public EsseriViventi(string path, string specie)
        {

            _path = path;
            Specie = specie;
            _mobilità = "striscia";
        }
        //public EssereVivente() { }

        public string Specie
        {
            get; set;
        }


        public string Path
        {
            get { return _path; }
        }


        public string InfoEssere()
        {

            return String.Format($"Specie: {Specie} | Path: {Path} | mobilità: {_mobilità}");
        }
    }
}
