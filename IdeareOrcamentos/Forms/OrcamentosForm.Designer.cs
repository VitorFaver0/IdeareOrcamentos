
namespace IdeareOrcamentos.Forms
{
    partial class OrcamentosForm
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
            this.metroListView1 = new MetroFramework.Controls.MetroListView();
            this.novoOrcamento = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // metroListView1
            // 
            this.metroListView1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroListView1.FullRowSelect = true;
            this.metroListView1.Location = new System.Drawing.Point(41, 75);
            this.metroListView1.Name = "metroListView1";
            this.metroListView1.OwnerDraw = true;
            this.metroListView1.Size = new System.Drawing.Size(551, 315);
            this.metroListView1.TabIndex = 0;
            this.metroListView1.UseCompatibleStateImageBehavior = false;
            this.metroListView1.UseSelectable = true;
            // 
            // novoOrcamento
            // 
            this.novoOrcamento.FlatAppearance.BorderSize = 0;
            this.novoOrcamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.novoOrcamento.IconChar = FontAwesome.Sharp.IconChar.FileInvoiceDollar;
            this.novoOrcamento.IconColor = System.Drawing.Color.Black;
            this.novoOrcamento.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.novoOrcamento.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.novoOrcamento.Location = new System.Drawing.Point(608, 85);
            this.novoOrcamento.Name = "novoOrcamento";
            this.novoOrcamento.Size = new System.Drawing.Size(125, 50);
            this.novoOrcamento.TabIndex = 1;
            this.novoOrcamento.Text = "Novo";
            this.novoOrcamento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.novoOrcamento.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.novoOrcamento.UseVisualStyleBackColor = true;
            this.novoOrcamento.Click += new System.EventHandler(this.novoOrcamento_Click);
            // 
            // OrcamentosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.novoOrcamento);
            this.Controls.Add(this.metroListView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrcamentosForm";
            this.Text = "OrcamentosForm";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroListView metroListView1;
        private FontAwesome.Sharp.IconButton novoOrcamento;
    }
}