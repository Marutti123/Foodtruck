namespace Foodtruck.Grafico
{
    partial class TelaListaPedidos
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lanches = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bebidas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataCompra,
            this.codPedido,
            this.cliente,
            this.lanches,
            this.bebidas,
            this.valorTotal});
            this.dataGridView1.Location = new System.Drawing.Point(36, 147);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(664, 294);
            this.dataGridView1.TabIndex = 8;
            // 
            // dataCompra
            // 
            this.dataCompra.HeaderText = "Data de compra";
            this.dataCompra.Name = "dataCompra";
            // 
            // codPedido
            // 
            this.codPedido.HeaderText = "Código Pedido";
            this.codPedido.Name = "codPedido";
            // 
            // cliente
            // 
            this.cliente.HeaderText = "Cliente";
            this.cliente.Name = "cliente";
            // 
            // lanches
            // 
            this.lanches.HeaderText = "Lanches";
            this.lanches.Name = "lanches";
            // 
            // bebidas
            // 
            this.bebidas.HeaderText = "Bebidas";
            this.bebidas.Name = "bebidas";
            // 
            // valorTotal
            // 
            this.valorTotal.HeaderText = "Valor Total";
            this.valorTotal.Name = "valorTotal";
            // 
            // TelaListaPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 453);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TelaListaPedidos";
            this.Text = "TelaListaPedidos";
            this.Load += new System.EventHandler(this.TelaListaPedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn codPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn lanches;
        private System.Windows.Forms.DataGridViewTextBoxColumn bebidas;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorTotal;
    }
}