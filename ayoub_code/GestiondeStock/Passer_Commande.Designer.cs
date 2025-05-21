namespace GestiondeStock
{
    partial class Passer_Commande
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Passer_Commande));
            this.btnquitter = new System.Windows.Forms.Button();
            this.lbltitre = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.combocategorie = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtNumm = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txtQuantité = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.txtPrix = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtNomP = new System.Windows.Forms.TextBox();
            this.btnannuler = new System.Windows.Forms.Button();
            this.btnCommander = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnquitter
            // 
            this.btnquitter.FlatAppearance.BorderSize = 0;
            this.btnquitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnquitter.Image = ((System.Drawing.Image)(resources.GetObject("btnquitter.Image")));
            this.btnquitter.Location = new System.Drawing.Point(531, 12);
            this.btnquitter.Name = "btnquitter";
            this.btnquitter.Size = new System.Drawing.Size(49, 37);
            this.btnquitter.TabIndex = 49;
            this.btnquitter.UseVisualStyleBackColor = true;
            this.btnquitter.Click += new System.EventHandler(this.btnquitter_Click);
            // 
            // lbltitre
            // 
            this.lbltitre.AutoSize = true;
            this.lbltitre.Font = new System.Drawing.Font("Corbel", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitre.ForeColor = System.Drawing.SystemColors.Window;
            this.lbltitre.Location = new System.Drawing.Point(115, 13);
            this.lbltitre.Name = "lbltitre";
            this.lbltitre.Size = new System.Drawing.Size(296, 36);
            this.lbltitre.TabIndex = 50;
            this.lbltitre.Text = "Passer une commande";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::GestiondeStock.Properties.Resources.login_32;
            this.pictureBox7.Location = new System.Drawing.Point(33, 78);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(32, 32);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox7.TabIndex = 92;
            this.pictureBox7.TabStop = false;
            // 
            // txtnum
            // 
            this.txtnum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.txtnum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnum.ForeColor = System.Drawing.SystemColors.Window;
            this.txtnum.Location = new System.Drawing.Point(49, 90);
            this.txtnum.Multiline = true;
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(134, 21);
            this.txtnum.TabIndex = 91;
            this.txtnum.Text = "ID Produit";
            this.txtnum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtnum.Enter += new System.EventHandler(this.txtnum_Entrer);
            this.txtnum.Leave += new System.EventHandler(this.txtnum_Leave);
            // 
            // combocategorie
            // 
            this.combocategorie.FormattingEnabled = true;
            this.combocategorie.Location = new System.Drawing.Point(374, 91);
            this.combocategorie.Name = "combocategorie";
            this.combocategorie.Size = new System.Drawing.Size(174, 21);
            this.combocategorie.TabIndex = 90;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(287, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 19);
            this.label3.TabIndex = 89;
            this.label3.Text = "Categorie:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GestiondeStock.Properties.Resources.login_32;
            this.pictureBox1.Location = new System.Drawing.Point(33, 131);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 94;
            this.pictureBox1.TabStop = false;
            // 
            // txtNumm
            // 
            this.txtNumm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.txtNumm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumm.ForeColor = System.Drawing.SystemColors.Window;
            this.txtNumm.Location = new System.Drawing.Point(49, 143);
            this.txtNumm.Multiline = true;
            this.txtNumm.Name = "txtNumm";
            this.txtNumm.Size = new System.Drawing.Size(134, 21);
            this.txtNumm.TabIndex = 93;
            this.txtNumm.Text = "ID Client";
            this.txtNumm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNumm.Enter += new System.EventHandler(this.txtNum_Entrer);
            this.txtNumm.Leave += new System.EventHandler(this.txtNum_Leave);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(32, 182);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 96;
            this.pictureBox3.TabStop = false;
            // 
            // txtQuantité
            // 
            this.txtQuantité.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.txtQuantité.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQuantité.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantité.ForeColor = System.Drawing.SystemColors.Window;
            this.txtQuantité.Location = new System.Drawing.Point(91, 193);
            this.txtQuantité.Multiline = true;
            this.txtQuantité.Name = "txtQuantité";
            this.txtQuantité.Size = new System.Drawing.Size(134, 21);
            this.txtQuantité.TabIndex = 95;
            this.txtQuantité.Text = "Quantité";
            this.txtQuantité.Enter += new System.EventHandler(this.txtQuantité_Entrer);
            this.txtQuantité.Leave += new System.EventHandler(this.txtQuantité_Leave);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(211, 233);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 97;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(211, 273);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 98;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 20);
            this.label1.TabIndex = 99;
            this.label1.Text = "Date d\'arrivé souhaitée";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(60, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 20);
            this.label2.TabIndex = 100;
            this.label2.Text = "Date d\'expiration";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DimGray;
            this.panel4.Location = new System.Drawing.Point(72, 345);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(135, 2);
            this.panel4.TabIndex = 103;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(35, 315);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 102;
            this.pictureBox4.TabStop = false;
            // 
            // txtPrix
            // 
            this.txtPrix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.txtPrix.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrix.ForeColor = System.Drawing.SystemColors.Window;
            this.txtPrix.Location = new System.Drawing.Point(73, 326);
            this.txtPrix.Multiline = true;
            this.txtPrix.Name = "txtPrix";
            this.txtPrix.Size = new System.Drawing.Size(134, 21);
            this.txtPrix.TabIndex = 101;
            this.txtPrix.Text = "Prix";
            this.txtPrix.Enter += new System.EventHandler(this.txtPrix_Entrer);
            this.txtPrix.Leave += new System.EventHandler(this.txtPrix_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(374, 162);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(135, 2);
            this.panel1.TabIndex = 106;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(335, 132);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 105;
            this.pictureBox2.TabStop = false;
            // 
            // txtNomP
            // 
            this.txtNomP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.txtNomP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomP.ForeColor = System.Drawing.SystemColors.Window;
            this.txtNomP.Location = new System.Drawing.Point(375, 143);
            this.txtNomP.Multiline = true;
            this.txtNomP.Name = "txtNomP";
            this.txtNomP.Size = new System.Drawing.Size(134, 21);
            this.txtNomP.TabIndex = 104;
            this.txtNomP.Text = "Nom Produit";
            this.txtNomP.Enter += new System.EventHandler(this.txtNomP_Entrer);
            this.txtNomP.Leave += new System.EventHandler(this.txtNomP_Leave);
            // 
            // btnannuler
            // 
            this.btnannuler.BackColor = System.Drawing.Color.DarkRed;
            this.btnannuler.FlatAppearance.BorderSize = 0;
            this.btnannuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnannuler.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnannuler.ForeColor = System.Drawing.SystemColors.Window;
            this.btnannuler.Location = new System.Drawing.Point(283, 384);
            this.btnannuler.Name = "btnannuler";
            this.btnannuler.Size = new System.Drawing.Size(125, 31);
            this.btnannuler.TabIndex = 108;
            this.btnannuler.Text = "Annuler";
            this.btnannuler.UseVisualStyleBackColor = false;
            // 
            // btnCommander
            // 
            this.btnCommander.BackColor = System.Drawing.Color.DarkRed;
            this.btnCommander.FlatAppearance.BorderSize = 0;
            this.btnCommander.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCommander.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCommander.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCommander.Location = new System.Drawing.Point(152, 384);
            this.btnCommander.Name = "btnCommander";
            this.btnCommander.Size = new System.Drawing.Size(112, 31);
            this.btnCommander.TabIndex = 107;
            this.btnCommander.Text = "Commander";
            this.btnCommander.UseVisualStyleBackColor = false;
            // 
            // Passer_Commande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(582, 427);
            this.Controls.Add(this.btnannuler);
            this.Controls.Add(this.btnCommander);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtNomP);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.txtPrix);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.txtQuantité);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtNumm);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.txtnum);
            this.Controls.Add(this.combocategorie);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbltitre);
            this.Controls.Add(this.btnquitter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Passer_Commande";
            this.Text = "Passer_Commande";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnquitter;
        public System.Windows.Forms.Label lbltitre;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.ComboBox combocategorie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtNumm;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txtQuantité;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox txtPrix;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtNomP;
        private System.Windows.Forms.Button btnannuler;
        public System.Windows.Forms.Button btnCommander;
    }
}