using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmileHotel.Helpers;

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

                // TODO: Make a call to SQL to check for existing user.
                bool isSuccessful = true;

                if (isSuccessful)
                {
                    var form = new MenuForm();
                    form.FormClosed += (o, args) => this.Show();
                    form.Show();
                    this.Hide();
                }
            }
            catch
            {
                MessageBox.Show("Невалидни данни!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}
