using IdeareOrcamentos.Models;
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
    public partial class NovoClienteForm : Form
    {
        public Panel master;
        private IClientesRepository clientesRepository;
        public NovoClienteForm(Panel master)
        {
            this.clientesRepository = new ClienteRepository(new Data.DataContext());
            this.master = master;
            InitializeComponent();
        }

        private void salvarClienteButton_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente(); 
            
            if(this.nome.Text!=null && this.nome.Text != "")
            {
                cliente.Nome = this.nome.Text;
            }
            if (this.numero.Text!=null && this.numero.Text!="")
            {
                cliente.Numero = this.numero.Text;
            }
            if (cliente.Nome != null && cliente.Numero!= null)
            {
                clientesRepository.Create(cliente);
                NovoOrcamento novoOrcamentoForm = new NovoOrcamento(master) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                master.Controls.Clear();
                master.Controls.Add(novoOrcamentoForm);
                novoOrcamentoForm.Show();
            }           
        }
    }
}
