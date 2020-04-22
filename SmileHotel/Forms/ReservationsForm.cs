using System.Windows.Forms;
using SmileHotel.Models;
using SmileHotel.Repositories;

namespace SmileHotel.Forms
{
    public partial class ReservationsForm : Form
    {
        private readonly ReservationRepository reservationRepository;

        public ReservationsForm()
        {
            this.InitializeComponent();
            this.reservationRepository = new ReservationRepository();
        }

        private void ReservationsForm_Load(object sender, System.EventArgs e)
        {
            this.reservationBindingSource.DataSource = this.reservationRepository.GetAllReservations();
        }

        private void DeleteReservationButton_Click(object sender, System.EventArgs e)
        {
            var selectedReservation = (Reservation)this.reservationBindingSource.Current;

            if (selectedReservation == null)
            {
                MessageBox.Show("Не е избрана резервация за изтриване!");
                return;
            }

            this.reservationRepository.DeleteReservation(selectedReservation.Id);
            this.reservationBindingSource.RemoveCurrent();
        }

        private void AddReservationButton_Click(object sender, System.EventArgs e)
        {
            var editForm = new ReservationAddEditForm(null);
            editForm.ShowDialog();

            if (editForm.DialogResult == DialogResult.OK)
            {
                var reservation = editForm.Reservation;

                if (reservation != null)
                {
                    reservation = this.reservationRepository.AddOrUpdateReservation(reservation);
                    this.reservationBindingSource.Add(reservation);
                }
            }
        }

        private void EditReservationButton_Click(object sender, System.EventArgs e)
        {
            var selectedReservation = (Reservation)this.reservationBindingSource.Current;

            if (selectedReservation == null)
            {
                MessageBox.Show("Не е избрана резервация за редакция!");
                return;
            }

            var editForm = new ReservationAddEditForm(selectedReservation);
            editForm.ShowDialog();

            if (editForm.DialogResult == DialogResult.OK)
            {
                var reservation = editForm.Reservation;

                if (reservation != null)
                {
                    reservation = this.reservationRepository.AddOrUpdateReservation(reservation);
                    this.reservationBindingSource[this.reservationBindingSource.Position] = reservation;
                }
            }
        }
    }
}
