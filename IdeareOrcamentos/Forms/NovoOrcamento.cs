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
        private IOrcamentosRepository orcamentosRepository;
        private IListaMateriaisOrcamentoRepository listaMateriaisOrcamentoRepository;

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
            this.orcamentosRepository= new OrcamentosRepository(new Data.DataContext());
            this.listaMateriaisOrcamentoRepository = new ListaMateriaisOrcamentoRepository(new Data.DataContext());

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
                decimal valorCusto = 0;
                int.TryParse(this.quantidadeMaterial.Text, out quantidade);
                if (quantidade == 0)
                {
                    quantidade = 1;
                }
                decimal.TryParse(this.valorCusto.Text, out valorCusto);
                if (valorCusto == 0)
                {
                    valorCusto = 2;
                }
                var valorAnt = Convert.ToDecimal(this.labelValorMaterial.Text);
                this.labelValorMaterial.Text = (valorAnt + (material.Material.Valor * quantidade)).ToString();
                this.labelValorTotal.Text = ((valorAnt + (material.Material.Valor * quantidade))*valorCusto).ToString();
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
                decimal valorCusto = 0;
                decimal.TryParse(this.valorCusto.Text, out valorCusto);
                if (valorCusto == 0)
                {
                    valorCusto = 2;
                }
                var valorMaterial = Convert.ToDecimal(this.labelValorMaterial.Text);
                var valorTotal = Convert.ToDecimal(this.labelValorTotal.Text);
                valorMaterial = valorMaterial - (material.Valor * quantidade);
                valorTotal = valorTotal - ((material.Valor * quantidade)*valorCusto);
                this.labelValorMaterial.Text = valorMaterial.ToString();
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

        private void valorCusto_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.valorCusto.Text == "2" || this.valorCusto.Text == "2,5" || this.valorCusto.Text == "3")
            {
                decimal valorCusto = 0;
                var valorMaterial = Convert.ToDecimal(this.labelValorMaterial.Text);
                decimal.TryParse(this.valorCusto.Text, out valorCusto);
                if (valorCusto == 0)
                {
                    valorCusto = 2;
                }
                var valorTotal = valorMaterial * valorCusto;
                this.labelValorTotal.Text = valorTotal.ToString();

            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            errorOrcamento.Clear();
            int errors = 0;
            Orcamento orcamento = new Orcamento();
            orcamento.DataCriacao = DateTime.Now;
            if(this.nomeProjeto.Text!=null && this.nomeProjeto.Text!= "")
            {
                orcamento.NomeProjeto = this.nomeProjeto.Text;
            }
            else
            {
                errorOrcamento.SetError(nomeProjeto, "Insira o nome do projeto.");
                errors = errors + 1;
            }
            if (this.listaClientes.SelectedItem!=null)
            {
                var item = this.listaClientes.SelectedItem as ComboboxItemCliente;
                orcamento.ID_Cliente = item.Cliente.ID_Cliente;
            }
            else
            {
                errorOrcamento.SetError(listaClientes, "Selecione um cliente.");
                errors = errors + 1;
            }
            if (this.dataEntrega.Value!=null)
            {
                orcamento.DataEntrega = this.dataEntrega.Value;

            }
            else
            {
                errorOrcamento.SetError(dataEntrega, "Selecione uma data valida.");
                errors = errors + 1;
            }
            if (this.valorCusto.SelectedItem!=null && this.valorCusto.SelectedItem.ToString() != "")
            {
                orcamento.ValorCusto = Convert.ToInt32(this.valorCusto.SelectedItem.ToString());
            }
            else
            {
                errorOrcamento.SetError(valorCusto, "Selecione um multiplicador valido");
                errors = errors + 1;
            }
            if (this.labelValorMaterial.Text!=null)
            {
                orcamento.ValorProjeto = Convert.ToDecimal(this.labelValorMaterial.Text);
            }
            List<ListaMateriaisOrcamento> listMateriais = new List<ListaMateriaisOrcamento>();
            if (this.listViewMateriais.Items.Count > 0)
            {
                
                foreach (ListViewItem item in this.listViewMateriais.Items)
                {
                    ListaMateriaisOrcamento mat = new ListaMateriaisOrcamento();
                    mat.ID_Material = Convert.ToInt32(item.Tag.ToString());
                    var quantidade = item.Text.Split('x');
                    mat.Quantidade = Convert.ToInt32(quantidade[1]);
                    listMateriais.Add(mat);
                }
            }
            else
            {
                errorOrcamento.SetError(addMaterial, "Adicione um material");
                errors = errors + 1;
            }

            if (errors==0 && listMateriais.Count>0)
            {
                orcamentosRepository.Create(orcamento);
                foreach (var mat in listMateriais)
                {
                    mat.ID_Orcamento = orcamento.ID_Orcamento;
                    listaMateriaisOrcamentoRepository.Create(mat);
                }

            }
            
        }          
        
    }
}
