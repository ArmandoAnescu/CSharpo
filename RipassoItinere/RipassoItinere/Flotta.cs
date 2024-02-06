using System.Collections.Generic;

namespace RipassoItinere
{
    internal class Flotta
    {
        public List<Auto> automobili;
        public string nome;
        public string autorizzazione;
        public Flotta()
        {
            automobili = new List<Auto>();
            autorizzazione = Authorization.CalcolaAutorita();
        }
        public Flotta(string _nome)
        {
            nome = _nome;
            automobili = new List<Auto>();
            autorizzazione = Authorization.CalcolaAutorita();
        }
        public void SetAuto(Auto macchina)
        {
            automobili.Add(macchina);
        }
        public void SetAuto(List<Auto> macchine)
        {
            automobili = macchine;
        }
        public List<Auto> GetAuto()
        {
            List<Auto> auto = automobili;
            return auto;
        }
        public string[] GetMarche()
        {
            int y = 0;
            string[] marche = new string[automobili.Count];
            for (int i = 0; i < automobili.Count; i++)
            {
                for (int k = 0; i < automobili.Count; i++)
                {
                    if (automobili[i].Marca != marche[k])
                    {
                        marche[y] = automobili[i].Marca;
                        y++;
                    }
                }
            }
            string[] strings = new string[y];
            strings = marche;
            return strings;
        }
    }
}
