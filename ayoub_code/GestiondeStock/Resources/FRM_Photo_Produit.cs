using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestiondeStock.Resources
{
    public partial class FRM_Photo_Produit : Form
    {
        public FRM_Photo_Produit()
        {
            InitializeComponent();
        }
        public void AfficherPhoto(Image image, string nomProduit)
        {
            this.Text = $"Photo de {nomProduit}";
            pictureBox1.Image = image; // pictureBox1 est votre PictureBox dans le formulaire
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnquitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
