using System;
using System.Windows.Forms;
using SmileHotel.Helpers;
using SmileHotel.Models;

namespace SmileHotel.Forms
{
    public partial class UserAddEditForm : Form
    {
        public UserAddEditForm(User user)
        {
            this.InitializeComponent();

            if (user == null)
            {
                user = new User();
            }
            else
            {
                this.nameTextBox.Text = user.Name;
                this.phoneNumberTextBox.Text = user.PhoneNumber;
                this.passwordMaskedTextBox.Text = user.Password;
            }

            this.User = user;
        }

        public User User { get; set; }

        private void AddEditButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.User.Name = this.nameTextBox.Text;
                this.User.PhoneNumber = this.phoneNumberTextBox.Text;
                this.User.Password = CryptoHelper.GetMd5Hash(this.passwordMaskedTextBox.Text);

                if (!this.User.IsValid())
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