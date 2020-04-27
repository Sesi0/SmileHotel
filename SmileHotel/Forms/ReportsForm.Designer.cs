namespace SmileHotel.Forms
{
    partial class ReportsForm
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
            this.reportsComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.extendedDataGridView1 = new SmileHotel.Compoentns.ExtendedDataGridView();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.extendedDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportsComboBox
            // 
            this.reportsComboBox.FormattingEnabled = true;
            this.reportsComboBox.Items.AddRange(new object[] {
            "Активни резервации",
            "Натовареност на хотела за месец"});
            this.reportsComboBox.Location = new System.Drawing.Point(13, 28);
            this.reportsComboBox.Name = "reportsComboBox";
            this.reportsComboBox.Size = new System.Drawing.Size(775, 24);
            this.reportsComboBox.TabIndex = 0;
            this.reportsComboBox.SelectedIndexChanged += new System.EventHandler(this.ReportsComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Избери справка";
            // 
            // extendedDataGridView1
            // 
            this.extendedDataGridView1.AllowUserToAddRows = false;
            this.extendedDataGridView1.AllowUserToDeleteRows = false;
            this.extendedDataGridView1.AutoGenerateColumns = false;
            this.extendedDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.extendedDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.startDateDataGridViewTextBoxColumn,
            this.durationDataGridViewTextBoxColumn});
            this.extendedDataGridView1.DataSource = this.reservationBindingSource;
            this.extendedDataGridView1.Location = new System.Drawing.Point(13, 59);
            this.extendedDataGridView1.Name = "extendedDataGridView1";
            this.extendedDataGridView1.ReadOnly = true;
            this.extendedDataGridView1.RowHeadersVisible = false;
            this.extendedDataGridView1.RowHeadersWidth = 51;
            this.extendedDataGridView1.RowTemplate.Height = 24;
            this.extendedDataGridView1.Size = new System.Drawing.Size(775, 379);
            this.extendedDataGridView1.TabIndex = 2;
            this.extendedDataGridView1.Visible = false;
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "От дата";
            this.startDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            this.startDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // durationDataGridViewTextBoxColumn
            // 
            this.durationDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.durationDataGridViewTextBoxColumn.DataPropertyName = "Duration";
            this.durationDataGridViewTextBoxColumn.HeaderText = "Престой (дни)";
            this.durationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.durationDataGridViewTextBoxColumn.Name = "durationDataGridViewTextBoxColumn";
            this.durationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reservationBindingSource
            // 
            this.reservationBindingSource.DataSource = typeof(SmileHotel.Models.Reservation);
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.extendedDataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportsComboBox);
            this.Name = "ReportsForm";
            this.Text = "Справки";
            ((System.ComponentModel.ISupportInitialize)(this.extendedDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox reportsComboBox;
        private System.Windows.Forms.Label label1;
        private Compoentns.ExtendedDataGridView extendedDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource reservationBindingSource;
    }
}