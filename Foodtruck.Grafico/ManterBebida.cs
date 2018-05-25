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
        private readonly object bebida;

        public Bebida BebidaSelecionada { get; set; }

        public ManterBebida()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

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

            Gerenciador gerenciador = new Gerenciador();
            Validacao resultado = gerenciador.CadastraBebida(bebida);

            /*if (resultado.Valido)
            {
                MessageBox.Show("Deu certo");
            }
            else
            {
                String msg = "";

                foreach (KeyValuePair<string, string> err in resultado.Mensagens)
                    msg += err.Value + "\n";

                MessageBox.Show(msg);
            }*/

            Validacao validacao;
            if (BebidaSelecionada == null)
            {
                validacao = Program.Gerenciador.CadastraBebida(BebidaSelecionada);
            }
            else
            {
                validacao = Program.Gerenciador.CadastraBebida(BebidaSelecionada);
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
                MessageBox.Show("Cliente salvo com sucesso");
            }

            this.Close();

            //////////////////////////////////////////////////

            /*Pedido pedido = new Pedido();

            Bebida bebida = gerenciador.TodasAsBebidas().First();

            pedido.Bebidas.Add(bebida);

            gerenciador.CadastraPedido(pedido);
            */
        }


        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManterCliente_Shown(object sender, EventArgs e)
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
