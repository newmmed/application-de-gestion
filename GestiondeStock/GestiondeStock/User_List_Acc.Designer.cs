namespace GestiondeStock
{
    partial class User_List_Acc
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button btndéconnecter;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_List_Acc));
            System.Windows.Forms.Button btnConnecter;
            this.btnparamettre = new System.Windows.Forms.Button();
            btndéconnecter = new System.Windows.Forms.Button();
            btnConnecter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btndéconnecter
            // 
            btndéconnecter.BackColor = System.Drawing.SystemColors.MenuText;
            btndéconnecter.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            btndéconnecter.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            btndéconnecter.Image = ((System.Drawing.Image)(resources.GetObject("btndéconnecter.Image")));
            btndéconnecter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btndéconnecter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btndéconnecter.Location = new System.Drawing.Point(570, 74);
            btndéconnecter.Name = "btndéconnecter";
            btndéconnecter.Size = new System.Drawing.Size(142, 36);
            btndéconnecter.TabIndex = 3;
            btndéconnecter.Text = "Déconnecter";
            btndéconnecter.UseVisualStyleBackColor = false;
            // 
            // btnConnecter
            // 
            btnConnecter.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            btnConnecter.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            btnConnecter.Font = new System.Drawing.Font("Corbel", 11.25F);
            btnConnecter.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            btnConnecter.Image = global::GestiondeStock.Properties.Resources.login_32;
            btnConnecter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnConnecter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            btnConnecter.Location = new System.Drawing.Point(570, 23);
            btnConnecter.Name = "btnConnecter";
            btnConnecter.Size = new System.Drawing.Size(142, 34);
            btnConnecter.TabIndex = 2;
            btnConnecter.Text = "Connecter";
            btnConnecter.UseVisualStyleBackColor = false;
            // 
            // btnparamettre
            // 
            this.btnparamettre.FlatAppearance.BorderSize = 0;
            this.btnparamettre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnparamettre.Image = ((System.Drawing.Image)(resources.GetObject("btnparamettre.Image")));
            this.btnparamettre.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnparamettre.Location = new System.Drawing.Point(38, 23);
            this.btnparamettre.Name = "btnparamettre";
            this.btnparamettre.Size = new System.Drawing.Size(32, 42);
            this.btnparamettre.TabIndex = 11;
            this.btnparamettre.UseVisualStyleBackColor = true;
            // 
            // User_List_Acc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(119)))), ((int)(((byte)(78)))));
            this.Controls.Add(this.btnparamettre);
            this.Controls.Add(btndéconnecter);
            this.Controls.Add(btnConnecter);
            this.Name = "User_List_Acc";
            this.Size = new System.Drawing.Size(1137, 720);
            this.Load += new System.EventHandler(this.User_List_Acc_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnparamettre;
    }
}
