namespace WindowsFormsApplication1
{
    partial class FrmList
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btn1to2 = new System.Windows.Forms.Button();
            this.btn2to1 = new System.Windows.Forms.Button();
            this.btnEffacer2 = new System.Windows.Forms.Button();
            this.btnEffacer1 = new System.Windows.Forms.Button();
            this.txtSaisie = new System.Windows.Forms.TextBox();
            this.lst1 = new System.Windows.Forms.ListBox();
            this.lst2 = new System.Windows.Forms.ListBox();
            this.lblsaisie = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAjouter
            // 
            this.btnAjouter.Enabled = false;
            this.btnAjouter.Location = new System.Drawing.Point(352, 34);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(103, 23);
            this.btnAjouter.TabIndex = 0;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btn1to2
            // 
            this.btn1to2.Enabled = false;
            this.btn1to2.Location = new System.Drawing.Point(253, 145);
            this.btn1to2.Name = "btn1to2";
            this.btn1to2.Size = new System.Drawing.Size(75, 23);
            this.btn1to2.TabIndex = 1;
            this.btn1to2.Text = "-->";
            this.btn1to2.UseVisualStyleBackColor = true;
            this.btn1to2.Click += new System.EventHandler(this.btn1to2_Click);
            // 
            // btn2to1
            // 
            this.btn2to1.Enabled = false;
            this.btn2to1.Location = new System.Drawing.Point(253, 196);
            this.btn2to1.Name = "btn2to1";
            this.btn2to1.Size = new System.Drawing.Size(75, 23);
            this.btn2to1.TabIndex = 2;
            this.btn2to1.Text = "<--";
            this.btn2to1.UseVisualStyleBackColor = true;
            this.btn2to1.Click += new System.EventHandler(this.btn2to1_Click);
            // 
            // btnEffacer2
            // 
            this.btnEffacer2.Enabled = false;
            this.btnEffacer2.Location = new System.Drawing.Point(438, 278);
            this.btnEffacer2.Name = "btnEffacer2";
            this.btnEffacer2.Size = new System.Drawing.Size(75, 23);
            this.btnEffacer2.TabIndex = 3;
            this.btnEffacer2.Text = "Effacer";
            this.btnEffacer2.UseVisualStyleBackColor = true;
            this.btnEffacer2.Click += new System.EventHandler(this.btnEffacer2_Click);
            // 
            // btnEffacer1
            // 
            this.btnEffacer1.Enabled = false;
            this.btnEffacer1.Location = new System.Drawing.Point(75, 278);
            this.btnEffacer1.Name = "btnEffacer1";
            this.btnEffacer1.Size = new System.Drawing.Size(75, 23);
            this.btnEffacer1.TabIndex = 4;
            this.btnEffacer1.Text = "Effacer";
            this.btnEffacer1.UseVisualStyleBackColor = true;
            this.btnEffacer1.Click += new System.EventHandler(this.btnEffacer1_Click);
            // 
            // txtSaisie
            // 
            this.txtSaisie.Location = new System.Drawing.Point(121, 34);
            this.txtSaisie.Name = "txtSaisie";
            this.txtSaisie.Size = new System.Drawing.Size(174, 20);
            this.txtSaisie.TabIndex = 5;
            this.txtSaisie.TextChanged += new System.EventHandler(this.txtSaisie_TextChanged);
            // 
            // lst1
            // 
            this.lst1.FormattingEnabled = true;
            this.lst1.Location = new System.Drawing.Point(12, 102);
            this.lst1.Name = "lst1";
            this.lst1.Size = new System.Drawing.Size(216, 160);
            this.lst1.TabIndex = 6;
            this.lst1.SelectedIndexChanged += new System.EventHandler(this.lst1_SelectedIndexChanged);
            // 
            // lst2
            // 
            this.lst2.FormattingEnabled = true;
            this.lst2.Location = new System.Drawing.Point(358, 102);
            this.lst2.Name = "lst2";
            this.lst2.Size = new System.Drawing.Size(216, 160);
            this.lst2.TabIndex = 7;
            this.lst2.SelectedIndexChanged += new System.EventHandler(this.lst2_SelectedIndexChanged);
            // 
            // lblsaisie
            // 
            this.lblsaisie.AutoSize = true;
            this.lblsaisie.Location = new System.Drawing.Point(29, 37);
            this.lblsaisie.Name = "lblsaisie";
            this.lblsaisie.Size = new System.Drawing.Size(35, 13);
            this.lblsaisie.TabIndex = 8;
            this.lblsaisie.Text = "Saisie";
            // 
            // FrmList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 325);
            this.Controls.Add(this.lblsaisie);
            this.Controls.Add(this.lst2);
            this.Controls.Add(this.lst1);
            this.Controls.Add(this.txtSaisie);
            this.Controls.Add(this.btnEffacer1);
            this.Controls.Add(this.btnEffacer2);
            this.Controls.Add(this.btn2to1);
            this.Controls.Add(this.btn1to2);
            this.Controls.Add(this.btnAjouter);
            this.Name = "FrmList";
            this.Text = "Listes";
            this.Load += new System.EventHandler(this.FrmList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btn1to2;
        private System.Windows.Forms.Button btn2to1;
        private System.Windows.Forms.Button btnEffacer2;
        private System.Windows.Forms.Button btnEffacer1;
        private System.Windows.Forms.TextBox txtSaisie;
        private System.Windows.Forms.ListBox lst1;
        private System.Windows.Forms.ListBox lst2;
        private System.Windows.Forms.Label lblsaisie;
    }
}

