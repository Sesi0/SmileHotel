using System;
using System.Windows.Forms;
using SmileHotel.Models;

namespace SmileHotel.Forms
{
    public partial class RoomAddEditForm : Form
    {
        public RoomAddEditForm(Room room)
        {
            this.InitializeComponent();

            if (room == null)
            {
                room = new Room();
            }
            else
            {
                this.numberTextBox.Text = room.Number.ToString();
                this.capacityTextBox.Text = room.Capacity.ToString();
                this.pricePerNightTextBox.Text = room.PricePerNight.ToString("F");
            }

            this.Room = room;
        }

        public Room Room { get; set; }

        private void AddEditButton_Click(object sender, EventArgs e)
        {
            try
            {
                int.TryParse(this.capacityTextBox.Text, out var number);
                int.TryParse(this.capacityTextBox.Text, out var capacity);
                float.TryParse(this.pricePerNightTextBox.Text, out var pricePerNight);

                this.Room.Number = number;
                this.Room.Capacity = capacity;
                this.Room.PricePerNight = pricePerNight;

                if (!this.Room.IsValid())
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
