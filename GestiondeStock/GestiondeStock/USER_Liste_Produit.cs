using GestiondeStock.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
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
            string sql = "SELECT Id_produit, Nom_produit, Quantité_produit, Prix_produit, ID_Categorie FROM Produit";
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

        private void btnimprimertout_Click(object sender, EventArgs e)
        {
            // Check if there's any data to print
            if (dvgProduit.Rows.Count == 0)
            {
                MessageBox.Show("Aucune donnée à imprimer.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Create a PrintDocument
            PrintDocument printDoc = new PrintDocument();
            printDoc.DocumentName = "Liste des Produits";
            printDoc.PrintPage += new PrintPageEventHandler(PrintPageHandler);

            // Show print dialog
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDoc;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDoc.Print();
            }
        }

        private void PrintPageHandler(object sender, PrintPageEventArgs e)
        {
            // Set up the font and margins
            Font font = new Font("Arial", 10);
            Font headerFont = new Font("Arial", 10, FontStyle.Bold);
            Font titleFont = new Font("Arial", 14, FontStyle.Bold);

            float lineHeight = font.GetHeight(e.Graphics);
            float x = e.MarginBounds.Left;
            float y = e.MarginBounds.Top;

            // Calculate column widths (do this once at the start)
            List<float> columnWidths = new List<float>();
            List<string> columnHeaders = new List<string>();

            foreach (DataGridViewColumn col in dvgProduit.Columns)
            {
                if (col.Visible)
                {
                    columnWidths.Add(col.Width * 0.75f);
                    columnHeaders.Add(col.HeaderText);
                }
            }

            // Print title
            e.Graphics.DrawString("Liste des Produits", titleFont, Brushes.Black,
                                 e.MarginBounds.Left + (e.MarginBounds.Width - e.Graphics.MeasureString("Liste des Produits", titleFont).Width) / 2,
                                 y);
            y += lineHeight * 2;

            // Print column headers
            x = e.MarginBounds.Left;
            for (int i = 0; i < columnHeaders.Count; i++)
            {
                e.Graphics.DrawString(columnHeaders[i], headerFont, Brushes.Black, x, y);
                x += columnWidths[i];
            }
            y += lineHeight;

            // Print horizontal line below headers
            e.Graphics.DrawLine(Pens.Black, e.MarginBounds.Left, y, e.MarginBounds.Right, y);
            y += lineHeight / 2;

            // Print each row
            foreach (DataGridViewRow row in dvgProduit.Rows)
            {
                if (!row.IsNewRow)
                {
                    x = e.MarginBounds.Left;
                    int colIndex = 0;

                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.OwningColumn.Visible)
                        {
                            string cellValue = cell.Value?.ToString() ?? "";
                            e.Graphics.DrawString(cellValue, font, Brushes.Black, x, y);
                            x += columnWidths[colIndex];
                            colIndex++;
                        }
                    }

                    y += lineHeight;

                    // Check if we need more pages
                    if (y + lineHeight > e.MarginBounds.Bottom)
                    {
                        e.HasMorePages = true;
                        return;
                    }
                }
            }

            e.HasMorePages = false;
        }
    }
}