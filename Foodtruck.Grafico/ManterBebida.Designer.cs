namespace Foodtruck.Grafico
{
    partial class ManterBebida
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTamanhoBebida = new System.Windows.Forms.MaskedTextBox();
            this.tbNomeBebida = new System.Windows.Forms.MaskedTextBox();
            this.tbCodigoBebida = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbValorBebida = new System.Windows.Forms.MaskedTextBox();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código bebida:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tamanho:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nome:";
            // 
            // tbTamanhoBebida
            // 
            this.tbTamanhoBebida.Location = new System.Drawing.Point(108, 118);
            this.tbTamanhoBebida.Name = "tbTamanhoBebida";
            this.tbTamanhoBebida.Size = new System.Drawing.Size(100, 20);
            this.tbTamanhoBebida.TabIndex = 6;
            // 
            // tbNomeBebida
            // 
            this.tbNomeBebida.Location = new System.Drawing.Point(108, 93);
            this.tbNomeBebida.Name = "tbNomeBebida";
            this.tbNomeBebida.Size = new System.Drawing.Size(100, 20);
            this.tbNomeBebida.TabIndex = 8;
            // 
            // tbCodigoBebida
            // 
            this.tbCodigoBebida.Location = new System.Drawing.Point(108, 62);
            this.tbCodigoBebida.Name = "tbCodigoBebida";
            this.tbCodigoBebida.Size = new System.Drawing.Size(100, 20);
            this.tbCodigoBebida.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Valor:";
            // 
            // tbValorBebida
            // 
            this.tbValorBebida.Location = new System.Drawing.Point(108, 177);
            this.tbValorBebida.Name = "tbValorBebida";
            this.tbValorBebida.Size = new System.Drawing.Size(100, 20);
            this.tbValorBebida.TabIndex = 11;
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(72, 243);
            this.btCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(96, 48);
            this.btCancelar.TabIndex = 13;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(193, 243);
            this.btSalvar.Margin = new System.Windows.Forms.Padding(2);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(95, 48);
            this.btSalvar.TabIndex = 12;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "ml";
            // 
            // ManterBebida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 302);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.tbValorBebida);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbCodigoBebida);
            this.Controls.Add(this.tbNomeBebida);
            this.Controls.Add(this.tbTamanhoBebida);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ManterBebida";
            this.Text = "ManterBebida";
            this.Shown += new System.EventHandler(this.ManterBebida_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox tbTamanhoBebida;
        private System.Windows.Forms.MaskedTextBox tbNomeBebida;
        private System.Windows.Forms.MaskedTextBox tbCodigoBebida;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox tbValorBebida;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Label label3;
    }
}