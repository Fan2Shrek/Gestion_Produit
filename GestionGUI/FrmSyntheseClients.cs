using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionGUI
{
    public partial class FrmSyntheseClients : Form
    {
        public FrmSyntheseClients()
        {
            InitializeComponent();
        }

        private void syntheseProduit_Click(object sender, EventArgs e)
        {
            FrmListeProduits FrmListesProduit;
            FrmListesProduit = new FrmListeProduits();
            FrmListesProduit.ShowDialog(); // ouverture du formulaire list produit
        }
    }
}
