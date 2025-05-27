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
    public partial class User_List_Acc : UserControl
    {
        public User_List_Acc()
        {
            InitializeComponent();
        }

        private void User_List_Acc_Load(object sender, EventArgs e)
        {

        }

        private void btndéconnecter_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();

            if (parentForm != null)
            {
                parentForm.Hide();

                Connexion connexionForm = new Connexion();
                connexionForm.FormClosed += (s, args) => parentForm.Close();
                connexionForm.Show();
            }
        }
    }
}
