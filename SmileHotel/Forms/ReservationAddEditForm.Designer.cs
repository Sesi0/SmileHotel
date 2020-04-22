namespace SmileHotel.Forms
{
    partial class ReservationAddEditForm
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
            this.components = new System.ComponentModel.Container();
            this.label3 = new System.Windows.Forms.Label();
            this.addEditButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.clientComboBox = new System.Windows.Forms.ComboBox();
            this.roomComboBox = new System.Windows.Forms.ComboBox();
            this.fromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.durationTextBox = new System.Windows.Forms.TextBox();
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "От дата";
            // 
            // addEditButton
            // 
            this.addEditButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.addEditButton.FlatAppearance.BorderSize = 0;
            this.addEditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addEditButton.ForeColor = System.Drawing.Color.White;
            this.addEditButton.Location = new System.Drawing.Point(18, 225);
            this.addEditButton.Name = "addEditButton";
            this.addEditButton.Size = new System.Drawing.Size(200, 40);
            this.addEditButton.TabIndex = 19;
            this.addEditButton.Text = "Запази";
            this.addEditButton.UseVisualStyleBackColor = false;
            this.addEditButton.Click += new System.EventHandler(this.AddEditButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Стая";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Клиент";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // clientComboBox
            // 
            this.clientComboBox.DataSource = this.clientBindingSource;
            this.clientComboBox.DisplayMember = "Name";
            this.clientComboBox.FormattingEnabled = true;
            this.clientComboBox.Location = new System.Drawing.Point(18, 30);
            this.clientComboBox.Name = "clientComboBox";
            this.clientComboBox.Size = new System.Drawing.Size(200, 24);
            this.clientComboBox.TabIndex = 22;
            // 
            // roomComboBox
            // 
            this.roomComboBox.DataSource = this.roomBindingSource;
            this.roomComboBox.DisplayMember = "Number";
            this.roomComboBox.FormattingEnabled = true;
            this.roomComboBox.Location = new System.Drawing.Point(18, 79);
            this.roomComboBox.Name = "roomComboBox";
            this.roomComboBox.Size = new System.Drawing.Size(200, 24);
            this.roomComboBox.TabIndex = 23;
            // 
            // fromDateTimePicker
            // 
            this.fromDateTimePicker.Location = new System.Drawing.Point(18, 135);
            this.fromDateTimePicker.Name = "fromDateTimePicker";
            this.fromDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.fromDateTimePicker.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Дни";
            // 
            // durationTextBox
            // 
            this.durationTextBox.Location = new System.Drawing.Point(21, 185);
            this.durationTextBox.Name = "durationTextBox";
            this.durationTextBox.Size = new System.Drawing.Size(197, 22);
            this.durationTextBox.TabIndex = 26;
            // 
            // roomBindingSource
            // 
            this.roomBindingSource.DataSource = typeof(SmileHotel.Models.Room);
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataSource = typeof(SmileHotel.Models.Client);
            // 
            // ReservationAddEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 284);
            this.Controls.Add(this.durationTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fromDateTimePicker);
            this.Controls.Add(this.roomComboBox);
            this.Controls.Add(this.clientComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addEditButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ReservationAddEditForm";
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addEditButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox clientComboBox;
        private System.Windows.Forms.ComboBox roomComboBox;
        private System.Windows.Forms.DateTimePicker fromDateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox durationTextBox;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private System.Windows.Forms.BindingSource roomBindingSource;
    }
}