using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GestiondeStock
{
    public partial class Connexion : Form
    {
        public Connexion()
        {
            InitializeComponent();
        }

        private void Connexion_Load(object sender, EventArgs e)
        {
            // Optionnel : initialisation
        }

        private string testobligatoire()
        {
            if (txtNom.Text == "" || txtNom.Text == "Nom d'utilisateur")
                return "Entrez votre Nom";

            if (txtPass.Text == "" || txtPass.Text == "Mot de Passe")
                return "Entrez votre Mot de Passe";

            return null;
        }

        private void btnquitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();  // Cache la fenêtre Connexion
            pnlafficher acc = new pnlafficher();
            acc.FormClosed += (s, args) => this.Close();  // Ferme complètement l'application quand acc est fermé
            acc.Show();  // Affiche le menu principal
            //// Vérifie les champs obligatoires
            //if (testobligatoire() != null)
            //{
            //    MessageBox.Show(testobligatoire(), "Obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            //string Nom = txtNom.Text;
            //string Pass = txtPass.Text;

            //string chaine = "Server=DESKTOP-HBV0SC5\\GSTR2_SERVER;Database=gestion_de_stock;Integrated Security=True;";
            //using (SqlConnection cnx = new SqlConnection(chaine))
            //{
            //    cnx.Open();
            //    string sql = "SELECT * FROM Utilisateur WHERE Nomutilisateur = @Nom AND Mot_De_Passe = @Pass";
            //    using (SqlCommand cmd = new SqlCommand(sql, cnx))
            //    {
            //        cmd.Parameters.AddWithValue("@Nom", Nom);
            //        cmd.Parameters.AddWithValue("@Pass", Pass);

            //        using (SqlDataReader rd = cmd.ExecuteReader())
            //        {
            //            if (rd.Read())
            //            {
            //                // Authentification réussie
            //                this.Hide();  // Cache la fenêtre Connexion
            //                pnlafficher acc = new pnlafficher();
            //                acc.FormClosed += (s, args) => this.Close();  // Ferme complètement l'application quand acc est fermé
            //                acc.Show();  // Affiche le menu principal
            //            }
            //            else
            //            {
            //                MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            }
            //        }
            //    }
            //}
        }

        private void textNom_TextChanged(object sender, EventArgs e)
        {
            // Optionnel
        }
    }
}
