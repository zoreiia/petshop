namespace petshop
{
    partial class verpets
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewpets2 = new System.Windows.Forms.DataGridView();
            this.buttonpesquisar = new System.Windows.Forms.Button();
            this.textBoxPESQUISA = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewpets2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewpets2
            // 
            this.dataGridViewpets2.AllowUserToAddRows = false;
            this.dataGridViewpets2.AllowUserToDeleteRows = false;
            this.dataGridViewpets2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewpets2.Location = new System.Drawing.Point(12, 73);
            this.dataGridViewpets2.Name = "dataGridViewpets2";
            this.dataGridViewpets2.ReadOnly = true;
            this.dataGridViewpets2.Size = new System.Drawing.Size(901, 428);
            this.dataGridViewpets2.TabIndex = 1;
            this.dataGridViewpets2.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // buttonpesquisar
            // 
            this.buttonpesquisar.Font = new System.Drawing.Font("Microsoft Uighur", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.buttonpesquisar.Location = new System.Drawing.Point(759, 12);
            this.buttonpesquisar.Name = "buttonpesquisar";
            this.buttonpesquisar.Size = new System.Drawing.Size(154, 55);
            this.buttonpesquisar.TabIndex = 2;
            this.buttonpesquisar.Text = "Pesquisar";
            this.buttonpesquisar.UseVisualStyleBackColor = true;
            this.buttonpesquisar.Click += new System.EventHandler(this.buttonpesquisar_Click);
            // 
            // textBoxPESQUISA
            // 
            this.textBoxPESQUISA.Location = new System.Drawing.Point(403, 33);
            this.textBoxPESQUISA.Name = "textBoxPESQUISA";
            this.textBoxPESQUISA.Size = new System.Drawing.Size(314, 20);
            this.textBoxPESQUISA.TabIndex = 3;
            // 
            // verpets
            // 
            this.ClientSize = new System.Drawing.Size(925, 513);
            this.Controls.Add(this.textBoxPESQUISA);
            this.Controls.Add(this.buttonpesquisar);
            this.Controls.Add(this.dataGridViewpets2);
            this.Controls.Add(this.button1);
            this.Name = "verpets";
            this.Text = "Pesquisar Pets";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewpets2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonmenu;
        private System.Windows.Forms.DataGridView dataGridViewlistapets;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewpets2;
        private System.Windows.Forms.Button buttonpesquisar;
        private System.Windows.Forms.TextBox textBoxPESQUISA;
    }
}