using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class Cliente
    {
        public int IDCliente { get; set; }
        public string Nome { get; set; }
        public string CpfCnpj { get; set; }
        public string RG { get; set; }
        public string Endereco { get; set; }
        public string Celular { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}
