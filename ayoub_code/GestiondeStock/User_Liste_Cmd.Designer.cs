namespace GestiondeStock
{
    partial class User_Liste_Cmd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_Liste_Cmd));
            this.btnimporter = new System.Windows.Forms.Button();
            this.dvgProduit = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnsupprimer = new System.Windows.Forms.Button();
            this.btnmodifier = new System.Windows.Forms.Button();
            this.btnajouter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgProduit)).BeginInit();
            this.SuspendLayout();
            // 
            // btnimporter
            // 
            this.btnimporter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(74)))), ((int)(((byte)(65)))));
            this.btnimporter.FlatAppearance.BorderSize = 0;
            this.btnimporter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnimporter.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnimporter.ForeColor = System.Drawing.SystemColors.Window;
            this.btnimporter.Location = new System.Drawing.Point(590, 108);
            this.btnimporter.Name = "btnimporter";
            this.btnimporter.Size = new System.Drawing.Size(90, 33);
            this.btnimporter.TabIndex = 33;
            this.btnimporter.Text = "importer";
            this.btnimporter.UseVisualStyleBackColor = false;
            this.btnimporter.Click += new System.EventHandler(this.btnimporter_Click);
            // 
            // dvgProduit
            // 
            this.dvgProduit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(74)))), ((int)(((byte)(65)))));
            this.dvgProduit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgProduit.Location = new System.Drawing.Point(36, 168);
            this.dvgProduit.Name = "dvgProduit";
            this.dvgProduit.Size = new System.Drawing.Size(697, 189);
            this.dvgProduit.TabIndex = 32;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Location = new System.Drawing.Point(21, 17);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(760, 2);
            this.panel4.TabIndex = 37;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(21, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 2);
            this.panel1.TabIndex = 38;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.btnsupprimer.TabIndex = 36;
            this.btnsupprimer.Text = "Supprimer";
            this.btnsupprimer.UseVisualStyleBackColor = false;
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
            this.btnmodifier.TabIndex = 35;
            this.btnmodifier.Text = "Modifier";
            this.btnmodifier.UseVisualStyleBackColor = false;
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
            this.btnajouter.TabIndex = 34;
            this.btnajouter.Text = "Ajouter";
            this.btnajouter.UseVisualStyleBackColor = false;
            this.btnajouter.Click += new System.EventHandler(this.btnajouter_Click_1);
            // 
            // User_Liste_Cmd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(119)))), ((int)(((byte)(78)))));
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnsupprimer);
            this.Controls.Add(this.btnmodifier);
            this.Controls.Add(this.btnajouter);
            this.Controls.Add(this.btnimporter);
            this.Controls.Add(this.dvgProduit);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "User_Liste_Cmd";
            this.Size = new System.Drawing.Size(823, 389);
            ((System.ComponentModel.ISupportInitialize)(this.dvgProduit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnimporter;
        private System.Windows.Forms.DataGridView dvgProduit;
        public System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button btnsupprimer;
        public System.Windows.Forms.Button btnmodifier;
        public System.Windows.Forms.Button btnajouter;
    }
}
