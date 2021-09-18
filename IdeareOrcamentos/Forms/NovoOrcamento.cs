using IdeareOrcamentos.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IdeareOrcamentos.Forms
{
    public partial class NovoOrcamento : Form
    {
        public Panel master;
        private IClientesRepository clientesRepository;

        public class ComboboxItem
        {
            public string Text { get; set; }
            public int Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }
        public NovoOrcamento(Panel master)
        {
            InitializeComponent();
            this.master = master;
            this.clientesRepository = new ClienteRepository(new Data.DataContext());

            var clientes = clientesRepository.GetAll();
            foreach (var cliente in clientes.OrderBy(a => a.Nome))
            {
                ComboboxItem item = new ComboboxItem();
                item.Value = cliente.ID_Cliente;
                item.Text = cliente.Nome;
                this.listaClientes.Items.Add(item);
            }
        }
            

        private void addCliente_Click(object sender, EventArgs e)
        {
            NovoClienteForm novoClienteForm = new NovoClienteForm(master) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            master.Controls.Clear();
            master.Controls.Add(novoClienteForm);
            novoClienteForm.Show();
        }
    }
}
