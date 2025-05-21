using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace GestiondeStock
{
    public partial class Modifier_Produit : Form
    {
        private dbStockContext1 db = new dbStockContext1();
        public Modifier_Produit()
        {
            InitializeComponent();
            ChargerCategories(); // Charger les catégories au démarrage
            combocategorie.DataSource = db.Categories.ToList();
            combocategorie.DisplayMember = "Nom_categorie"; // Nom de la propriété à afficher
            combocategorie.ValueMember = "ID_Categorie"; // Nom de la propriété de valeur
        }

        private void ChargerCategories()
        {
            string chaine = "Server=DESKTOP-HBV0SC5\\GSTR2_SERVER;Database=gestion_de_stock;Integrated Security=True;";
            using (SqlConnection cnx = new SqlConnection(chaine))
            {
                cnx.Open();
                string requete = "SELECT ID_Categorie, Nom_categorie FROM Categorie";
                SqlDataAdapter da = new SqlDataAdapter(requete, cnx);
                DataTable dt = new DataTable();
                da.Fill(dt);

                combocategorie.DisplayMember = "Nom_categorie";
                combocategorie.ValueMember = "ID_Categorie";
                combocategorie.DataSource = dt;
            }
        }

        private void btnrecherche_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtnum.Text))
            {
                MessageBox.Show("Veuillez entrer le numéro du produit à modifier", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int ID_Produit = int.Parse(txtnum.Text);
            string chaine = "Server=DESKTOP-HBV0SC5\\GSTR2_SERVER;Database=gestion_de_stock;Integrated Security=True;";

            using (SqlConnection cnx = new SqlConnection(chaine))
            {
                cnx.Open();
                string requete = "SELECT * FROM Produit WHERE ID_Produit = @ID_Produit";
                using (SqlCommand cmd = new SqlCommand(requete, cnx))
                {
                    cmd.Parameters.AddWithValue("@ID_Produit", ID_Produit);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        txtNomP.Text = reader["Nom_produit"].ToString();
                        txtQuantité.Text = reader["Quantité_produit"].ToString();
                        txtPrix.Text = reader["Prix_produit"].ToString();

                        if (reader["ID_Categorie"] != DBNull.Value)
                            combocategorie.SelectedValue = Convert.ToInt32(reader["ID_Categorie"]);

                        if (reader["Image_produit"] != DBNull.Value)
                        {
                            byte[] imgBytes = (byte[])reader["Image_produit"];
                            using (MemoryStream ms = new MemoryStream(imgBytes))
                            {
                                PicProduit.Image = Image.FromStream(ms);
                            }
                        }
                        else
                        {
                            PicProduit.Image = null;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Produit non trouvé.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btnenregistrer_Click(object sender, EventArgs e)
        {
            try
            {
                int ID_Produit = int.Parse(txtnum.Text);
                string nom = txtNomP.Text;
                int quantite = int.Parse(txtQuantité.Text);
                decimal prix = decimal.Parse(txtPrix.Text);
                int idCategorie = Convert.ToInt32(combocategorie.SelectedValue);

                byte[] imageBytes = null;
                if (PicProduit.Image != null)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        using (Bitmap bmp = new Bitmap(PicProduit.Image))
                        {
                            bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                            imageBytes = ms.ToArray();
                        }
                    }
                }

                string chaine = "Server=DESKTOP-HBV0SC5\\GSTR2_SERVER;Database=gestion_de_stock;Integrated Security=True;";
                using (SqlConnection cnx = new SqlConnection(chaine))
                {
                    cnx.Open();
                    string requete = @"UPDATE Produit SET 
                        Nom_produit = @Nom, 
                        Quantité_produit = @Quantite, 
                        Prix_produit = @Prix, 
                        Image_produit = @Image, 
                        ID_Categorie = @IdCategorie
                        WHERE ID_Produit = @ID_Produit";

                    using (SqlCommand cmd = new SqlCommand(requete, cnx))
                    {
                        cmd.Parameters.AddWithValue("@Nom", nom);
                        cmd.Parameters.AddWithValue("@Quantite", quantite);
                        cmd.Parameters.AddWithValue("@Prix", prix);
                        cmd.Parameters.AddWithValue("@Image", (object)imageBytes ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@IdCategorie", idCategorie);
                        cmd.Parameters.AddWithValue("@ID_Produit", ID_Produit);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Produit modifié avec succès!", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void combocategorie_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Tu peux laisser vide si tu ne fais rien à ce moment-là
        }


        private void btnChoisirImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Images (*.jpg;*.png)|*.jpg;*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                using (var fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read))
                {
                    PicProduit.Image = Image.FromStream(fs);
                }
            }
        }

        private void btnquitter_Click(object sender, EventArgs e)
        {
            this.Close();  
        }

        private void txtNomP_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtNomP_Entrer(object sender, EventArgs e)
        {
            if (txtNomP.Text == "Nom Produit")
            {
                txtNomP.Text = "";
                txtNomP.ForeColor = Color.White;
            }
        }

        private void txtNomP_Leave(object sender, EventArgs e)
        {
            if (txtNomP.Text == "")
            {
                txtNomP.Text = "Nom Produit";
                txtNomP.ForeColor = Color.Silver;
            }
            }

        private void txtQuantité_Entrer(object sender, EventArgs e)
        {
            if(txtQuantité.Text == "Quantité")
            {
                txtQuantité.Text = "";
                txtQuantité.ForeColor = Color.White;
            }
        }

        private void txtQuantité_Leave(object sender, EventArgs e)
        {
            if(txtQuantité.Text == "")
            {
                txtQuantité.Text = "Quantité";
                txtQuantité.ForeColor = Color.Silver;
            }
        }

        private void txtPrix_Entrer(object sender, EventArgs e)
        {
            if(txtPrix.Text == "Prix")
            {
                txtPrix.Text = "";
                txtPrix.ForeColor = Color.Black;
            }
        }

        private void txtPrix_Leave(object sender, EventArgs e)
        {
            if(txtPrix.Text == "")
            {
                txtPrix.Text = "Prix";
                txtPrix.ForeColor = Color.Silver;
            }
        }



        private void txtnum_Entrer(object sender, EventArgs e)
        {
            if(txtnum.Text == "ID Produit")
            {
                txtnum.Text = "";
                txtnum.ForeColor = Color.White;
            }
        }

        private void txtnum_Leave(object sender, EventArgs e)
        {
            if(txtnum.Text == "")
            {
                txtnum.Text = "ID Produit";
                txtnum.ForeColor = Color.Silver;
            }
        }

        private void btnactualiser_Click(object sender, EventArgs e)
        {
            // Réinitialiser les champs texte
            txtNomP.Text = "Nom Produit"; txtNomP.ForeColor = Color.Silver;
            txtQuantité.Text = "Quantité"; txtQuantité.ForeColor = Color.Silver;
            txtPrix.Text = "Prix"; txtPrix.ForeColor = Color.Silver;

            // Réinitialiser les images
            PicProduit.Image = null;
            if (pictureBox2 != null)
                pictureBox2.Image = null;

            // Réinitialiser la ComboBox catégorie
            db = new dbStockContext1(); // recréer le contexte pour avoir les données les plus récentes
            combocategorie.DataSource = db.Categories.ToList();
            combocategorie.DisplayMember = "Nom_categorie";
            combocategorie.ValueMember = "ID_Categorie";
            if (combocategorie.Items.Count > 0)
                combocategorie.SelectedIndex = 0;

            // Réinitialiser l'ID du produit (important pour ne pas modifier un ancien produit)

        }

        private void Modifier_Produit_Load(object sender, EventArgs e)
        {

        }

        private void txtnum_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
