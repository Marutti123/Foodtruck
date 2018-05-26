using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Foodtruck.Negocio.Models;
using Foodtruck.Negocio;

namespace Foodtruck.Grafico
{
    public partial class ManterBebida : Form
    {
        public Bebida BebidaSelecionada { get; set; }

        public ManterBebida()
        {
            InitializeComponent();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            Bebida bebida = new Bebida();
            //bebida.Id = Convert.ToInt64(tbCodigoBebida.Text);
            if (Int64.TryParse(tbCodigoBebida.Text, out long value))
            {
                bebida.Id = value;
            }
            else
            {
                bebida.Id = -1;
                //passa indentificador com valor negativo se não conseguir converter
            }
            bebida.Nome = tbNomeBebida.Text;
            bebida.Tamanho = Convert.ToSingle(tbTamanhoBebida.Text);
            bebida.Valor = Convert.ToDecimal(tbValorBebida.Text);

            Validacao validacao;
            if (BebidaSelecionada != null)
            {
                validacao = Program.Gerenciador.CadastraBebida(BebidaSelecionada);
            }
            else
            {
                validacao = Program.Gerenciador.CadastraBebida(bebida);
            }

            if (!validacao.Valido)
            {
                String mensagemValidacao = "";
                foreach (var chave in validacao.Mensagens.Keys)
                {
                    String msg = validacao.Mensagens[chave];
                    mensagemValidacao += msg;
                    mensagemValidacao += Environment.NewLine;
                }
                MessageBox.Show(mensagemValidacao);
            }
            else
            {
                MessageBox.Show("Bebida salva com sucesso");
            }

            this.Close();
        }


        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManterBebida_Shown(object sender, EventArgs e)
        {
            if (BebidaSelecionada != null)
            {
                this.tbCodigoBebida.Text = BebidaSelecionada.Id.ToString();
                this.tbNomeBebida.Text = BebidaSelecionada.Nome;
                this.tbTamanhoBebida.Text = Convert.ToString(BebidaSelecionada.Tamanho);
                this.tbValorBebida.Text = Convert.ToString(BebidaSelecionada.Valor);
            }
        }
    }
}
