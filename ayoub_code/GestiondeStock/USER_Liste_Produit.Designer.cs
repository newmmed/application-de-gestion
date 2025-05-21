namespace GestiondeStock
{
    partial class USER_Liste_Produit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(USER_Liste_Produit));
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dvgProduit = new System.Windows.Forms.DataGridView();
            this.btnimporter = new System.Windows.Forms.Button();
            this.btnsauvegarder = new System.Windows.Forms.Button();
            this.btnimprimertout = new System.Windows.Forms.Button();
            this.btnimprimerselect = new System.Windows.Forms.Button();
            this.btnafficherphoto = new System.Windows.Forms.Button();
            this.btnsupprimer = new System.Windows.Forms.Button();
            this.btnmodifier = new System.Windows.Forms.Button();
            this.btnajouter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgProduit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Location = new System.Drawing.Point(42, 25);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(760, 2);
            this.panel4.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(42, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 2);
            this.panel1.TabIndex = 15;
            // 
            // dvgProduit
            // 
            this.dvgProduit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(74)))), ((int)(((byte)(65)))));
            this.dvgProduit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgProduit.Location = new System.Drawing.Point(42, 173);
            this.dvgProduit.Name = "dvgProduit";
            this.dvgProduit.Size = new System.Drawing.Size(712, 147);
            this.dvgProduit.TabIndex = 23;
            this.dvgProduit.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgProduit_CellContentClick);
            // 
            // btnimporter
            // 
            this.btnimporter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(74)))), ((int)(((byte)(65)))));
            this.btnimporter.FlatAppearance.BorderSize = 0;
            this.btnimporter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnimporter.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnimporter.ForeColor = System.Drawing.SystemColors.Window;
            this.btnimporter.Location = new System.Drawing.Point(602, 134);
            this.btnimporter.Name = "btnimporter";
            this.btnimporter.Size = new System.Drawing.Size(90, 33);
            this.btnimporter.TabIndex = 24;
            this.btnimporter.Text = "importer";
            this.btnimporter.UseVisualStyleBackColor = false;
            this.btnimporter.Click += new System.EventHandler(this.btnimporter_Click);
            // 
            // btnsauvegarder
            // 
            this.btnsauvegarder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(74)))), ((int)(((byte)(65)))));
            this.btnsauvegarder.FlatAppearance.BorderSize = 0;
            this.btnsauvegarder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsauvegarder.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsauvegarder.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnsauvegarder.Image = ((System.Drawing.Image)(resources.GetObject("btnsauvegarder.Image")));
            this.btnsauvegarder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsauvegarder.Location = new System.Drawing.Point(572, 393);
            this.btnsauvegarder.Name = "btnsauvegarder";
            this.btnsauvegarder.Size = new System.Drawing.Size(269, 51);
            this.btnsauvegarder.TabIndex = 22;
            this.btnsauvegarder.Text = "Sauvgarder dans Excel";
            this.btnsauvegarder.UseVisualStyleBackColor = false;
            // 
            // btnimprimertout
            // 
            this.btnimprimertout.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnimprimertout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(74)))), ((int)(((byte)(65)))));
            this.btnimprimertout.FlatAppearance.BorderSize = 0;
            this.btnimprimertout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnimprimertout.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnimprimertout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnimprimertout.Image = ((System.Drawing.Image)(resources.GetObject("btnimprimertout.Image")));
            this.btnimprimertout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnimprimertout.Location = new System.Drawing.Point(299, 393);
            this.btnimprimertout.Name = "btnimprimertout";
            this.btnimprimertout.Size = new System.Drawing.Size(236, 51);
            this.btnimprimertout.TabIndex = 21;
            this.btnimprimertout.Text = "Imprimer toutes";
            this.btnimprimertout.UseVisualStyleBackColor = false;
            // 
            // btnimprimerselect
            // 
            this.btnimprimerselect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnimprimerselect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(74)))), ((int)(((byte)(65)))));
            this.btnimprimerselect.FlatAppearance.BorderSize = 0;
            this.btnimprimerselect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnimprimerselect.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnimprimerselect.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnimprimerselect.Image = ((System.Drawing.Image)(resources.GetObject("btnimprimerselect.Image")));
            this.btnimprimerselect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnimprimerselect.Location = new System.Drawing.Point(13, 393);
            this.btnimprimerselect.Name = "btnimprimerselect";
            this.btnimprimerselect.Size = new System.Drawing.Size(256, 51);
            this.btnimprimerselect.TabIndex = 20;
            this.btnimprimerselect.Text = "Imprimer PR cocher";
            this.btnimprimerselect.UseVisualStyleBackColor = false;
            // 
            // btnafficherphoto
            // 
            this.btnafficherphoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnafficherphoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(178)))), ((int)(((byte)(74)))));
            this.btnafficherphoto.FlatAppearance.BorderSize = 0;
            this.btnafficherphoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnafficherphoto.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnafficherphoto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnafficherphoto.Image = ((System.Drawing.Image)(resources.GetObject("btnafficherphoto.Image")));
            this.btnafficherphoto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnafficherphoto.Location = new System.Drawing.Point(729, 33);
            this.btnafficherphoto.Name = "btnafficherphoto";
            this.btnafficherphoto.Size = new System.Drawing.Size(236, 51);
            this.btnafficherphoto.TabIndex = 19;
            this.btnafficherphoto.Text = "Afficher Photo";
            this.btnafficherphoto.UseVisualStyleBackColor = false;
            this.btnafficherphoto.Click += new System.EventHandler(this.btnafficherphoto_Click);
            // 
            // btnsupprimer
            // 
            this.btnsupprimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsupprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(178)))), ((int)(((byte)(74)))));
            this.btnsupprimer.FlatAppearance.BorderSize = 0;
            this.btnsupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsupprimer.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsupprimer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnsupprimer.Image = ((System.Drawing.Image)(resources.GetObject("btnsupprimer.Image")));
            this.btnsupprimer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsupprimer.Location = new System.Drawing.Point(487, 33);
            this.btnsupprimer.Name = "btnsupprimer";
            this.btnsupprimer.Size = new System.Drawing.Size(225, 51);
            this.btnsupprimer.TabIndex = 13;
            this.btnsupprimer.Text = "Supprimer";
            this.btnsupprimer.UseVisualStyleBackColor = false;
            this.btnsupprimer.Click += new System.EventHandler(this.btnsupprimer_Click);
            // 
            // btnmodifier
            // 
            this.btnmodifier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmodifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(178)))), ((int)(((byte)(74)))));
            this.btnmodifier.FlatAppearance.BorderSize = 0;
            this.btnmodifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmodifier.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodifier.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnmodifier.Image = ((System.Drawing.Image)(resources.GetObject("btnmodifier.Image")));
            this.btnmodifier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmodifier.Location = new System.Drawing.Point(245, 33);
            this.btnmodifier.Name = "btnmodifier";
            this.btnmodifier.Size = new System.Drawing.Size(236, 51);
            this.btnmodifier.TabIndex = 12;
            this.btnmodifier.Text = "Modifier";
            this.btnmodifier.UseVisualStyleBackColor = false;
            this.btnmodifier.Click += new System.EventHandler(this.btnmodifier_Click);
            // 
            // btnajouter
            // 
            this.btnajouter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnajouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(178)))), ((int)(((byte)(74)))));
            this.btnajouter.FlatAppearance.BorderSize = 0;
            this.btnajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnajouter.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnajouter.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnajouter.Image = ((System.Drawing.Image)(resources.GetObject("btnajouter.Image")));
            this.btnajouter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnajouter.Location = new System.Drawing.Point(3, 33);
            this.btnajouter.Name = "btnajouter";
            this.btnajouter.Size = new System.Drawing.Size(236, 51);
            this.btnajouter.TabIndex = 11;
            this.btnajouter.Text = "Ajouter";
            this.btnajouter.UseVisualStyleBackColor = false;
            this.btnajouter.Click += new System.EventHandler(this.btnajouter_Click);
            // 
            // USER_Liste_Produit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(119)))), ((int)(((byte)(78)))));
            this.Controls.Add(this.btnimporter);
            this.Controls.Add(this.dvgProduit);
            this.Controls.Add(this.btnsauvegarder);
            this.Controls.Add(this.btnimprimertout);
            this.Controls.Add(this.btnimprimerselect);
            this.Controls.Add(this.btnafficherphoto);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnsupprimer);
            this.Controls.Add(this.btnmodifier);
            this.Controls.Add(this.btnajouter);
            this.Name = "USER_Liste_Produit";
            this.Size = new System.Drawing.Size(1137, 720);
            this.Load += new System.EventHandler(this.USER_Liste_Produit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgProduit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnsupprimer;
        private System.Windows.Forms.Button btnmodifier;
        private System.Windows.Forms.Button btnajouter;
        private System.Windows.Forms.Button btnafficherphoto;
        private System.Windows.Forms.Button btnsauvegarder;
        private System.Windows.Forms.Button btnimprimertout;
        private System.Windows.Forms.Button btnimprimerselect;
        private System.Windows.Forms.DataGridView dvgProduit;
        private System.Windows.Forms.Button btnimporter;
    }
}
