using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                string password = this.passwordMaskedTextBox.Text;
                bool isSuccessful = true;

                // TODO: Make a call to SQL to check for existing user.
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
