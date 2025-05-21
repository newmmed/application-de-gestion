using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestiondeStock.Ressource;
namespace GestiondeStock
{
    public partial class Ajouter_Produit : Form
    {
        private dbStockContext1 db;
        public Ajouter_Produit()
        {
            InitializeComponent();
            db = new dbStockContext1();
            // Remplir la liste des catégories dans comboxcategorie
            combocategorie.DataSource = db.Categories.ToList();
            combocategorie.DisplayMember = "Nom_categorie"; // Nom de la propriété à afficher
            combocategorie.ValueMember = "ID_Categorie"; // Nom de la propriété de valeur
        }
        SqlConnection connection = new SqlConnection();
        SqlCommand requet = new SqlCommand();
        //champ obligatoire
        string testobligatoire()
        {
            if (txtNomP.Text == "Nom Produit" || txtNomP.Text == "")
            {
                return "Veuillez entrer le nom du produit";
            }
            if (txtQuantité.Text == "Quantité" || txtQuantité.Text == "")
            {
                return "Veuillez entrer la quantité";
            }
            if (txtPrix.Text == "Prix" || txtPrix.Text == "")
            {
                return "Veuillez entrer le prix";
            }
            if (PicProduit.Image == null)
            {
                return "Veuillez choisir une image";
            }
            return null;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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

        private void txtNomproduit_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQuantité_Entrer(object sender, EventArgs e)
        {
            if (txtQuantité.Text == "Quantité")
            {
                txtQuantité.Text = "";
                txtQuantité.ForeColor = Color.White;
            }
        }

        private void txtQuantité_Leave(object sender, EventArgs e)
        {
            if (txtQuantité.Text == "")
            {
                txtQuantité.Text = "Quantité";
                txtQuantité.ForeColor = Color.Silver;
            }
        }

        private void txtQuantité_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrix_Entrer(object sender, EventArgs e)
        {
            if (txtPrix.Text == "Prix")
            {
                txtPrix.Text = "";
                txtPrix.ForeColor = Color.White;
            }
        }

        private void txtPrix_Leave(object sender, EventArgs e)
        {

        }

        private void btnquitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnparcourire_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                PicProduit.Image = Image.FromFile(openFileDialog.FileName);
            }

        }

        private void btnactualiser_Click(object sender, EventArgs e)
        {
            //vider les champs
            txtNomP.Text = "Nom Produit"; txtNomP.ForeColor = Color.Silver;
            txtQuantité.Text = "Quantité"; txtQuantité.ForeColor = Color.Silver;
            txtPrix.Text = "Prix"; txtPrix.ForeColor = Color.Silver;

            // Réinitialiser l'image
            PicProduit.Image = null;

            // Recharger les catégories depuis la base de données
            db = new dbStockContext1(); // re-crée le contexte pour rafraîchir les données
            combocategorie.DataSource = db.Categories.ToList();
            combocategorie.DisplayMember = "Nom_categorie";
            combocategorie.ValueMember = "ID_Categorie";

            // Réinitialiser la sélection de la ComboBox
            if (combocategorie.Items.Count > 0)
                combocategorie.SelectedIndex = 0;

            // Réinitialiser l'image secondaire (si présente)
            if (pictureBox2 != null)
                pictureBox2.Image = null; ;

        }
        //Ce code autorise uniquement les chiffres (0 à 9) et la touche retour arrière
        private void txtPrix_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 48 || e.KeyChar > 57)//si la touche pressée n’est pas un chiffre (ASCII de 48 à 57), elle est bloqué
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }
        public int Id_produit;

        private void btnenregistrer_Click(object sender, EventArgs e)
        {
            if (testobligatoire() != null)
            {
                MessageBox.Show(testobligatoire(), "Obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Stop ici si un champ est vide
            }
            if (txtnum.Text == "" || !int.TryParse(txtnum.Text, out _))
            {
                MessageBox.Show("Veuillez entrer un ID valide pour le produit.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            try
            {
                // Récupération des valeurs du formulaire
                string nomProduit = txtNomP.Text;
                int quantite = int.Parse(txtQuantité.Text);
                decimal prix = decimal.Parse(txtPrix.Text);

                // Conversion de l'image en tableau de bytes
                byte[] imageBytes = null;
                if (PicProduit.Image != null)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        PicProduit.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        imageBytes = ms.ToArray();
                    }

                    // Sauvegarde locale de l'image (optionnelle)
                    string imageFolderPath = @"C:\image";
                    if (!Directory.Exists(imageFolderPath))
                    {
                        Directory.CreateDirectory(imageFolderPath);
                    }

                    string imagePath = Path.Combine(imageFolderPath, nomProduit + ".jpg");
                    File.WriteAllBytes(imagePath, imageBytes);
                }

                // Connexion à la base de données
                string connectionString = "Server=DESKTOP-HBV0SC5\\GSTR2_SERVER;Database=gestion_de_stock;Integrated Security=True;";

                using (SqlConnection cnx = new SqlConnection(connectionString))
                {
                    cnx.Open();
                    string sql = "SET IDENTITY_INSERT Produit ON; " +
             "INSERT INTO Produit (ID_Produit, Nom_produit, Quantité_produit, Prix_produit, Image_produit, ID_Categorie) " +
             "VALUES (@ID, @Nom, @Quantite, @Prix, @Image, @IdCategorie); " +
             "SET IDENTITY_INSERT Produit OFF;";


                    using (SqlCommand cmd = new SqlCommand(sql, cnx))
                    {
                        cmd.Parameters.AddWithValue("@ID", int.Parse(txtnum.Text));
                        cmd.Parameters.AddWithValue("@Nom", nomProduit);
                        cmd.Parameters.AddWithValue("@Quantite", quantite);
                        cmd.Parameters.AddWithValue("@Prix", prix);
                        cmd.Parameters.AddWithValue("@Image", imageBytes ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@IdCategorie", 1); // Modifier si vous avez une vraie sélection de catégorie

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Produit ajouté avec succès!", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur: {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (lbltitre.Text == "Ajouter Produit")
            {
                CLS_Produit cls = new CLS_Produit();
                MemoryStream ms = new MemoryStream();
                pictureBox2.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] image = ms.ToArray();
                if (cls.Ajouter_Produit(txtNomP.Text, int.Parse(txtQuantité.Text), int.Parse(txtPrix.Text), image, int.Parse(combocategorie.SelectedValue.ToString())))
                {
                    MessageBox.Show("Produit ajouté avec succès", "Ajouter Produit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erreur d'ajout du produit", "Ajouter Produit", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else
            {
                MemoryStream ms = new MemoryStream();
                pictureBox2.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] image = ms.ToArray();
                CLS_Produit cls = new CLS_Produit();
                DialogResult result = MessageBox.Show("Voulez-vous vraiment modifier ce produit?", "Modifier Produit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                cls.Modifier_Produit(Id_produit,txtNomP.Text, int.Parse(txtQuantité.Text), int.Parse(txtPrix.Text), image, int.Parse(combocategorie.SelectedValue.ToString()));
            }
            }


        private void Ajouter_Produit_Load(object sender, EventArgs e)
        {

        }

        private void combocategorie_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            if (txtnum.Text == "")
            {
                txtnum.Text = "ID Produit";
                txtnum.ForeColor = Color.Silver;
            }
        }
    }
}