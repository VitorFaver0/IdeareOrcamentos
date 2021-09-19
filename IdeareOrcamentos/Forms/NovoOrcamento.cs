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
    public partial class NovoOrcamento : Form
    {
        public Panel master;
        private IClientesRepository clientesRepository;
        private IMateriaisRepository materiaisRepository;

        public class ComboboxItemCliente
        {
            public string Text { get; set; }
            public Cliente Cliente { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }
        public class ComboboxItemMaterial
        {
            public string Text { get; set; }
            public Material Material { get; set; }

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
            this.materiaisRepository = new MaterialRepository(new Data.DataContext());

            var clientes = clientesRepository.GetAll();
            var materiais = materiaisRepository.GetAll();
            foreach (var cliente in clientes.OrderBy(a => a.Nome))
            {
                ComboboxItemCliente item = new ComboboxItemCliente();
                item.Cliente = cliente;
                item.Text = cliente.Nome;
                this.listaClientes.Items.Add(item);
            }
            foreach (var material in materiais.OrderBy(a => a.Nome))
            {
                ComboboxItemMaterial item = new ComboboxItemMaterial();
                item.Material = material;
                item.Text = material.Nome;
                this.listaMateriais.Items.Add(item);
            }
        }
            

        private void addCliente_Click(object sender, EventArgs e)
        {
            NovoClienteForm novoClienteForm = new NovoClienteForm(master) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            master.Controls.Clear();
            master.Controls.Add(novoClienteForm);
            novoClienteForm.Show();
        }

        private void addMaterial_Click(object sender, EventArgs e)
        {
            var material = this.listaMateriais.SelectedItem as ComboboxItemMaterial;
            if (material != null)
            {
                int quantidade = 0;
                int.TryParse(this.quantidadeMaterial.Text, out quantidade);
                if (quantidade == 0)
                {
                    quantidade = 1;
                }
                var valorAnt = Convert.ToDecimal(this.labelValorTotal.Text);
                this.labelValorTotal.Text = (valorAnt + (material.Material.Valor * quantidade)).ToString();
                ListViewItem item = new ListViewItem();
                item.Text = material.Text + "  x" + quantidade;
                item.Tag = material.Material.ID_Material;
                listViewMateriais.Items.Add(item);
            }
            
        }

        private void removerMaterialButton_Click(object sender, EventArgs e)
        {
            var itens = this.listViewMateriais.SelectedItems;
            foreach (ListViewItem item in itens)
            {
                var material = materiaisRepository.GetById(Convert.ToInt32(item.Tag));
                var aux = item.Text.Split('x');
                var quantidade = Convert.ToInt32(aux[1]);
                var valorTotal = Convert.ToDecimal(this.labelValorTotal.Text);
                valorTotal = valorTotal - (material.Valor * quantidade);
                this.labelValorTotal.Text = valorTotal.ToString();
                item.Remove();
            }
            
        }

        private void listViewMateriais_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (this.listViewMateriais.SelectedItems.Count>0)
            {
                this.removerMaterialButton.Visible = true;
            }
            else
            {
                this.removerMaterialButton.Visible = false;
            }
        }
    }
}
