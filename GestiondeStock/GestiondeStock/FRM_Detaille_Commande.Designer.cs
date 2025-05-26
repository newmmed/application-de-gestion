namespace GestiondeStock
{
    partial class FRM_Detaille_Commande
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Detaille_Commande));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtrecherche = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dvgProduit1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.textVille = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.textPays = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.btnClient = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTVA = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTTC = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTotalHT = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dvgProduit = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbltitre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnquitter = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgProduit1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgProduit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtrecherche);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.dvgProduit1);
            this.panel1.Location = new System.Drawing.Point(0, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(297, 355);
            this.panel1.TabIndex = 0;
            // 
            // txtrecherche
            // 
            this.txtrecherche.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.txtrecherche.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtrecherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrecherche.ForeColor = System.Drawing.SystemColors.Window;
            this.txtrecherche.Location = new System.Drawing.Point(112, 15);
            this.txtrecherche.Multiline = true;
            this.txtrecherche.Name = "txtrecherche";
            this.txtrecherche.Size = new System.Drawing.Size(134, 21);
            this.txtrecherche.TabIndex = 90;
            this.txtrecherche.Text = "Recherche";
            this.txtrecherche.TextChanged += new System.EventHandler(this.txtrecherche_TextChanged);
            this.txtrecherche.Enter += new System.EventHandler(this.txtrecherche_Enter);
            this.txtrecherche.Leave += new System.EventHandler(this.txtrecherche_Leave);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(74)))), ((int)(((byte)(65)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(3, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 26);
            this.button1.TabIndex = 86;
            this.button1.Text = "importer";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // dvgProduit1
            // 
            this.dvgProduit1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(74)))), ((int)(((byte)(65)))));
            this.dvgProduit1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgProduit1.Location = new System.Drawing.Point(3, 67);
            this.dvgProduit1.Name = "dvgProduit1";
            this.dvgProduit1.Size = new System.Drawing.Size(291, 277);
            this.dvgProduit1.TabIndex = 85;
            this.dvgProduit1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgProduit1_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.textVille);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.textPays);
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.textEmail);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.txtTelephone);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.txtPrenom);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.txtNom);
            this.panel2.Controls.Add(this.btnClient);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.txtTVA);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtTTC);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txtTotalHT);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.dvgProduit);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(303, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(539, 344);
            this.panel2.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel6.Location = new System.Drawing.Point(377, 94);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(135, 2);
            this.panel6.TabIndex = 108;
            // 
            // textVille
            // 
            this.textVille.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.textVille.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textVille.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textVille.ForeColor = System.Drawing.SystemColors.Window;
            this.textVille.Location = new System.Drawing.Point(380, 75);
            this.textVille.Multiline = true;
            this.textVille.Name = "textVille";
            this.textVille.Size = new System.Drawing.Size(134, 21);
            this.textVille.TabIndex = 107;
            this.textVille.Text = "Ville";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel7.Location = new System.Drawing.Point(236, 94);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(135, 2);
            this.panel7.TabIndex = 106;
            // 
            // textPays
            // 
            this.textPays.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.textPays.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textPays.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPays.ForeColor = System.Drawing.SystemColors.Window;
            this.textPays.Location = new System.Drawing.Point(239, 75);
            this.textPays.Multiline = true;
            this.textPays.Name = "textPays";
            this.textPays.Size = new System.Drawing.Size(134, 21);
            this.textPays.TabIndex = 105;
            this.textPays.Text = "Pays";
            this.textPays.Enter += new System.EventHandler(this.txtPays_Enter);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel8.Location = new System.Drawing.Point(96, 94);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(135, 2);
            this.panel8.TabIndex = 104;
            // 
            // textEmail
            // 
            this.textEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.textEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEmail.ForeColor = System.Drawing.SystemColors.Window;
            this.textEmail.Location = new System.Drawing.Point(96, 75);
            this.textEmail.Multiline = true;
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(134, 21);
            this.textEmail.TabIndex = 103;
            this.textEmail.Text = "Email";
            this.textEmail.Enter += new System.EventHandler(this.txtEmail_Enter);
            this.textEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel5.Location = new System.Drawing.Point(375, 41);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(135, 2);
            this.panel5.TabIndex = 102;
            // 
            // txtTelephone
            // 
            this.txtTelephone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.txtTelephone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelephone.ForeColor = System.Drawing.SystemColors.Window;
            this.txtTelephone.Location = new System.Drawing.Point(378, 22);
            this.txtTelephone.Multiline = true;
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(134, 21);
            this.txtTelephone.TabIndex = 101;
            this.txtTelephone.Text = "Telephone";
            this.txtTelephone.Enter += new System.EventHandler(this.txtTelephone_Enter);
            this.txtTelephone.Leave += new System.EventHandler(this.txtTelephone_Leave);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Location = new System.Drawing.Point(234, 41);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(135, 2);
            this.panel4.TabIndex = 100;
            // 
            // txtPrenom
            // 
            this.txtPrenom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.txtPrenom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrenom.ForeColor = System.Drawing.SystemColors.Window;
            this.txtPrenom.Location = new System.Drawing.Point(237, 22);
            this.txtPrenom.Multiline = true;
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(134, 21);
            this.txtPrenom.TabIndex = 99;
            this.txtPrenom.Text = "Prenom";
            this.txtPrenom.Enter += new System.EventHandler(this.txtPrenom_Enter);
            this.txtPrenom.Leave += new System.EventHandler(this.txtPrenom_Leave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(94, 41);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(135, 2);
            this.panel3.TabIndex = 98;
            // 
            // txtNom
            // 
            this.txtNom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.txtNom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNom.ForeColor = System.Drawing.SystemColors.Window;
            this.txtNom.Location = new System.Drawing.Point(94, 22);
            this.txtNom.Multiline = true;
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(134, 21);
            this.txtNom.TabIndex = 96;
            this.txtNom.Text = "Nom ";
            this.txtNom.TextChanged += new System.EventHandler(this.txtNomP_TextChanged);
            this.txtNom.Enter += new System.EventHandler(this.txtNom_Enter);
            this.txtNom.Leave += new System.EventHandler(this.txtNom_Leave);
            // 
            // btnClient
            // 
            this.btnClient.BackColor = System.Drawing.Color.Blue;
            this.btnClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClient.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClient.Location = new System.Drawing.Point(7, 39);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(41, 23);
            this.btnClient.TabIndex = 95;
            this.btnClient.Text = "...";
            this.btnClient.UseVisualStyleBackColor = false;
            this.btnClient.Click += new System.EventHandler(this.btnAjouterCommande_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.Window;
            this.label13.Location = new System.Drawing.Point(307, 298);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(22, 19);
            this.label13.TabIndex = 94;
            this.label13.Text = "%";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // txtTVA
            // 
            this.txtTVA.Enabled = false;
            this.txtTVA.Location = new System.Drawing.Point(222, 297);
            this.txtTVA.Name = "txtTVA";
            this.txtTVA.Size = new System.Drawing.Size(83, 24);
            this.txtTVA.TabIndex = 93;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Window;
            this.label10.Location = new System.Drawing.Point(173, 297);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 19);
            this.label10.TabIndex = 92;
            this.label10.Text = "TVA:";
            // 
            // txtTTC
            // 
            this.txtTTC.Enabled = false;
            this.txtTTC.Location = new System.Drawing.Point(429, 298);
            this.txtTTC.Name = "txtTTC";
            this.txtTTC.Size = new System.Drawing.Size(99, 24);
            this.txtTTC.TabIndex = 91;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Window;
            this.label11.Location = new System.Drawing.Point(331, 299);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 19);
            this.label11.TabIndex = 90;
            this.label11.Text = "TOTAL TTC:";
            // 
            // txtTotalHT
            // 
            this.txtTotalHT.Enabled = false;
            this.txtTotalHT.Location = new System.Drawing.Point(94, 297);
            this.txtTotalHT.Name = "txtTotalHT";
            this.txtTotalHT.Size = new System.Drawing.Size(73, 24);
            this.txtTotalHT.TabIndex = 89;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.Window;
            this.label12.Location = new System.Drawing.Point(9, 295);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 19);
            this.label12.TabIndex = 88;
            this.label12.Text = "TOTAL HT:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(74)))), ((int)(((byte)(65)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Window;
            this.button2.Location = new System.Drawing.Point(13, 136);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 26);
            this.button2.TabIndex = 87;
            this.button2.Text = "importer";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // dvgProduit
            // 
            this.dvgProduit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(74)))), ((int)(((byte)(65)))));
            this.dvgProduit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgProduit.Location = new System.Drawing.Point(13, 172);
            this.dvgProduit.Name = "dvgProduit";
            this.dvgProduit.Size = new System.Drawing.Size(515, 120);
            this.dvgProduit.TabIndex = 84;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(311, 146);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(181, 24);
            this.dateTimePicker1.TabIndex = 83;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Chartreuse;
            this.label9.Location = new System.Drawing.Point(135, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 23);
            this.label9.TabIndex = 82;
            this.label9.Text = "Date Commande";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(3, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 23);
            this.label2.TabIndex = 69;
            this.label2.Text = "Client";
            // 
            // lbltitre
            // 
            this.lbltitre.AutoSize = true;
            this.lbltitre.Font = new System.Drawing.Font("Corbel", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitre.ForeColor = System.Drawing.SystemColors.Window;
            this.lbltitre.Location = new System.Drawing.Point(399, 3);
            this.lbltitre.Name = "lbltitre";
            this.lbltitre.Size = new System.Drawing.Size(260, 36);
            this.lbltitre.TabIndex = 68;
            this.lbltitre.Text = "Ajouter Commande";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(49, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 36);
            this.label1.TabIndex = 69;
            this.label1.Text = "Produit";
            // 
            // btnquitter
            // 
            this.btnquitter.FlatAppearance.BorderSize = 0;
            this.btnquitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnquitter.Image = ((System.Drawing.Image)(resources.GetObject("btnquitter.Image")));
            this.btnquitter.Location = new System.Drawing.Point(808, -1);
            this.btnquitter.Name = "btnquitter";
            this.btnquitter.Size = new System.Drawing.Size(49, 37);
            this.btnquitter.TabIndex = 70;
            this.btnquitter.UseVisualStyleBackColor = true;
            this.btnquitter.Click += new System.EventHandler(this.btnquitter_Click);
            // 
            // FRM_Detaille_Commande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(869, 450);
            this.Controls.Add(this.btnquitter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbltitre);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_Detaille_Commande";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_Detaille_Commande";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgProduit1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgProduit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label lbltitre;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dvgProduit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dvgProduit1;
        private System.Windows.Forms.TextBox txtTVA;
        public System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTTC;
        public System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTotalHT;
        public System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtrecherche;
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Button btnquitter;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox textVille;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox textPays;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtTelephone;
    }
}