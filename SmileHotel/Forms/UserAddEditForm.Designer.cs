﻿namespace SmileHotel.Forms
{
    partial class UserAddEditForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.addEditButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.passwordMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Име";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(16, 34);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(129, 22);
            this.nameTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Телефонен номер";
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Location = new System.Drawing.Point(16, 84);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(129, 22);
            this.phoneNumberTextBox.TabIndex = 3;
            // 
            // addEditButton
            // 
            this.addEditButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.addEditButton.FlatAppearance.BorderSize = 0;
            this.addEditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addEditButton.ForeColor = System.Drawing.Color.White;
            this.addEditButton.Location = new System.Drawing.Point(12, 172);
            this.addEditButton.Name = "addEditButton";
            this.addEditButton.Size = new System.Drawing.Size(129, 40);
            this.addEditButton.TabIndex = 7;
            this.addEditButton.Text = "Запази";
            this.addEditButton.UseVisualStyleBackColor = false;
            this.addEditButton.Click += new System.EventHandler(this.AddEditButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Парола";
            // 
            // passwordMaskedTextBox
            // 
            this.passwordMaskedTextBox.Location = new System.Drawing.Point(19, 134);
            this.passwordMaskedTextBox.Name = "passwordMaskedTextBox";
            this.passwordMaskedTextBox.PasswordChar = '*';
            this.passwordMaskedTextBox.Size = new System.Drawing.Size(126, 22);
            this.passwordMaskedTextBox.TabIndex = 9;
            this.passwordMaskedTextBox.UseSystemPasswordChar = true;
            // 
            // UserAddEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(155, 234);
            this.Controls.Add(this.passwordMaskedTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addEditButton);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "UserAddEditForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.Button addEditButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox passwordMaskedTextBox;
    }
}