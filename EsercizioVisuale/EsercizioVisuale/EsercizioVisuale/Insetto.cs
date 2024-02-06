using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioVisuale
{
    internal class Insetto : EsseriViventi
    {
        static int _numero = 0;
        int _numero2;
        string _famiglia;
        string _nome;
        new string _mobilità;

        public Insetto(string nome, string famiglia, string path, string specie) : base(path, specie)
        {
            _numero++;
            _numero2 = _numero;
            _famiglia = famiglia;
            _nome = nome;
            _mobilità = "salta";
        }
        static public int Numero
        {
            get { return _numero; }
        }
        new public string InfoEssere()
        {

            return String.Format($" {base.InfoEssere()} | Famiglia: {_famiglia} | Nome: {_nome}");
        }
        public string stampa()
        {

            //return String.Format($"{_famiglia}, {_mobilità}, {base._mobilità}, {_nome}, {_numero2}");
            return String.Format($"{Numero}");
        }
    }
}
