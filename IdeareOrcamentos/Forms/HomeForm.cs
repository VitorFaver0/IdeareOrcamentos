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
    public partial class HomeForm : Form
    {
        private IMateriaisRepository materiaisRepository;
        public Panel master;
        public HomeForm()
        {
            
        }
        public HomeForm(Panel master)
        {
            this.materiaisRepository = new MaterialRepository(new Data.DataContext());
            this.master = master;
            
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            var listaMateriais = materiaisRepository.GetAll();
            this.chart1.Series["Teste"].Points.AddXY("Chapas", listaMateriais.Count(a => a.Tipo=="Chapa"));
            this.chart1.Series["Teste"].Points.AddXY("Ferragem", listaMateriais.Count(a => a.Tipo == "Ferragem"));

            base.OnShown(e);
        }
    }
}
