namespace GestionBO
{
    public class Produit
    {
        private int code;
        private string libelle;
        private float prix;
        private int codeCategorie;

        public Produit(int code, string libelle, float prix, int codeCategorie)
        {
            this.code = code;
            this.libelle = libelle;
            this.prix = prix;
            this.codeCategorie= codeCategorie;
        }

        public int Code { get => code; set => code = value; }
        public string Libelle { get => libelle; set => libelle = value; }
        public float Prix { get => prix; set => prix = value; }
        public int CodeCategorie { get => codeCategorie; set => codeCategorie = value; }
    }
}
