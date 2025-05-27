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
    public partial class User_Client : UserControl
    {

        private static User_Client Userclient;
        //crée une instance de la classe User_Client
        public static User_Client Instance
        {
            get
            {
                if (Userclient == null)
                {
                    Userclient = new User_Client();
                }
                return Userclient;
            }
           
        }

        public User_Client()
        {
            InitializeComponent();
            this.Load += UserAlert_Load;
        }
        //ajouter dans dataGridView

        private void User_Client_Load(object sender, EventArgs e)
        {

        }
        private void txtrecherche_TextChanged(object sender, EventArgs e)
        {
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnajouterclient_Click(object sender, EventArgs e)
        {
            Ajouter_Modifer_Client ajouter_Modifer_Client = new Ajouter_Modifer_Client();
            ajouter_Modifer_Client.ShowDialog();

        }

        private void btnmodifierclient_Click(object sender, EventArgs e)
        {
            Modifier_Client modifier_Client = new Modifier_Client();
            modifier_Client.ShowDialog();
        }

        private void btnsupprimer_Click(object sender, EventArgs e)
        {
            Supprimer_Client supprimer_Client = new Supprimer_Client();
            supprimer_Client.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnimporter_Click(object sender, EventArgs e)
        {
        //    SqlConnection cnx = new SqlConnection("Server=DESKTOP-HBV0SC5\\GSTR2_SERVER;Database=gestion_de_stock;Integrated Security=True;");
        //    string sql = "SELECT * FROM Client";
        //    SqlCommand cmd = new SqlCommand(sql, cnx);
        //    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        //    DataTable table = new DataTable();
        //    adapter.Fill(table);
        //    dataGridView1.DataSource = table;
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadData()
        {
            string connectionString = "Server=DESKTOP-HBV0SC5\\GSTR2_SERVER;Database=gestion_de_stock;Integrated Security=True;";
            string query = "SELECT * FROM Client";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des Client : " + ex.Message);
            }
        }
        private void UserAlert_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}