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
            this.reservationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomCombobox = new System.Windows.Forms.ComboBox();
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.stayByRoom = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.extendedDataGridView1 = new SmileHotel.Compoentns.ExtendedDataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.extendedDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportsComboBox
            // 
            this.reportsComboBox.FormattingEnabled = true;
            this.reportsComboBox.Items.AddRange(new object[] {
            "Активни резервации",
            "Натовареност на хотела за стая за този месец",
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
            // reservationBindingSource
            // 
            this.reservationBindingSource.DataSource = typeof(SmileHotel.Models.Reservation);
            // 
            // roomCombobox
            // 
            this.roomCombobox.DataSource = this.roomBindingSource;
            this.roomCombobox.DisplayMember = "Number";
            this.roomCombobox.FormattingEnabled = true;
            this.roomCombobox.Location = new System.Drawing.Point(13, 59);
            this.roomCombobox.Name = "roomCombobox";
            this.roomCombobox.Size = new System.Drawing.Size(775, 24);
            this.roomCombobox.TabIndex = 3;
            this.roomCombobox.Visible = false;
            this.roomCombobox.SelectedIndexChanged += new System.EventHandler(this.roomCombobox_SelectedIndexChanged);
            // 
            // roomBindingSource
            // 
            this.roomBindingSource.DataSource = typeof(SmileHotel.Models.Room);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Натовареност в дни:";
            this.label2.Visible = false;
            // 
            // stayByRoom
            // 
            this.stayByRoom.AutoSize = true;
            this.stayByRoom.Location = new System.Drawing.Point(165, 119);
            this.stayByRoom.Name = "stayByRoom";
            this.stayByRoom.Size = new System.Drawing.Size(0, 17);
            this.stayByRoom.TabIndex = 5;
            this.stayByRoom.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(16, 90);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.Visible = false;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // extendedDataGridView1
            // 
            this.extendedDataGridView1.AllowUserToAddRows = false;
            this.extendedDataGridView1.AllowUserToDeleteRows = false;
            this.extendedDataGridView1.AutoGenerateColumns = false;
            this.extendedDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.extendedDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn4,
            this.startDateDataGridViewTextBoxColumn,
            this.durationDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn6});
            this.extendedDataGridView1.DataSource = this.reservationBindingSource;
            this.extendedDataGridView1.Location = new System.Drawing.Point(13, 90);
            this.extendedDataGridView1.MultiSelect = false;
            this.extendedDataGridView1.Name = "extendedDataGridView1";
            this.extendedDataGridView1.ReadOnly = true;
            this.extendedDataGridView1.RowHeadersVisible = false;
            this.extendedDataGridView1.RowHeadersWidth = 51;
            this.extendedDataGridView1.RowTemplate.Height = 24;
            this.extendedDataGridView1.Size = new System.Drawing.Size(775, 348);
            this.extendedDataGridView1.TabIndex = 7;
            this.extendedDataGridView1.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Room.Number";
            this.dataGridViewTextBoxColumn5.HeaderText = "Стая";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Client.Name";
            this.dataGridViewTextBoxColumn4.HeaderText = "Клиент";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
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
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "User.Name";
            this.dataGridViewTextBoxColumn6.HeaderText = "Създадено от";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.extendedDataGridView1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.stayByRoom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.roomCombobox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportsComboBox);
            this.Name = "ReportsForm";
            this.Text = "Справки";
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.extendedDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox reportsComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource reservationBindingSource;
        private System.Windows.Forms.ComboBox roomCombobox;
        private System.Windows.Forms.BindingSource roomBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label stayByRoom;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private Compoentns.ExtendedDataGridView extendedDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}