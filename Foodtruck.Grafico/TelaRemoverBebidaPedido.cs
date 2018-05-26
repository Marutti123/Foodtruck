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
    public partial class TelaRemoverBebidaPedido : Form
    {
        private Int64 Id;
        private Pedido pedido;
        /*
        public TelaRemoverBebidaPedido()
        {
            InitializeComponent();
        }*/
        public TelaRemoverBebidaPedido(long Id)
        {
            this.Id = Id;
            InitializeComponent();
            pedido = Util.Gerenciador.BuscaPedidoPorId(Id);
            cbxBebidas.DataSource = pedido.Bebidas;
            cbxBebidas.DisplayMember = "Nome";
            cbxBebidas.ValueMember = "Id";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Pedido pedido = Util.Gerenciador.BuscaPedidoPorId(Id);
                Int64 bebidaId = (Int64)cbxBebidas.SelectedValue;
                Util.Gerenciador.RemoverBebidaDoPedido(pedido, bebidaId);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TelaRemoverBebidaPedido_Shown(object sender, EventArgs e)
        {
            if (pedido.Bebidas.Count <= 0)
            {
                MessageBox.Show("O pedido não possui nenhuma bebida");
                this.Close();
            }
        }
    }
}
