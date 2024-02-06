namespace RipassoItinere
{
    internal class Auto
    {
        string marca;
        public int codice;
        string modello;
        public string targa;
        Posti nPosti;
        public static int nCodice = 0;
        public Auto()
        {
            nCodice++;
            codice = nCodice;
            targa = Targa._Targa;
        }
        public Auto(string _marca, string _modello)
        {
            Marca = _marca;
            Modello = _modello;
            targa = Targa._Targa;
            nCodice++;
            codice = nCodice;

        }
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        public string Modello
        {
            get { return modello; }
            set { modello = value; }
        }
        public void numeroPosti(Posti posti)
        {
            nPosti = posti;
        }

        public Posti numeroPosti()
        {
            return nPosti;
        }
        public override string ToString()
        {
            return string.Format($"marca:{marca,-10} modello:{modello,-10} codice:{codice,+1} numero di posti:{nPosti} targa:{targa}");
        }



    }

}
