﻿using Foodtruck.Negocio.Models;
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
    public partial class TelaAdicionarBebidaPedido : Form
    {
        /*public TelaAdicionarBebidaPedido()
        {
            InitializeComponent();
        }*/
        public Int64 PedidoId { get; set; }

		//Adiciona pedido
        public TelaAdicionarBebidaPedido()
        {
            InitializeComponent();
            ConfigurarCombobox();
        }

        private void ConfigurarCombobox()
        {
            cbBebidas.DisplayMember = "Nome";
            cbBebidas.ValueMember = "Id";
        }

        private void CarregarCombobox()
        {
            List<Bebida> bebidas = Util.Gerenciador.TodasAsBebidas();
            cbBebidas.DataSource = bebidas;
            if(bebidas.Count>0)
            {
                cbBebidas.SelectedIndex = 0;
            }
        }

        private void TelaAdicionarBebidaPedido_Load(object sender, EventArgs e)
        {
            CarregarCombobox();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                Pedido pedido = Util.Gerenciador.BuscaPedidoPorId(PedidoId);
                Int64 bebidaId = (Int64)cbBebidas.SelectedValue;
                Bebida bebida = Util.Gerenciador.BuscaBebidaPorId(bebidaId);
                Util.Gerenciador.AdicionarBebidaAoPedido(pedido, bebida);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
