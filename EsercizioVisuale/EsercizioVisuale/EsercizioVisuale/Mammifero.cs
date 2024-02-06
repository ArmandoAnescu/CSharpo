using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioVisuale
{
    enum TipoParto
    {
        Monotremi,
        Marsupiali,
        Placentali
    }
    internal class Mammifero : EsseriViventi
    {
        static int _numero = 0;
        int _numero2;
        string _famiglia;
        string _nome;
        TipoParto categoria;

        public Mammifero(string nome, string famiglia, string path, string specie, TipoParto parto) : base(path, specie)
        {
            _numero++;
            _numero2 = _numero;
            _famiglia = famiglia;
            _nome = nome;
            categoria = parto;
        }
        static public int Numero
        {
            get { return _numero; }
        }
        new public string InfoEssere()
        {

            return String.Format($" {base.InfoEssere()} | Famiglia: {_famiglia} | Nome: {_nome} | Categoria: {categoria}");
        }
        public string stampa()
        {

            //return String.Format($"{_famiglia}, {_mobilità}, {base._mobilità}, {_nome}, {_numero2}");
            return String.Format($"{Numero}");
        }
    }
}
