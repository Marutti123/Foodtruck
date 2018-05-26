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
    public partial class TelaRemoverLanchePedido : Form
    {
        /*public TelaRemoverLanchePedido()
        {
            InitializeComponent();
        }*/
        private Int64 Id;
        private Pedido pedido;

        public TelaRemoverLanchePedido(long Id)
        {
            this.Id = Id;
            InitializeComponent();
            pedido = Util.Gerenciador.BuscaPedidoPorId(Id);
            cbxLanches.DataSource = pedido.Lanches;
            cbxLanches.DisplayMember = "Nome";
            cbxLanches.ValueMember = "Id";
        }

        private void btnRemover_Click_1(object sender, EventArgs e)
        {
            try
            {
                Pedido pedido = Util.Gerenciador.BuscaPedidoPorId(Id);
                Int64 lancheId = (Int64)cbxLanches.SelectedValue;
                Util.Gerenciador.RemoverLancheDoPedido(pedido, lancheId);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TelaRemoverLanchePedido_Shown(object sender, EventArgs e)
        {
            if (pedido.Lanches.Count <= 0)
            {
                MessageBox.Show("O pedido não possui nenhum lanche");
                this.Close();
            }
        }
    }
}
