using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBO
{
    public class Contenir
    {
        private int code_devis;
        private int code_produit;
        private int quantite;
        private float remise;

        public Contenir(int code_devis, int code_produit, int quantite, float remise)
        {
            this.code_devis = code_devis ;
            this.code_produit = code_produit;
            this.quantite = quantite;
            this.remise = remise;
        }

        public int Code_devis { get => code_devis; set => code_devis = value; }
        public int Code_produit { get => code_produit; set => code_produit = value; }
        public int Quantite { get => quantite; set => quantite = value; }
        public float Remise { get => remise; set => remise = value; }
    }
}
