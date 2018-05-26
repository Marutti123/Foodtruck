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
    public partial class TelaCadastrarPedido : Form
    {
        public TelaCadastrarPedido()
        {
            InitializeComponent();
            ConfigurarCombobox();

            tbData.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void ConfigurarCombobox()
        {
            cbCliente.DisplayMember = "Nome";
            cbCliente.ValueMember = "Id";
        }

        private void CarregarComboboxClientes()
        {
            List<Cliente> clientes = Util.Gerenciador.TodosOsClientes();
            cbCliente.DataSource = clientes;
        }

        private void TelaCadastrarPedido_Shown(object sender, EventArgs e)
        {
            List<Cliente> clientes = Program.Gerenciador.TodosOsClientes();
            cbCliente.DataSource = clientes;
            cbCliente.DisplayMember = "Nome";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSalvarPedido_Click(object sender, EventArgs e)
        {
            try
            {
                Pedido pedido = new Pedido();
                pedido.Id = -1;
                pedido.DataCompra = DateTime.ParseExact(tbData.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                Int64 idCliente = (Int64)cbCliente.SelectedValue;
                pedido.Cliente = Util.Gerenciador.BuscaClientePorId(idCliente);
                Util.Gerenciador.CadastraPedido(pedido);
                MessageBox.Show("Pedido cadastrado com sucesso!");

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tbData_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbData.Text))
                return;

            DateTime dataPedido;
            if (!DateTime.TryParseExact(tbData.Text, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out dataPedido))
            {
                MessageBox.Show("A data deve estar no formato DD/MM/AAAA");
                tbData.Text = "";
            }
        }
    }
}
