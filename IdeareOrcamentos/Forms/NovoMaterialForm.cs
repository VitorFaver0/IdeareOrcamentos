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
    public partial class NovoMaterialForm : Form
    {
        public Panel master;
        public int id_material;
        public Material material;
        private IMateriaisRepository materiaisRepository;

        public NovoMaterialForm()
        {

        }

        public NovoMaterialForm(Panel master, int id)
        {
            this.materiaisRepository = new MaterialRepository(new Data.DataContext());
            this.master = master;
            this.id_material = id;
            if (id_material>0)
            {
                this.material = materiaisRepository.GetById(id);
            }
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            if (material!=null)
            {
                this.nome.Text = material.Nome;
                this.fornecedor.Text = material.Fornecedor;
                this.descricao.Text = material.Descricao;
                this.tipo.Text = material.Tipo;
                this.valor.Text = material.Valor.ToString();

            }
            
            base.OnShown(e);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (material!=null)
            {
                material.Nome = this.nome.Text;
                material.Fornecedor = this.fornecedor.Text;
                material.Descricao = this.descricao.Text;
                if (this.tipo.Text != null && (this.tipo.Text == "Chapa" || this.tipo.Text == "Ferragem"))
                {
                    material.Tipo = this.tipo.Text;
                }
                decimal n = 0;
                if (decimal.TryParse(this.valor.Text, out n))
                {
                    material.Valor = n;
                }
                materiaisRepository.Save();
            }
            else
            {
                this.material = new Material();
                material.Nome = this.nome.Text;
                material.Fornecedor = this.fornecedor.Text;
                material.Descricao = this.descricao.Text;
                if (this.tipo.Text!=null &&(this.tipo.Text=="Chapa" || this.tipo.Text=="Ferragem"))
                {
                    material.Tipo = this.tipo.Text;
                }
                decimal n = 0;
                if (decimal.TryParse(this.valor.Text, out n))
                {
                    material.Valor = n;
                }
                
                materiaisRepository.Create(material);
            }
            master.Controls.Clear();
            MateriaisForm materiaisForm = new MateriaisForm(master) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            master.Controls.Add(materiaisForm);
            materiaisForm.Show();
        }
    }
}
