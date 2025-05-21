namespace GestiondeStock
{
    partial class pnlafficher
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
            System.Windows.Forms.Button btnConnecter;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pnlafficher));
            System.Windows.Forms.Button btndéconnecter;
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlBut = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.btnutilisateur = new System.Windows.Forms.Button();
            this.btncommande = new System.Windows.Forms.Button();
            this.btnproduit = new System.Windows.Forms.Button();
            this.btnclient = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnparamettre = new System.Windows.Forms.Button();
            this.pnlParamettre = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlaficher = new System.Windows.Forms.Panel();
            btnConnecter = new System.Windows.Forms.Button();
            btndéconnecter = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnlParamettre.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConnecter
            // 
            btnConnecter.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            btnConnecter.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            resources.ApplyResources(btnConnecter, "btnConnecter");
            btnConnecter.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            btnConnecter.Image = global::GestiondeStock.Properties.Resources.login_32;
            btnConnecter.Name = "btnConnecter";
            btnConnecter.UseVisualStyleBackColor = false;
            btnConnecter.Click += new System.EventHandler(this.button4_Click);
            // 
            // btndéconnecter
            // 
            btndéconnecter.BackColor = System.Drawing.SystemColors.MenuText;
            btndéconnecter.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            btndéconnecter.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            resources.ApplyResources(btndéconnecter, "btndéconnecter");
            btndéconnecter.Name = "btndéconnecter";
            btndéconnecter.UseVisualStyleBackColor = false;
            btndéconnecter.Click += new System.EventHandler(this.btndéconnecter_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.pnlBut);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.btnutilisateur);
            this.panel1.Controls.Add(this.btncommande);
            this.panel1.Controls.Add(this.btnproduit);
            this.panel1.Controls.Add(this.btnclient);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pnlBut
            // 
            this.pnlBut.BackColor = System.Drawing.Color.Maroon;
            resources.ApplyResources(this.pnlBut, "pnlBut");
            this.pnlBut.Name = "pnlBut";
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnutilisateur
            // 
            this.btnutilisateur.BackColor = System.Drawing.Color.Transparent;
            this.btnutilisateur.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnutilisateur, "btnutilisateur");
            this.btnutilisateur.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnutilisateur.Name = "btnutilisateur";
            this.btnutilisateur.UseVisualStyleBackColor = false;
            this.btnutilisateur.Click += new System.EventHandler(this.btnutilisateur_Click);
            // 
            // btncommande
            // 
            this.btncommande.BackColor = System.Drawing.Color.Transparent;
            this.btncommande.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btncommande, "btncommande");
            this.btncommande.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btncommande.Name = "btncommande";
            this.btncommande.UseVisualStyleBackColor = false;
            this.btncommande.Click += new System.EventHandler(this.btncommande_Click);
            // 
            // btnproduit
            // 
            this.btnproduit.BackColor = System.Drawing.Color.Transparent;
            this.btnproduit.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnproduit, "btnproduit");
            this.btnproduit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnproduit.Name = "btnproduit";
            this.btnproduit.UseVisualStyleBackColor = false;
            this.btnproduit.Click += new System.EventHandler(this.btnproduit_Click);
            // 
            // btnclient
            // 
            this.btnclient.BackColor = System.Drawing.Color.Transparent;
            this.btnclient.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnclient, "btnclient");
            this.btnclient.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnclient.Name = "btnclient";
            this.btnclient.UseVisualStyleBackColor = false;
            this.btnclient.Click += new System.EventHandler(this.btnclient_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(74)))), ((int)(((byte)(65)))));
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnparamettre
            // 
            this.btnparamettre.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnparamettre, "btnparamettre");
            this.btnparamettre.Name = "btnparamettre";
            this.btnparamettre.UseVisualStyleBackColor = true;
            this.btnparamettre.Click += new System.EventHandler(this.btnparamettre_Click);
            // 
            // pnlParamettre
            // 
            this.pnlParamettre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(74)))), ((int)(((byte)(65)))));
            this.pnlParamettre.Controls.Add(btndéconnecter);
            this.pnlParamettre.Controls.Add(btnConnecter);
            this.pnlParamettre.ForeColor = System.Drawing.SystemColors.ControlText;
            resources.ApplyResources(this.pnlParamettre, "pnlParamettre");
            this.pnlParamettre.Name = "pnlParamettre";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(74)))), ((int)(((byte)(65)))));
            this.panel3.Controls.Add(this.pnlaficher);
            this.panel3.Controls.Add(this.pnlParamettre);
            this.panel3.Controls.Add(this.btnparamettre);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button1);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.Name = "panel3";
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // pnlaficher
            // 
            resources.ApplyResources(this.pnlaficher, "pnlaficher");
            this.pnlaficher.BackColor = System.Drawing.SystemColors.Control;
            this.pnlaficher.Name = "pnlaficher";
            // 
            // pnlafficher
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.Name = "pnlafficher";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.pnlafficher_Load);
            this.panel1.ResumeLayout(false);
            this.pnlParamettre.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnclient;
        private System.Windows.Forms.Button btnutilisateur;
        private System.Windows.Forms.Button btncommande;
        private System.Windows.Forms.Button btnproduit;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel pnlBut;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnparamettre;
        private System.Windows.Forms.Panel pnlParamettre;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlaficher;
    }
}