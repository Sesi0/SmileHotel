using System.Windows.Forms;
using SmileHotel.Models;
using SmileHotel.Repositories;

namespace SmileHotel.Forms
{
    public partial class UsersForm : Form
    {
        private readonly UserRepository userRepository;

        public UsersForm()
        {
            this.InitializeComponent();
            this.userRepository = new UserRepository();
        }

        private void UsersForm_Load(object sender, System.EventArgs e)
        {
            this.userBindingSource.DataSource = this.userRepository.GetAllUsers();
        }

        private void DeleteUserButton_Click(object sender, System.EventArgs e)
        {
            var selectedUser = (User)this.userBindingSource.Current;

            if (selectedUser == null)
            {
                MessageBox.Show("Не е избран потребител за изтриване!");
                return;
            }

            this.userRepository.DeleteUser(selectedUser.Id);
            this.userBindingSource.RemoveCurrent();
        }

        private void AddUserButton_Click(object sender, System.EventArgs e)
        {
            var editForm = new UserAddEditForm(null);
            editForm.ShowDialog();

            if (editForm.DialogResult == DialogResult.OK)
            {
                var user = editForm.User;

                if (user != null)
                {
                    user = this.userRepository.AddOrUpdateUser(user);
                    this.userBindingSource.Add(user);
                }
            }
        }

        private void EditUserButton_Click(object sender, System.EventArgs e)
        {
            var selectedUser = (User)this.userBindingSource.Current;

            if (selectedUser == null)
            {
                MessageBox.Show("Не е избран потребител за редакция!");
                return;
            }

            var editForm = new UserAddEditForm(selectedUser);
            editForm.ShowDialog();

            if (editForm.DialogResult == DialogResult.OK)
            {
                var user = editForm.User;

                if (user != null)
                {
                    user = this.userRepository.AddOrUpdateUser(user);
                    this.userBindingSource[this.userBindingSource.Position] = user;
                }
            }
        }
    }
}
