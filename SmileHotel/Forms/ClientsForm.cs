using System.Windows.Forms;
using SmileHotel.Models;
using SmileHotel.Repositories;

namespace SmileHotel.Forms
{
    public partial class ClientsForm : Form
    {
        private readonly ClientRepository clientRepository;

        public ClientsForm()
        {
            this.InitializeComponent();
            this.clientRepository = new ClientRepository();
        }

        private void ClientsForm_Load(object sender, System.EventArgs e)
        {
            this.clientBindingSource.DataSource = this.clientRepository.GetAllClients();
        }

        private void DeleteClientButton_Click(object sender, System.EventArgs e)
        {
            var selectedClient = (Client)this.clientBindingSource.Current;

            if (selectedClient == null)
            {
                MessageBox.Show("Не е избран клиент за изтриване!");
                return;
            }

            this.clientRepository.DeleteClient(selectedClient.Id);
            this.clientBindingSource.RemoveCurrent();
        }

        private void AddClientButton_Click(object sender, System.EventArgs e)
        {
            var editForm = new ClientAddEditForm(null);
            editForm.ShowDialog();

            if (editForm.DialogResult == DialogResult.OK)
            {
                var client = editForm.Client;

                if (client != null)
                {
                    client = this.clientRepository.AddOrUpdateClient(client);
                    this.clientBindingSource.Add(client);
                }
            }
        }

        private void EditClientButton_Click(object sender, System.EventArgs e)
        {
            var selectedClient = (Client)this.clientBindingSource.Current;

            if (selectedClient == null)
            {
                MessageBox.Show("Не е избран клиент за редакция!");
                return;
            }

            var editForm = new ClientAddEditForm(selectedClient);
            editForm.ShowDialog();

            if (editForm.DialogResult == DialogResult.OK)
            {
                var client = editForm.Client;

                if (client != null)
                {
                    client = this.clientRepository.AddOrUpdateClient(client);
                    this.clientBindingSource[this.clientBindingSource.Position] = client;
                }
            }
        }
    }
}
