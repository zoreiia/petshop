namespace petshop
{
    partial class menu
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
            this.buttoncadastro = new System.Windows.Forms.Button();
            this.buttonpets = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttoncadastro
            // 
            this.buttoncadastro.Font = new System.Drawing.Font("Microsoft Uighur", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttoncadastro.Location = new System.Drawing.Point(12, 113);
            this.buttoncadastro.Name = "buttoncadastro";
            this.buttoncadastro.Size = new System.Drawing.Size(143, 52);
            this.buttoncadastro.TabIndex = 0;
            this.buttoncadastro.Text = "Cadastrar";
            this.buttoncadastro.UseVisualStyleBackColor = true;
            this.buttoncadastro.Click += new System.EventHandler(this.buttoncadastro_Click);
            // 
            // buttonpets
            // 
            this.buttonpets.Font = new System.Drawing.Font("Microsoft Uighur", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.buttonpets.Location = new System.Drawing.Point(236, 113);
            this.buttonpets.Name = "buttonpets";
            this.buttonpets.Size = new System.Drawing.Size(143, 52);
            this.buttonpets.TabIndex = 1;
            this.buttonpets.Text = "Pets";
            this.buttonpets.UseVisualStyleBackColor = true;
            this.buttonpets.Click += new System.EventHandler(this.buttonpets_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 284);
            this.Controls.Add(this.buttonpets);
            this.Controls.Add(this.buttoncadastro);
            this.Name = "menu";
            this.Text = "PetShop";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttoncadastro;
        private System.Windows.Forms.Button buttonpets;
    }
}

