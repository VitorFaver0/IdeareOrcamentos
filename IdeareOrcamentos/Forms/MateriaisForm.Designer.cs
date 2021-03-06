
namespace IdeareOrcamentos.Forms
{
    partial class MateriaisForm
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
            this.listaMateriais = new MetroFramework.Controls.MetroListView();
            this.nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fornecedor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.valor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.headerTable = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.novoMaterialButton = new FontAwesome.Sharp.IconButton();
            this.excluirMaterial = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.headerTable.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // listaMateriais
            // 
            this.listaMateriais.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listaMateriais.BackColor = System.Drawing.SystemColors.Control;
            this.listaMateriais.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listaMateriais.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nome,
            this.fornecedor,
            this.tipo,
            this.valor});
            this.listaMateriais.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listaMateriais.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.listaMateriais.ForeColor = System.Drawing.SystemColors.Control;
            this.listaMateriais.FullRowSelect = true;
            this.listaMateriais.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listaMateriais.HideSelection = false;
            this.listaMateriais.LabelEdit = true;
            this.listaMateriais.Location = new System.Drawing.Point(0, 64);
            this.listaMateriais.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.listaMateriais.Name = "listaMateriais";
            this.listaMateriais.OwnerDraw = true;
            this.listaMateriais.Size = new System.Drawing.Size(813, 399);
            this.listaMateriais.TabIndex = 0;
            this.listaMateriais.UseCompatibleStateImageBehavior = false;
            this.listaMateriais.UseSelectable = true;
            this.listaMateriais.View = System.Windows.Forms.View.Details;
            this.listaMateriais.DoubleClick += new System.EventHandler(this.listaMateriais_DoubleClick);
            
            // 
            // nome
            // 
            this.nome.Text = "Nome";
            this.nome.Width = 171;
            // 
            // fornecedor
            // 
            this.fornecedor.Text = "Fornecedor";
            this.fornecedor.Width = 204;
            // 
            // tipo
            // 
            this.tipo.Text = "Tipo";
            this.tipo.Width = 158;
            // 
            // valor
            // 
            this.valor.Text = "Valor";
            this.valor.Width = 151;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listaMateriais);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.headerTable);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(10, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panel1.Size = new System.Drawing.Size(813, 522);
            this.panel1.TabIndex = 2;
            // 
            // headerTable
            // 
            this.headerTable.BackColor = System.Drawing.SystemColors.Control;
            this.headerTable.Controls.Add(this.panel4);
            this.headerTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerTable.Location = new System.Drawing.Point(0, 10);
            this.headerTable.Name = "headerTable";
            this.headerTable.Size = new System.Drawing.Size(813, 54);
            this.headerTable.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(426, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tipo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(583, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Valor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(169, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fornecedor";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.Location = new System.Drawing.Point(13, 21);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(55, 20);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome";
            // 
            // novoMaterialButton
            // 
            this.novoMaterialButton.FlatAppearance.BorderSize = 0;
            this.novoMaterialButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.novoMaterialButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.novoMaterialButton.IconChar = FontAwesome.Sharp.IconChar.File;
            this.novoMaterialButton.IconColor = System.Drawing.Color.Black;
            this.novoMaterialButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.novoMaterialButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.novoMaterialButton.Location = new System.Drawing.Point(144, 3);
            this.novoMaterialButton.Name = "novoMaterialButton";
            this.novoMaterialButton.Size = new System.Drawing.Size(111, 52);
            this.novoMaterialButton.TabIndex = 3;
            this.novoMaterialButton.Text = "Novo";
            this.novoMaterialButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.novoMaterialButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.novoMaterialButton.UseVisualStyleBackColor = true;
            this.novoMaterialButton.Click += new System.EventHandler(this.novoMaterialButton_Click);
            // 
            // excluirMaterial
            // 
            this.excluirMaterial.FlatAppearance.BorderSize = 0;
            this.excluirMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.excluirMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.excluirMaterial.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.excluirMaterial.IconColor = System.Drawing.Color.Black;
            this.excluirMaterial.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.excluirMaterial.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.excluirMaterial.Location = new System.Drawing.Point(17, 3);
            this.excluirMaterial.Name = "excluirMaterial";
            this.excluirMaterial.Size = new System.Drawing.Size(111, 52);
            this.excluirMaterial.TabIndex = 4;
            this.excluirMaterial.Text = "Excluir";
            this.excluirMaterial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.excluirMaterial.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.excluirMaterial.UseVisualStyleBackColor = true;
            this.excluirMaterial.Click += new System.EventHandler(this.excluirMaterial_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(705, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(118, 522);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.novoMaterialButton);
            this.panel3.Controls.Add(this.excluirMaterial);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 463);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(813, 59);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.labelNome);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(0, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(689, 51);
            this.panel4.TabIndex = 0;
            // 
            // MateriaisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 522);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MateriaisForm";
            this.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Text = "Materiais";
            this.panel1.ResumeLayout(false);
            this.headerTable.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroListView listaMateriais;
        private System.Windows.Forms.ColumnHeader nome;
        private System.Windows.Forms.ColumnHeader tipo;
        private System.Windows.Forms.ColumnHeader valor;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton novoMaterialButton;
        private System.Windows.Forms.ColumnHeader fornecedor;
        private FontAwesome.Sharp.IconButton excluirMaterial;
        private System.Windows.Forms.Panel headerTable;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}