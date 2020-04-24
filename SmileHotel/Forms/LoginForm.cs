using System;
using System.Windows.Forms;
using SmileHotel.Helpers;
using SmileHotel.Repositories;

namespace SmileHotel.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            this.InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                string username = this.usenameTextBox.Text;
                string password = CryptoHelper.GetMd5Hash(this.passwordMaskedTextBox.Text);

                var userRepository = new UserRepository();
                var user = userRepository.GetUserWithPassword(username, password);

                if (user != null)
                {
                    SessionHelper.User = user;
                    var form = new MenuForm();
                    form.FormClosed += (o, args) => this.Show();
                    form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Грешен потребител и/или парола!");
                }
            }
            catch
            {
                MessageBox.Show("Невалидни данни!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}
