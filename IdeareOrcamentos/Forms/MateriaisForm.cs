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
    public partial class MateriaisForm : Form
    {
        private IMateriaisRepository materiaisRepository;
        public Panel master;
        public MateriaisForm(Panel master)
        {
            InitializeComponent();           
            this.materiaisRepository = new MateriaisRepository(new Data.DataContext());
            this.master = master;
            var materiais = materiaisRepository.GetAll().ToList();
            foreach (var material in materiais)
            {            
                ListViewItem item = new ListViewItem(material.Nome);
                item.Tag = material.ID_Material;
                item.SubItems.Add(""+material.Fornecedor);
                item.SubItems.Add("                 "+material.Tipo);
                item.SubItems.Add("                 R$"+material.Valor.ToString());
                             
                listaMateriais.Items.Add(item);
            }

        }

        private void listaMateriais_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void listaMateriais_DoubleClick(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(this.listaMateriais.FocusedItem.Tag);
            NovoMaterialForm materialForm = new NovoMaterialForm(master, id ) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            
            master.Controls.Clear();
            master.Controls.Add(materialForm);
            materialForm.Show();
        }       

        private void novoMaterialButton_Click(object sender, EventArgs e)
        {
            NovoMaterialForm materialForm = new NovoMaterialForm(master, 0) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            master.Controls.Clear();
            master.Controls.Add(materialForm);
            materialForm.Show();
        }

        private void excluirMaterial_Click(object sender, EventArgs e)
        {
            if (this.listaMateriais.FocusedItem.Tag != null)
            {
                int id = Convert.ToInt32(this.listaMateriais.FocusedItem.Tag.ToString());
                this.listaMateriais.FocusedItem.Remove();
                materiaisRepository.Delete(id);
                
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
