namespace GestionBO
{
    public class Produit
    {
        private int code;
        private string libelle;
        private float prix;
        private string categorie;

        public Produit(int code, string libelle, float prix, string categorie)
        {
            this.code = code;
            this.libelle = libelle;
            this.prix = prix;
            this.categorie = categorie;
        }

        public int Code { get => code; set => code = value; }
        public string Libelle { get => libelle; set => libelle = value; }
        public float Prix { get => prix; set => prix = value; }
        public string Categorie { get => categorie; set => categorie = value; }
    }
}
