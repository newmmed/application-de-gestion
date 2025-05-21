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
    public partial class pnlafficher : Form
    {
        public pnlafficher()
        {
            InitializeComponent();
            panel1.Size = new Size(178, 466);
            pnlParamettre.Visible = false;
        }
        //desactiver formulaire

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
             
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if(panel1.Width== 178)
            {
                panel1.Size = new Size(71, 466);
            }
            else
            {
                panel1.Size = new Size(178, 466);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btnclient_Click(object sender, EventArgs e)
        {
            pnlBut.Top = btnclient.Top;
            if(!pnlaficher.Controls.Contains(User_Client.Instance))
            {
                pnlaficher.Controls.Add(User_Client.Instance);
                User_Client.Instance.Dock = DockStyle.Fill;
                User_Client.Instance.BringToFront();
            }
            else
            {
                User_Client.Instance.BringToFront();
            }


        }

        private void btnproduit_Click(object sender, EventArgs e)
        {
            pnlBut.Top=btnproduit.Top;
            USER_Liste_Produit user = new USER_Liste_Produit();
            if (!pnlaficher.Controls.Contains(user))
            {
                pnlaficher.Controls.Add(user);
                user.Dock = DockStyle.Fill;
                user.BringToFront();
            }
            else
            {
                user.BringToFront();
            }
        }


        private void btncommande_Click(object sender, EventArgs e)
        {
            pnlBut.Top = btncommande.Top;
            User_Liste_Cmd user = new User_Liste_Cmd();
            if (!pnlaficher.Controls.Contains(user))
            {
                pnlaficher.Controls.Add(user);
                user.Dock = DockStyle.Fill;
                user.BringToFront();
            }
            else
            {
                user.BringToFront();
            }
        }


        private void btnutilisateur_Click(object sender, EventArgs e)
        {
            pnlBut.Top = btnutilisateur.Top;
        }

        private void btnparamettre_Click(object sender, EventArgs e)
        {
            pnlParamettre.Size = new Size(199, 80); 
            pnlParamettre.Visible = !pnlParamettre.Visible;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Connexion cnx = new Connexion();
            cnx.Show();
            this.Hide();
        }


        private void btndéconnecter_Click(object sender, EventArgs e)
        {
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlafficher_Load(object sender, EventArgs e)
        {

        }
    }
}
