using GestionBO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDAL
{
    public class ClientDAO
    {
        private static ClientDAO unClientDAO;

        // Accesseur en lecture, renvoi une instance
        public static ClientDAO GetunClientDAO()
        {
            if (unClientDAO == null)
            {
                unClientDAO = new ClientDAO();
            }
            return unClientDAO;
        }

        public static List<Client> GetClient()
        {
            int code;
            string nom;
            string prenom;
            string rue_facturation;
            string cp_facturation;
            string ville_facturation;
            string rue_livraison;
            string cp_livraison;
            string ville_livraison;
            string telephone;
            string fax;
            string email;

            Client unClient;

            // Connexion à la BD
            SqlConnection maConnexion = ConnexionBD.GetConnexionBD().GetSqlConnexion();

            // Création d'une liste vide d'objets Client
            List<Client> lesClients = new List<Client>();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = maConnexion;
            cmd.CommandText = " SELECT * FROM client";
            SqlDataReader monReader = cmd.ExecuteReader();

            // Remplissage de la liste
            while (monReader.Read())
            {
                code = Int32.Parse(monReader["code_client"].ToString());
                nom = monReader["nom_client"].ToString();
                prenom = monReader["prenom_client"].ToString();
                rue_facturation = monReader["rue_facturation_client"].ToString();
                cp_facturation = monReader["cp_facturation_client"].ToString();
                ville_facturation = monReader["ville_facturation_client"].ToString();
                rue_livraison = monReader["rue_livraison_client"].ToString();
                cp_livraison = monReader["cp_livraison_client"].ToString();
                ville_livraison = monReader["ville_livraison_client"].ToString();
                telephone = monReader["telephone_client"].ToString();
                fax = monReader["fax_client"].ToString();
                email = monReader["email_client"].ToString();


                unClient = new Client(code, nom, prenom, rue_facturation, cp_facturation,
                    ville_facturation, rue_livraison, cp_livraison, ville_livraison,
                    telephone, fax, email);
                lesClients.Add(unClient);
            }

            // Fermeture de la connexion
            maConnexion.Close();
            return lesClients;
        }
    }

}
