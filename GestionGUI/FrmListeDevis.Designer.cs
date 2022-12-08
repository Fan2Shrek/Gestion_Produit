﻿namespace GestionGUI
{
    partial class FrmListeDevis
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
            this.actualiserDevis = new System.Windows.Forms.Button();
            this.dgvDevis = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Taux_TVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Statut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.retSynt = new System.Windows.Forms.Button();
            this.Telephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDevis = new System.Windows.Forms.Label();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConfirmerDeleteDevis = new System.Windows.Forms.Button();
            this.AnnulerDeleteDevis = new System.Windows.Forms.Button();
            this.MessageDelete1Devis = new System.Windows.Forms.Label();
            this.MessageDelete2Devis = new System.Windows.Forms.Label();
            this.PanelDeleteDevis = new System.Windows.Forms.Panel();
            this.ModifierDevis = new System.Windows.Forms.Button();
            this.SupprimerDevis = new System.Windows.Forms.Button();
            this.textCodeDevis = new System.Windows.Forms.TextBox();
            this.textTauxTVA = new System.Windows.Forms.TextBox();
            this.textTauxRemiseDevis = new System.Windows.Forms.TextBox();
            this.LabelDetails = new System.Windows.Forms.Label();
            this.lblTauxTVADevis = new System.Windows.Forms.Label();
            this.lblCodeDevis = new System.Windows.Forms.Label();
            this.lblTauxRemiseDevis = new System.Windows.Forms.Label();
            this.AjouterDevis = new System.Windows.Forms.Button();
            this.textMontantHTsansTauxRemise = new System.Windows.Forms.TextBox();
            this.lblMontantHTaHorsRemise = new System.Windows.Forms.Label();
            this.lblMontantTVADevis = new System.Windows.Forms.Label();
            this.lblMontantHTaAvecRemise = new System.Windows.Forms.Label();
            this.textMontantTVA = new System.Windows.Forms.TextBox();
            this.textMontantHTAvecRemise = new System.Windows.Forms.TextBox();
            this.lblMontantTTCDevis = new System.Windows.Forms.Label();
            this.textMontantTTC = new System.Windows.Forms.TextBox();
            this.lblErrorDevis = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtRemise = new System.Windows.Forms.TextBox();
            this.txtQte = new System.Windows.Forms.TextBox();
            this.cbxProduit = new System.Windows.Forms.ComboBox();
            this.comboProduit = new System.Windows.Forms.ComboBox();
            this.lblProduit = new System.Windows.Forms.Label();
            this.lblErrordv = new System.Windows.Forms.Label();
            this.textQuantite = new System.Windows.Forms.TextBox();
            this.lblQuantite = new System.Windows.Forms.Label();
            this.dgvProduitsDevis = new System.Windows.Forms.DataGridView();
            this.comboClient = new System.Windows.Forms.ComboBox();
            this.comboStatut = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblStatut = new System.Windows.Forms.Label();
            this.lblListClient = new System.Windows.Forms.Label();
            this.Produit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Libelle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prix_Unitaire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantité = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remise = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prix_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevis)).BeginInit();
            this.PanelDeleteDevis.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduitsDevis)).BeginInit();
            this.SuspendLayout();
            // 
            // actualiserDevis
            // 
            this.actualiserDevis.Location = new System.Drawing.Point(18, 114);
            this.actualiserDevis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.actualiserDevis.Name = "actualiserDevis";
            this.actualiserDevis.Size = new System.Drawing.Size(82, 22);
            this.actualiserDevis.TabIndex = 27;
            this.actualiserDevis.Text = "Actualiser";
            this.actualiserDevis.UseVisualStyleBackColor = true;
            this.actualiserDevis.Click += new System.EventHandler(this.actualiserDevis_Click);
            // 
            // dgvDevis
            // 
            this.dgvDevis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDevis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.Taux_TVA,
            this.Client,
            this.Statut});
            this.dgvDevis.Location = new System.Drawing.Point(18, 153);
            this.dgvDevis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDevis.Name = "dgvDevis";
            this.dgvDevis.RowHeadersWidth = 51;
            this.dgvDevis.RowTemplate.Height = 29;
            this.dgvDevis.Size = new System.Drawing.Size(485, 375);
            this.dgvDevis.TabIndex = 26;
            this.dgvDevis.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDevis_CellClick);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Code";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Date";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // Taux_TVA
            // 
            this.Taux_TVA.HeaderText = "Taux TVA";
            this.Taux_TVA.MinimumWidth = 6;
            this.Taux_TVA.Name = "Taux_TVA";
            this.Taux_TVA.Width = 125;
            // 
            // Client
            // 
            this.Client.HeaderText = "Client";
            this.Client.MinimumWidth = 6;
            this.Client.Name = "Client";
            this.Client.Width = 125;
            // 
            // Statut
            // 
            this.Statut.HeaderText = "Statut";
            this.Statut.MinimumWidth = 6;
            this.Statut.Name = "Statut";
            this.Statut.Width = 125;
            // 
            // retSynt
            // 
            this.retSynt.Location = new System.Drawing.Point(18, 572);
            this.retSynt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.retSynt.Name = "retSynt";
            this.retSynt.Size = new System.Drawing.Size(82, 22);
            this.retSynt.TabIndex = 25;
            this.retSynt.Text = "Retour";
            this.retSynt.UseVisualStyleBackColor = true;
            this.retSynt.Click += new System.EventHandler(this.retSynt_Click);
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
            // lblDevis
            // 
            this.lblDevis.AutoSize = true;
            this.lblDevis.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDevis.Location = new System.Drawing.Point(326, 31);
            this.lblDevis.Name = "lblDevis";
            this.lblDevis.Size = new System.Drawing.Size(376, 59);
            this.lblDevis.TabIndex = 24;
            this.lblDevis.Text = "Gestion des devis";
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nom";
            this.Nom.MinimumWidth = 6;
            this.Nom.Name = "Nom";
            this.Nom.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Code";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Code";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Date";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // ConfirmerDeleteDevis
            // 
            this.ConfirmerDeleteDevis.Location = new System.Drawing.Point(34, 84);
            this.ConfirmerDeleteDevis.Margin = new System.Windows.Forms.Padding(2);
            this.ConfirmerDeleteDevis.Name = "ConfirmerDeleteDevis";
            this.ConfirmerDeleteDevis.Size = new System.Drawing.Size(79, 20);
            this.ConfirmerDeleteDevis.TabIndex = 0;
            this.ConfirmerDeleteDevis.Text = "Oui";
            this.ConfirmerDeleteDevis.UseVisualStyleBackColor = true;
            this.ConfirmerDeleteDevis.Click += new System.EventHandler(this.ConfirmerDeleteDevis_Click);
            // 
            // AnnulerDeleteDevis
            // 
            this.AnnulerDeleteDevis.Location = new System.Drawing.Point(156, 84);
            this.AnnulerDeleteDevis.Margin = new System.Windows.Forms.Padding(2);
            this.AnnulerDeleteDevis.Name = "AnnulerDeleteDevis";
            this.AnnulerDeleteDevis.Size = new System.Drawing.Size(79, 20);
            this.AnnulerDeleteDevis.TabIndex = 1;
            this.AnnulerDeleteDevis.Text = "Non";
            this.AnnulerDeleteDevis.UseVisualStyleBackColor = true;
            this.AnnulerDeleteDevis.Click += new System.EventHandler(this.AnnulerDeleteDevis_Click);
            // 
            // MessageDelete1Devis
            // 
            this.MessageDelete1Devis.AutoSize = true;
            this.MessageDelete1Devis.Location = new System.Drawing.Point(56, 16);
            this.MessageDelete1Devis.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MessageDelete1Devis.Name = "MessageDelete1Devis";
            this.MessageDelete1Devis.Size = new System.Drawing.Size(147, 15);
            this.MessageDelete1Devis.TabIndex = 2;
            this.MessageDelete1Devis.Text = "Êtes-vous sûr(e) de vouloir";
            // 
            // MessageDelete2Devis
            // 
            this.MessageDelete2Devis.AutoSize = true;
            this.MessageDelete2Devis.Location = new System.Drawing.Point(74, 32);
            this.MessageDelete2Devis.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MessageDelete2Devis.Name = "MessageDelete2Devis";
            this.MessageDelete2Devis.Size = new System.Drawing.Size(114, 15);
            this.MessageDelete2Devis.TabIndex = 3;
            this.MessageDelete2Devis.Text = "supprimer ce devis ?";
            this.MessageDelete2Devis.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PanelDeleteDevis
            // 
            this.PanelDeleteDevis.Controls.Add(this.MessageDelete2Devis);
            this.PanelDeleteDevis.Controls.Add(this.MessageDelete1Devis);
            this.PanelDeleteDevis.Controls.Add(this.AnnulerDeleteDevis);
            this.PanelDeleteDevis.Controls.Add(this.ConfirmerDeleteDevis);
            this.PanelDeleteDevis.Location = new System.Drawing.Point(397, 281);
            this.PanelDeleteDevis.Margin = new System.Windows.Forms.Padding(2);
            this.PanelDeleteDevis.Name = "PanelDeleteDevis";
            this.PanelDeleteDevis.Size = new System.Drawing.Size(270, 123);
            this.PanelDeleteDevis.TabIndex = 29;
            // 
            // ModifierDevis
            // 
            this.ModifierDevis.Location = new System.Drawing.Point(229, 434);
            this.ModifierDevis.Margin = new System.Windows.Forms.Padding(2);
            this.ModifierDevis.Name = "ModifierDevis";
            this.ModifierDevis.Size = new System.Drawing.Size(88, 20);
            this.ModifierDevis.TabIndex = 6;
            this.ModifierDevis.Text = "Modifier";
            this.ModifierDevis.UseVisualStyleBackColor = true;
            this.ModifierDevis.Click += new System.EventHandler(this.ModifierDevis_Click);
            // 
            // SupprimerDevis
            // 
            this.SupprimerDevis.Location = new System.Drawing.Point(397, 434);
            this.SupprimerDevis.Margin = new System.Windows.Forms.Padding(2);
            this.SupprimerDevis.Name = "SupprimerDevis";
            this.SupprimerDevis.Size = new System.Drawing.Size(90, 20);
            this.SupprimerDevis.TabIndex = 7;
            this.SupprimerDevis.Text = "Supprimer";
            this.SupprimerDevis.UseVisualStyleBackColor = true;
            this.SupprimerDevis.Click += new System.EventHandler(this.SupprimerDevis_Click);
            // 
            // textCodeDevis
            // 
            this.textCodeDevis.Enabled = false;
            this.textCodeDevis.Location = new System.Drawing.Point(16, 85);
            this.textCodeDevis.Margin = new System.Windows.Forms.Padding(2);
            this.textCodeDevis.Name = "textCodeDevis";
            this.textCodeDevis.Size = new System.Drawing.Size(151, 23);
            this.textCodeDevis.TabIndex = 8;
            // 
            // textTauxTVA
            // 
            this.textTauxTVA.Enabled = false;
            this.textTauxTVA.Location = new System.Drawing.Point(16, 132);
            this.textTauxTVA.Margin = new System.Windows.Forms.Padding(2);
            this.textTauxTVA.Name = "textTauxTVA";
            this.textTauxTVA.Size = new System.Drawing.Size(151, 23);
            this.textTauxTVA.TabIndex = 9;
            // 
            // textTauxRemiseDevis
            // 
            this.textTauxRemiseDevis.Location = new System.Drawing.Point(199, 187);
            this.textTauxRemiseDevis.Margin = new System.Windows.Forms.Padding(2);
            this.textTauxRemiseDevis.Name = "textTauxRemiseDevis";
            this.textTauxRemiseDevis.Size = new System.Drawing.Size(149, 23);
            this.textTauxRemiseDevis.TabIndex = 10;
            // 
            // LabelDetails
            // 
            this.LabelDetails.AutoSize = true;
            this.LabelDetails.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelDetails.Location = new System.Drawing.Point(200, 7);
            this.LabelDetails.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelDetails.Name = "LabelDetails";
            this.LabelDetails.Size = new System.Drawing.Size(143, 54);
            this.LabelDetails.TabIndex = 12;
            this.LabelDetails.Text = "Détails";
            // 
            // lblTauxTVADevis
            // 
            this.lblTauxTVADevis.AutoSize = true;
            this.lblTauxTVADevis.Location = new System.Drawing.Point(18, 115);
            this.lblTauxTVADevis.Name = "lblTauxTVADevis";
            this.lblTauxTVADevis.Size = new System.Drawing.Size(60, 15);
            this.lblTauxTVADevis.TabIndex = 14;
            this.lblTauxTVADevis.Text = "Taux TVA :";
            // 
            // lblCodeDevis
            // 
            this.lblCodeDevis.AutoSize = true;
            this.lblCodeDevis.Location = new System.Drawing.Point(18, 68);
            this.lblCodeDevis.Name = "lblCodeDevis";
            this.lblCodeDevis.Size = new System.Drawing.Size(41, 15);
            this.lblCodeDevis.TabIndex = 15;
            this.lblCodeDevis.Text = "Code :";
            // 
            // lblTauxRemiseDevis
            // 
            this.lblTauxRemiseDevis.AutoSize = true;
            this.lblTauxRemiseDevis.Location = new System.Drawing.Point(199, 170);
            this.lblTauxRemiseDevis.Name = "lblTauxRemiseDevis";
            this.lblTauxRemiseDevis.Size = new System.Drawing.Size(75, 15);
            this.lblTauxRemiseDevis.TabIndex = 16;
            this.lblTauxRemiseDevis.Text = "Taux remise :";
            // 
            // AjouterDevis
            // 
            this.AjouterDevis.Location = new System.Drawing.Point(55, 433);
            this.AjouterDevis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AjouterDevis.Name = "AjouterDevis";
            this.AjouterDevis.Size = new System.Drawing.Size(88, 22);
            this.AjouterDevis.TabIndex = 19;
            this.AjouterDevis.Text = "Ajouter";
            this.AjouterDevis.UseVisualStyleBackColor = true;
            // 
            // textMontantHTsansTauxRemise
            // 
            this.textMontantHTsansTauxRemise.Enabled = false;
            this.textMontantHTsansTauxRemise.Location = new System.Drawing.Point(18, 301);
            this.textMontantHTsansTauxRemise.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textMontantHTsansTauxRemise.Name = "textMontantHTsansTauxRemise";
            this.textMontantHTsansTauxRemise.Size = new System.Drawing.Size(153, 23);
            this.textMontantHTsansTauxRemise.TabIndex = 20;
            // 
            // lblMontantHTaHorsRemise
            // 
            this.lblMontantHTaHorsRemise.AutoSize = true;
            this.lblMontantHTaHorsRemise.Location = new System.Drawing.Point(16, 284);
            this.lblMontantHTaHorsRemise.Name = "lblMontantHTaHorsRemise";
            this.lblMontantHTaHorsRemise.Size = new System.Drawing.Size(141, 15);
            this.lblMontantHTaHorsRemise.TabIndex = 21;
            this.lblMontantHTaHorsRemise.Text = "Montant HT sans remise :";
            // 
            // lblMontantTVADevis
            // 
            this.lblMontantTVADevis.AutoSize = true;
            this.lblMontantTVADevis.Location = new System.Drawing.Point(18, 224);
            this.lblMontantTVADevis.Name = "lblMontantTVADevis";
            this.lblMontantTVADevis.Size = new System.Drawing.Size(82, 15);
            this.lblMontantTVADevis.TabIndex = 22;
            this.lblMontantTVADevis.Text = "Montant TVA :";
            // 
            // lblMontantHTaAvecRemise
            // 
            this.lblMontantHTaAvecRemise.AutoSize = true;
            this.lblMontantHTaAvecRemise.Location = new System.Drawing.Point(18, 340);
            this.lblMontantHTaAvecRemise.Name = "lblMontantHTaAvecRemise";
            this.lblMontantHTaAvecRemise.Size = new System.Drawing.Size(142, 15);
            this.lblMontantHTaAvecRemise.TabIndex = 23;
            this.lblMontantHTaAvecRemise.Text = "Montant HT avec remise :";
            // 
            // textMontantTVA
            // 
            this.textMontantTVA.Enabled = false;
            this.textMontantTVA.Location = new System.Drawing.Point(16, 242);
            this.textMontantTVA.Margin = new System.Windows.Forms.Padding(2);
            this.textMontantTVA.Name = "textMontantTVA";
            this.textMontantTVA.Size = new System.Drawing.Size(151, 23);
            this.textMontantTVA.TabIndex = 24;
            // 
            // textMontantHTAvecRemise
            // 
            this.textMontantHTAvecRemise.Enabled = false;
            this.textMontantHTAvecRemise.Location = new System.Drawing.Point(18, 357);
            this.textMontantHTAvecRemise.Margin = new System.Windows.Forms.Padding(2);
            this.textMontantHTAvecRemise.Name = "textMontantHTAvecRemise";
            this.textMontantHTAvecRemise.Size = new System.Drawing.Size(151, 23);
            this.textMontantHTAvecRemise.TabIndex = 25;
            // 
            // lblMontantTTCDevis
            // 
            this.lblMontantTTCDevis.AutoSize = true;
            this.lblMontantTTCDevis.Location = new System.Drawing.Point(18, 170);
            this.lblMontantTTCDevis.Name = "lblMontantTTCDevis";
            this.lblMontantTTCDevis.Size = new System.Drawing.Size(81, 15);
            this.lblMontantTTCDevis.TabIndex = 26;
            this.lblMontantTTCDevis.Text = "Montant TTC :";
            // 
            // textMontantTTC
            // 
            this.textMontantTTC.Enabled = false;
            this.textMontantTTC.Location = new System.Drawing.Point(16, 187);
            this.textMontantTTC.Margin = new System.Windows.Forms.Padding(2);
            this.textMontantTTC.Name = "textMontantTTC";
            this.textMontantTTC.Size = new System.Drawing.Size(151, 23);
            this.textMontantTTC.TabIndex = 27;
            // 
            // lblErrorDevis
            // 
            this.lblErrorDevis.AutoSize = true;
            this.lblErrorDevis.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblErrorDevis.Location = new System.Drawing.Point(170, 362);
            this.lblErrorDevis.Name = "lblErrorDevis";
            this.lblErrorDevis.Size = new System.Drawing.Size(192, 15);
            this.lblErrorDevis.TabIndex = 37;
            this.lblErrorDevis.Text = "Veuillez renseigner tous les champs";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtRemise);
            this.panel1.Controls.Add(this.txtQte);
            this.panel1.Controls.Add(this.cbxProduit);
            this.panel1.Controls.Add(this.comboProduit);
            this.panel1.Controls.Add(this.lblProduit);
            this.panel1.Controls.Add(this.lblErrordv);
            this.panel1.Controls.Add(this.textQuantite);
            this.panel1.Controls.Add(this.lblQuantite);
            this.panel1.Controls.Add(this.dgvProduitsDevis);
            this.panel1.Controls.Add(this.comboClient);
            this.panel1.Controls.Add(this.comboStatut);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.lblTauxRemiseDevis);
            this.panel1.Controls.Add(this.textTauxRemiseDevis);
            this.panel1.Controls.Add(this.lblStatut);
            this.panel1.Controls.Add(this.lblListClient);
            this.panel1.Controls.Add(this.lblErrorDevis);
            this.panel1.Controls.Add(this.textMontantTTC);
            this.panel1.Controls.Add(this.lblMontantTTCDevis);
            this.panel1.Controls.Add(this.textMontantHTAvecRemise);
            this.panel1.Controls.Add(this.textMontantTVA);
            this.panel1.Controls.Add(this.lblMontantHTaAvecRemise);
            this.panel1.Controls.Add(this.lblMontantTVADevis);
            this.panel1.Controls.Add(this.lblMontantHTaHorsRemise);
            this.panel1.Controls.Add(this.textMontantHTsansTauxRemise);
            this.panel1.Controls.Add(this.AjouterDevis);
            this.panel1.Controls.Add(this.lblCodeDevis);
            this.panel1.Controls.Add(this.lblTauxTVADevis);
            this.panel1.Controls.Add(this.LabelDetails);
            this.panel1.Controls.Add(this.textTauxTVA);
            this.panel1.Controls.Add(this.textCodeDevis);
            this.panel1.Controls.Add(this.SupprimerDevis);
            this.panel1.Controls.Add(this.ModifierDevis);
            this.panel1.Location = new System.Drawing.Point(524, 114);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(536, 466);
            this.panel1.TabIndex = 28;
            // 
            // txtRemise
            // 
            this.txtRemise.Location = new System.Drawing.Point(359, 401);
            this.txtRemise.Name = "txtRemise";
            this.txtRemise.Size = new System.Drawing.Size(128, 23);
            this.txtRemise.TabIndex = 53;
            // 
            // txtQte
            // 
            this.txtQte.Location = new System.Drawing.Point(200, 401);
            this.txtQte.Name = "txtQte";
            this.txtQte.Size = new System.Drawing.Size(127, 23);
            this.txtQte.TabIndex = 52;
            // 
            // cbxProduit
            // 
            this.cbxProduit.FormattingEnabled = true;
            this.cbxProduit.Location = new System.Drawing.Point(18, 401);
            this.cbxProduit.Name = "cbxProduit";
            this.cbxProduit.Size = new System.Drawing.Size(153, 23);
            this.cbxProduit.TabIndex = 51;
            // 
            // comboProduit
            // 
            this.comboProduit.FormattingEnabled = true;
            this.comboProduit.Location = new System.Drawing.Point(199, 85);
            this.comboProduit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboProduit.Name = "comboProduit";
            this.comboProduit.Size = new System.Drawing.Size(152, 23);
            this.comboProduit.TabIndex = 50;
            // 
            // lblProduit
            // 
            this.lblProduit.AutoSize = true;
            this.lblProduit.Location = new System.Drawing.Point(199, 68);
            this.lblProduit.Name = "lblProduit";
            this.lblProduit.Size = new System.Drawing.Size(52, 15);
            this.lblProduit.TabIndex = 49;
            this.lblProduit.Text = "Produit :";
            // 
            // lblErrordv
            // 
            this.lblErrordv.AutoSize = true;
            this.lblErrordv.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblErrordv.Location = new System.Drawing.Point(170, 404);
            this.lblErrordv.Name = "lblErrordv";
            this.lblErrordv.Size = new System.Drawing.Size(192, 15);
            this.lblErrordv.TabIndex = 48;
            this.lblErrordv.Text = "Veuillez renseigner tous les champs";
            // 
            // textQuantite
            // 
            this.textQuantite.Location = new System.Drawing.Point(200, 132);
            this.textQuantite.Margin = new System.Windows.Forms.Padding(2);
            this.textQuantite.Name = "textQuantite";
            this.textQuantite.Size = new System.Drawing.Size(151, 23);
            this.textQuantite.TabIndex = 47;
            // 
            // lblQuantite
            // 
            this.lblQuantite.AutoSize = true;
            this.lblQuantite.Location = new System.Drawing.Point(200, 115);
            this.lblQuantite.Name = "lblQuantite";
            this.lblQuantite.Size = new System.Drawing.Size(59, 15);
            this.lblQuantite.TabIndex = 46;
            this.lblQuantite.Text = "Quantité :";
            // 
            // dgvProduitsDevis
            // 
            this.dgvProduitsDevis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduitsDevis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Produit,
            this.Libelle,
            this.Prix_Unitaire,
            this.Quantité,
            this.Remise,
            this.Prix_Total});
            this.dgvProduitsDevis.Location = new System.Drawing.Point(200, 232);
            this.dgvProduitsDevis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvProduitsDevis.Name = "dgvProduitsDevis";
            this.dgvProduitsDevis.RowHeadersWidth = 51;
            this.dgvProduitsDevis.RowTemplate.Height = 29;
            this.dgvProduitsDevis.Size = new System.Drawing.Size(326, 148);
            this.dgvProduitsDevis.TabIndex = 45;
            this.dgvProduitsDevis.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduitsDevis_CellClick);
            // 
            // comboClient
            // 
            this.comboClient.FormattingEnabled = true;
            this.comboClient.Location = new System.Drawing.Point(374, 132);
            this.comboClient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboClient.Name = "comboClient";
            this.comboClient.Size = new System.Drawing.Size(151, 23);
            this.comboClient.TabIndex = 44;
            // 
            // comboStatut
            // 
            this.comboStatut.FormattingEnabled = true;
            this.comboStatut.Location = new System.Drawing.Point(374, 186);
            this.comboStatut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboStatut.Name = "comboStatut";
            this.comboStatut.Size = new System.Drawing.Size(151, 23);
            this.comboStatut.TabIndex = 43;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(419, 83);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(106, 23);
            this.dateTimePicker1.TabIndex = 42;
            // 
            // lblStatut
            // 
            this.lblStatut.AutoSize = true;
            this.lblStatut.Location = new System.Drawing.Point(374, 170);
            this.lblStatut.Name = "lblStatut";
            this.lblStatut.Size = new System.Drawing.Size(44, 15);
            this.lblStatut.TabIndex = 41;
            this.lblStatut.Text = "Statut :";
            // 
            // lblListClient
            // 
            this.lblListClient.AutoSize = true;
            this.lblListClient.Location = new System.Drawing.Point(374, 115);
            this.lblListClient.Name = "lblListClient";
            this.lblListClient.Size = new System.Drawing.Size(44, 15);
            this.lblListClient.TabIndex = 40;
            this.lblListClient.Text = "Client :";
            // 
            // Produit
            // 
            this.Produit.HeaderText = "Produit";
            this.Produit.MinimumWidth = 6;
            this.Produit.Name = "Produit";
            this.Produit.Width = 125;
            // 
            // Libelle
            // 
            this.Libelle.HeaderText = "Libelle";
            this.Libelle.MinimumWidth = 6;
            this.Libelle.Name = "Libelle";
            this.Libelle.Width = 125;
            // 
            // Prix_Unitaire
            // 
            this.Prix_Unitaire.HeaderText = "Prix Unitaire";
            this.Prix_Unitaire.MinimumWidth = 6;
            this.Prix_Unitaire.Name = "Prix_Unitaire";
            this.Prix_Unitaire.Width = 125;
            // 
            // Quantité
            // 
            this.Quantité.HeaderText = "Quantité";
            this.Quantité.MinimumWidth = 6;
            this.Quantité.Name = "Quantité";
            this.Quantité.Width = 125;
            // 
            // Remise
            // 
            this.Remise.HeaderText = "Remise";
            this.Remise.MinimumWidth = 8;
            this.Remise.Name = "Remise";
            this.Remise.Width = 150;
            // 
            // Prix_Total
            // 
            this.Prix_Total.HeaderText = "Prix Total";
            this.Prix_Total.MinimumWidth = 6;
            this.Prix_Total.Name = "Prix_Total";
            this.Prix_Total.Width = 125;
            // 
            // FrmListeDevis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1078, 562);
            this.Controls.Add(this.PanelDeleteDevis);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.actualiserDevis);
            this.Controls.Add(this.retSynt);
            this.Controls.Add(this.lblDevis);
            this.Controls.Add(this.dgvDevis);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmListeDevis";
            this.Text = "FrmListeDevis";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevis)).EndInit();
            this.PanelDeleteDevis.ResumeLayout(false);
            this.PanelDeleteDevis.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduitsDevis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button actualiserDevis;
        private DataGridView dgvDevis;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn Taux_TVA;
        private DataGridViewTextBoxColumn Client;
        private DataGridViewTextBoxColumn Statut;
        private Button retSynt;
        private DataGridViewTextBoxColumn Telephone;
        private DataGridViewTextBoxColumn Code;
        private DataGridViewTextBoxColumn Prenom;
        private DataGridViewTextBoxColumn Email;
        private Label lblDevis;
        private DataGridViewTextBoxColumn Nom;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private Button ConfirmerDeleteDevis;
        private Button AnnulerDeleteDevis;
        private Label MessageDelete1Devis;
        private Label MessageDelete2Devis;
        private Panel PanelDeleteDevis;
        private Button ModifierDevis;
        private Button SupprimerDevis;
        private TextBox textCodeDevis;
        private TextBox textTauxTVA;
        private TextBox textTauxRemiseDevis;
        private Label LabelDetails;
        private Label lblTauxTVADevis;
        private Label lblCodeDevis;
        private Label lblTauxRemiseDevis;
        private Button AjouterDevis;
        private TextBox textMontantHTsansTauxRemise;
        private Label lblMontantHTaHorsRemise;
        private Label lblMontantTVADevis;
        private Label lblMontantHTaAvecRemise;
        private TextBox textMontantTVA;
        private TextBox textMontantHTAvecRemise;
        private Label lblMontantTTCDevis;
        private TextBox textMontantTTC;
        private Label lblErrorDevis;
        private Panel panel1;
        private Label lblStatut;
        private Label lblListClient;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboClient;
        private ComboBox comboStatut;
        private DataGridView dgvProduitsDevis;
        private TextBox textQuantite;
        private Label lblQuantite;
        private Label lblErrordv;
        private DataGridViewTextBoxColumn Produit;
        private DataGridViewTextBoxColumn Libelle;
        private DataGridViewTextBoxColumn Prix_Unitaire;
        private DataGridViewTextBoxColumn Quantité;
        private DataGridViewTextBoxColumn Remise;
        private DataGridViewTextBoxColumn Prix_Total;
        private ComboBox comboProduit;
        private Label lblProduit;
        private ComboBox cbxProduit;
        private TextBox txtQte;
        private DataGridViewTextBoxColumn id;
        private TextBox txtRemise;
    }
}