using Foodtruck.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foodtruck.Grafico
{
    class Util
    {
        public static Gerenciador Gerenciador = new Gerenciador();

        public static object GetCellValueFromColumnHeader(DataGridViewCellCollection CellCollection, string propertyName)
        {
            return CellCollection.Cast<DataGridViewCell>().First(c => c.OwningColumn.DataPropertyName == propertyName).Value;
        }
    }
}
