
namespace IdeareOrcamentos.Forms
{
    partial class NovoMaterialForm
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
            this.nome = new System.Windows.Forms.TextBox();
            this.saveButton = new FontAwesome.Sharp.IconButton();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelFornecedor = new System.Windows.Forms.Label();
            this.fornecedor = new System.Windows.Forms.TextBox();
            this.valor = new System.Windows.Forms.TextBox();
            this.descricao = new System.Windows.Forms.RichTextBox();
            this.tipo = new System.Windows.Forms.ComboBox();
            this.labelDescricao = new System.Windows.Forms.Label();
            this.labelTipo = new System.Windows.Forms.Label();
            this.labelValor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nome
            // 
            this.nome.Location = new System.Drawing.Point(98, 51);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(253, 20);
            this.nome.TabIndex = 0;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.SystemColors.Control;
            this.saveButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.saveButton.FlatAppearance.BorderSize = 0;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.saveButton.IconColor = System.Drawing.Color.Black;
            this.saveButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.saveButton.Location = new System.Drawing.Point(0, 376);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(800, 74);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Salvar";
            this.saveButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(57, 54);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(35, 13);
            this.labelNome.TabIndex = 2;
            this.labelNome.Text = "Nome";
            // 
            // labelFornecedor
            // 
            this.labelFornecedor.AutoSize = true;
            this.labelFornecedor.Location = new System.Drawing.Point(31, 90);
            this.labelFornecedor.Name = "labelFornecedor";
            this.labelFornecedor.Size = new System.Drawing.Size(61, 13);
            this.labelFornecedor.TabIndex = 4;
            this.labelFornecedor.Text = "Fornecedor";
            // 
            // fornecedor
            // 
            this.fornecedor.Location = new System.Drawing.Point(98, 87);
            this.fornecedor.Name = "fornecedor";
            this.fornecedor.Size = new System.Drawing.Size(253, 20);
            this.fornecedor.TabIndex = 5;
            // 
            // valor
            // 
            this.valor.Location = new System.Drawing.Point(98, 267);
            this.valor.Name = "valor";
            this.valor.Size = new System.Drawing.Size(96, 20);
            this.valor.TabIndex = 6;
            // 
            // descricao
            // 
            this.descricao.Location = new System.Drawing.Point(98, 124);
            this.descricao.Name = "descricao";
            this.descricao.Size = new System.Drawing.Size(253, 86);
            this.descricao.TabIndex = 9;
            this.descricao.Text = "";
            // 
            // tipo
            // 
            this.tipo.FormattingEnabled = true;
            this.tipo.Items.AddRange(new object[] {
            "Chapa",
            "Ferragem"});
            this.tipo.Location = new System.Drawing.Point(98, 230);
            this.tipo.Name = "tipo";
            this.tipo.Size = new System.Drawing.Size(129, 21);
            this.tipo.TabIndex = 10;
            // 
            // labelDescricao
            // 
            this.labelDescricao.AutoSize = true;
            this.labelDescricao.Location = new System.Drawing.Point(31, 161);
            this.labelDescricao.Name = "labelDescricao";
            this.labelDescricao.Size = new System.Drawing.Size(55, 13);
            this.labelDescricao.TabIndex = 11;
            this.labelDescricao.Text = "Descricao";
            // 
            // labelTipo
            // 
            this.labelTipo.AutoSize = true;
            this.labelTipo.Location = new System.Drawing.Point(64, 233);
            this.labelTipo.Name = "labelTipo";
            this.labelTipo.Size = new System.Drawing.Size(28, 13);
            this.labelTipo.TabIndex = 12;
            this.labelTipo.Text = "Tipo";
            // 
            // labelValor
            // 
            this.labelValor.AutoSize = true;
            this.labelValor.Location = new System.Drawing.Point(57, 270);
            this.labelValor.Name = "labelValor";
            this.labelValor.Size = new System.Drawing.Size(31, 13);
            this.labelValor.TabIndex = 13;
            this.labelValor.Text = "Valor";
            // 
            // NovoMaterialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelValor);
            this.Controls.Add(this.labelTipo);
            this.Controls.Add(this.labelDescricao);
            this.Controls.Add(this.tipo);
            this.Controls.Add(this.descricao);
            this.Controls.Add(this.valor);
            this.Controls.Add(this.fornecedor);
            this.Controls.Add(this.labelFornecedor);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.nome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NovoMaterialForm";
            this.Text = "NovoMaterialForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nome;
        private FontAwesome.Sharp.IconButton saveButton;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelFornecedor;
        private System.Windows.Forms.TextBox fornecedor;
        private System.Windows.Forms.TextBox valor;
        private System.Windows.Forms.RichTextBox descricao;
        private System.Windows.Forms.ComboBox tipo;
        private System.Windows.Forms.Label labelDescricao;
        private System.Windows.Forms.Label labelTipo;
        private System.Windows.Forms.Label labelValor;
    }
}