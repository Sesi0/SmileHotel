namespace SmileHotel.Forms
{
    partial class MenuForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reservationsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customersMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.reservationsMenuItem,
            this.roomsMenuItem,
            this.customersMenuItem,
            this.reportsMenuItem,
            this.usersMenuItem,
            this.exitMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(539, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(14, 24);
            // 
            // reservationsMenuItem
            // 
            this.reservationsMenuItem.Name = "reservationsMenuItem";
            this.reservationsMenuItem.Size = new System.Drawing.Size(106, 24);
            this.reservationsMenuItem.Text = "Резервации";
            this.reservationsMenuItem.Click += new System.EventHandler(this.ReservationsMenuItem_Click);
            // 
            // roomsMenuItem
            // 
            this.roomsMenuItem.Name = "roomsMenuItem";
            this.roomsMenuItem.Size = new System.Drawing.Size(55, 24);
            this.roomsMenuItem.Text = "Стаи";
            this.roomsMenuItem.Click += new System.EventHandler(this.RoomsMenuItem_Click);
            // 
            // customersMenuItem
            // 
            this.customersMenuItem.Name = "customersMenuItem";
            this.customersMenuItem.Size = new System.Drawing.Size(81, 24);
            this.customersMenuItem.Text = "Клиенти";
            this.customersMenuItem.Click += new System.EventHandler(this.ClientsMenuItem_Click);
            // 
            // reportsMenuItem
            // 
            this.reportsMenuItem.Name = "reportsMenuItem";
            this.reportsMenuItem.Size = new System.Drawing.Size(82, 24);
            this.reportsMenuItem.Text = "Справки";
            this.reportsMenuItem.Click += new System.EventHandler(this.ReportsMenuItem_Click);
            // 
            // usersMenuItem
            // 
            this.usersMenuItem.Name = "usersMenuItem";
            this.usersMenuItem.Size = new System.Drawing.Size(115, 24);
            this.usersMenuItem.Text = "Потребители";
            this.usersMenuItem.Click += new System.EventHandler(this.UsersMenuItem_Click);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(65, 24);
            this.exitMenuItem.Text = "Изход";
            this.exitMenuItem.Click += new System.EventHandler(this.ExitMenuItem_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 32);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuForm";
            this.Text = "SmileHotel";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reservationsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customersMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsMenuItem;
    }
}

