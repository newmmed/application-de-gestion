namespace GestiondeStock
{
    partial class Supprimer_Produit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Supprimer_Produit));
            this.lbltitre = new System.Windows.Forms.Label();
            this.btnquitter = new System.Windows.Forms.Button();
            this.Labmessage = new System.Windows.Forms.Label();
            this.btnsupprimer = new System.Windows.Forms.Button();
            this.btnretour = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.txtnum = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltitre
            // 
            this.lbltitre.AutoSize = true;
            this.lbltitre.Font = new System.Drawing.Font("Corbel", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitre.ForeColor = System.Drawing.SystemColors.Window;
            this.lbltitre.Location = new System.Drawing.Point(87, 13);
            this.lbltitre.Name = "lbltitre";
            this.lbltitre.Size = new System.Drawing.Size(246, 36);
            this.lbltitre.TabIndex = 49;
            this.lbltitre.Text = "Supprimer Produit";
            // 
            // btnquitter
            // 
            this.btnquitter.FlatAppearance.BorderSize = 0;
            this.btnquitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnquitter.Image = ((System.Drawing.Image)(resources.GetObject("btnquitter.Image")));
            this.btnquitter.Location = new System.Drawing.Point(418, 12);
            this.btnquitter.Name = "btnquitter";
            this.btnquitter.Size = new System.Drawing.Size(49, 37);
            this.btnquitter.TabIndex = 50;
            this.btnquitter.UseVisualStyleBackColor = true;
            this.btnquitter.Click += new System.EventHandler(this.btnquitter_Click);
            // 
            // Labmessage
            // 
            this.Labmessage.AutoSize = true;
            this.Labmessage.Location = new System.Drawing.Point(173, 239);
            this.Labmessage.Name = "Labmessage";
            this.Labmessage.Size = new System.Drawing.Size(0, 13);
            this.Labmessage.TabIndex = 68;
            // 
            // btnsupprimer
            // 
            this.btnsupprimer.BackColor = System.Drawing.Color.DarkRed;
            this.btnsupprimer.FlatAppearance.BorderSize = 0;
            this.btnsupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsupprimer.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsupprimer.ForeColor = System.Drawing.SystemColors.Window;
            this.btnsupprimer.Location = new System.Drawing.Point(224, 171);
            this.btnsupprimer.Name = "btnsupprimer";
            this.btnsupprimer.Size = new System.Drawing.Size(125, 31);
            this.btnsupprimer.TabIndex = 67;
            this.btnsupprimer.Text = "Supprimer";
            this.btnsupprimer.UseVisualStyleBackColor = false;
            this.btnsupprimer.Click += new System.EventHandler(this.btnsupprimer_Click);
            // 
            // btnretour
            // 
            this.btnretour.BackColor = System.Drawing.Color.DarkRed;
            this.btnretour.FlatAppearance.BorderSize = 0;
            this.btnretour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnretour.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnretour.ForeColor = System.Drawing.SystemColors.Window;
            this.btnretour.Location = new System.Drawing.Point(93, 171);
            this.btnretour.Name = "btnretour";
            this.btnretour.Size = new System.Drawing.Size(112, 31);
            this.btnretour.TabIndex = 66;
            this.btnretour.Text = "Retour";
            this.btnretour.UseVisualStyleBackColor = false;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel7.Location = new System.Drawing.Point(144, 121);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(135, 2);
            this.panel7.TabIndex = 65;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::GestiondeStock.Properties.Resources.login_32;
            this.pictureBox7.Location = new System.Drawing.Point(107, 91);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(32, 32);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox7.TabIndex = 64;
            this.pictureBox7.TabStop = false;
            // 
            // txtnum
            // 
            this.txtnum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.txtnum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnum.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnum.ForeColor = System.Drawing.SystemColors.Info;
            this.txtnum.Location = new System.Drawing.Point(145, 102);
            this.txtnum.Multiline = true;
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(134, 21);
            this.txtnum.TabIndex = 63;
            this.txtnum.Text = "Id Produit";
            this.txtnum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtnum.Enter += new System.EventHandler(this.txtnum_Entrer);
            this.txtnum.Leave += new System.EventHandler(this.txtnum_Leave);
            // 
            // Supprimer_Produit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(479, 374);
            this.Controls.Add(this.Labmessage);
            this.Controls.Add(this.btnsupprimer);
            this.Controls.Add(this.btnretour);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.txtnum);
            this.Controls.Add(this.btnquitter);
            this.Controls.Add(this.lbltitre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Supprimer_Produit";
            this.Text = "Supprimer_Produit";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnquitter;
        public System.Windows.Forms.Label lbltitre;
        private System.Windows.Forms.Label Labmessage;
        private System.Windows.Forms.Button btnsupprimer;
        private System.Windows.Forms.Button btnretour;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.TextBox txtnum;
    }
}