using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionBLL; // Référence la couche BLL
using GestionBO; // Référence la couche BO
using static System.Collections.Specialized.BitVector32;


namespace GestionGUI
{
    public partial class FrmListeProduits : Form
    {
        public FrmListeProduits()
        {
            InitializeComponent();
            // Récupération de chaîne de connexion à la BD à l'ouverture du formulaire
            Utilisateur.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Utilisateur"]);

            // Blocage de la génération automatique des colonnes
            dgv.AutoGenerateColumns = false;


            // Création d'une en-tête de colonne pour la colonne 1
            DataGridViewTextBoxColumn IdColumn = new DataGridViewTextBoxColumn();
            IdColumn.DataPropertyName = "Id_utilisateur1";
            IdColumn.HeaderText = "Identifiant";


            // Création d'une en-tête de colonne pour la colonne 2
            DataGridViewTextBoxColumn NomColumn = new DataGridViewTextBoxColumn();
            NomColumn.DataPropertyName = "Nom_utilisateur1";
            NomColumn.HeaderText = "Nom de l'utilisateur";


            // Ajout des 2 en-têtes de colonne au datagridview
            dgv.Columns.Add(IdColumn);
            dgv.Columns.Add(NomColumn);


            // Définition du style apporté au datagridview
            dgv.ColumnHeadersVisible = true;
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 10, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            // Création d'un objet List d'Utilisateur à afficher dans le datagridview
            List<Utilisateur> liste = new List<Utilisateur>();
            liste = Utilisateur.GetUtilisateurs();

            // Rattachement de la List à la source de données du datagridview
            dgv.DataSource = liste;

        }

        private void retSynt_Click(object sender, EventArgs e)
        {
            FrmSyntheseClients FrmSyntheseClients;
            FrmSyntheseClients = new FrmSyntheseClients();
            FrmSyntheseClients.ShowDialog(); // ouverture du formulaire synthexe client (retour)
        }


    }
}
