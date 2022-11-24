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
            this.textCodeCli = new System.Windows.Forms.TextBox();
            this.textNomCli = new System.Windows.Forms.TextBox();
            this.LabelDetails = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblEmailCli = new System.Windows.Forms.Label();
            this.lblTelCli = new System.Windows.Forms.Label();
            this.lblRueFactCli = new System.Windows.Forms.Label();
            this.lblCodePostalFactuCli = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCodeCli = new System.Windows.Forms.Label();
            this.Supprimer = new System.Windows.Forms.Button();
            this.Modifier = new System.Windows.Forms.Button();
            this.lblPrenomCli = new System.Windows.Forms.Label();
            this.textPrenomCli = new System.Windows.Forms.TextBox();
            this.textTelCli = new System.Windows.Forms.TextBox();
            this.lblFaxCli = new System.Windows.Forms.Label();
            this.textRueFactuCli = new System.Windows.Forms.TextBox();
            this.textEmailCli = new System.Windows.Forms.TextBox();
            this.lblProduit = new System.Windows.Forms.Label();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textCPFactuCli = new System.Windows.Forms.TextBox();
            this.lblNomCli = new System.Windows.Forms.Label();
            this.textFaxCli = new System.Windows.Forms.TextBox();
            this.lblErrorClient = new System.Windows.Forms.Label();
            this.lblVilleFactuCli = new System.Windows.Forms.Label();
            this.textVilleFactCli = new System.Windows.Forms.TextBox();
            this.lblRueLivraisonCli = new System.Windows.Forms.Label();
            this.textRueLivraisonCli = new System.Windows.Forms.TextBox();
            this.lblCodePostalLivraiCli = new System.Windows.Forms.Label();
            this.textRueLivraiCli = new System.Windows.Forms.TextBox();
            this.lblVilleLivraiCli = new System.Windows.Forms.Label();
            this.textVilleLivraiCli = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // retSynt
            // 
            this.retSynt.Location = new System.Drawing.Point(21, 752);
            this.retSynt.Name = "retSynt";
            this.retSynt.Size = new System.Drawing.Size(94, 29);
            this.retSynt.TabIndex = 2;
            this.retSynt.Text = "Retour";
            this.retSynt.UseVisualStyleBackColor = true;
            this.retSynt.Click += new System.EventHandler(this.retSynt_Click);
            // 
            // actualiserProduit
            // 
            this.actualiserProduit.Location = new System.Drawing.Point(21, 173);
            this.actualiserProduit.Name = "actualiserProduit";
            this.actualiserProduit.Size = new System.Drawing.Size(94, 29);
            this.actualiserProduit.TabIndex = 5;
            this.actualiserProduit.Text = "Actualiser";
            this.actualiserProduit.UseVisualStyleBackColor = true;
            this.actualiserProduit.Click += new System.EventHandler(this.actualiserProduit_Click);
            // 
            // dgvClient
            // 
            this.dgvClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClient.Location = new System.Drawing.Point(21, 230);
            this.dgvClient.Name = "dgvClient";
            this.dgvClient.RowHeadersWidth = 51;
            this.dgvClient.RowTemplate.Height = 29;
            this.dgvClient.Size = new System.Drawing.Size(554, 500);
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
            // textCodeCli
            // 
            this.textCodeCli.Enabled = false;
            this.textCodeCli.Location = new System.Drawing.Point(27, 172);
            this.textCodeCli.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textCodeCli.Name = "textCodeCli";
            this.textCodeCli.Size = new System.Drawing.Size(170, 27);
            this.textCodeCli.TabIndex = 8;
            this.textCodeCli.TextChanged += new System.EventHandler(this.textCodeCli_TextChanged);
            // 
            // textNomCli
            // 
            this.textNomCli.Location = new System.Drawing.Point(27, 354);
            this.textNomCli.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textNomCli.Name = "textNomCli";
            this.textNomCli.Size = new System.Drawing.Size(170, 27);
            this.textNomCli.TabIndex = 9;
            // 
            // LabelDetails
            // 
            this.LabelDetails.AutoSize = true;
            this.LabelDetails.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelDetails.Location = new System.Drawing.Point(229, 19);
            this.LabelDetails.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelDetails.Name = "LabelDetails";
            this.LabelDetails.Size = new System.Drawing.Size(177, 67);
            this.LabelDetails.TabIndex = 12;
            this.LabelDetails.Text = "Détails";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(63, 560);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 29);
            this.button1.TabIndex = 19;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblEmailCli
            // 
            this.lblEmailCli.AutoSize = true;
            this.lblEmailCli.Location = new System.Drawing.Point(27, 426);
            this.lblEmailCli.Name = "lblEmailCli";
            this.lblEmailCli.Size = new System.Drawing.Size(53, 20);
            this.lblEmailCli.TabIndex = 21;
            this.lblEmailCli.Text = "Email :";
            // 
            // lblTelCli
            // 
            this.lblTelCli.AutoSize = true;
            this.lblTelCli.Location = new System.Drawing.Point(229, 149);
            this.lblTelCli.Name = "lblTelCli";
            this.lblTelCli.Size = new System.Drawing.Size(85, 20);
            this.lblTelCli.TabIndex = 22;
            this.lblTelCli.Text = "Téléphone :";
            // 
            // lblRueFactCli
            // 
            this.lblRueFactCli.AutoSize = true;
            this.lblRueFactCli.Location = new System.Drawing.Point(229, 331);
            this.lblRueFactCli.Name = "lblRueFactCli";
            this.lblRueFactCli.Size = new System.Drawing.Size(117, 20);
            this.lblRueFactCli.TabIndex = 26;
            this.lblRueFactCli.Text = "Rue facturation :";
            // 
            // lblCodePostalFactuCli
            // 
            this.lblCodePostalFactuCli.AutoSize = true;
            this.lblCodePostalFactuCli.Location = new System.Drawing.Point(229, 426);
            this.lblCodePostalFactuCli.Name = "lblCodePostalFactuCli";
            this.lblCodePostalFactuCli.Size = new System.Drawing.Size(172, 20);
            this.lblCodePostalFactuCli.TabIndex = 20;
            this.lblCodePostalFactuCli.Text = "Code postal facturation :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblErrorClient);
            this.panel1.Controls.Add(this.textVilleLivraiCli);
            this.panel1.Controls.Add(this.lblVilleLivraiCli);
            this.panel1.Controls.Add(this.textRueLivraiCli);
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
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lblPrenomCli);
            this.panel1.Controls.Add(this.lblCodeCli);
            this.panel1.Controls.Add(this.lblNomCli);
            this.panel1.Controls.Add(this.LabelDetails);
            this.panel1.Controls.Add(this.textPrenomCli);
            this.panel1.Controls.Add(this.textNomCli);
            this.panel1.Controls.Add(this.textCodeCli);
            this.panel1.Controls.Add(this.Supprimer);
            this.panel1.Controls.Add(this.Modifier);
            this.panel1.Location = new System.Drawing.Point(599, 173);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(612, 608);
            this.panel1.TabIndex = 7;
            // 
            // lblCodeCli
            // 
            this.lblCodeCli.AutoSize = true;
            this.lblCodeCli.Location = new System.Drawing.Point(27, 149);
            this.lblCodeCli.Name = "lblCodeCli";
            this.lblCodeCli.Size = new System.Drawing.Size(51, 20);
            this.lblCodeCli.TabIndex = 15;
            this.lblCodeCli.Text = "Code :";
            // 
            // Supprimer
            // 
            this.Supprimer.Location = new System.Drawing.Point(456, 562);
            this.Supprimer.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Size = new System.Drawing.Size(103, 27);
            this.Supprimer.TabIndex = 7;
            this.Supprimer.Text = "Supprimer";
            this.Supprimer.UseVisualStyleBackColor = true;
            this.Supprimer.Click += new System.EventHandler(this.Supprimer_Click);
            // 
            // Modifier
            // 
            this.Modifier.Location = new System.Drawing.Point(262, 561);
            this.Modifier.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(101, 27);
            this.Modifier.TabIndex = 6;
            this.Modifier.Text = "Modifier";
            this.Modifier.UseVisualStyleBackColor = true;
            this.Modifier.Click += new System.EventHandler(this.Modifier_Click);
            // 
            // lblPrenomCli
            // 
            this.lblPrenomCli.AutoSize = true;
            this.lblPrenomCli.Location = new System.Drawing.Point(27, 331);
            this.lblPrenomCli.Name = "lblPrenomCli";
            this.lblPrenomCli.Size = new System.Drawing.Size(67, 20);
            this.lblPrenomCli.TabIndex = 16;
            this.lblPrenomCli.Text = "Prénom :";
            // 
            // textPrenomCli
            // 
            this.textPrenomCli.Location = new System.Drawing.Point(27, 262);
            this.textPrenomCli.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textPrenomCli.Name = "textPrenomCli";
            this.textPrenomCli.Size = new System.Drawing.Size(170, 27);
            this.textPrenomCli.TabIndex = 10;
            // 
            // textTelCli
            // 
            this.textTelCli.Location = new System.Drawing.Point(229, 172);
            this.textTelCli.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textTelCli.Name = "textTelCli";
            this.textTelCli.Size = new System.Drawing.Size(172, 27);
            this.textTelCli.TabIndex = 24;
            this.textTelCli.TextChanged += new System.EventHandler(this.textTelCli_TextChanged);
            // 
            // lblFaxCli
            // 
            this.lblFaxCli.AutoSize = true;
            this.lblFaxCli.Location = new System.Drawing.Point(229, 239);
            this.lblFaxCli.Name = "lblFaxCli";
            this.lblFaxCli.Size = new System.Drawing.Size(37, 20);
            this.lblFaxCli.TabIndex = 23;
            this.lblFaxCli.Text = "Fax :";
            // 
            // textRueFactuCli
            // 
            this.textRueFactuCli.Location = new System.Drawing.Point(229, 354);
            this.textRueFactuCli.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textRueFactuCli.Name = "textRueFactuCli";
            this.textRueFactuCli.Size = new System.Drawing.Size(172, 27);
            this.textRueFactuCli.TabIndex = 27;
            // 
            // textEmailCli
            // 
            this.textEmailCli.Location = new System.Drawing.Point(27, 449);
            this.textEmailCli.Name = "textEmailCli";
            this.textEmailCli.Size = new System.Drawing.Size(174, 27);
            this.textEmailCli.TabIndex = 20;
            // 
            // lblProduit
            // 
            this.lblProduit.AutoSize = true;
            this.lblProduit.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProduit.Location = new System.Drawing.Point(350, 64);
            this.lblProduit.Name = "lblProduit";
            this.lblProduit.Size = new System.Drawing.Size(502, 72);
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
            // textCPFactuCli
            // 
            this.textCPFactuCli.Location = new System.Drawing.Point(229, 449);
            this.textCPFactuCli.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textCPFactuCli.Name = "textCPFactuCli";
            this.textCPFactuCli.Size = new System.Drawing.Size(172, 27);
            this.textCPFactuCli.TabIndex = 28;
            // 
            // lblNomCli
            // 
            this.lblNomCli.AutoSize = true;
            this.lblNomCli.Location = new System.Drawing.Point(27, 239);
            this.lblNomCli.Name = "lblNomCli";
            this.lblNomCli.Size = new System.Drawing.Size(49, 20);
            this.lblNomCli.TabIndex = 14;
            this.lblNomCli.Text = "Nom :";
            // 
            // textFaxCli
            // 
            this.textFaxCli.Location = new System.Drawing.Point(229, 262);
            this.textFaxCli.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textFaxCli.Name = "textFaxCli";
            this.textFaxCli.Size = new System.Drawing.Size(172, 27);
            this.textFaxCli.TabIndex = 25;
            // 
            // lblErrorClient
            // 
            this.lblErrorClient.AutoSize = true;
            this.lblErrorClient.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblErrorClient.Location = new System.Drawing.Point(201, 509);
            this.lblErrorClient.Name = "lblErrorClient";
            this.lblErrorClient.Size = new System.Drawing.Size(242, 20);
            this.lblErrorClient.TabIndex = 37;
            this.lblErrorClient.Text = "Veuillez renseigner tous les champs";
            // 
            // lblVilleFactuCli
            // 
            this.lblVilleFactuCli.AutoSize = true;
            this.lblVilleFactuCli.Location = new System.Drawing.Point(423, 149);
            this.lblVilleFactuCli.Name = "lblVilleFactuCli";
            this.lblVilleFactuCli.Size = new System.Drawing.Size(121, 20);
            this.lblVilleFactuCli.TabIndex = 29;
            this.lblVilleFactuCli.Text = "Ville facturation :";
            // 
            // textVilleFactCli
            // 
            this.textVilleFactCli.Location = new System.Drawing.Point(423, 172);
            this.textVilleFactCli.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textVilleFactCli.Name = "textVilleFactCli";
            this.textVilleFactCli.Size = new System.Drawing.Size(172, 27);
            this.textVilleFactCli.TabIndex = 30;
            // 
            // lblRueLivraisonCli
            // 
            this.lblRueLivraisonCli.AutoSize = true;
            this.lblRueLivraisonCli.Location = new System.Drawing.Point(423, 239);
            this.lblRueLivraisonCli.Name = "lblRueLivraisonCli";
            this.lblRueLivraisonCli.Size = new System.Drawing.Size(100, 20);
            this.lblRueLivraisonCli.TabIndex = 31;
            this.lblRueLivraisonCli.Text = "Rue livraison :";
            // 
            // textRueLivraisonCli
            // 
            this.textRueLivraisonCli.Location = new System.Drawing.Point(423, 262);
            this.textRueLivraisonCli.Name = "textRueLivraisonCli";
            this.textRueLivraisonCli.Size = new System.Drawing.Size(172, 27);
            this.textRueLivraisonCli.TabIndex = 21;
            // 
            // lblCodePostalLivraiCli
            // 
            this.lblCodePostalLivraiCli.AutoSize = true;
            this.lblCodePostalLivraiCli.Location = new System.Drawing.Point(423, 331);
            this.lblCodePostalLivraiCli.Name = "lblCodePostalLivraiCli";
            this.lblCodePostalLivraiCli.Size = new System.Drawing.Size(155, 20);
            this.lblCodePostalLivraiCli.TabIndex = 32;
            this.lblCodePostalLivraiCli.Text = "Code postal livraison :";
            // 
            // textRueLivraiCli
            // 
            this.textRueLivraiCli.Location = new System.Drawing.Point(423, 354);
            this.textRueLivraiCli.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textRueLivraiCli.Name = "textRueLivraiCli";
            this.textRueLivraiCli.Size = new System.Drawing.Size(172, 27);
            this.textRueLivraiCli.TabIndex = 33;
            // 
            // lblVilleLivraiCli
            // 
            this.lblVilleLivraiCli.AutoSize = true;
            this.lblVilleLivraiCli.Location = new System.Drawing.Point(423, 426);
            this.lblVilleLivraiCli.Name = "lblVilleLivraiCli";
            this.lblVilleLivraiCli.Size = new System.Drawing.Size(104, 20);
            this.lblVilleLivraiCli.TabIndex = 34;
            this.lblVilleLivraiCli.Text = "Ville livraison :";
            // 
            // textVilleLivraiCli
            // 
            this.textVilleLivraiCli.Location = new System.Drawing.Point(423, 449);
            this.textVilleLivraiCli.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textVilleLivraiCli.Name = "textVilleLivraiCli";
            this.textVilleLivraiCli.Size = new System.Drawing.Size(172, 27);
            this.textVilleLivraiCli.TabIndex = 35;
            // 
            // FrmListeClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1232, 803);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.actualiserProduit);
            this.Controls.Add(this.dgvClient);
            this.Controls.Add(this.retSynt);
            this.Controls.Add(this.lblProduit);
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
        private TextBox textCodeCli;
        private TextBox textNomCli;
        private Label LabelDetails;
        private Button button1;
        private Label lblEmailCli;
        private Label lblTelCli;
        private Label lblRueFactCli;
        private Label lblCodePostalFactuCli;
        private Panel panel1;
        private Label lblErrorClient;
        private TextBox textCPFactuCli;
        private TextBox textRueFactuCli;
        private TextBox textFaxCli;
        private TextBox textTelCli;
        private Label lblFaxCli;
        private TextBox textEmailCli;
        private Label lblPrenomCli;
        private Label lblCodeCli;
        private Label lblNomCli;
        private TextBox textPrenomCli;
        private Button Supprimer;
        private Button Modifier;
        private Label lblProduit;
        private DataGridViewTextBoxColumn Nom;
        private TextBox textVilleLivraiCli;
        private Label lblVilleLivraiCli;
        private TextBox textRueLivraiCli;
        private Label lblCodePostalLivraiCli;
        private TextBox textRueLivraisonCli;
        private Label lblRueLivraisonCli;
        private TextBox textVilleFactCli;
        private Label lblVilleFactuCli;
    }
}