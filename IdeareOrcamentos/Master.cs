using IdeareOrcamentos.Forms;
using IdeareOrcamentos.Models;
using IdeareOrcamentos.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IdeareOrcamentos
{
    public partial class Master : Form
    {
        private IMateriaisRepository materiaisRepository;
        
        /// Params
        private int borderSize = 2;
        public Master()
        {
            InitializeComponent();
            this.materiaisRepository = new MateriaisRepository(new Data.DataContext());

            // Params
            this.Padding = new Padding(borderSize); //Tamanho da borda
            this.BackColor = Color.FromArgb(67, 159, 200); //Cor da borda


        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);

        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Materiais_Click(object sender, EventArgs e)
        {
            this.Tittle.Text = "Materiais";
            this.panelDesktop.Controls.Clear();
            MateriaisForm materiaisForm = new MateriaisForm(this.panelDesktop) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panelDesktop.Controls.Add(materiaisForm);
            materiaisForm.Show();
        }
    }
}
