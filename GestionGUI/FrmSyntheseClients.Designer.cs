namespace GestionGUI
{
    partial class FrmSyntheseClients
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
            this.syntheseProduit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // syntheseProduit
            // 
            this.syntheseProduit.Location = new System.Drawing.Point(405, 224);
            this.syntheseProduit.Name = "syntheseProduit";
            this.syntheseProduit.Size = new System.Drawing.Size(94, 29);
            this.syntheseProduit.TabIndex = 0;
            this.syntheseProduit.Text = "Produit";
            this.syntheseProduit.UseVisualStyleBackColor = true;
            this.syntheseProduit.Click += new System.EventHandler(this.syntheseProduit_Click);
            // 
            // SyntheseClientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.syntheseProduit);
            this.Name = "SyntheseClientsForm";
            this.Text = "SyntheseClientsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Button syntheseProduit;
    }
}