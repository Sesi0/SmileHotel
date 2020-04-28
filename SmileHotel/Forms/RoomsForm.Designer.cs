namespace SmileHotel.Forms
{
    partial class RoomsForm
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
            this.roomDataGridView = new System.Windows.Forms.DataGridView();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pricePerNightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addRoomButton = new System.Windows.Forms.Button();
            this.editRoomButton = new System.Windows.Forms.Button();
            this.deleteRoomButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.roomDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // roomDataGridView
            // 
            this.roomDataGridView.AllowUserToAddRows = false;
            this.roomDataGridView.AllowUserToDeleteRows = false;
            this.roomDataGridView.AutoGenerateColumns = false;
            this.roomDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roomDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numberDataGridViewTextBoxColumn,
            this.capacityDataGridViewTextBoxColumn,
            this.pricePerNightDataGridViewTextBoxColumn});
            this.roomDataGridView.DataSource = this.roomBindingSource;
            this.roomDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.roomDataGridView.Location = new System.Drawing.Point(12, 62);
            this.roomDataGridView.MultiSelect = false;
            this.roomDataGridView.Name = "roomDataGridView";
            this.roomDataGridView.ReadOnly = true;
            this.roomDataGridView.RowHeadersVisible = false;
            this.roomDataGridView.RowHeadersWidth = 51;
            this.roomDataGridView.RowTemplate.Height = 24;
            this.roomDataGridView.ShowEditingIcon = false;
            this.roomDataGridView.Size = new System.Drawing.Size(776, 259);
            this.roomDataGridView.TabIndex = 0;
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "Номер";
            this.numberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            this.numberDataGridViewTextBoxColumn.ReadOnly = true;
            this.numberDataGridViewTextBoxColumn.Width = 125;
            // 
            // capacityDataGridViewTextBoxColumn
            // 
            this.capacityDataGridViewTextBoxColumn.DataPropertyName = "Capacity";
            this.capacityDataGridViewTextBoxColumn.HeaderText = "Капацитет";
            this.capacityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.capacityDataGridViewTextBoxColumn.Name = "capacityDataGridViewTextBoxColumn";
            this.capacityDataGridViewTextBoxColumn.ReadOnly = true;
            this.capacityDataGridViewTextBoxColumn.Width = 125;
            // 
            // pricePerNightDataGridViewTextBoxColumn
            // 
            this.pricePerNightDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pricePerNightDataGridViewTextBoxColumn.DataPropertyName = "PricePerNight";
            this.pricePerNightDataGridViewTextBoxColumn.HeaderText = "Цена на нощувка";
            this.pricePerNightDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pricePerNightDataGridViewTextBoxColumn.Name = "pricePerNightDataGridViewTextBoxColumn";
            this.pricePerNightDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roomBindingSource
            // 
            this.roomBindingSource.DataSource = typeof(SmileHotel.Models.Room);
            // 
            // addRoomButton
            // 
            this.addRoomButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.addRoomButton.FlatAppearance.BorderSize = 0;
            this.addRoomButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addRoomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addRoomButton.ForeColor = System.Drawing.Color.White;
            this.addRoomButton.Location = new System.Drawing.Point(12, 12);
            this.addRoomButton.Name = "addRoomButton";
            this.addRoomButton.Size = new System.Drawing.Size(98, 44);
            this.addRoomButton.TabIndex = 2;
            this.addRoomButton.Text = "Добавяне";
            this.addRoomButton.UseVisualStyleBackColor = false;
            this.addRoomButton.Click += new System.EventHandler(this.AddRoomButton_Click);
            // 
            // editRoomButton
            // 
            this.editRoomButton.BackColor = System.Drawing.Color.Coral;
            this.editRoomButton.FlatAppearance.BorderSize = 0;
            this.editRoomButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.editRoomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editRoomButton.ForeColor = System.Drawing.Color.White;
            this.editRoomButton.Location = new System.Drawing.Point(116, 12);
            this.editRoomButton.Name = "editRoomButton";
            this.editRoomButton.Size = new System.Drawing.Size(108, 44);
            this.editRoomButton.TabIndex = 3;
            this.editRoomButton.Text = "Редакция";
            this.editRoomButton.UseVisualStyleBackColor = false;
            this.editRoomButton.Click += new System.EventHandler(this.EditRoomButton_Click);
            // 
            // deleteRoomButton
            // 
            this.deleteRoomButton.BackColor = System.Drawing.Color.Maroon;
            this.deleteRoomButton.FlatAppearance.BorderSize = 0;
            this.deleteRoomButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteRoomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteRoomButton.ForeColor = System.Drawing.Color.White;
            this.deleteRoomButton.Location = new System.Drawing.Point(677, 12);
            this.deleteRoomButton.Name = "deleteRoomButton";
            this.deleteRoomButton.Size = new System.Drawing.Size(111, 44);
            this.deleteRoomButton.TabIndex = 4;
            this.deleteRoomButton.Text = "Изтриване";
            this.deleteRoomButton.UseVisualStyleBackColor = false;
            this.deleteRoomButton.Click += new System.EventHandler(this.DeleteRoomButton_Click);
            // 
            // RoomsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 333);
            this.Controls.Add(this.deleteRoomButton);
            this.Controls.Add(this.editRoomButton);
            this.Controls.Add(this.addRoomButton);
            this.Controls.Add(this.roomDataGridView);
            this.Name = "RoomsForm";
            this.Text = "Стаи";
            this.Load += new System.EventHandler(this.RoomsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roomDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource roomBindingSource;
        private System.Windows.Forms.DataGridView roomDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pricePerNightDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button addRoomButton;
        private System.Windows.Forms.Button editRoomButton;
        private System.Windows.Forms.Button deleteRoomButton;
    }
}