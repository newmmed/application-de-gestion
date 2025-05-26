using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace GestiondeStock
{
    public partial class Ajouter_Modifer_Client : Form
    {
        public Ajouter_Modifer_Client()
        {
            InitializeComponent();
        }

        private void txtNom_TextChanged(object sender, EventArgs e)
        {
            if (txtNom.Text == "Nom d'utilisateur")
            {
                txtNom.Text = "";
                txtNom.ForeColor = Color.Black;
            }
        }

        private void btnquitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnenregistrer_Click(object sender, EventArgs e)
        {
            if (txtnum.Text == "" || txtNom.Text == "" || txtPrenom.Text == "" || txtadresse.Text == "" || txttelephone.Text == "" || txtville.Text == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs obligatoires", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Regex.IsMatch(txttelephone.Text, @"^\d{10}$"))
            {
                MessageBox.Show("Le numéro de téléphone doit contenir exactement 10 chiffres.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtmail.Text != "")
            {
                try
                {
                    MailAddress mail = new MailAddress(txtmail.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Adresse e-mail invalide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            int id = int.Parse(txtnum.Text);
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

                // Utilisation du nom correct de la colonne "ID_Client"
                string sql = "SET IDENTITY_INSERT Client ON; " +
                             "INSERT INTO Client (ID_Client, Nom, Prenom, Adresse, Telephone, Ville, Email) " + // Remplacer ID par ID_Client
                             "VALUES (@ID, @Nom, @Prenom, @Adresse, @Telephone, @Ville, @Email); " +
                             "SET IDENTITY_INSERT Client OFF;";

                using (SqlCommand cmd = new SqlCommand(sql, cnx))
                {
                    cmd.Parameters.AddWithValue("@ID", id);  // Assurez-vous que ce paramètre correspond bien à la colonne dans la base de données
                    cmd.Parameters.AddWithValue("@Nom", Nom);
                    cmd.Parameters.AddWithValue("@Prenom", Prenom);
                    cmd.Parameters.AddWithValue("@Adresse", Adresse);
                    cmd.Parameters.AddWithValue("@Telephone", Telephone);
                    cmd.Parameters.AddWithValue("@Ville", Ville);
                    cmd.Parameters.AddWithValue("@Email", Email);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Client ajouté avec succès", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }



        private void btnretour_Click(object sender, EventArgs e)
        {
            User_Client user_Client = new User_Client();
            user_Client.Show();
            this.Hide();
        }



        private void btnactualiser_Click(object sender, EventArgs e)
        {
        }

        private void Ajouter_Modifer_Client_Load(object sender, EventArgs e)
        {

        }

        private void txtnum_Entrer(object sender, EventArgs e)
        {
            if(txtnum.Text == "ID Client")
            {
                txtnum.Text = "";
                txtnum.ForeColor = Color.Black;
            }
        }

        private void txtnum_Leave(object sender, EventArgs e)
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
            if(txtNom.Text == "")
            {
                txtNom.Text = "Nom de Client";
                txtNom.ForeColor = Color.Silver;
            }
        }

        private void txtPrenom_Entrer(object sender, EventArgs e)
        {
            if(txtPrenom.Text == "Prenom de Client")
            {
                txtPrenom.Text = "";
                txtPrenom.ForeColor = Color.Black;
            }
        }

        private void txtPrenom_Leave(object sender, EventArgs e)
        {
            if(txtPrenom.Text == "")
            {
                txtPrenom.Text = "Prenom de Client";
                txtPrenom.ForeColor = Color.Silver;
            }
        }

        private void txtAdresse_Entrer(object sender, EventArgs e)
        {
            if(txtadresse.Text == "Adresse Client")
            {
                txtadresse.Text = "";
                txtadresse.ForeColor = Color.Black;
            }
        }

        private void txtAdresse_Leave(object sender, EventArgs e)
        {
            if(txtadresse.Text == "")
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
            if(txttelephone.Text == "")
            {
                txttelephone.Text = "Telephone Client";
                txttelephone.ForeColor = Color.Silver;
            }
        }

        private void txtEmail_Entrer(object sender, EventArgs e)
        {
            if(txtmail.Text == "Email Client")
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

        private void txtnum_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
