using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace GestiondeStock
{
    public partial class Supprimer_Produit : Form
    {
        public Supprimer_Produit()
        {
            InitializeComponent();
        }

        private void btnsupprimer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtnum.Text))
            {
                MessageBox.Show("Veuillez entrer le numéro du produit à supprimer", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtnum.Text, out int ID_Produit))
            {
                MessageBox.Show("Le numéro du produit doit être un entier valide.", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Demande de confirmation
            var confirmResult = MessageBox.Show($"Êtes-vous sûr de vouloir supprimer le produit avec l'ID {ID_Produit}?",
                                     "Confirmation de suppression",
                                     MessageBoxButtons.YesNo,
                                     MessageBoxIcon.Question);

            if (confirmResult != DialogResult.Yes)
            {
                return;
            }

            string chaine = "Server=DESKTOP-HBV0SC5\\GSTR2_SERVER;Database=gestion_de_stock;Integrated Security=True;";

            try
            {
                using (SqlConnection cnx = new SqlConnection(chaine))
                {
                    cnx.Open();
                    string sql = "DELETE FROM Produit WHERE Id_produit = @ID_Produit";

                    using (SqlCommand cmd = new SqlCommand(sql, cnx))
                    {
                        cmd.Parameters.AddWithValue("@ID_Produit", ID_Produit);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Produit supprimé avec succès", "Succès",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtnum.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Aucun produit trouvé avec cet ID.", "Information",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la suppression: {ex.Message}", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnquitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtnum_Entrer(object sender, EventArgs e)
        {
            if (txtnum.Text == "Id Produit")
            {
                txtnum.Text = "";
                txtnum.ForeColor = Color.White;
            }
        }

        private void txtnum_Leave(object sender, EventArgs e)
        {
            if (txtnum.Text == "")
            {
                txtnum.Text = "Id Produit";
                txtnum.ForeColor = Color.Silver;
            }
        }
    }
}