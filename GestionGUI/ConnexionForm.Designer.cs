﻿namespace Connexion
{
    partial class ConnexionForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblConnexion = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtBoxUsername = new System.Windows.Forms.TextBox();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.btnConnexion = new System.Windows.Forms.Button();
            this.temp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblConnexion
            // 
            this.lblConnexion.AutoSize = true;
            this.lblConnexion.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblConnexion.Location = new System.Drawing.Point(292, 82);
            this.lblConnexion.Name = "lblConnexion";
            this.lblConnexion.Size = new System.Drawing.Size(303, 72);
            this.lblConnexion.TabIndex = 0;
            this.lblConnexion.Text = "Connexion";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUsername.Location = new System.Drawing.Point(163, 277);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(106, 25);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username :";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPassword.Location = new System.Drawing.Point(163, 415);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(100, 25);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password :";
            // 
            // txtBoxUsername
            // 
            this.txtBoxUsername.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxUsername.Location = new System.Drawing.Point(424, 277);
            this.txtBoxUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxUsername.Name = "txtBoxUsername";
            this.txtBoxUsername.Size = new System.Drawing.Size(171, 23);
            this.txtBoxUsername.TabIndex = 3;
            this.txtBoxUsername.TextChanged += new System.EventHandler(this.txtBoxUsername_TextChanged);
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxPassword.Location = new System.Drawing.Point(424, 415);
            this.txtBoxPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.Size = new System.Drawing.Size(171, 23);
            this.txtBoxPassword.TabIndex = 4;
            // 
            // btnConnexion
            // 
            this.btnConnexion.Location = new System.Drawing.Point(716, 520);
            this.btnConnexion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(155, 47);
            this.btnConnexion.TabIndex = 6;
            this.btnConnexion.Text = "Connexion";
            this.btnConnexion.UseVisualStyleBackColor = true;
            this.btnConnexion.Click += new System.EventHandler(this.btnConnexion_Click);
            // 
            // temp
            // 
            this.temp.Location = new System.Drawing.Point(779, 117);
            this.temp.Name = "temp";
            this.temp.Size = new System.Drawing.Size(94, 29);
            this.temp.TabIndex = 7;
            this.temp.Text = "temp";
            this.temp.UseVisualStyleBackColor = true;
            this.temp.Click += new System.EventHandler(this.temp_Click);
            // 
            // ConnexionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.temp);
            this.Controls.Add(this.btnConnexion);
            this.Controls.Add(this.txtBoxPassword);
            this.Controls.Add(this.txtBoxUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblConnexion);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ConnexionForm";
            this.Text = "Connexion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblConnexion;
        private Label lblUsername;
        private Label lblPassword;
        private TextBox txtBoxUsername;
        private TextBox txtBoxPassword;
        private Button btnConnexion;
        private Button temp;
    }
}