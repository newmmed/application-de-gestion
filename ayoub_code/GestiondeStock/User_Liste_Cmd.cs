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
    public partial class User_Liste_Cmd : UserControl
    {
        public User_Liste_Cmd()
        {
            InitializeComponent();
        }

        private void btnajouter_Click(object sender, EventArgs e)
        {
            FRM_Detaille_Commande frm = new FRM_Detaille_Commande();
            frm.ShowDialog();
        }

        private void btnimporter_Click(object sender, EventArgs e)
        {
            SqlConnection cnx = new SqlConnection("Server=DESKTOP-HBV0SC5\\GSTR2_SERVER;Database=gestion_de_stock;Integrated Security=True;");
            string sql = "SELECT * FROM Commande";
            SqlCommand cmd = new SqlCommand(sql, cnx);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dvgProduit.DataSource = table;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnajouter_Click_1(object sender, EventArgs e)
        {
            Passer_Commande frm = new Passer_Commande();
            frm.ShowDialog();
        }
    }
}
