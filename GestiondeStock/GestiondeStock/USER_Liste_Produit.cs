using GestiondeStock.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestiondeStock
{
    public partial class USER_Liste_Produit : UserControl
    {
        public USER_Liste_Produit()
        {
            InitializeComponent();
        }

        private void btnajouter_Click(object sender, EventArgs e)
        {
            Ajouter_Produit ajouter_Produit = new Ajouter_Produit();
            ajouter_Produit.ShowDialog();
        }

        private void btnimporter_Click(object sender, EventArgs e)
        {
            SqlConnection cnx = new SqlConnection("Server=DESKTOP-HBV0SC5\\GSTR2_SERVER;Database=gestion_de_stock;Integrated Security=True;");
            string sql = "SELECT * FROM Produit";
            SqlCommand cmd = new SqlCommand(sql, cnx);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dvgProduit.DataSource = table;
        }

        private void btnmodifier_Click(object sender, EventArgs e)
        {
            Modifier_Produit modifier_Produit = new Modifier_Produit();
            modifier_Produit.ShowDialog();
        }

        private void USER_Liste_Produit_Load(object sender, EventArgs e)
        {

        }

        private void btnafficherphoto_Click(object sender, EventArgs e)
        {
            if (dvgProduit.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un produit");
                return;
            }

            int Id_produit = Convert.ToInt32(dvgProduit.SelectedRows[0].Cells["Id_produit"].Value);



            using (SqlConnection cnx = new SqlConnection("Server=DESKTOP-HBV0SC5\\GSTR2_SERVER;Database=gestion_de_stock;Integrated Security=True;"))
            {
                cnx.Open();
                SqlCommand cmd = new SqlCommand("SELECT Nom_produit, Image_produit FROM Produit WHERE Id_produit = @Id_produit", cnx);
                cmd.Parameters.AddWithValue("@Id_produit", Id_produit);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    if (!reader.IsDBNull(1))
                    {
                        string nomProduit = reader.GetString(0);
                        byte[] imageBytes = (byte[])reader["Image_produit"];

                        // Convertir en Image
                        using (MemoryStream ms = new MemoryStream(imageBytes))
                        {
                            Image image = Image.FromStream(ms);

                            // Affichage dans un formulaire
                            FRM_Photo_Produit frm = new FRM_Photo_Produit();
                            frm.AfficherPhoto(image, nomProduit);
                            frm.ShowDialog();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Aucune image disponible pour ce produit.");
                    }
                }
                cnx.Close();

            }
        }

        private void btnsupprimer_Click(object sender, EventArgs e)
        {
            Supprimer_Produit supprimer_Produit = new Supprimer_Produit();
            supprimer_Produit.ShowDialog();
        }

        private void dvgProduit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}