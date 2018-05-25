namespace Foodtruck.Grafico
{
    partial class ManterLanches
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
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbCodigoBebida = new System.Windows.Forms.MaskedTextBox();
            this.tbNomeBebida = new System.Windows.Forms.MaskedTextBox();
            this.tbQuantidadeBebida = new System.Windows.Forms.MaskedTextBox();
            this.tbNumeroPedido = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(144, 195);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(94, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 15);
            this.label6.TabIndex = 22;
            this.label6.Text = "Valor:";
            // 
            // tbCodigoBebida
            // 
            this.tbCodigoBebida.Location = new System.Drawing.Point(144, 80);
            this.tbCodigoBebida.Name = "tbCodigoBebida";
            this.tbCodigoBebida.Size = new System.Drawing.Size(100, 20);
            this.tbCodigoBebida.TabIndex = 21;
            // 
            // tbNomeBebida
            // 
            this.tbNomeBebida.Location = new System.Drawing.Point(144, 111);
            this.tbNomeBebida.Name = "tbNomeBebida";
            this.tbNomeBebida.Size = new System.Drawing.Size(100, 20);
            this.tbNomeBebida.TabIndex = 20;
            // 
            // tbQuantidadeBebida
            // 
            this.tbQuantidadeBebida.Location = new System.Drawing.Point(144, 162);
            this.tbQuantidadeBebida.Name = "tbQuantidadeBebida";
            this.tbQuantidadeBebida.Size = new System.Drawing.Size(100, 20);
            this.tbQuantidadeBebida.TabIndex = 19;
            // 
            // tbNumeroPedido
            // 
            this.tbNumeroPedido.Location = new System.Drawing.Point(144, 44);
            this.tbNumeroPedido.Name = "tbNumeroPedido";
            this.tbNumeroPedido.Size = new System.Drawing.Size(100, 20);
            this.tbNumeroPedido.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Quantidade:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Pedido Número:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Código lanche:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(80, 261);
            this.btCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(96, 48);
            this.btCancelar.TabIndex = 25;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(201, 261);
            this.btSalvar.Margin = new System.Windows.Forms.Padding(2);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(95, 48);
            this.btSalvar.TabIndex = 24;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            // 
            // ManterLanches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 345);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbCodigoBebida);
            this.Controls.Add(this.tbNomeBebida);
            this.Controls.Add(this.tbQuantidadeBebida);
            this.Controls.Add(this.tbNumeroPedido);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "ManterLanches";
            this.Text = "ManterLanches";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox tbCodigoBebida;
        private System.Windows.Forms.MaskedTextBox tbNomeBebida;
        private System.Windows.Forms.MaskedTextBox tbQuantidadeBebida;
        private System.Windows.Forms.MaskedTextBox tbNumeroPedido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btSalvar;
    }
}