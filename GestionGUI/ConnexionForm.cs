using GestionBLL;
using GestionBO;
using GestionGUI;
using System.Configuration;

namespace Connexion
{
    public partial class ConnexionForm : Form
    {
        public ConnexionForm()
        {
            InitializeComponent();
            UtilisateurBLL.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Utilisateur"]);
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            string nom = txtBoxUsername.Text;
            string password = txtBoxPassword.Text;

            Utilisateur? uti = UtilisateurBLL.nomUtilisateur(nom);

            if (uti != null && uti.Password == password)
            {
                this.Hide()
;               FrmSyntheseClients FrmSyntheseClients;
                FrmSyntheseClients = new FrmSyntheseClients();
                FrmSyntheseClients.Closed += (s, args) => this.Close();
                FrmSyntheseClients.ShowDialog(); // ouverture du formulaire list produit
                this.Close();
            }
            else
            {
                lblErreur.ForeColor = Color.Red;
            }
        }

        private void txtBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void temp_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmListeProduits FrmListeProduits;
            FrmListeProduits = new FrmListeProduits();
            FrmListeProduits.Closed += (s, args) => this.Close();
            FrmListeProduits.ShowDialog(); // ouverture du formulaire list produit
            this.Close();
        }
    }
}