
namespace IdeareOrcamentos
{
    partial class Master
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Master));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.Tittle = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.Materiais = new FontAwesome.Sharp.IconButton();
            this.Orcamentos = new FontAwesome.Sharp.IconButton();
            this.Home = new FontAwesome.Sharp.IconButton();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Aquamarine;
            this.panelMenu.Controls.Add(this.Materiais);
            this.panelMenu.Controls.Add(this.Orcamentos);
            this.panelMenu.Controls.Add(this.Home);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(230, 594);
            this.panelMenu.TabIndex = 0;
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(230, 100);
            this.panelLogo.TabIndex = 0;
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.Turquoise;
            this.panelTitle.Controls.Add(this.Tittle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(230, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(893, 70);
            this.panelTitle.TabIndex = 1;
            this.panelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseDown);
            // 
            // Tittle
            // 
            this.Tittle.AutoSize = true;
            this.Tittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tittle.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Tittle.Location = new System.Drawing.Point(17, 25);
            this.Tittle.Name = "Tittle";
            this.Tittle.Size = new System.Drawing.Size(72, 25);
            this.Tittle.TabIndex = 0;
            this.Tittle.Text = "Home";
            this.Tittle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelDesktop
            // 
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(230, 70);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(893, 524);
            this.panelDesktop.TabIndex = 2;
            // 
            // Materiais
            // 
            this.Materiais.Dock = System.Windows.Forms.DockStyle.Top;
            this.Materiais.FlatAppearance.BorderSize = 0;
            this.Materiais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Materiais.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Materiais.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Materiais.IconChar = FontAwesome.Sharp.IconChar.Hammer;
            this.Materiais.IconColor = System.Drawing.Color.DimGray;
            this.Materiais.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Materiais.IconSize = 36;
            this.Materiais.Location = new System.Drawing.Point(0, 184);
            this.Materiais.Name = "Materiais";
            this.Materiais.Size = new System.Drawing.Size(230, 42);
            this.Materiais.TabIndex = 3;
            this.Materiais.Tag = "Materiais";
            this.Materiais.Text = "Materiais";
            this.Materiais.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Materiais.UseVisualStyleBackColor = true;
            this.Materiais.Click += new System.EventHandler(this.Materiais_Click);
            // 
            // Orcamentos
            // 
            this.Orcamentos.Dock = System.Windows.Forms.DockStyle.Top;
            this.Orcamentos.FlatAppearance.BorderSize = 0;
            this.Orcamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Orcamentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Orcamentos.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Orcamentos.IconChar = FontAwesome.Sharp.IconChar.FileInvoiceDollar;
            this.Orcamentos.IconColor = System.Drawing.Color.DimGray;
            this.Orcamentos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Orcamentos.IconSize = 36;
            this.Orcamentos.Location = new System.Drawing.Point(0, 142);
            this.Orcamentos.Name = "Orcamentos";
            this.Orcamentos.Size = new System.Drawing.Size(230, 42);
            this.Orcamentos.TabIndex = 2;
            this.Orcamentos.Tag = "Orcamentos";
            this.Orcamentos.Text = "Orçamentos";
            this.Orcamentos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Orcamentos.UseVisualStyleBackColor = true;
            this.Orcamentos.Click += new System.EventHandler(this.Orcamentos_Click);
            // 
            // Home
            // 
            this.Home.Dock = System.Windows.Forms.DockStyle.Top;
            this.Home.FlatAppearance.BorderSize = 0;
            this.Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Home.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.Home.IconColor = System.Drawing.Color.DimGray;
            this.Home.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Home.IconSize = 36;
            this.Home.Location = new System.Drawing.Point(0, 100);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(230, 42);
            this.Home.TabIndex = 1;
            this.Home.Tag = "Home";
            this.Home.Text = "Home";
            this.Home.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Home.UseVisualStyleBackColor = true;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // pictureLogo
            // 
            this.pictureLogo.BackgroundImage = global::IdeareOrcamentos.Properties.Resources.logo__1_;
            this.pictureLogo.Location = new System.Drawing.Point(36, 12);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(103, 81);
            this.pictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureLogo.TabIndex = 0;
            this.pictureLogo.TabStop = false;
            // 
            // Master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 594);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Master";
            this.Text = "Ideare";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureLogo;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconButton Home;
        private FontAwesome.Sharp.IconButton Materiais;
        private FontAwesome.Sharp.IconButton Orcamentos;
        private System.Windows.Forms.Label Tittle;
    }
}

