namespace Foodtruck.Grafico
{
    partial class TelaListarPedidos
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
            this.dgPedidos = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_Gambi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgPedidos
            // 
            this.dgPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Data,
            this.cl_cliente,
            this.Valor,
            this.cl_Gambi});
            this.dgPedidos.Location = new System.Drawing.Point(125, 12);
            this.dgPedidos.Name = "dgPedidos";
            this.dgPedidos.Size = new System.Drawing.Size(718, 304);
            this.dgPedidos.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 55);
            this.button1.TabIndex = 2;
            this.button1.Text = "Adicionar Lanche";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.tbLanche_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(878, 200);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 57);
            this.button2.TabIndex = 3;
            this.button2.Text = "Remover Bebida";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnRemoverBebida_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(878, 106);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 55);
            this.button3.TabIndex = 4;
            this.button3.Text = "Adicionar Bebida";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.tbAdicionarBebida_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(23, 204);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 53);
            this.button4.TabIndex = 5;
            this.button4.Text = "Remover Lanche";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btnRemoverLanche_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(322, 350);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 61);
            this.button5.TabIndex = 6;
            this.button5.Text = "Adicionar Pedido";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.btAdicionar_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(466, 350);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 61);
            this.button6.TabIndex = 7;
            this.button6.Text = "Detalhes do Pedido";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.tbDetalhe_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(605, 350);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 61);
            this.button7.TabIndex = 8;
            this.button7.Text = "Atualizar";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // Data
            // 
            this.Data.DataPropertyName = "DataCompra";
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            // 
            // cl_cliente
            // 
            this.cl_cliente.DataPropertyName = "NomeCliente";
            this.cl_cliente.HeaderText = "Cliente";
            this.cl_cliente.Name = "cl_cliente";
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "Valor";
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            // 
            // cl_Gambi
            // 
            this.cl_Gambi.DataPropertyName = "Cliente";
            this.cl_Gambi.HeaderText = "Column1";
            this.cl_Gambi.Name = "cl_Gambi";
            this.cl_Gambi.Visible = false;
            // 
            // TelaListarPedidos
            // 
            this.ClientSize = new System.Drawing.Size(989, 528);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgPedidos);
            this.Name = "TelaListarPedidos";
            this.Load += new System.EventHandler(this.ListarPedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPedidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnRemoverLanche;
        private System.Windows.Forms.Button btnRemoverBebida;
        private System.Windows.Forms.Button tbLanche;
        private System.Windows.Forms.Button tbAdicionarBebida;
        private System.Windows.Forms.Button tbDetalhe;
        private System.Windows.Forms.Button btAtualizar;
        private System.Windows.Forms.Button btAdicionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn codPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorTotal;
        private System.Windows.Forms.DataGridView dgPedidos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_Gambi;
    }
}