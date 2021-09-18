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
    public partial class OrcamentosForm : Form
    {
        public Panel master;
        public OrcamentosForm(Panel master)
        {
            InitializeComponent();
            this.master = master;
        }

        private void novoOrcamento_Click(object sender, EventArgs e)
        {
            NovoOrcamento novoOrcamentoForm = new NovoOrcamento(master) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            master.Controls.Clear();
            master.Controls.Add(novoOrcamentoForm);
            novoOrcamentoForm.Show();
        }
    }
}
