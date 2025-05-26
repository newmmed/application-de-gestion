using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GestiondeStock
{
    public partial class Supprimer_Client : Form
    {
        public Supprimer_Client()
        {
            InitializeComponent();
        }

        private void btnsupprimer_Click(object sender, EventArgs e)
        {
            if (txtnum.Text == "")
            {
                MessageBox.Show("Veuillez entrer le numéro du client à supprimer", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int ID_Client = int.Parse(txtnum.Text);
            if (!int.TryParse(txtnum.Text, out ID_Client))
            {
                MessageBox.Show("Le numéro du client doit être un entier valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string chaine = "Server=DESKTOP-HBV0SC5\\GSTR2_SERVER;Database=gestion_de_stock;Integrated Security=True;";
            using (SqlConnection cnx = new SqlConnection(chaine))
            {
                cnx.Open();
                string sql = "DELETE FROM Client WHERE ID_Client = @ID_Client";
                using (SqlCommand cmd = new SqlCommand(sql, cnx))
                {
                    cmd.Parameters.AddWithValue("@ID_Client", ID_Client);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Client supprimé avec succès", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtnum.Text = "";
                        Labmessage.Text = "Client supprimé avec succès";
                    }
                    else
                    {
                        MessageBox.Show("Aucun client trouvé avec cet ID.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btnretour_Click(object sender, EventArgs e)
        {
            User_Client user_Client = new User_Client();
            user_Client.Show();
            this.Hide();
        }

        private void btnquitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtnum_Entrer(object sender, EventArgs e)
        {
            if (txtnum.Text == "ID Client")
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

        private void txtnum_TextChanged(object sender, EventArgs e)
        {

        }
    }
} 


