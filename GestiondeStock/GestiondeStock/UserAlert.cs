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
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
            this.Load += UserAlert_Load;
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void dvgAlert_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void LoadData()
        {
            string connectionString = "Server=DESKTOP-HBV0SC5\\GSTR2_SERVER;Database=gestion_de_stock;Integrated Security=True;";
            string query = "SELECT Id_produit, Quantité_produit, Nom_produit FROM Produit WHERE Quantité_produit < 5";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dvgAlert.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des Produits : " + ex.Message);
            }
        }
        private void UserAlert_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbltitre_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
