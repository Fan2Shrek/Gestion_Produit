namespace GestionGUI
{
    partial class FrmListeProduits
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
            this.lblProduit = new System.Windows.Forms.Label();
            this.retSynt = new System.Windows.Forms.Button();
            this.dgvProduit = new System.Windows.Forms.DataGridView();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Libelle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ajouterProduit = new System.Windows.Forms.Button();
            this.actualiserProduit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblErrorCategorie = new System.Windows.Forms.Label();
            this.lblErrorPrix = new System.Windows.Forms.Label();
            this.lblErrorLibellé = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLibelleProAdd = new System.Windows.Forms.Label();
            this.lblCatAddPro = new System.Windows.Forms.Label();
            this.listCategorie = new System.Windows.Forms.ListBox();
            this.LabelDetails = new System.Windows.Forms.Label();
            this.textPrix = new System.Windows.Forms.TextBox();
            this.textLibelle = new System.Windows.Forms.TextBox();
            this.textCode = new System.Windows.Forms.TextBox();
            this.Supprimer = new System.Windows.Forms.Button();
            this.Modifier = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduit)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblProduit
            // 
            this.lblProduit.AutoSize = true;
            this.lblProduit.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProduit.Location = new System.Drawing.Point(306, 48);
            this.lblProduit.Name = "lblProduit";
            this.lblProduit.Size = new System.Drawing.Size(443, 59);
            this.lblProduit.TabIndex = 1;
            this.lblProduit.Text = "Gestion des produits";
            // 
            // retSynt
            // 
            this.retSynt.Location = new System.Drawing.Point(37, 572);
            this.retSynt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.retSynt.Name = "retSynt";
            this.retSynt.Size = new System.Drawing.Size(82, 22);
            this.retSynt.TabIndex = 2;
            this.retSynt.Text = "Retour";
            this.retSynt.UseVisualStyleBackColor = true;
            this.retSynt.Click += new System.EventHandler(this.retSynt_Click);
            // 
            // dgvProduit
            // 
            this.dgvProduit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Code,
            this.Libelle,
            this.Prix,
            this.Categorie});
            this.dgvProduit.Location = new System.Drawing.Point(37, 137);
            this.dgvProduit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvProduit.Name = "dgvProduit";
            this.dgvProduit.RowHeadersWidth = 51;
            this.dgvProduit.RowTemplate.Height = 29;
            this.dgvProduit.Size = new System.Drawing.Size(485, 375);
            this.dgvProduit.TabIndex = 3;
            this.dgvProduit.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduit_CellClick);
            // 
            // Code
            // 
            this.Code.HeaderText = "Code";
            this.Code.MinimumWidth = 6;
            this.Code.Name = "Code";
            this.Code.Width = 125;
            // 
            // Libelle
            // 
            this.Libelle.HeaderText = "Libelle";
            this.Libelle.MinimumWidth = 6;
            this.Libelle.Name = "Libelle";
            this.Libelle.Width = 125;
            // 
            // Prix
            // 
            this.Prix.HeaderText = "Prix";
            this.Prix.MinimumWidth = 6;
            this.Prix.Name = "Prix";
            this.Prix.Width = 125;
            // 
            // Categorie
            // 
            this.Categorie.HeaderText = "Categorie";
            this.Categorie.MinimumWidth = 6;
            this.Categorie.Name = "Categorie";
            this.Categorie.Width = 125;
            // 
            // ajouterProduit
            // 
            this.ajouterProduit.Location = new System.Drawing.Point(439, 572);
            this.ajouterProduit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ajouterProduit.Name = "ajouterProduit";
            this.ajouterProduit.Size = new System.Drawing.Size(82, 22);
            this.ajouterProduit.TabIndex = 4;
            this.ajouterProduit.Text = "Ajouter";
            this.ajouterProduit.UseVisualStyleBackColor = true;
            this.ajouterProduit.Click += new System.EventHandler(this.ajouterProdui_Click);
            // 
            // actualiserProduit
            // 
            this.actualiserProduit.Location = new System.Drawing.Point(230, 572);
            this.actualiserProduit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.actualiserProduit.Name = "actualiserProduit";
            this.actualiserProduit.Size = new System.Drawing.Size(82, 22);
            this.actualiserProduit.TabIndex = 5;
            this.actualiserProduit.Text = "Actualiser";
            this.actualiserProduit.UseVisualStyleBackColor = true;
            this.actualiserProduit.Click += new System.EventHandler(this.actualiserProduit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblErrorCategorie);
            this.panel1.Controls.Add(this.lblErrorPrix);
            this.panel1.Controls.Add(this.lblErrorLibellé);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblLibelleProAdd);
            this.panel1.Controls.Add(this.lblCatAddPro);
            this.panel1.Controls.Add(this.listCategorie);
            this.panel1.Controls.Add(this.LabelDetails);
            this.panel1.Controls.Add(this.textPrix);
            this.panel1.Controls.Add(this.textLibelle);
            this.panel1.Controls.Add(this.textCode);
            this.panel1.Controls.Add(this.Supprimer);
            this.panel1.Controls.Add(this.Modifier);
            this.panel1.Location = new System.Drawing.Point(595, 137);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 375);
            this.panel1.TabIndex = 7;
            // 
            // lblErrorCategorie
            // 
            this.lblErrorCategorie.AutoSize = true;
            this.lblErrorCategorie.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblErrorCategorie.Location = new System.Drawing.Point(164, 202);
            this.lblErrorCategorie.Name = "lblErrorCategorie";
            this.lblErrorCategorie.Size = new System.Drawing.Size(97, 15);
            this.lblErrorCategorie.TabIndex = 15;
            this.lblErrorCategorie.Text = "Catég. incorrecte";
            // 
            // lblErrorPrix
            // 
            this.lblErrorPrix.AutoSize = true;
            this.lblErrorPrix.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblErrorPrix.Location = new System.Drawing.Point(31, 188);
            this.lblErrorPrix.Name = "lblErrorPrix";
            this.lblErrorPrix.Size = new System.Drawing.Size(77, 15);
            this.lblErrorPrix.TabIndex = 18;
            this.lblErrorPrix.Text = "Prix incorrect";
            // 
            // lblErrorLibellé
            // 
            this.lblErrorLibellé.AutoSize = true;
            this.lblErrorLibellé.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblErrorLibellé.Location = new System.Drawing.Point(164, 95);
            this.lblErrorLibellé.Name = "lblErrorLibellé";
            this.lblErrorLibellé.Size = new System.Drawing.Size(91, 15);
            this.lblErrorLibellé.TabIndex = 17;
            this.lblErrorLibellé.Text = "Libellé incorrect";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Prix :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Code :";
            // 
            // lblLibelleProAdd
            // 
            this.lblLibelleProAdd.AutoSize = true;
            this.lblLibelleProAdd.Location = new System.Drawing.Point(164, 58);
            this.lblLibelleProAdd.Name = "lblLibelleProAdd";
            this.lblLibelleProAdd.Size = new System.Drawing.Size(47, 15);
            this.lblLibelleProAdd.TabIndex = 14;
            this.lblLibelleProAdd.Text = "Libellé :";
            // 
            // lblCatAddPro
            // 
            this.lblCatAddPro.AutoSize = true;
            this.lblCatAddPro.Location = new System.Drawing.Point(164, 151);
            this.lblCatAddPro.Name = "lblCatAddPro";
            this.lblCatAddPro.Size = new System.Drawing.Size(64, 15);
            this.lblCatAddPro.TabIndex = 12;
            this.lblCatAddPro.Text = "Catégorie :";
            // 
            // listCategorie
            // 
            this.listCategorie.FormattingEnabled = true;
            this.listCategorie.ItemHeight = 15;
            this.listCategorie.Location = new System.Drawing.Point(164, 167);
            this.listCategorie.Margin = new System.Windows.Forms.Padding(2);
            this.listCategorie.Name = "listCategorie";
            this.listCategorie.Size = new System.Drawing.Size(91, 34);
            this.listCategorie.TabIndex = 13;
            // 
            // LabelDetails
            // 
            this.LabelDetails.AutoSize = true;
            this.LabelDetails.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelDetails.Location = new System.Drawing.Point(66, 8);
            this.LabelDetails.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelDetails.Name = "LabelDetails";
            this.LabelDetails.Size = new System.Drawing.Size(143, 54);
            this.LabelDetails.TabIndex = 12;
            this.LabelDetails.Text = "Détails";
            // 
            // textPrix
            // 
            this.textPrix.Location = new System.Drawing.Point(31, 167);
            this.textPrix.Margin = new System.Windows.Forms.Padding(2);
            this.textPrix.Name = "textPrix";
            this.textPrix.Size = new System.Drawing.Size(89, 23);
            this.textPrix.TabIndex = 10;
            // 
            // textLibelle
            // 
            this.textLibelle.Location = new System.Drawing.Point(164, 75);
            this.textLibelle.Margin = new System.Windows.Forms.Padding(2);
            this.textLibelle.Name = "textLibelle";
            this.textLibelle.Size = new System.Drawing.Size(91, 23);
            this.textLibelle.TabIndex = 9;
            // 
            // textCode
            // 
            this.textCode.Enabled = false;
            this.textCode.Location = new System.Drawing.Point(31, 75);
            this.textCode.Margin = new System.Windows.Forms.Padding(2);
            this.textCode.Name = "textCode";
            this.textCode.Size = new System.Drawing.Size(89, 23);
            this.textCode.TabIndex = 8;
            // 
            // Supprimer
            // 
            this.Supprimer.Location = new System.Drawing.Point(164, 334);
            this.Supprimer.Margin = new System.Windows.Forms.Padding(2);
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Size = new System.Drawing.Size(90, 20);
            this.Supprimer.TabIndex = 7;
            this.Supprimer.Text = "Supprimer";
            this.Supprimer.UseVisualStyleBackColor = true;
            this.Supprimer.Click += new System.EventHandler(this.Supprimer_Click);
            // 
            // Modifier
            // 
            this.Modifier.Location = new System.Drawing.Point(31, 334);
            this.Modifier.Margin = new System.Windows.Forms.Padding(2);
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(88, 20);
            this.Modifier.TabIndex = 6;
            this.Modifier.Text = "Modifier";
            this.Modifier.UseVisualStyleBackColor = true;
            this.Modifier.Click += new System.EventHandler(this.Modifier_Click);
            // 
            // FrmListeProduits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1078, 562);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.actualiserProduit);
            this.Controls.Add(this.ajouterProduit);
            this.Controls.Add(this.dgvProduit);
            this.Controls.Add(this.retSynt);
            this.Controls.Add(this.lblProduit);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmListeProduits";
            this.Text = "ListeProduitsForms";
            this.Load += new System.EventHandler(this.FrmListeProduits_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduit)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblProduit;
        private Button retSynt;
        private DataGridView dgvProduit;
        private Button ajouterProduit;
        private DataGridViewTextBoxColumn Code;
        private DataGridViewTextBoxColumn Libelle;
        private DataGridViewTextBoxColumn Prix;
        private DataGridViewTextBoxColumn Categorie;
        private Button actualiserProduit;
        private Panel panel1;
        private Label lblErrorCategorie;
        private Label lblErrorPrix;
        private Label lblErrorLibellé;
        private Label label2;
        private Label label1;
        private Label lblLibelleProAdd;
        private Label lblCatAddPro;
        private ListBox listCategorie;
        private Label LabelDetails;
        private TextBox textPrix;
        private TextBox textLibelle;
        private TextBox textCode;
        private Button Supprimer;
        private Button Modifier;
    }
}