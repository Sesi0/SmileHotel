using System;
using System.Windows.Forms;
using SmileHotel.Models;

namespace SmileHotel.Forms
{
    public partial class ClientAddEditForm : Form
    {
        public ClientAddEditForm(Client client)
        {
            this.InitializeComponent();

            if (client == null)
            {
                client = new Client();
            }
            else
            {
                this.nameTextBox.Text = client.Name;
                this.personalDocumentNumberTextBox.Text = client.PersonalDocNumber;
                this.phoneNumberTextBox.Text = client.PhoneNumber;
            }

            this.Client = client;
        }

        public Client Client { get; set; }

        private void AddEditButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.Client.Name = this.nameTextBox.Text;
                this.Client.PersonalDocNumber = this.personalDocumentNumberTextBox.Text;
                this.Client.PhoneNumber = this.phoneNumberTextBox.Text;

                if (!this.Client.IsValid())
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