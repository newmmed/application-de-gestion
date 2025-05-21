using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestiondeStock
{
    public partial class Passer_Commande : Form
    {
        public Passer_Commande()
        {
            InitializeComponent();
        }

        private void txtnum_Entrer(object sender, EventArgs e)
        {
            if (txtnum.Text == "ID Produit")
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
                txtnum.ForeColor = Color.White;
            }
        }

        private void txtNum_Entrer(object sender, EventArgs e)
        {
            if (txtNumm.Text == "ID Client")
            {
                txtNumm.Text = "";
                txtNumm.ForeColor = Color.White;
            }
        }

        private void txtNum_Leave(object sender, EventArgs e)
        {
            if (txtNumm.Text == "")
            {
                txtNumm.Text = "ID Client";
                txtNumm.ForeColor = Color.White;
            }
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

        }

        private void txtNomP_Entrer(object sender, EventArgs e)
        {

        }

        private void txtNomP_Leave(object sender, EventArgs e)
        {

        }

        private void txtPrix_Entrer(object sender, EventArgs e)
        {

        }

        private void txtPrix_Leave(object sender, EventArgs e)
        {

        }

        private void btnquitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
