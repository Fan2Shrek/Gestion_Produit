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
                this.BackColor= Color.White;
            }
        }

        private void txtBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void temp_Click(object sender, EventArgs e)
        {
            FrmSyntheseClients FrmSyntheseClients;
            FrmSyntheseClients = new FrmSyntheseClients();
            FrmSyntheseClients.ShowDialog(); // ouverture du formulaire list produit
        }
    }
}