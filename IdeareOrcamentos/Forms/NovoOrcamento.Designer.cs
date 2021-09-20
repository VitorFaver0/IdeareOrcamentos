
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
            this.components = new System.ComponentModel.Container();
            this.nomeProjeto = new System.Windows.Forms.TextBox();
            this.listaClientes = new System.Windows.Forms.ComboBox();
            this.labelNomeProj = new System.Windows.Forms.Label();
            this.labelCliente = new System.Windows.Forms.Label();
            this.listaMateriais = new System.Windows.Forms.ComboBox();
            this.listViewMateriais = new System.Windows.Forms.ListView();
            this.quantidadeMaterial = new System.Windows.Forms.TextBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelValorMaterial = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataEntrega = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.labelValorTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.valorCusto = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.errorOrcamento = new System.Windows.Forms.ErrorProvider(this.components);
            this.removerMaterialButton = new FontAwesome.Sharp.IconButton();
            this.addMaterial = new FontAwesome.Sharp.IconButton();
            this.saveButton = new FontAwesome.Sharp.IconButton();
            this.addCliente = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorOrcamento)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeProjeto
            // 
            this.nomeProjeto.Location = new System.Drawing.Point(59, 74);
            this.nomeProjeto.Name = "nomeProjeto";
            this.nomeProjeto.Size = new System.Drawing.Size(201, 20);
            this.nomeProjeto.TabIndex = 0;
            // 
            // listaClientes
            // 
            this.listaClientes.FormattingEnabled = true;
            this.listaClientes.Location = new System.Drawing.Point(59, 118);
            this.listaClientes.Name = "listaClientes";
            this.listaClientes.Size = new System.Drawing.Size(201, 21);
            this.listaClientes.TabIndex = 3;
            // 
            // labelNomeProj
            // 
            this.labelNomeProj.AutoSize = true;
            this.labelNomeProj.Location = new System.Drawing.Point(56, 58);
            this.labelNomeProj.Name = "labelNomeProj";
            this.labelNomeProj.Size = new System.Drawing.Size(86, 13);
            this.labelNomeProj.TabIndex = 4;
            this.labelNomeProj.Text = "Nome do Proejto";
            // 
            // labelCliente
            // 
            this.labelCliente.AutoSize = true;
            this.labelCliente.Location = new System.Drawing.Point(56, 102);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(39, 13);
            this.labelCliente.TabIndex = 5;
            this.labelCliente.Text = "Cliente";
            // 
            // listaMateriais
            // 
            this.listaMateriais.FormattingEnabled = true;
            this.listaMateriais.Location = new System.Drawing.Point(59, 170);
            this.listaMateriais.Name = "listaMateriais";
            this.listaMateriais.Size = new System.Drawing.Size(201, 21);
            this.listaMateriais.TabIndex = 7;
            // 
            // listViewMateriais
            // 
            this.listViewMateriais.HideSelection = false;
            this.listViewMateriais.Location = new System.Drawing.Point(59, 198);
            this.listViewMateriais.Name = "listViewMateriais";
            this.listViewMateriais.Size = new System.Drawing.Size(320, 228);
            this.listViewMateriais.TabIndex = 8;
            this.listViewMateriais.UseCompatibleStateImageBehavior = false;
            this.listViewMateriais.View = System.Windows.Forms.View.List;
            this.listViewMateriais.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listViewMateriais_ItemSelectionChanged);
            // 
            // quantidadeMaterial
            // 
            this.quantidadeMaterial.Location = new System.Drawing.Point(266, 171);
            this.quantidadeMaterial.Name = "quantidadeMaterial";
            this.quantidadeMaterial.Size = new System.Drawing.Size(57, 20);
            this.quantidadeMaterial.TabIndex = 9;
            this.quantidadeMaterial.Text = "1";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(-4, 0);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(49, 20);
            this.labelTotal.TabIndex = 11;
            this.labelTotal.Text = "Total";
            // 
            // labelValorMaterial
            // 
            this.labelValorMaterial.AutoSize = true;
            this.labelValorMaterial.Location = new System.Drawing.Point(70, 20);
            this.labelValorMaterial.Name = "labelValorMaterial";
            this.labelValorMaterial.Size = new System.Drawing.Size(28, 13);
            this.labelValorMaterial.TabIndex = 12;
            this.labelValorMaterial.Text = "0,00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Materiais: R$";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Materiais";
            // 
            // dataEntrega
            // 
            this.dataEntrega.Location = new System.Drawing.Point(385, 198);
            this.dataEntrega.Name = "dataEntrega";
            this.dataEntrega.Size = new System.Drawing.Size(226, 20);
            this.dataEntrega.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(382, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Data Estimada da Entrega";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.labelValorTotal);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.labelTotal);
            this.panel1.Controls.Add(this.labelValorMaterial);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(385, 311);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(174, 79);
            this.panel1.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Valor total: R$";
            // 
            // labelValorTotal
            // 
            this.labelValorTotal.AutoSize = true;
            this.labelValorTotal.Location = new System.Drawing.Point(83, 54);
            this.labelValorTotal.Name = "labelValorTotal";
            this.labelValorTotal.Size = new System.Drawing.Size(28, 13);
            this.labelValorTotal.TabIndex = 16;
            this.labelValorTotal.Text = "0,00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(266, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Quant.";
            // 
            // valorCusto
            // 
            this.valorCusto.FormattingEnabled = true;
            this.valorCusto.Items.AddRange(new object[] {
            "2",
            "2,5",
            "3"});
            this.valorCusto.Location = new System.Drawing.Point(476, 240);
            this.valorCusto.Name = "valorCusto";
            this.valorCusto.Size = new System.Drawing.Size(46, 21);
            this.valorCusto.TabIndex = 20;
            this.valorCusto.Text = "2";
            this.valorCusto.SelectedValueChanged += new System.EventHandler(this.valorCusto_SelectedValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(395, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Valor de custo";
            // 
            // errorOrcamento
            // 
            this.errorOrcamento.ContainerControl = this;
            // 
            // removerMaterialButton
            // 
            this.removerMaterialButton.FlatAppearance.BorderSize = 0;
            this.removerMaterialButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removerMaterialButton.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.removerMaterialButton.IconColor = System.Drawing.Color.DarkRed;
            this.removerMaterialButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.removerMaterialButton.IconSize = 20;
            this.removerMaterialButton.Location = new System.Drawing.Point(385, 396);
            this.removerMaterialButton.Name = "removerMaterialButton";
            this.removerMaterialButton.Size = new System.Drawing.Size(26, 30);
            this.removerMaterialButton.TabIndex = 15;
            this.removerMaterialButton.UseVisualStyleBackColor = true;
            this.removerMaterialButton.Visible = false;
            this.removerMaterialButton.Click += new System.EventHandler(this.removerMaterialButton_Click);
            // 
            // addMaterial
            // 
            this.addMaterial.FlatAppearance.BorderSize = 0;
            this.addMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMaterial.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.addMaterial.IconColor = System.Drawing.Color.ForestGreen;
            this.addMaterial.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.addMaterial.IconSize = 20;
            this.addMaterial.Location = new System.Drawing.Point(329, 170);
            this.addMaterial.Name = "addMaterial";
            this.addMaterial.Size = new System.Drawing.Size(31, 22);
            this.addMaterial.TabIndex = 10;
            this.addMaterial.UseVisualStyleBackColor = true;
            this.addMaterial.Click += new System.EventHandler(this.addMaterial_Click);
            // 
            // saveButton
            // 
            this.saveButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.saveButton.FlatAppearance.BorderSize = 0;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.saveButton.IconColor = System.Drawing.Color.Black;
            this.saveButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.saveButton.Location = new System.Drawing.Point(0, 562);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(1135, 78);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Salvar";
            this.saveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
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
            this.addCliente.Location = new System.Drawing.Point(278, 115);
            this.addCliente.Name = "addCliente";
            this.addCliente.Size = new System.Drawing.Size(27, 24);
            this.addCliente.TabIndex = 2;
            this.addCliente.Text = "\r\n";
            this.addCliente.UseVisualStyleBackColor = false;
            this.addCliente.Click += new System.EventHandler(this.addCliente_Click);
            // 
            // NovoOrcamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 640);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.valorCusto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataEntrega);
            this.Controls.Add(this.removerMaterialButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addMaterial);
            this.Controls.Add(this.quantidadeMaterial);
            this.Controls.Add(this.listViewMateriais);
            this.Controls.Add(this.listaMateriais);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.labelCliente);
            this.Controls.Add(this.labelNomeProj);
            this.Controls.Add(this.listaClientes);
            this.Controls.Add(this.addCliente);
            this.Controls.Add(this.nomeProjeto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NovoOrcamento";
            this.Text = "NovoOrcamento";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorOrcamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nomeProjeto;
        private FontAwesome.Sharp.IconButton addCliente;
        private System.Windows.Forms.ComboBox listaClientes;
        private System.Windows.Forms.Label labelNomeProj;
        private System.Windows.Forms.Label labelCliente;
        private FontAwesome.Sharp.IconButton saveButton;
        private System.Windows.Forms.ComboBox listaMateriais;
        private System.Windows.Forms.ListView listViewMateriais;
        private System.Windows.Forms.TextBox quantidadeMaterial;
        private FontAwesome.Sharp.IconButton addMaterial;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelValorMaterial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton removerMaterialButton;
        private System.Windows.Forms.DateTimePicker dataEntrega;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelValorTotal;
        private System.Windows.Forms.ComboBox valorCusto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider errorOrcamento;
    }
}