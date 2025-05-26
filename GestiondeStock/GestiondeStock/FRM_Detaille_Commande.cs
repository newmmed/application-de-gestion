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
    public partial class FRM_Detaille_Commande : Form
    {
        private dbStockContext1 db;

        public FRM_Detaille_Commande()
        {
            InitializeComponent();
            db = new dbStockContext1();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            // Facultatif : laisser vide si ce label n'a pas d'action
        }

        private void label13_Click(object sender, EventArgs e)
        {
            // Facultatif
        }

        private void btnimporter_Click(object sender, EventArgs e)
        {
            // À implémenter si nécessaire
        }

        private void txtrecherche_Enter(object sender, EventArgs e)
        {
            if (txtrecherche.Text == "Recherche")
            {
                txtrecherche.Text = "";
                txtrecherche.ForeColor = Color.White;
            }
        }

        private void txtrecherche_Leave(object sender, EventArgs e)
        {
            if (txtrecherche.Text == "")
            {
                txtrecherche.Text = "Recherche";
                txtrecherche.ForeColor = Color.White;
            }
        }

        private void dvgProduit1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Facultatif
        }

        private void txtrecherche_TextChanged(object sender, EventArgs e)
        {
            db = new dbStockContext1();
            var liste = db.Produits
                          .Where(p => p.Nom_produit.ToLower().Contains(txtrecherche.Text.ToLower()))
                          .ToList();

            dvgProduit1.Rows.Clear();

            foreach (var item in liste)
            {
                dvgProduit1.Rows.Add(item.Id_produit, item.Nom_produit, item.Prix_produit, item.Quantité_produit, item.Image_produit);
            }
        }


        private void btnAjouterCommande_Click(object sender, EventArgs e)
        {

        }

        private void btnquitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNomP_Entrer(object sender, EventArgs e)
        {

        }

        private void txtNomP_Leave(object sender, EventArgs e)
        {

        }

        private void txtNomP_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNom_Enter(object sender, EventArgs e)
        {

        }

        private void txtNom_Leave(object sender, EventArgs e)
        {

        }

        private void txtPrenom_Enter(object sender, EventArgs e)
        {

        }

        private void txtPrenom_Leave(object sender, EventArgs e)
        {

        }

        private void txtTelephone_Enter(object sender, EventArgs e) 
        {

        }

        private void txtTelephone_Leave(object sender, EventArgs e)
        {

        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {

        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {

        }

        private void txtPays_Enter(object sender, EventArgs e)
        {

        }
    }
}
