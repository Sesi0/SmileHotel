using System;
using System.Windows.Forms;
using SmileHotel.Repositories;

namespace SmileHotel.Forms
{
    public partial class ReportsForm : Form
    {
        private ReservationRepository reservationRepository;

        public ReportsForm()
        {
            this.InitializeComponent();
            this.reservationRepository = new ReservationRepository();
        }

        private void ReportsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.extendedDataGridView1.Visible = false;
            
            switch (this.reportsComboBox.SelectedIndex)
            {
                case 0:
                    this.extendedDataGridView1.Visible = true;
                    this.reservationBindingSource.DataSource = this.reservationRepository.GetAllReservations();
                    break;
                case 1:
                    break;
                default:
                    break;
            }
        }
    }
}
