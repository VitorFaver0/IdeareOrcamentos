
namespace IdeareOrcamentos.Forms
{
    partial class NovoClienteForm
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
            this.labelNovoCliente = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelNumero = new System.Windows.Forms.Label();
            this.salvarClienteButton = new FontAwesome.Sharp.IconButton();
            this.nome = new System.Windows.Forms.TextBox();
            this.numero = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelNovoCliente
            // 
            this.labelNovoCliente.AutoSize = true;
            this.labelNovoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNovoCliente.Location = new System.Drawing.Point(35, 23);
            this.labelNovoCliente.Name = "labelNovoCliente";
            this.labelNovoCliente.Size = new System.Drawing.Size(130, 24);
            this.labelNovoCliente.TabIndex = 0;
            this.labelNovoCliente.Text = "Novo Cliente";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(86, 104);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(35, 13);
            this.labelNome.TabIndex = 1;
            this.labelNome.Text = "Nome";
            // 
            // labelNumero
            // 
            this.labelNumero.AutoSize = true;
            this.labelNumero.Location = new System.Drawing.Point(32, 134);
            this.labelNumero.Name = "labelNumero";
            this.labelNumero.Size = new System.Drawing.Size(89, 13);
            this.labelNumero.TabIndex = 2;
            this.labelNumero.Text = "Numero (contato)";
            // 
            // salvarClienteButton
            // 
            this.salvarClienteButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.salvarClienteButton.IconColor = System.Drawing.Color.Black;
            this.salvarClienteButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.salvarClienteButton.Location = new System.Drawing.Point(234, 169);
            this.salvarClienteButton.Name = "salvarClienteButton";
            this.salvarClienteButton.Size = new System.Drawing.Size(75, 23);
            this.salvarClienteButton.TabIndex = 3;
            this.salvarClienteButton.Text = "salvarCliente";
            this.salvarClienteButton.UseVisualStyleBackColor = true;
            this.salvarClienteButton.Click += new System.EventHandler(this.salvarClienteButton_Click);
            // 
            // nome
            // 
            this.nome.Location = new System.Drawing.Point(127, 101);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(182, 20);
            this.nome.TabIndex = 4;
            // 
            // numero
            // 
            this.numero.Location = new System.Drawing.Point(127, 131);
            this.numero.Name = "numero";
            this.numero.Size = new System.Drawing.Size(182, 20);
            this.numero.TabIndex = 5;
            // 
            // NovoClienteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numero);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.salvarClienteButton);
            this.Controls.Add(this.labelNumero);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.labelNovoCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NovoClienteForm";
            this.Text = "NovoClienteForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNovoCliente;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelNumero;
        private FontAwesome.Sharp.IconButton salvarClienteButton;
        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.TextBox numero;
    }
}