namespace GestionGUI
{
    partial class FrmListeClients
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
            this.retSynt = new System.Windows.Forms.Button();
            this.actualiserProduit = new System.Windows.Forms.Button();
            this.dgvClient = new System.Windows.Forms.DataGridView();
            this.Telephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblProduit = new System.Windows.Forms.Label();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModifierCli = new System.Windows.Forms.Button();
            this.SupprimerCli = new System.Windows.Forms.Button();
            this.textCodeCli = new System.Windows.Forms.TextBox();
            this.textNomCli = new System.Windows.Forms.TextBox();
            this.textPrenomCli = new System.Windows.Forms.TextBox();
            this.LabelDetails = new System.Windows.Forms.Label();
            this.lblNomCli = new System.Windows.Forms.Label();
            this.lblCodeCli = new System.Windows.Forms.Label();
            this.lblPrenomCli = new System.Windows.Forms.Label();
            this.AjouterCli = new System.Windows.Forms.Button();
            this.textEmailCli = new System.Windows.Forms.TextBox();
            this.lblEmailCli = new System.Windows.Forms.Label();
            this.lblTelCli = new System.Windows.Forms.Label();
            this.lblFaxCli = new System.Windows.Forms.Label();
            this.textTelCli = new System.Windows.Forms.TextBox();
            this.textFaxCli = new System.Windows.Forms.TextBox();
            this.lblRueFactCli = new System.Windows.Forms.Label();
            this.textRueFactuCli = new System.Windows.Forms.TextBox();
            this.lblCodePostalFactuCli = new System.Windows.Forms.Label();
            this.textCPFactuCli = new System.Windows.Forms.TextBox();
            this.lblVilleFactuCli = new System.Windows.Forms.Label();
            this.textVilleFactCli = new System.Windows.Forms.TextBox();
            this.lblRueLivraisonCli = new System.Windows.Forms.Label();
            this.textRueLivraisonCli = new System.Windows.Forms.TextBox();
            this.lblCodePostalLivraiCli = new System.Windows.Forms.Label();
            this.CodePostalLivraiCli = new System.Windows.Forms.TextBox();
            this.lblVilleLivraiCli = new System.Windows.Forms.Label();
            this.textVilleLivraiCli = new System.Windows.Forms.TextBox();
            this.lblErrorClient = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // retSynt
            // 
            this.retSynt.Location = new System.Drawing.Point(18, 564);
            this.retSynt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.retSynt.Name = "retSynt";
            this.retSynt.Size = new System.Drawing.Size(82, 22);
            this.retSynt.TabIndex = 2;
            this.retSynt.Text = "Retour";
            this.retSynt.UseVisualStyleBackColor = true;
            this.retSynt.Click += new System.EventHandler(this.retSynt_Click);
            // 
            // actualiserProduit
            // 
            this.actualiserProduit.Location = new System.Drawing.Point(18, 130);
            this.actualiserProduit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.actualiserProduit.Name = "actualiserProduit";
            this.actualiserProduit.Size = new System.Drawing.Size(82, 22);
            this.actualiserProduit.TabIndex = 5;
            this.actualiserProduit.Text = "Actualiser";
            this.actualiserProduit.UseVisualStyleBackColor = true;
            this.actualiserProduit.Click += new System.EventHandler(this.actualiserProduit_Click);
            // 
            // dgvClient
            // 
            this.dgvClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dgvClient.Location = new System.Drawing.Point(18, 172);
            this.dgvClient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvClient.Name = "dgvClient";
            this.dgvClient.RowHeadersWidth = 51;
            this.dgvClient.RowTemplate.Height = 29;
            this.dgvClient.Size = new System.Drawing.Size(485, 375);
            this.dgvClient.TabIndex = 3;
            this.dgvClient.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduit_CellClick);
            // 
            // Telephone
            // 
            this.Telephone.HeaderText = "Telephone";
            this.Telephone.MinimumWidth = 6;
            this.Telephone.Name = "Telephone";
            this.Telephone.Width = 125;
            // 
            // Code
            // 
            this.Code.HeaderText = "Code";
            this.Code.MinimumWidth = 6;
            this.Code.Name = "Code";
            this.Code.Width = 125;
            // 
            // Prenom
            // 
            this.Prenom.HeaderText = "Prenom";
            this.Prenom.MinimumWidth = 6;
            this.Prenom.Name = "Prenom";
            this.Prenom.Width = 125;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.Width = 125;
            // 
            // lblProduit
            // 
            this.lblProduit.AutoSize = true;
            this.lblProduit.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProduit.Location = new System.Drawing.Point(306, 48);
            this.lblProduit.Name = "lblProduit";
            this.lblProduit.Size = new System.Drawing.Size(402, 59);
            this.lblProduit.TabIndex = 1;
            this.lblProduit.Text = "Gestion des clients";
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nom";
            this.Nom.MinimumWidth = 6;
            this.Nom.Name = "Nom";
            this.Nom.Width = 125;
            // 
            // ModifierCli
            // 
            this.ModifierCli.Location = new System.Drawing.Point(229, 421);
            this.ModifierCli.Margin = new System.Windows.Forms.Padding(2);
            this.ModifierCli.Name = "ModifierCli";
            this.ModifierCli.Size = new System.Drawing.Size(88, 20);
            this.ModifierCli.TabIndex = 6;
            this.ModifierCli.Text = "Modifier";
            this.ModifierCli.UseVisualStyleBackColor = true;
            this.ModifierCli.Click += new System.EventHandler(this.Modifier_Click);
            // 
            // SupprimerCli
            // 
            this.SupprimerCli.Location = new System.Drawing.Point(399, 422);
            this.SupprimerCli.Margin = new System.Windows.Forms.Padding(2);
            this.SupprimerCli.Name = "SupprimerCli";
            this.SupprimerCli.Size = new System.Drawing.Size(90, 20);
            this.SupprimerCli.TabIndex = 7;
            this.SupprimerCli.Text = "Supprimer";
            this.SupprimerCli.UseVisualStyleBackColor = true;
            this.SupprimerCli.Click += new System.EventHandler(this.Supprimer_Click);
            // 
            // textCodeCli
            // 
            this.textCodeCli.Enabled = false;
            this.textCodeCli.Location = new System.Drawing.Point(24, 129);
            this.textCodeCli.Margin = new System.Windows.Forms.Padding(2);
            this.textCodeCli.Name = "textCodeCli";
            this.textCodeCli.Size = new System.Drawing.Size(149, 23);
            this.textCodeCli.TabIndex = 8;
            this.textCodeCli.TextChanged += new System.EventHandler(this.textCodeCli_TextChanged);
            // 
            // textNomCli
            // 
            this.textNomCli.Location = new System.Drawing.Point(24, 196);
            this.textNomCli.Margin = new System.Windows.Forms.Padding(2);
            this.textNomCli.Name = "textNomCli";
            this.textNomCli.Size = new System.Drawing.Size(149, 23);
            this.textNomCli.TabIndex = 9;
            // 
            // textPrenomCli
            // 
            this.textPrenomCli.Location = new System.Drawing.Point(24, 266);
            this.textPrenomCli.Margin = new System.Windows.Forms.Padding(2);
            this.textPrenomCli.Name = "textPrenomCli";
            this.textPrenomCli.Size = new System.Drawing.Size(149, 23);
            this.textPrenomCli.TabIndex = 10;
            // 
            // LabelDetails
            // 
            this.LabelDetails.AutoSize = true;
            this.LabelDetails.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelDetails.Location = new System.Drawing.Point(200, 14);
            this.LabelDetails.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelDetails.Name = "LabelDetails";
            this.LabelDetails.Size = new System.Drawing.Size(143, 54);
            this.LabelDetails.TabIndex = 12;
            this.LabelDetails.Text = "Détails";
            // 
            // lblNomCli
            // 
            this.lblNomCli.AutoSize = true;
            this.lblNomCli.Location = new System.Drawing.Point(24, 179);
            this.lblNomCli.Name = "lblNomCli";
            this.lblNomCli.Size = new System.Drawing.Size(40, 15);
            this.lblNomCli.TabIndex = 14;
            this.lblNomCli.Text = "Nom :";
            // 
            // lblCodeCli
            // 
            this.lblCodeCli.AutoSize = true;
            this.lblCodeCli.Location = new System.Drawing.Point(24, 112);
            this.lblCodeCli.Name = "lblCodeCli";
            this.lblCodeCli.Size = new System.Drawing.Size(41, 15);
            this.lblCodeCli.TabIndex = 15;
            this.lblCodeCli.Text = "Code :";
            // 
            // lblPrenomCli
            // 
            this.lblPrenomCli.AutoSize = true;
            this.lblPrenomCli.Location = new System.Drawing.Point(24, 248);
            this.lblPrenomCli.Name = "lblPrenomCli";
            this.lblPrenomCli.Size = new System.Drawing.Size(55, 15);
            this.lblPrenomCli.TabIndex = 16;
            this.lblPrenomCli.Text = "Prénom :";
            // 
            // AjouterCli
            // 
            this.AjouterCli.Location = new System.Drawing.Point(55, 420);
            this.AjouterCli.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AjouterCli.Name = "AjouterCli";
            this.AjouterCli.Size = new System.Drawing.Size(88, 22);
            this.AjouterCli.TabIndex = 19;
            this.AjouterCli.Text = "Ajouter";
            this.AjouterCli.UseVisualStyleBackColor = true;
            // 
            // textEmailCli
            // 
            this.textEmailCli.Location = new System.Drawing.Point(24, 337);
            this.textEmailCli.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textEmailCli.Name = "textEmailCli";
            this.textEmailCli.Size = new System.Drawing.Size(153, 23);
            this.textEmailCli.TabIndex = 20;
            // 
            // lblEmailCli
            // 
            this.lblEmailCli.AutoSize = true;
            this.lblEmailCli.Location = new System.Drawing.Point(24, 320);
            this.lblEmailCli.Name = "lblEmailCli";
            this.lblEmailCli.Size = new System.Drawing.Size(42, 15);
            this.lblEmailCli.TabIndex = 21;
            this.lblEmailCli.Text = "Email :";
            // 
            // lblTelCli
            // 
            this.lblTelCli.AutoSize = true;
            this.lblTelCli.Location = new System.Drawing.Point(200, 112);
            this.lblTelCli.Name = "lblTelCli";
            this.lblTelCli.Size = new System.Drawing.Size(67, 15);
            this.lblTelCli.TabIndex = 22;
            this.lblTelCli.Text = "Téléphone :";
            // 
            // lblFaxCli
            // 
            this.lblFaxCli.AutoSize = true;
            this.lblFaxCli.Location = new System.Drawing.Point(200, 179);
            this.lblFaxCli.Name = "lblFaxCli";
            this.lblFaxCli.Size = new System.Drawing.Size(31, 15);
            this.lblFaxCli.TabIndex = 23;
            this.lblFaxCli.Text = "Fax :";
            // 
            // textTelCli
            // 
            this.textTelCli.Location = new System.Drawing.Point(200, 129);
            this.textTelCli.Margin = new System.Windows.Forms.Padding(2);
            this.textTelCli.Name = "textTelCli";
            this.textTelCli.Size = new System.Drawing.Size(151, 23);
            this.textTelCli.TabIndex = 24;
            this.textTelCli.TextChanged += new System.EventHandler(this.textTelCli_TextChanged);
            // 
            // textFaxCli
            // 
            this.textFaxCli.Location = new System.Drawing.Point(200, 196);
            this.textFaxCli.Margin = new System.Windows.Forms.Padding(2);
            this.textFaxCli.Name = "textFaxCli";
            this.textFaxCli.Size = new System.Drawing.Size(151, 23);
            this.textFaxCli.TabIndex = 25;
            // 
            // lblRueFactCli
            // 
            this.lblRueFactCli.AutoSize = true;
            this.lblRueFactCli.Location = new System.Drawing.Point(200, 248);
            this.lblRueFactCli.Name = "lblRueFactCli";
            this.lblRueFactCli.Size = new System.Drawing.Size(94, 15);
            this.lblRueFactCli.TabIndex = 26;
            this.lblRueFactCli.Text = "Rue facturation :";
            // 
            // textRueFactuCli
            // 
            this.textRueFactuCli.Location = new System.Drawing.Point(200, 266);
            this.textRueFactuCli.Margin = new System.Windows.Forms.Padding(2);
            this.textRueFactuCli.Name = "textRueFactuCli";
            this.textRueFactuCli.Size = new System.Drawing.Size(151, 23);
            this.textRueFactuCli.TabIndex = 27;
            // 
            // lblCodePostalFactuCli
            // 
            this.lblCodePostalFactuCli.AutoSize = true;
            this.lblCodePostalFactuCli.Location = new System.Drawing.Point(200, 320);
            this.lblCodePostalFactuCli.Name = "lblCodePostalFactuCli";
            this.lblCodePostalFactuCli.Size = new System.Drawing.Size(137, 15);
            this.lblCodePostalFactuCli.TabIndex = 20;
            this.lblCodePostalFactuCli.Text = "Code postal facturation :";
            // 
            // textCPFactuCli
            // 
            this.textCPFactuCli.Location = new System.Drawing.Point(200, 337);
            this.textCPFactuCli.Margin = new System.Windows.Forms.Padding(2);
            this.textCPFactuCli.Name = "textCPFactuCli";
            this.textCPFactuCli.Size = new System.Drawing.Size(151, 23);
            this.textCPFactuCli.TabIndex = 28;
            // 
            // lblVilleFactuCli
            // 
            this.lblVilleFactuCli.AutoSize = true;
            this.lblVilleFactuCli.Location = new System.Drawing.Point(370, 112);
            this.lblVilleFactuCli.Name = "lblVilleFactuCli";
            this.lblVilleFactuCli.Size = new System.Drawing.Size(96, 15);
            this.lblVilleFactuCli.TabIndex = 29;
            this.lblVilleFactuCli.Text = "Ville facturation :";
            // 
            // textVilleFactCli
            // 
            this.textVilleFactCli.Location = new System.Drawing.Point(370, 129);
            this.textVilleFactCli.Margin = new System.Windows.Forms.Padding(2);
            this.textVilleFactCli.Name = "textVilleFactCli";
            this.textVilleFactCli.Size = new System.Drawing.Size(151, 23);
            this.textVilleFactCli.TabIndex = 30;
            // 
            // lblRueLivraisonCli
            // 
            this.lblRueLivraisonCli.AutoSize = true;
            this.lblRueLivraisonCli.Location = new System.Drawing.Point(370, 179);
            this.lblRueLivraisonCli.Name = "lblRueLivraisonCli";
            this.lblRueLivraisonCli.Size = new System.Drawing.Size(80, 15);
            this.lblRueLivraisonCli.TabIndex = 31;
            this.lblRueLivraisonCli.Text = "Rue livraison :";
            // 
            // textRueLivraisonCli
            // 
            this.textRueLivraisonCli.Location = new System.Drawing.Point(370, 196);
            this.textRueLivraisonCli.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textRueLivraisonCli.Name = "textRueLivraisonCli";
            this.textRueLivraisonCli.Size = new System.Drawing.Size(151, 23);
            this.textRueLivraisonCli.TabIndex = 21;
            // 
            // lblCodePostalLivraiCli
            // 
            this.lblCodePostalLivraiCli.AutoSize = true;
            this.lblCodePostalLivraiCli.Location = new System.Drawing.Point(370, 248);
            this.lblCodePostalLivraiCli.Name = "lblCodePostalLivraiCli";
            this.lblCodePostalLivraiCli.Size = new System.Drawing.Size(123, 15);
            this.lblCodePostalLivraiCli.TabIndex = 32;
            this.lblCodePostalLivraiCli.Text = "Code postal livraison :";
            // 
            // CodePostalLivraiCli
            // 
            this.CodePostalLivraiCli.Location = new System.Drawing.Point(370, 266);
            this.CodePostalLivraiCli.Margin = new System.Windows.Forms.Padding(2);
            this.CodePostalLivraiCli.Name = "CodePostalLivraiCli";
            this.CodePostalLivraiCli.Size = new System.Drawing.Size(151, 23);
            this.CodePostalLivraiCli.TabIndex = 33;
            // 
            // lblVilleLivraiCli
            // 
            this.lblVilleLivraiCli.AutoSize = true;
            this.lblVilleLivraiCli.Location = new System.Drawing.Point(370, 320);
            this.lblVilleLivraiCli.Name = "lblVilleLivraiCli";
            this.lblVilleLivraiCli.Size = new System.Drawing.Size(82, 15);
            this.lblVilleLivraiCli.TabIndex = 34;
            this.lblVilleLivraiCli.Text = "Ville livraison :";
            // 
            // textVilleLivraiCli
            // 
            this.textVilleLivraiCli.Location = new System.Drawing.Point(370, 337);
            this.textVilleLivraiCli.Margin = new System.Windows.Forms.Padding(2);
            this.textVilleLivraiCli.Name = "textVilleLivraiCli";
            this.textVilleLivraiCli.Size = new System.Drawing.Size(151, 23);
            this.textVilleLivraiCli.TabIndex = 35;
            // 
            // lblErrorClient
            // 
            this.lblErrorClient.AutoSize = true;
            this.lblErrorClient.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblErrorClient.Location = new System.Drawing.Point(176, 382);
            this.lblErrorClient.Name = "lblErrorClient";
            this.lblErrorClient.Size = new System.Drawing.Size(192, 15);
            this.lblErrorClient.TabIndex = 37;
            this.lblErrorClient.Text = "Veuillez renseigner tous les champs";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblErrorClient);
            this.panel1.Controls.Add(this.textVilleLivraiCli);
            this.panel1.Controls.Add(this.lblVilleLivraiCli);
            this.panel1.Controls.Add(this.CodePostalLivraiCli);
            this.panel1.Controls.Add(this.lblCodePostalLivraiCli);
            this.panel1.Controls.Add(this.textRueLivraisonCli);
            this.panel1.Controls.Add(this.lblRueLivraisonCli);
            this.panel1.Controls.Add(this.textVilleFactCli);
            this.panel1.Controls.Add(this.lblVilleFactuCli);
            this.panel1.Controls.Add(this.textCPFactuCli);
            this.panel1.Controls.Add(this.lblCodePostalFactuCli);
            this.panel1.Controls.Add(this.textRueFactuCli);
            this.panel1.Controls.Add(this.lblRueFactCli);
            this.panel1.Controls.Add(this.textFaxCli);
            this.panel1.Controls.Add(this.textTelCli);
            this.panel1.Controls.Add(this.lblFaxCli);
            this.panel1.Controls.Add(this.lblTelCli);
            this.panel1.Controls.Add(this.lblEmailCli);
            this.panel1.Controls.Add(this.textEmailCli);
            this.panel1.Controls.Add(this.AjouterCli);
            this.panel1.Controls.Add(this.lblPrenomCli);
            this.panel1.Controls.Add(this.lblCodeCli);
            this.panel1.Controls.Add(this.lblNomCli);
            this.panel1.Controls.Add(this.LabelDetails);
            this.panel1.Controls.Add(this.textPrenomCli);
            this.panel1.Controls.Add(this.textNomCli);
            this.panel1.Controls.Add(this.textCodeCli);
            this.panel1.Controls.Add(this.SupprimerCli);
            this.panel1.Controls.Add(this.ModifierCli);
            this.panel1.Location = new System.Drawing.Point(524, 130);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(536, 456);
            this.panel1.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Code";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Nom";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Prenom";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Email";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Téléphone";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // FrmListeClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1078, 602);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.actualiserProduit);
            this.Controls.Add(this.dgvClient);
            this.Controls.Add(this.retSynt);
            this.Controls.Add(this.lblProduit);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmListeClients";
            this.Text = "ListeProduitsForms";
            this.Load += new System.EventHandler(this.FrmListeProduits_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button retSynt;
        private Button actualiserProduit;
        private DataGridView dgvClient;
        private DataGridViewTextBoxColumn Telephone;
        private DataGridViewTextBoxColumn Code;
        private DataGridViewTextBoxColumn Prenom;
        private DataGridViewTextBoxColumn Email;
        private Label lblProduit;
        private DataGridViewTextBoxColumn Nom;
        private Button ModifierCli;
        private Button SupprimerCli;
        private TextBox textCodeCli;
        private TextBox textNomCli;
        private TextBox textPrenomCli;
        private Label LabelDetails;
        private Label lblNomCli;
        private Label lblCodeCli;
        private Label lblPrenomCli;
        private Button AjouterCli;
        private TextBox textEmailCli;
        private Label lblEmailCli;
        private Label lblTelCli;
        private Label lblFaxCli;
        private TextBox textTelCli;
        private TextBox textFaxCli;
        private Label lblRueFactCli;
        private TextBox textRueFactuCli;
        private Label lblCodePostalFactuCli;
        private TextBox textCPFactuCli;
        private Label lblVilleFactuCli;
        private TextBox textVilleFactCli;
        private Label lblRueLivraisonCli;
        private TextBox textRueLivraisonCli;
        private Label lblCodePostalLivraiCli;
        private TextBox CodePostalLivraiCli;
        private Label lblVilleLivraiCli;
        private TextBox textVilleLivraiCli;
        private Label lblErrorClient;
        private Panel panel1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}