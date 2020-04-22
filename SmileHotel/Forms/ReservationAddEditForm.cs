using System;
using System.Linq;
using System.Windows.Forms;
using SmileHotel.Helpers;
using SmileHotel.Models;
using SmileHotel.Repositories;

namespace SmileHotel.Forms
{
    public partial class ReservationAddEditForm : Form
    {
        public ReservationAddEditForm(Reservation reservation)
        {
            this.InitializeComponent();
            ClientRepository clientRepository = new ClientRepository();
            RoomRepository roomRepository = new RoomRepository();

            var clients = clientRepository.GetAllClients();
            this.clientBindingSource.DataSource = clients;

            var rooms = roomRepository.GetAllRooms();
            this.roomBindingSource.DataSource = rooms;

            if (reservation == null)
            {
                reservation = new Reservation();
            }
            else
            {
                this.clientComboBox.SelectedItem = clients?.FirstOrDefault(c => c.Id == reservation.Client.Id);
                this.roomComboBox.SelectedItem = rooms?.FirstOrDefault(r => r.Id == reservation.Room.Id);
                this.durationTextBox.Text = reservation.Duration.ToString();
                this.fromDateTimePicker.Value = reservation.StartDate;
            }
            
            this.Reservation = reservation;
        }

        public Reservation Reservation { get; set; }

        private void AddEditButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.Reservation.StartDate = this.fromDateTimePicker.Value;
                int.TryParse(this.durationTextBox.Text, out var duration);
                this.Reservation.Duration = duration;
                this.Reservation.Client = (Client) this.clientComboBox.SelectedItem;
                this.Reservation.Room = (Room) this.roomComboBox.SelectedItem;

                if (this.Reservation.User == null)
                {
                    this.Reservation.User = SessionHelper.User;
                }

                if (!this.Reservation.IsValid())
                {
                    throw new Exception();
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch
            {
                MessageBox.Show("Невалидни данни!");
            }
        }
    }
}