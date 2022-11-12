using GestionBLL;
using GestionBO;

namespace Connexion
{
    public partial class ConnexionForm : Form
    {
        public ConnexionForm()
        {
            InitializeComponent();
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            string nom = txtBoxUsername.Text;
            string password = txtBoxUsername.Text;

            Utilisateur uti = UtilisateurBLL.nomUtilisateur(nom);

            if (uti != null && uti.Password == password)
            {
                this.BackColor= Color.White;
            }
        }
    }
}