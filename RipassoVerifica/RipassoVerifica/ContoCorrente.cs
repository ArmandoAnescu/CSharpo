using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RipassoVerifica
{
    internal class ContoCorrente
    {
        int nContoCorrente;
        string nome;
        string cognome;
        double conto;
        public ContoCorrente() 
        {
            
            nome=Nome; 
            cognome=Cognome; 
            conto=10;    
        }
        public string Nome 
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Cognome
        {
            get { return cognome; }
            set { cognome = value; }
        }
        public double Conto 
        {
            get { return conto; }
            set { conto = value; }
        }
        public int nConto 
        {
            get { return nContoCorrente; }
            set { nContoCorrente = value; }
        }
        public override string ToString()
        {
            return string.Format($"numero:{nContoCorrente} conto di: {cognome} {nome} saldo:{conto} ");
        }
    }
}
