using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class Produto
    {
        public int IDProduto { get; set; }
        public int CodigoProduto { get; set; }
        public string Descricao { get; set; }
        public string MarcaFabricante { get; set; }
        public string UnidadeMedida { get; set; }
        public decimal PrecoUnitario { get; set; }
    }
}
