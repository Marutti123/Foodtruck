using Foodtruck.Negocio.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foodtruck.Grafico
{
    public partial class TelaAdicionarLanchePedido : Form
    {
        public Int64 PedidoId { get; set; }

        public TelaAdicionarLanchePedido()
        {
            InitializeComponent();

            cbxLanches.DisplayMember = "Nome";
            cbxLanches.ValueMember = "Id";

            List<Lanche> lanches = Util.Gerenciador.TodosOsLanches();
            cbxLanches.DataSource = lanches;
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdicionar_Click_1(object sender, EventArgs e)
        {
            try
            {
                Pedido pedido = Util.Gerenciador.BuscaPedidoPorId(PedidoId);
                Int64 lancheId = (Int64)cbxLanches.SelectedValue;
                Lanche lanche = Util.Gerenciador.BuscaLanchePorId(lancheId);
                Util.Gerenciador.AdicionarLancheAoPedido(pedido, lanche);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
