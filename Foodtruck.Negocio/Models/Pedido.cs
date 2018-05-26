using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foodtruck.Negocio.Models
{
    [Table(name: "Pedidos")]
    public class Pedido
    {
        public long Id { get; set; }
        public DateTime DataCompra { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual List<Lanche> Lanches { get; set; }
        public virtual List<Bebida> Bebidas { get; set; }

        public Pedido()
        {
            this.Lanches = new List<Lanche>();
            this.Bebidas = new List<Bebida>();
        }

        public String NomeCliente
        {
            get
            {
                return Cliente.Nome;
            }
        }

        public Decimal Valor
        {
            get
            {
                return ValorTotal();
            }
        }

        public Decimal ValorTotal()
        {
            Decimal totalLanches = this.Lanches.Sum(m => m.Valor);
            Decimal totalBebidas = this.Bebidas.Sum(m => m.Valor);
            return totalLanches + totalBebidas;
        }

        public void AdicionarLanche(Lanche lanche)
        {
            this.Lanches.Add(lanche);
        }

        public void AdicionarBebida(Bebida bebida)
        {
            this.Bebidas.Add(bebida);
        }

    }
}
