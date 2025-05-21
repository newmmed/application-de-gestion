using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestiondeStock
{
    public partial class Modifier_Client : Form
    {
        public Modifier_Client()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnrecherche_Click(object sender, EventArgs e)
        {
            if (txtnum.Text == "")
            {
                MessageBox.Show("Veuillez entrer le numéro du client à modifier", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                int ID_Client = int.Parse(txtnum.Text);  // Le numéro du client que tu cherches
                string Nom = txtNom.Text;
                string Prenom = txtPrenom.Text;
                string Adresse = txtadresse.Text;
                string Telephone = txttelephone.Text;
                string Ville = txtville.Text;
                string Email = txtmail.Text;
                string chaine = "Server=DESKTOP-HBV0SC5\\GSTR2_SERVER;Database=gestion_de_stock;Integrated Security=True;";
                using (SqlConnection cnx = new SqlConnection(chaine))
                {
                    cnx.Open();
                    // Utiliser le bon nom de colonne "ID_Client"
                    string requete = "SELECT * FROM Client WHERE ID_Client = @ID_Client";  // Assurez-vous que le nom de la colonne dans la table est bien "ID_Client"
                    using (SqlCommand cmd = new SqlCommand(requete, cnx))
                    {
                        cmd.Parameters.AddWithValue("@ID_Client", ID_Client);  // Utilisation du même nom ici
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            txtNom.Text = reader["Nom"].ToString();
                            txtPrenom.Text = reader["Prenom"].ToString();
                            txtadresse.Text = reader["Adresse"].ToString();
                            txttelephone.Text = reader["Telephone"].ToString();
                            txtmail.Text = reader["Email"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Client introuvable", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void btnquitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnmodifier_Click(object sender, EventArgs e)
        {
            int ID_Client = int.Parse(txtnum.Text);
            string nom = txtNom.Text;
            string prenom = txtPrenom.Text;
            string adresse = txtadresse.Text;
            string telephone = txttelephone.Text;
            string ville = txtville.Text;
            string email = txtmail.Text;

            string chaine = "Server=DESKTOP-HBV0SC5\\GSTR2_SERVER;Database=gestion_de_stock;Integrated Security=True;";
            SqlConnection cnx = new SqlConnection(chaine);
            cnx.Open();

            string sql = "UPDATE Client SET Nom = @Nom, Prenom = @Prenom, Adresse = @Adresse, Telephone = @Telephone, Ville = @Ville, Email = @Email WHERE ID_Client = @ID_Client";
            SqlCommand cmd = new SqlCommand(sql, cnx);

            // Ajouter les paramètres
            cmd.Parameters.AddWithValue("@ID_Client", ID_Client);
            cmd.Parameters.AddWithValue("@Nom", nom);
            cmd.Parameters.AddWithValue("@Prenom", prenom);
            cmd.Parameters.AddWithValue("@Adresse", adresse);
            cmd.Parameters.AddWithValue("@Telephone", telephone);
            cmd.Parameters.AddWithValue("@Ville", ville);
            cmd.Parameters.AddWithValue("@Email", email);

            cmd.ExecuteNonQuery();
            cnx.Close();

            Labmessage2.Text = "Client modifié avec succès";
        }

        private void btnretour_Click(object sender, EventArgs e)
        {
            User_Client user_Client = new User_Client();
            user_Client.Show();
            this.Hide();
        }

        private void Labmessage2_Click(object sender, EventArgs e)
        {

        }

        private void txtnumero_Entrer(object sender, EventArgs e)
        {
            if (txtnum.Text == "ID Client")
            {
                txtnum.Text = "";
                txtnum.ForeColor = Color.Black;
            }
        }

        private void txtnumero_Leave(object sender, EventArgs e)
        {
            if (txtnum.Text == "")
            {
                txtnum.Text = "ID Client";
                txtnum.ForeColor = Color.Silver;
            }
        }

        private void txtNom_Entrer(object sender, EventArgs e)
        {
            if (txtNom.Text == "Nom de Client")
            {
                txtNom.Text = "";
                txtNom.ForeColor = Color.Black;
            }
        }

        private void txtNom_Leave(object sender, EventArgs e)
        {
            if (txtNom.Text == "")
            {
                txtNom.Text = "Nom de Client";
                txtNom.ForeColor = Color.Silver;
            }
        }

        private void txtPrenom_Entrer(object sender, EventArgs e)
        {
            if (txtPrenom.Text == "Prenom de Client")
            {
                txtPrenom.Text = "";
                txtPrenom.ForeColor = Color.Black;
            }
        }

        private void txtPrenom_Leave(object sender, EventArgs e)
        {
            if (txtPrenom.Text == "")
            {
                txtPrenom.Text = "Prenom de Client";
                txtPrenom.ForeColor = Color.Silver;
            }
        }

        private void txtAdresse_Entrer(object sender, EventArgs e)
        {
            if (txtadresse.Text == "Adresse Client")
            {
                txtadresse.Text = "";
                txtadresse.ForeColor = Color.Black;
            }
        }

        private void txtAdresse_Leave(object sender, EventArgs e)
        {
            if (txtadresse.Text == "")
            {
                txtadresse.Text = "Adresse Client";
                txtadresse.ForeColor = Color.Silver;
            }
        }

        private void txtTelephone_Entrer(object sender, EventArgs e)
        {
            if (txttelephone.Text == "Telephone Client")
            {
                txttelephone.Text = "";
                txttelephone.ForeColor = Color.Black;
            }
        }

        private void txtTelephone_Leave(object sender, EventArgs e)
        {
            if (txttelephone.Text == "")
            {
                txttelephone.Text = "Telephone Client";
                txttelephone.ForeColor = Color.Silver;
            }
        }

        private void txtEmail_Entrer(object sender, EventArgs e)
        {
            if (txtmail.Text == "Email Client")
            {
                txtmail.Text = "";
                txtmail.ForeColor = Color.Black;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtmail.Text == "")
            {
                txtmail.Text = "Email Client";
                txtmail.ForeColor = Color.Silver;
            }
        }

        private void txtVille_Entrer(object sender, EventArgs e)
        {
            if (txtville.Text == "Ville Client")
            {
                txtville.Text = "";
                txtville.ForeColor = Color.Black;
            }
        }

        private void txtVille_Leave(object sender, EventArgs e)
        {
            if (txtville.Text == "")
            {
                txtville.Text = "Ville Client";
                txtville.ForeColor = Color.Silver;
            }
        }

        private void txtPrenom_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnum_TextChanged(object sender, EventArgs e)
        {

        }
    }
}