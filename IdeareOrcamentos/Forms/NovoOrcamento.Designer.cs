
namespace IdeareOrcamentos.Forms
{
    partial class NovoOrcamento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nomeProjeto = new System.Windows.Forms.TextBox();
            this.addCliente = new FontAwesome.Sharp.IconButton();
            this.listaClientes = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // nomeProjeto
            // 
            this.nomeProjeto.Location = new System.Drawing.Point(59, 74);
            this.nomeProjeto.Name = "nomeProjeto";
            this.nomeProjeto.Size = new System.Drawing.Size(201, 20);
            this.nomeProjeto.TabIndex = 0;
            // 
            // addCliente
            // 
            this.addCliente.BackColor = System.Drawing.SystemColors.Control;
            this.addCliente.FlatAppearance.BorderSize = 0;
            this.addCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCliente.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.addCliente.IconColor = System.Drawing.Color.Black;
            this.addCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.addCliente.IconSize = 24;
            this.addCliente.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.addCliente.Location = new System.Drawing.Point(266, 115);
            this.addCliente.Name = "addCliente";
            this.addCliente.Size = new System.Drawing.Size(27, 24);
            this.addCliente.TabIndex = 2;
            this.addCliente.Text = "\r\n";
            this.addCliente.UseVisualStyleBackColor = false;
            this.addCliente.Click += new System.EventHandler(this.addCliente_Click);
            // 
            // listaClientes
            // 
            this.listaClientes.FormattingEnabled = true;
            this.listaClientes.Location = new System.Drawing.Point(59, 118);
            this.listaClientes.Name = "listaClientes";
            this.listaClientes.Size = new System.Drawing.Size(201, 21);
            this.listaClientes.TabIndex = 3;
            // 
            // NovoOrcamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 579);
            this.Controls.Add(this.listaClientes);
            this.Controls.Add(this.addCliente);
            this.Controls.Add(this.nomeProjeto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NovoOrcamento";
            this.Text = "NovoOrcamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nomeProjeto;
        private FontAwesome.Sharp.IconButton addCliente;
        private System.Windows.Forms.ComboBox listaClientes;
    }
}