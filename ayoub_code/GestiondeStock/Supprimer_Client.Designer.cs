namespace GestiondeStock
{
    partial class Supprimer_Client
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Supprimer_Client));
            this.panel7 = new System.Windows.Forms.Panel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.btnquitter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Labmessage2 = new System.Windows.Forms.Label();
            this.btnsupprimer = new System.Windows.Forms.Button();
            this.btnretour = new System.Windows.Forms.Button();
            this.Labmessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel7.Location = new System.Drawing.Point(86, 106);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(135, 2);
            this.panel7.TabIndex = 58;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::GestiondeStock.Properties.Resources.login_32;
            this.pictureBox7.Location = new System.Drawing.Point(49, 76);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(32, 32);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox7.TabIndex = 57;
            this.pictureBox7.TabStop = false;
            // 
            // txtnum
            // 
            this.txtnum.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtnum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnum.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtnum.Location = new System.Drawing.Point(87, 87);
            this.txtnum.Multiline = true;
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(134, 21);
            this.txtnum.TabIndex = 56;
            this.txtnum.Text = "ID Client";
            this.txtnum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtnum.TextChanged += new System.EventHandler(this.txtnum_TextChanged);
            this.txtnum.Enter += new System.EventHandler(this.txtnum_Entrer);
            this.txtnum.Leave += new System.EventHandler(this.txtnum_Leave);
            // 
            // btnquitter
            // 
            this.btnquitter.FlatAppearance.BorderSize = 0;
            this.btnquitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnquitter.Image = ((System.Drawing.Image)(resources.GetObject("btnquitter.Image")));
            this.btnquitter.Location = new System.Drawing.Point(312, 6);
            this.btnquitter.Name = "btnquitter";
            this.btnquitter.Size = new System.Drawing.Size(49, 37);
            this.btnquitter.TabIndex = 55;
            this.btnquitter.UseVisualStyleBackColor = true;
            this.btnquitter.Click += new System.EventHandler(this.btnquitter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 36);
            this.label1.TabIndex = 54;
            this.label1.Text = "Supprimer Client";
            // 
            // Labmessage2
            // 
            this.Labmessage2.AutoSize = true;
            this.Labmessage2.Location = new System.Drawing.Point(163, 250);
            this.Labmessage2.Name = "Labmessage2";
            this.Labmessage2.Size = new System.Drawing.Size(0, 13);
            this.Labmessage2.TabIndex = 61;
            // 
            // btnsupprimer
            // 
            this.btnsupprimer.BackColor = System.Drawing.Color.Red;
            this.btnsupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsupprimer.Location = new System.Drawing.Point(166, 156);
            this.btnsupprimer.Name = "btnsupprimer";
            this.btnsupprimer.Size = new System.Drawing.Size(125, 31);
            this.btnsupprimer.TabIndex = 60;
            this.btnsupprimer.Text = "Supprimer";
            this.btnsupprimer.UseVisualStyleBackColor = false;
            this.btnsupprimer.Click += new System.EventHandler(this.btnsupprimer_Click);
            // 
            // btnretour
            // 
            this.btnretour.BackColor = System.Drawing.Color.Red;
            this.btnretour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnretour.Location = new System.Drawing.Point(35, 156);
            this.btnretour.Name = "btnretour";
            this.btnretour.Size = new System.Drawing.Size(112, 31);
            this.btnretour.TabIndex = 59;
            this.btnretour.Text = "Retour";
            this.btnretour.UseVisualStyleBackColor = false;
            this.btnretour.Click += new System.EventHandler(this.btnretour_Click);
            // 
            // Labmessage
            // 
            this.Labmessage.AutoSize = true;
            this.Labmessage.Location = new System.Drawing.Point(115, 224);
            this.Labmessage.Name = "Labmessage";
            this.Labmessage.Size = new System.Drawing.Size(0, 13);
            this.Labmessage.TabIndex = 62;
            // 
            // Supprimer_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(373, 297);
            this.Controls.Add(this.Labmessage);
            this.Controls.Add(this.Labmessage2);
            this.Controls.Add(this.btnsupprimer);
            this.Controls.Add(this.btnretour);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.txtnum);
            this.Controls.Add(this.btnquitter);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Supprimer_Client";
            this.Text = "Supprimer_Client";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.Button btnquitter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Labmessage2;
        private System.Windows.Forms.Button btnsupprimer;
        private System.Windows.Forms.Button btnretour;
        private System.Windows.Forms.Label Labmessage;
    }
}