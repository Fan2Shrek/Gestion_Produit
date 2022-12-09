namespace GestionGUI
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblprod = new System.Windows.Forms.Label();
            this.lbldev = new System.Windows.Forms.Label();
            this.comboBoxProd = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbltitre2 = new System.Windows.Forms.Label();
            this.combodev = new System.Windows.Forms.ComboBox();
            this.lbltxremise = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblqte = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txttxremise = new System.Windows.Forms.TextBox();
            this.textqte = new System.Windows.Forms.TextBox();
            this.lblErreur = new System.Windows.Forms.Label();
            this.txtRemise = new System.Windows.Forms.TextBox();
            this.txtQte = new System.Windows.Forms.TextBox();
            this.lblErrordv = new System.Windows.Forms.Label();
            this.lblQuantite = new System.Windows.Forms.Label();
            this.dgvProduitsDevis = new System.Windows.Forms.DataGridView();
            this.Produit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Libelle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prix_Unitaire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantité = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remise = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prix_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboClient = new System.Windows.Forms.ComboBox();
            this.comboStatut = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblStatut = new System.Windows.Forms.Label();
            this.lblListClient = new System.Windows.Forms.Label();
            this.ajouterProDev = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevis)).BeginInit();
            this.PanelDeleteDevis.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduitsDevis)).BeginInit();
            this.SuspendLayout();
            // 
            // actualiserDevis
            // 
            this.actualiserDevis.Location = new System.Drawing.Point(21, 152);
            this.actualiserDevis.Name = "actualiserDevis";
            this.actualiserDevis.Size = new System.Drawing.Size(94, 29);
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
            this.dgvDevis.Location = new System.Drawing.Point(21, 204);
            this.dgvDevis.Name = "dgvDevis";
            this.dgvDevis.RowHeadersWidth = 51;
            this.dgvDevis.RowTemplate.Height = 29;
            this.dgvDevis.Size = new System.Drawing.Size(554, 500);
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
            this.retSynt.Location = new System.Drawing.Point(21, 763);
            this.retSynt.Name = "retSynt";
            this.retSynt.Size = new System.Drawing.Size(94, 29);
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
            this.lblDevis.Location = new System.Drawing.Point(373, 41);
            this.lblDevis.Name = "lblDevis";
            this.lblDevis.Size = new System.Drawing.Size(469, 72);
            this.lblDevis.TabIndex = 24;
            this.lblDevis.Text = "Gestion des devis";
            this.lblDevis.Click += new System.EventHandler(this.lblDevis_Click);
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
            this.ConfirmerDeleteDevis.Location = new System.Drawing.Point(39, 112);
            this.ConfirmerDeleteDevis.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ConfirmerDeleteDevis.Name = "ConfirmerDeleteDevis";
            this.ConfirmerDeleteDevis.Size = new System.Drawing.Size(90, 27);
            this.ConfirmerDeleteDevis.TabIndex = 0;
            this.ConfirmerDeleteDevis.Text = "Oui";
            this.ConfirmerDeleteDevis.UseVisualStyleBackColor = true;
            this.ConfirmerDeleteDevis.Click += new System.EventHandler(this.ConfirmerDeleteDevis_Click);
            // 
            // AnnulerDeleteDevis
            // 
            this.AnnulerDeleteDevis.Location = new System.Drawing.Point(178, 112);
            this.AnnulerDeleteDevis.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.AnnulerDeleteDevis.Name = "AnnulerDeleteDevis";
            this.AnnulerDeleteDevis.Size = new System.Drawing.Size(90, 27);
            this.AnnulerDeleteDevis.TabIndex = 1;
            this.AnnulerDeleteDevis.Text = "Non";
            this.AnnulerDeleteDevis.UseVisualStyleBackColor = true;
            this.AnnulerDeleteDevis.Click += new System.EventHandler(this.AnnulerDeleteDevis_Click);
            // 
            // MessageDelete1Devis
            // 
            this.MessageDelete1Devis.AutoSize = true;
            this.MessageDelete1Devis.Location = new System.Drawing.Point(64, 21);
            this.MessageDelete1Devis.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MessageDelete1Devis.Name = "MessageDelete1Devis";
            this.MessageDelete1Devis.Size = new System.Drawing.Size(184, 20);
            this.MessageDelete1Devis.TabIndex = 2;
            this.MessageDelete1Devis.Text = "Êtes-vous sûr(e) de vouloir";
            // 
            // MessageDelete2Devis
            // 
            this.MessageDelete2Devis.AutoSize = true;
            this.MessageDelete2Devis.Location = new System.Drawing.Point(85, 43);
            this.MessageDelete2Devis.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MessageDelete2Devis.Name = "MessageDelete2Devis";
            this.MessageDelete2Devis.Size = new System.Drawing.Size(144, 20);
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
            this.PanelDeleteDevis.Location = new System.Drawing.Point(454, 375);
            this.PanelDeleteDevis.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.PanelDeleteDevis.Name = "PanelDeleteDevis";
            this.PanelDeleteDevis.Size = new System.Drawing.Size(309, 164);
            this.PanelDeleteDevis.TabIndex = 29;
            // 
            // ModifierDevis
            // 
            this.ModifierDevis.Location = new System.Drawing.Point(262, 579);
            this.ModifierDevis.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ModifierDevis.Name = "ModifierDevis";
            this.ModifierDevis.Size = new System.Drawing.Size(101, 27);
            this.ModifierDevis.TabIndex = 6;
            this.ModifierDevis.Text = "Modifier";
            this.ModifierDevis.UseVisualStyleBackColor = true;
            this.ModifierDevis.Click += new System.EventHandler(this.ModifierDevis_Click);
            // 
            // SupprimerDevis
            // 
            this.SupprimerDevis.Location = new System.Drawing.Point(454, 579);
            this.SupprimerDevis.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.SupprimerDevis.Name = "SupprimerDevis";
            this.SupprimerDevis.Size = new System.Drawing.Size(103, 27);
            this.SupprimerDevis.TabIndex = 7;
            this.SupprimerDevis.Text = "Supprimer";
            this.SupprimerDevis.UseVisualStyleBackColor = true;
            this.SupprimerDevis.Click += new System.EventHandler(this.SupprimerDevis_Click);
            // 
            // textCodeDevis
            // 
            this.textCodeDevis.Enabled = false;
            this.textCodeDevis.Location = new System.Drawing.Point(18, 113);
            this.textCodeDevis.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textCodeDevis.Name = "textCodeDevis";
            this.textCodeDevis.Size = new System.Drawing.Size(172, 27);
            this.textCodeDevis.TabIndex = 8;
            // 
            // textTauxTVA
            // 
            this.textTauxTVA.Enabled = false;
            this.textTauxTVA.Location = new System.Drawing.Point(18, 176);
            this.textTauxTVA.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textTauxTVA.Name = "textTauxTVA";
            this.textTauxTVA.Size = new System.Drawing.Size(172, 27);
            this.textTauxTVA.TabIndex = 9;
            // 
            // LabelDetails
            // 
            this.LabelDetails.AutoSize = true;
            this.LabelDetails.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelDetails.Location = new System.Drawing.Point(229, 9);
            this.LabelDetails.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelDetails.Name = "LabelDetails";
            this.LabelDetails.Size = new System.Drawing.Size(177, 67);
            this.LabelDetails.TabIndex = 12;
            this.LabelDetails.Text = "Détails";
            // 
            // lblTauxTVADevis
            // 
            this.lblTauxTVADevis.AutoSize = true;
            this.lblTauxTVADevis.Location = new System.Drawing.Point(21, 153);
            this.lblTauxTVADevis.Name = "lblTauxTVADevis";
            this.lblTauxTVADevis.Size = new System.Drawing.Size(75, 20);
            this.lblTauxTVADevis.TabIndex = 14;
            this.lblTauxTVADevis.Text = "Taux TVA :";
            // 
            // lblCodeDevis
            // 
            this.lblCodeDevis.AutoSize = true;
            this.lblCodeDevis.Location = new System.Drawing.Point(21, 91);
            this.lblCodeDevis.Name = "lblCodeDevis";
            this.lblCodeDevis.Size = new System.Drawing.Size(51, 20);
            this.lblCodeDevis.TabIndex = 15;
            this.lblCodeDevis.Text = "Code :";
            // 
            // lblTauxRemiseDevis
            // 
            this.lblTauxRemiseDevis.AutoSize = true;
            this.lblTauxRemiseDevis.Location = new System.Drawing.Point(227, 227);
            this.lblTauxRemiseDevis.Name = "lblTauxRemiseDevis";
            this.lblTauxRemiseDevis.Size = new System.Drawing.Size(93, 20);
            this.lblTauxRemiseDevis.TabIndex = 16;
            this.lblTauxRemiseDevis.Text = "Taux remise :";
            // 
            // AjouterDevis
            // 
            this.AjouterDevis.Location = new System.Drawing.Point(63, 577);
            this.AjouterDevis.Name = "AjouterDevis";
            this.AjouterDevis.Size = new System.Drawing.Size(101, 29);
            this.AjouterDevis.TabIndex = 19;
            this.AjouterDevis.Text = "Ajouter";
            this.AjouterDevis.UseVisualStyleBackColor = true;
            // 
            // textMontantHTsansTauxRemise
            // 
            this.textMontantHTsansTauxRemise.Enabled = false;
            this.textMontantHTsansTauxRemise.Location = new System.Drawing.Point(21, 401);
            this.textMontantHTsansTauxRemise.Name = "textMontantHTsansTauxRemise";
            this.textMontantHTsansTauxRemise.Size = new System.Drawing.Size(174, 27);
            this.textMontantHTsansTauxRemise.TabIndex = 20;
            // 
            // lblMontantHTaHorsRemise
            // 
            this.lblMontantHTaHorsRemise.AutoSize = true;
            this.lblMontantHTaHorsRemise.Location = new System.Drawing.Point(18, 379);
            this.lblMontantHTaHorsRemise.Name = "lblMontantHTaHorsRemise";
            this.lblMontantHTaHorsRemise.Size = new System.Drawing.Size(175, 20);
            this.lblMontantHTaHorsRemise.TabIndex = 21;
            this.lblMontantHTaHorsRemise.Text = "Montant HT sans remise :";
            // 
            // lblMontantTVADevis
            // 
            this.lblMontantTVADevis.AutoSize = true;
            this.lblMontantTVADevis.Location = new System.Drawing.Point(21, 299);
            this.lblMontantTVADevis.Name = "lblMontantTVADevis";
            this.lblMontantTVADevis.Size = new System.Drawing.Size(102, 20);
            this.lblMontantTVADevis.TabIndex = 22;
            this.lblMontantTVADevis.Text = "Montant TVA :";
            // 
            // lblMontantHTaAvecRemise
            // 
            this.lblMontantHTaAvecRemise.AutoSize = true;
            this.lblMontantHTaAvecRemise.Location = new System.Drawing.Point(21, 453);
            this.lblMontantHTaAvecRemise.Name = "lblMontantHTaAvecRemise";
            this.lblMontantHTaAvecRemise.Size = new System.Drawing.Size(177, 20);
            this.lblMontantHTaAvecRemise.TabIndex = 23;
            this.lblMontantHTaAvecRemise.Text = "Montant HT avec remise :";
            // 
            // textMontantTVA
            // 
            this.textMontantTVA.Enabled = false;
            this.textMontantTVA.Location = new System.Drawing.Point(18, 323);
            this.textMontantTVA.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textMontantTVA.Name = "textMontantTVA";
            this.textMontantTVA.Size = new System.Drawing.Size(172, 27);
            this.textMontantTVA.TabIndex = 24;
            // 
            // textMontantHTAvecRemise
            // 
            this.textMontantHTAvecRemise.Enabled = false;
            this.textMontantHTAvecRemise.Location = new System.Drawing.Point(21, 476);
            this.textMontantHTAvecRemise.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textMontantHTAvecRemise.Name = "textMontantHTAvecRemise";
            this.textMontantHTAvecRemise.Size = new System.Drawing.Size(172, 27);
            this.textMontantHTAvecRemise.TabIndex = 25;
            // 
            // lblMontantTTCDevis
            // 
            this.lblMontantTTCDevis.AutoSize = true;
            this.lblMontantTTCDevis.Location = new System.Drawing.Point(21, 227);
            this.lblMontantTTCDevis.Name = "lblMontantTTCDevis";
            this.lblMontantTTCDevis.Size = new System.Drawing.Size(100, 20);
            this.lblMontantTTCDevis.TabIndex = 26;
            this.lblMontantTTCDevis.Text = "Montant TTC :";
            // 
            // textMontantTTC
            // 
            this.textMontantTTC.Enabled = false;
            this.textMontantTTC.Location = new System.Drawing.Point(18, 249);
            this.textMontantTTC.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textMontantTTC.Name = "textMontantTTC";
            this.textMontantTTC.Size = new System.Drawing.Size(172, 27);
            this.textMontantTTC.TabIndex = 27;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblErreur);
            this.panel1.Controls.Add(this.txtRemise);
            this.panel1.Controls.Add(this.txtQte);
            this.panel1.Controls.Add(this.lblErrordv);
            this.panel1.Controls.Add(this.lblQuantite);
            this.panel1.Controls.Add(this.dgvProduitsDevis);
            this.panel1.Controls.Add(this.comboClient);
            this.panel1.Controls.Add(this.comboStatut);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.lblTauxRemiseDevis);
            this.panel1.Controls.Add(this.lblStatut);
            this.panel1.Controls.Add(this.lblListClient);
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
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(599, 152);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(613, 621);
            this.panel1.TabIndex = 28;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.lblprod);
            this.panel2.Controls.Add(this.lbldev);
            this.panel2.Controls.Add(this.comboBoxProd);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lbltitre2);
            this.panel2.Controls.Add(this.combodev);
            this.panel2.Controls.Add(this.lbltxremise);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.lblqte);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.txttxremise);
            this.panel2.Controls.Add(this.textqte);
            this.panel2.Location = new System.Drawing.Point(2, 52);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(593, 480);
            this.panel2.TabIndex = 54;
            // 
            // lblprod
            // 
            this.lblprod.AutoSize = true;
            this.lblprod.Location = new System.Drawing.Point(85, 256);
            this.lblprod.Name = "lblprod";
            this.lblprod.Size = new System.Drawing.Size(64, 20);
            this.lblprod.TabIndex = 49;
            this.lblprod.Text = "Produit :";
            // 
            // lbldev
            // 
            this.lbldev.AutoSize = true;
            this.lbldev.Location = new System.Drawing.Point(357, 256);
            this.lbldev.Name = "lbldev";
            this.lbldev.Size = new System.Drawing.Size(52, 20);
            this.lbldev.TabIndex = 50;
            this.lbldev.Text = "Devis :";
            // 
            // comboBoxProd
            // 
            this.comboBoxProd.FormattingEnabled = true;
            this.comboBoxProd.Location = new System.Drawing.Point(85, 292);
            this.comboBoxProd.Name = "comboBoxProd";
            this.comboBoxProd.Size = new System.Drawing.Size(151, 28);
            this.comboBoxProd.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 3;
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbltitre2
            // 
            this.lbltitre2.AutoSize = true;
            this.lbltitre2.Location = new System.Drawing.Point(185, 41);
            this.lbltitre2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltitre2.Name = "lbltitre2";
            this.lbltitre2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbltitre2.Size = new System.Drawing.Size(224, 20);
            this.lbltitre2.TabIndex = 2;
            this.lbltitre2.Text = "Ajouter un produit dans un devis";
            // 
            // combodev
            // 
            this.combodev.FormattingEnabled = true;
            this.combodev.Location = new System.Drawing.Point(357, 297);
            this.combodev.Name = "combodev";
            this.combodev.Size = new System.Drawing.Size(151, 28);
            this.combodev.TabIndex = 34;
            // 
            // lbltxremise
            // 
            this.lbltxremise.AutoSize = true;
            this.lbltxremise.Location = new System.Drawing.Point(357, 105);
            this.lbltxremise.Name = "lbltxremise";
            this.lbltxremise.Size = new System.Drawing.Size(93, 20);
            this.lbltxremise.TabIndex = 48;
            this.lbltxremise.Text = "Taux remise :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(418, 427);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 27);
            this.button1.TabIndex = 1;
            this.button1.Text = "Non";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblqte
            // 
            this.lblqte.AutoSize = true;
            this.lblqte.Location = new System.Drawing.Point(85, 105);
            this.lblqte.Name = "lblqte";
            this.lblqte.Size = new System.Drawing.Size(73, 20);
            this.lblqte.TabIndex = 47;
            this.lblqte.Text = "Quantité :";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(85, 429);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 27);
            this.button2.TabIndex = 0;
            this.button2.Text = "Oui";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txttxremise
            // 
            this.txttxremise.Location = new System.Drawing.Point(357, 148);
            this.txttxremise.Name = "txttxremise";
            this.txttxremise.Size = new System.Drawing.Size(151, 27);
            this.txttxremise.TabIndex = 32;
            // 
            // textqte
            // 
            this.textqte.Location = new System.Drawing.Point(85, 145);
            this.textqte.Name = "textqte";
            this.textqte.Size = new System.Drawing.Size(151, 27);
            this.textqte.TabIndex = 31;
            // 
            // lblErreur
            // 
            this.lblErreur.AutoSize = true;
            this.lblErreur.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblErreur.Location = new System.Drawing.Point(215, 532);
            this.lblErreur.Name = "lblErreur";
            this.lblErreur.Size = new System.Drawing.Size(221, 20);
            this.lblErreur.TabIndex = 54;
            this.lblErreur.Text = "Veuillez remplir tous les champs";
            // 
            // txtRemise
            // 
            this.txtRemise.Location = new System.Drawing.Point(229, 249);
            this.txtRemise.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRemise.Name = "txtRemise";
            this.txtRemise.Size = new System.Drawing.Size(172, 27);
            this.txtRemise.TabIndex = 53;
            // 
            // txtQte
            // 
            this.txtQte.Location = new System.Drawing.Point(227, 177);
            this.txtQte.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtQte.Name = "txtQte";
            this.txtQte.Size = new System.Drawing.Size(174, 27);
            this.txtQte.TabIndex = 52;
            // 
            // lblErrordv
            // 
            this.lblErrordv.AutoSize = true;
            this.lblErrordv.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblErrordv.Location = new System.Drawing.Point(194, 539);
            this.lblErrordv.Name = "lblErrordv";
            this.lblErrordv.Size = new System.Drawing.Size(242, 20);
            this.lblErrordv.TabIndex = 48;
            this.lblErrordv.Text = "Veuillez renseigner tous les champs";
            // 
            // lblQuantite
            // 
            this.lblQuantite.AutoSize = true;
            this.lblQuantite.Location = new System.Drawing.Point(227, 153);
            this.lblQuantite.Name = "lblQuantite";
            this.lblQuantite.Size = new System.Drawing.Size(73, 20);
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
            this.dgvProduitsDevis.Location = new System.Drawing.Point(229, 309);
            this.dgvProduitsDevis.Name = "dgvProduitsDevis";
            this.dgvProduitsDevis.RowHeadersWidth = 51;
            this.dgvProduitsDevis.RowTemplate.Height = 29;
            this.dgvProduitsDevis.Size = new System.Drawing.Size(373, 197);
            this.dgvProduitsDevis.TabIndex = 45;
            this.dgvProduitsDevis.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduitsDevis_CellClick);
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
            // comboClient
            // 
            this.comboClient.FormattingEnabled = true;
            this.comboClient.Location = new System.Drawing.Point(427, 176);
            this.comboClient.Name = "comboClient";
            this.comboClient.Size = new System.Drawing.Size(172, 28);
            this.comboClient.TabIndex = 44;
            // 
            // comboStatut
            // 
            this.comboStatut.FormattingEnabled = true;
            this.comboStatut.Location = new System.Drawing.Point(427, 248);
            this.comboStatut.Name = "comboStatut";
            this.comboStatut.Size = new System.Drawing.Size(172, 28);
            this.comboStatut.TabIndex = 43;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(479, 111);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 27);
            this.dateTimePicker1.TabIndex = 42;
            // 
            // lblStatut
            // 
            this.lblStatut.AutoSize = true;
            this.lblStatut.Location = new System.Drawing.Point(427, 227);
            this.lblStatut.Name = "lblStatut";
            this.lblStatut.Size = new System.Drawing.Size(55, 20);
            this.lblStatut.TabIndex = 41;
            this.lblStatut.Text = "Statut :";
            // 
            // lblListClient
            // 
            this.lblListClient.AutoSize = true;
            this.lblListClient.Location = new System.Drawing.Point(427, 153);
            this.lblListClient.Name = "lblListClient";
            this.lblListClient.Size = new System.Drawing.Size(54, 20);
            this.lblListClient.TabIndex = 40;
            this.lblListClient.Text = "Client :";
            // 
            // ajouterProDev
            // 
            this.ajouterProDev.Location = new System.Drawing.Point(427, 744);
            this.ajouterProDev.Name = "ajouterProDev";
            this.ajouterProDev.Size = new System.Drawing.Size(155, 29);
            this.ajouterProDev.TabIndex = 30;
            this.ajouterProDev.Text = "Ajouter un produit";
            this.ajouterProDev.UseVisualStyleBackColor = true;
            // 
            // FrmListeDevis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1232, 803);
            this.Controls.Add(this.PanelDeleteDevis);
            this.Controls.Add(this.ajouterProDev);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.actualiserDevis);
            this.Controls.Add(this.retSynt);
            this.Controls.Add(this.lblDevis);
            this.Controls.Add(this.dgvDevis);
            this.Name = "FrmListeDevis";
            this.Text = "FrmListeDevis";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevis)).EndInit();
            this.PanelDeleteDevis.ResumeLayout(false);
            this.PanelDeleteDevis.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private Panel panel1;
        private Label lblStatut;
        private Label lblListClient;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboClient;
        private ComboBox comboStatut;
        private DataGridView dgvProduitsDevis;
        private Label lblQuantite;
        private Label lblErrordv;
        private DataGridViewTextBoxColumn Produit;
        private DataGridViewTextBoxColumn Libelle;
        private DataGridViewTextBoxColumn Prix_Unitaire;
        private DataGridViewTextBoxColumn Quantité;
        private DataGridViewTextBoxColumn Remise;
        private DataGridViewTextBoxColumn Prix_Total;
        private TextBox txtQte;
        private DataGridViewTextBoxColumn id;
        private TextBox txtRemise;
        private Button ajouterProDev;
        private Panel panel2;
        private Label lblprod;
        private Label lbldev;
        private ComboBox comboBoxProd;
        private Label label1;
        private Label lbltitre2;
        private ComboBox combodev;
        private Label lbltxremise;
        private Button button1;
        private Label lblqte;
        private Button button2;
        private TextBox txttxremise;
        private TextBox textqte;
        private Label lblErreur;
    }
}