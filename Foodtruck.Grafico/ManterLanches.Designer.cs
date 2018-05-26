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
            this.tbValorLanche = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbCodigoLanche = new System.Windows.Forms.MaskedTextBox();
            this.tbNomeLanche = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbValorLanche
            // 
            this.tbValorLanche.Location = new System.Drawing.Point(144, 195);
            this.tbValorLanche.Name = "tbValorLanche";
            this.tbValorLanche.Size = new System.Drawing.Size(100, 20);
            this.tbValorLanche.TabIndex = 23;
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
            // tbCodigoLanche
            // 
            this.tbCodigoLanche.Location = new System.Drawing.Point(144, 80);
            this.tbCodigoLanche.Name = "tbCodigoLanche";
            this.tbCodigoLanche.Size = new System.Drawing.Size(100, 20);
            this.tbCodigoLanche.TabIndex = 21;
            // 
            // tbNomeLanche
            // 
            this.tbNomeLanche.Location = new System.Drawing.Point(144, 111);
            this.tbNomeLanche.Name = "tbNomeLanche";
            this.tbNomeLanche.Size = new System.Drawing.Size(100, 20);
            this.tbNomeLanche.TabIndex = 20;
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
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
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
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // ManterLanches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 345);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.tbValorLanche);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbCodigoLanche);
            this.Controls.Add(this.tbNomeLanche);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "ManterLanches";
            this.Text = "ManterLanches";
            this.Shown += new System.EventHandler(this.ManterLanche_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox tbValorLanche;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox tbCodigoLanche;
        private System.Windows.Forms.MaskedTextBox tbNomeLanche;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btSalvar;
    }
}