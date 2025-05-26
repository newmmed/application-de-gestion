using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestiondeStock
{
    public partial class Passer_Commande : Form
    {
        private dbStockContext1 db;

        public Passer_Commande()
        {
            InitializeComponent();
            db = new dbStockContext1();
            combocategorie.DataSource = db.Categories.ToList();
            combocategorie.DisplayMember = "Nom_categorie";
            combocategorie.ValueMember = "ID_Categorie";
        }

        SqlConnection connection = new SqlConnection();
        SqlCommand requet = new SqlCommand();

        string testobligatoire()
        {
            if (string.IsNullOrWhiteSpace(txtnum.Text) || txtnum.Text == "ID Commande") return "ID Commande";
            if (string.IsNullOrWhiteSpace(txtNumm.Text) || txtNumm.Text == "ID Client") return "ID Client";
            return "";
        }

        private void txtnum_Entrer(object sender, EventArgs e)
        {
            if (txtnum.Text == "ID Commande")
            {
                txtnum.Text = "";
                txtnum.ForeColor = Color.White;
            }
        }

        private void txtnum_Leave(object sender, EventArgs e)
        {
            if (txtnum.Text == "")
            {
                txtnum.Text = "ID Commande";
                txtnum.ForeColor = Color.White;
            }
        }

        private void txtNum_Entrer(object sender, EventArgs e)
        {
            if (txtNumm.Text == "ID Client")
            {
                txtNumm.Text = "";
                txtNumm.ForeColor = Color.White;
            }
        }

        private void txtNum_Leave(object sender, EventArgs e)
        {
            if (txtNumm.Text == "")
            {
                txtNumm.Text = "ID Client";
                txtNumm.ForeColor = Color.White;
            }
        }



        private void txtQuantité_Leave(object sender, EventArgs e) { }

        private void txtNomP_Entrer(object sender, EventArgs e) { }

        private void txtNomP_Leave(object sender, EventArgs e) { }

        private void txtPrix_Entrer(object sender, EventArgs e) { }

        private void txtPrix_Leave(object sender, EventArgs e) { }

        private void btnquitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCommander_Click(object sender, EventArgs e)
        {
            string champ = testobligatoire();
            if (!string.IsNullOrEmpty(champ))
            {
                MessageBox.Show($"Le champ '{champ}' est obligatoire ou invalide.", "Obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                int idClient = int.Parse(txtNumm.Text);
                DateTime dateArrivee = dateTimePicker1.Value.Date;
                DateTime dateExpiration = dateTimePicker2.Value.Date;
                DateTime dateCommande = DateTime.Now;  // Ajouter la date de commande (date actuelle)

                string connectionString = "Server=DESKTOP-HBV0SC5\\GSTR2_SERVER;Database=gestion_de_stock;Integrated Security=True;";
                using (SqlConnection cnx = new SqlConnection(connectionString))
                {
                    cnx.Open();

                    string sql = @"
                INSERT INTO Commande (ID_Client, [Date d_arrivee], [date_expiration], date_Commande) 
                VALUES (@ID_Client, @DateArrivee, @DateExpiration, @DateCommande); 
                SELECT SCOPE_IDENTITY();";

                    using (SqlCommand cmd = new SqlCommand(sql, cnx))
                    {
                        cmd.Parameters.AddWithValue("@ID_Client", idClient);
                        cmd.Parameters.AddWithValue("@DateArrivee", dateArrivee);
                        cmd.Parameters.AddWithValue("@DateExpiration", dateExpiration);
                        cmd.Parameters.AddWithValue("@DateCommande", dateCommande);

                        decimal newId = (decimal)cmd.ExecuteScalar();

                        MessageBox.Show($"Commande passée avec succès. Numéro de commande : {newId}", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Optionnel : reset formulaire après insertion
                        txtNumm.Text = "ID Client";
                        txtNumm.ForeColor = Color.Gray;
                        dateTimePicker1.Value = DateTime.Today;
                        dateTimePicker2.Value = DateTime.Today.AddDays(1);
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Le champ 'ID Client' doit être un nombre valide.", "Erreur de format", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



    }
}
