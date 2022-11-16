namespace GestionGUI
{
    partial class FrmAjoutProduit
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
            this.lblProduit2 = new System.Windows.Forms.Label();
            this.btnRetourInPro = new System.Windows.Forms.Button();
            this.libelleProAdd = new System.Windows.Forms.TextBox();
            this.PrixProAdd = new System.Windows.Forms.TextBox();
            this.CategorieProAdd = new System.Windows.Forms.ListBox();
            this.addPro = new System.Windows.Forms.Button();
            this.lblLibelleProAdd = new System.Windows.Forms.Label();
            this.lblPrixAddPro = new System.Windows.Forms.Label();
            this.lblCatAddPro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblProduit2
            // 
            this.lblProduit2.AutoSize = true;
            this.lblProduit2.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProduit2.Location = new System.Drawing.Point(388, 91);
            this.lblProduit2.Name = "lblProduit2";
            this.lblProduit2.Size = new System.Drawing.Size(449, 72);
            this.lblProduit2.TabIndex = 2;
            this.lblProduit2.Text = "Créer un produit";
            // 
            // btnRetourInPro
            // 
            this.btnRetourInPro.Location = new System.Drawing.Point(12, 712);
            this.btnRetourInPro.Name = "btnRetourInPro";
            this.btnRetourInPro.Size = new System.Drawing.Size(94, 29);
            this.btnRetourInPro.TabIndex = 3;
            this.btnRetourInPro.Text = "Retour";
            this.btnRetourInPro.UseVisualStyleBackColor = true;
            // 
            // libelleProAdd
            // 
            this.libelleProAdd.Location = new System.Drawing.Point(388, 359);
            this.libelleProAdd.Name = "libelleProAdd";
            this.libelleProAdd.Size = new System.Drawing.Size(186, 27);
            this.libelleProAdd.TabIndex = 4;
            // 
            // PrixProAdd
            // 
            this.PrixProAdd.Location = new System.Drawing.Point(654, 359);
            this.PrixProAdd.Name = "PrixProAdd";
            this.PrixProAdd.Size = new System.Drawing.Size(183, 27);
            this.PrixProAdd.TabIndex = 9;
            // 
            // CategorieProAdd
            // 
            this.CategorieProAdd.FormattingEnabled = true;
            this.CategorieProAdd.ItemHeight = 20;
            this.CategorieProAdd.Location = new System.Drawing.Point(388, 541);
            this.CategorieProAdd.Name = "CategorieProAdd";
            this.CategorieProAdd.Size = new System.Drawing.Size(186, 44);
            this.CategorieProAdd.TabIndex = 6;
            // 
            // addPro
            // 
            this.addPro.Location = new System.Drawing.Point(743, 556);
            this.addPro.Name = "addPro";
            this.addPro.Size = new System.Drawing.Size(94, 29);
            this.addPro.TabIndex = 7;
            this.addPro.Text = "Ajouter";
            this.addPro.UseVisualStyleBackColor = true;
            // 
            // lblLibelleProAdd
            // 
            this.lblLibelleProAdd.AutoSize = true;
            this.lblLibelleProAdd.Location = new System.Drawing.Point(388, 318);
            this.lblLibelleProAdd.Name = "lblLibelleProAdd";
            this.lblLibelleProAdd.Size = new System.Drawing.Size(60, 20);
            this.lblLibelleProAdd.TabIndex = 8;
            this.lblLibelleProAdd.Text = "Libellé :";
            this.lblLibelleProAdd.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPrixAddPro
            // 
            this.lblPrixAddPro.AutoSize = true;
            this.lblPrixAddPro.Location = new System.Drawing.Point(654, 318);
            this.lblPrixAddPro.Name = "lblPrixAddPro";
            this.lblPrixAddPro.Size = new System.Drawing.Size(40, 20);
            this.lblPrixAddPro.TabIndex = 10;
            this.lblPrixAddPro.Text = "Prix :";
            // 
            // lblCatAddPro
            // 
            this.lblCatAddPro.AutoSize = true;
            this.lblCatAddPro.Location = new System.Drawing.Point(388, 500);
            this.lblCatAddPro.Name = "lblCatAddPro";
            this.lblCatAddPro.Size = new System.Drawing.Size(81, 20);
            this.lblCatAddPro.TabIndex = 11;
            this.lblCatAddPro.Text = "Catégorié :";
            // 
            // FrmAjoutProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1232, 753);
            this.Controls.Add(this.lblCatAddPro);
            this.Controls.Add(this.lblPrixAddPro);
            this.Controls.Add(this.lblLibelleProAdd);
            this.Controls.Add(this.addPro);
            this.Controls.Add(this.CategorieProAdd);
            this.Controls.Add(this.PrixProAdd);
            this.Controls.Add(this.libelleProAdd);
            this.Controls.Add(this.btnRetourInPro);
            this.Controls.Add(this.lblProduit2);
            this.Name = "FrmAjoutProduit";
            this.Text = "FrmAjoutProduit";
            this.Load += new System.EventHandler(this.FrmAjoutProduit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblProduit2;
        private TextBox inLibellePro;
        private TextBox inPrixPro;
        private ListBox inCategoriePro;
        private Label inLibellelbl;
        private Label inPrixlbl;
        private Label inCatlbl;
        private ListBox listBoxCateg;
        private Button ajoutPro;
        private Button retAjoutPro;
        private Button btnRetourInPro;
        private TextBox libelleProAdd;
        private TextBox PrixProAdd;
        private ListBox CategorieProAdd;
        private Button addPro;
        private Label lblLibelleProAdd;
        private Label lblPrixAddPro;
        private Label lblCatAddPro;
    }
}