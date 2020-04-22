using System;
using System.Windows.Forms;

namespace SmileHotel.Forms
{
    public partial class MenuForm : Form
    {
        private RoomsForm roomsForm;
        private ReservationsForm reservationsForm;
        private UsersForm userForm;
        private ClientsForm clientForm;

        public MenuForm()
        {
            this.InitializeComponent();
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RoomsMenuItem_Click(object sender, EventArgs e)
        {
            this.roomsForm = new RoomsForm();
            this.roomsForm.WindowState = FormWindowState.Normal;
            this.roomsForm.Show();
        }

        private void UsersMenuItem_Click(object sender, EventArgs e)
        {
            this.userForm = new UsersForm();
            this.userForm.WindowState = FormWindowState.Normal;
            this.userForm.Show();
        }

        private void ClientsMenuItem_Click(object sender, EventArgs e)
        {
            this.clientForm = new ClientsForm();
            this.clientForm.WindowState = FormWindowState.Normal;
            this.clientForm.Show();
        }

        private void ReservationsMenuItem_Click(object sender, EventArgs e)
        {
            this.reservationsForm = new ReservationsForm();
            this.reservationsForm.WindowState = FormWindowState.Normal;
            this.reservationsForm.Show();
        }
    }
}
