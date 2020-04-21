using System.Windows.Forms;
using SmileHotel.Models;
using SmileHotel.Repositories;

namespace SmileHotel.Forms
{
    public partial class RoomsForm : Form
    {
        private readonly RoomRepository roomRepository;

        public RoomsForm()
        {
            this.InitializeComponent();
            this.roomRepository = new RoomRepository();
        }

        private void RoomsForm_Load(object sender, System.EventArgs e)
        {
            this.roomBindingSource.DataSource = this.roomRepository.GetAllRooms();
        }

        private void DeleteRoomButton_Click(object sender, System.EventArgs e)
        {
            var selectedRoom = (Room) this.roomBindingSource.Current;

            if (selectedRoom == null)
            {
                MessageBox.Show("Не е избрана стая за изтриване!");
                return;
            }

            this.roomRepository.DeleteRoom(selectedRoom.Id);
            this.roomBindingSource.RemoveCurrent();
        }

        private void AddRoomButton_Click(object sender, System.EventArgs e)
        {
            var editForm = new RoomAddEditForm(null);
            editForm.ShowDialog();
            
            if (editForm.DialogResult == DialogResult.OK)
            {
                var room = editForm.Room;

                if (room != null)
                {
                    room = this.roomRepository.AddOrUpdateRoom(room);
                    this.roomBindingSource.Add(room);
                }
            }
        }

        private void EditRoomButton_Click(object sender, System.EventArgs e)
        {
            var selectedRoom = (Room)this.roomBindingSource.Current;

            if (selectedRoom == null)
            {
                MessageBox.Show("Не е избрана стая за редакция!");
                return;
            }

            var editForm = new RoomAddEditForm(selectedRoom);
            editForm.ShowDialog();

            if (editForm.DialogResult == DialogResult.OK)
            {
                var room = editForm.Room;

                if (room != null)
                {
                    room = this.roomRepository.AddOrUpdateRoom(room);
                    this.roomBindingSource[this.roomBindingSource.Position] = room;
                }
            }
        }
    }
}
