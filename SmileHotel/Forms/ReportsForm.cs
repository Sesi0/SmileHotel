using System;
using System.Windows.Forms;
using SmileHotel.Models;
using SmileHotel.Repositories;

namespace SmileHotel.Forms
{
    public partial class ReportsForm : Form
    {
        private readonly ReservationRepository reservationRepository;
        private readonly RoomRepository roomRepository;

        public ReportsForm()
        {
            this.InitializeComponent();
            this.reservationRepository = new ReservationRepository();
            this.roomRepository = new RoomRepository();
        }

        private void ReportsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.extendedDataGridView1.Visible = false;
            this.stayByRoom.Visible = false;
            this.label2.Visible = false;
            this.stayByRoom.Text = string.Empty;
            this.roomCombobox.Visible = false;
            this.roomBindingSource.Clear();
            this.dateTimePicker1.Visible = false;

            switch (this.reportsComboBox.SelectedIndex)
            {
                case 0:
                    this.reservationBindingSource.DataSource = this.reservationRepository.GetActiveReservations();
                    this.extendedDataGridView1.Visible = true;
                    break;
                case 1:
                    this.roomBindingSource.DataSource = this.roomRepository.GetAllRooms();
                    this.roomCombobox.Visible = true;
                    break;
                case 2:
                    this.dateTimePicker1.Visible = true;
                    this.dateTimePicker1.Value = DateTime.Now;
                    break;
                default:
                    break;
            }
        }

        private void roomCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.roomBindingSource.Current == null)
            {
                return;
            }

            this.stayByRoom.Text = this.reservationRepository.GetProductivityForAroom(((Room)this.roomBindingSource.Current).Id, DateTime.Now).ToString();
            this.label2.Visible = true;
            this.stayByRoom.Visible = true;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            this.stayByRoom.Text = this.reservationRepository.GetProductivityForHotel(this.dateTimePicker1.Value).ToString();
            this.label2.Visible = true;
            this.stayByRoom.Visible = true;
        }
    }
}
