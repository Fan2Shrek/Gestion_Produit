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
            this.ajouterProduit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LabelDetails = new System.Windows.Forms.Label();
            this.textPrix = new System.Windows.Forms.TextBox();
            this.textLibelle = new System.Windows.Forms.TextBox();
            this.textCode = new System.Windows.Forms.TextBox();
            this.Supprimer = new System.Windows.Forms.Button();
            this.Modifier = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduit)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblProduit
            // 
            this.lblProduit.AutoSize = true;
            this.lblProduit.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProduit.Location = new System.Drawing.Point(438, 80);
            this.lblProduit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProduit.Name = "lblProduit";
            this.lblProduit.Size = new System.Drawing.Size(660, 86);
            this.lblProduit.TabIndex = 1;
            this.lblProduit.Text = "Gestion des produits";
            // 
            // retSynt
            // 
            this.retSynt.Location = new System.Drawing.Point(52, 952);
            this.retSynt.Margin = new System.Windows.Forms.Padding(4);
            this.retSynt.Name = "retSynt";
            this.retSynt.Size = new System.Drawing.Size(118, 36);
            this.retSynt.TabIndex = 2;
            this.retSynt.Text = "Retour";
            this.retSynt.UseVisualStyleBackColor = true;
            this.retSynt.Click += new System.EventHandler(this.retSynt_Click);
            // 
            // dgvProduit
            // 
            this.dgvProduit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduit.Location = new System.Drawing.Point(52, 229);
            this.dgvProduit.Margin = new System.Windows.Forms.Padding(4);
            this.dgvProduit.Name = "dgvProduit";
            this.dgvProduit.RowHeadersWidth = 51;
            this.dgvProduit.RowTemplate.Height = 29;
            this.dgvProduit.Size = new System.Drawing.Size(692, 625);
            this.dgvProduit.TabIndex = 3;
            this.dgvProduit.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduit_CellClick);
            // 
            // ajouterProduit
            // 
            this.ajouterProduit.Location = new System.Drawing.Point(628, 952);
            this.ajouterProduit.Margin = new System.Windows.Forms.Padding(4);
            this.ajouterProduit.Name = "ajouterProduit";
            this.ajouterProduit.Size = new System.Drawing.Size(118, 36);
            this.ajouterProduit.TabIndex = 4;
            this.ajouterProduit.Text = "Ajouter";
            this.ajouterProduit.UseVisualStyleBackColor = true;
            this.ajouterProduit.Click += new System.EventHandler(this.ajouterProdui_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.LabelDetails);
            this.panel1.Controls.Add(this.textPrix);
            this.panel1.Controls.Add(this.textLibelle);
            this.panel1.Controls.Add(this.textCode);
            this.panel1.Controls.Add(this.Supprimer);
            this.panel1.Controls.Add(this.Modifier);
            this.panel1.Location = new System.Drawing.Point(985, 229);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(402, 625);
            this.panel1.TabIndex = 5;
            // 
            // LabelDetails
            // 
            this.LabelDetails.AutoSize = true;
            this.LabelDetails.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelDetails.Location = new System.Drawing.Point(95, 13);
            this.LabelDetails.Name = "LabelDetails";
            this.LabelDetails.Size = new System.Drawing.Size(214, 81);
            this.LabelDetails.TabIndex = 12;
            this.LabelDetails.Text = "Détails";
            // 
            // textPrix
            // 
            this.textPrix.Location = new System.Drawing.Point(44, 227);
            this.textPrix.Name = "textPrix";
            this.textPrix.Size = new System.Drawing.Size(126, 31);
            this.textPrix.TabIndex = 10;
            // 
            // textLibelle
            // 
            this.textLibelle.Location = new System.Drawing.Point(234, 125);
            this.textLibelle.Name = "textLibelle";
            this.textLibelle.Size = new System.Drawing.Size(128, 31);
            this.textLibelle.TabIndex = 9;
            // 
            // textCode
            // 
            this.textCode.Enabled = false;
            this.textCode.Location = new System.Drawing.Point(44, 125);
            this.textCode.Name = "textCode";
            this.textCode.Size = new System.Drawing.Size(126, 31);
            this.textCode.TabIndex = 8;
            // 
            // Supprimer
            // 
            this.Supprimer.Location = new System.Drawing.Point(234, 557);
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Size = new System.Drawing.Size(128, 34);
            this.Supprimer.TabIndex = 7;
            this.Supprimer.Text = "Supprimer";
            this.Supprimer.UseVisualStyleBackColor = true;
            this.Supprimer.Click += new System.EventHandler(this.Supprimer_Click);
            // 
            // Modifier
            // 
            this.Modifier.Location = new System.Drawing.Point(44, 557);
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(126, 34);
            this.Modifier.TabIndex = 6;
            this.Modifier.Text = "Modifier";
            this.Modifier.UseVisualStyleBackColor = true;
            this.Modifier.Click += new System.EventHandler(this.modifier_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(234, 227);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(128, 54);
            this.listBox1.TabIndex = 13;
            // 
            // FrmListeProduits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1540, 1004);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ajouterProduit);
            this.Controls.Add(this.dgvProduit);
            this.Controls.Add(this.retSynt);
            this.Controls.Add(this.lblProduit);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private Panel panel1;
        private Button Supprimer;
        private Button Modifier;
        private TextBox textLibelle;
        private TextBox textCode;
        private TextBox textPrix;
        private Label LabelDetails;
        private ListBox listBox1;
    }
}