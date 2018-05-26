namespace Foodtruck.Grafico
{
    partial class TelaListaBebidas
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
            this.btAdicionar = new System.Windows.Forms.Button();
            this.btRemover = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            this.dgBebidas = new System.Windows.Forms.DataGridView();
            this.tbCodigoBebida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbNomeBebida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbTamanhoBebida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbValorBebida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgBebidas)).BeginInit();
            this.SuspendLayout();
            // 
            // btAdicionar
            // 
            this.btAdicionar.Location = new System.Drawing.Point(13, 13);
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btAdicionar.TabIndex = 0;
            this.btAdicionar.Text = "Adicionar";
            this.btAdicionar.UseVisualStyleBackColor = true;
            this.btAdicionar.Click += new System.EventHandler(this.btAdicionar_Click);
            // 
            // btRemover
            // 
            this.btRemover.Location = new System.Drawing.Point(95, 12);
            this.btRemover.Name = "btRemover";
            this.btRemover.Size = new System.Drawing.Size(75, 23);
            this.btRemover.TabIndex = 1;
            this.btRemover.Text = "Remover";
            this.btRemover.UseVisualStyleBackColor = true;
            this.btRemover.Click += new System.EventHandler(this.btRemover_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.Location = new System.Drawing.Point(177, 12);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(75, 23);
            this.btAlterar.TabIndex = 2;
            this.btAlterar.Text = "Alterar";
            this.btAlterar.UseVisualStyleBackColor = true;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // dgBebidas
            // 
            this.dgBebidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBebidas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tbCodigoBebida,
            this.tbNomeBebida,
            this.tbTamanhoBebida,
            this.tbValorBebida});
            this.dgBebidas.Location = new System.Drawing.Point(13, 43);
            this.dgBebidas.Name = "dgBebidas";
            this.dgBebidas.Size = new System.Drawing.Size(593, 292);
            this.dgBebidas.TabIndex = 3;
            // 
            // tbCodigoBebida
            // 
            this.tbCodigoBebida.DataPropertyName = "Id";
            this.tbCodigoBebida.HeaderText = "Código Bebida";
            this.tbCodigoBebida.Name = "tbCodigoBebida";
            // 
            // tbNomeBebida
            // 
            this.tbNomeBebida.DataPropertyName = "Nome";
            this.tbNomeBebida.HeaderText = "Nome";
            this.tbNomeBebida.Name = "tbNomeBebida";
            // 
            // tbTamanhoBebida
            // 
            this.tbTamanhoBebida.DataPropertyName = "Tamanho";
            this.tbTamanhoBebida.HeaderText = "Tamanho";
            this.tbTamanhoBebida.Name = "tbTamanhoBebida";
            // 
            // tbValorBebida
            // 
            this.tbValorBebida.DataPropertyName = "Valor";
            this.tbValorBebida.HeaderText = "Valor";
            this.tbValorBebida.Name = "tbValorBebida";
            // 
            // TelaListaBebidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 358);
            this.Controls.Add(this.dgBebidas);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.btRemover);
            this.Controls.Add(this.btAdicionar);
            this.Name = "TelaListaBebidas";
            this.Text = "TelaListaBebidas";
            this.Load += new System.EventHandler(this.TelaListaBebidas_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgBebidas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btAdicionar;
        private System.Windows.Forms.Button btRemover;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.DataGridView dgBebidas;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbCodigoBebida;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbNomeBebida;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbTamanhoBebida;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbValorBebida;
    }
}