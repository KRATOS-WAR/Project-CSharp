using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class Cliente
    {
        public int IDPessoacliente { get; set; }
        public Pessoa Pessoa { get; set; }
        public Pessoa Nome { get; set; }
        public Pessoa CpfCnpj { get; set; }
        public PessoaTipo IDPessoaTipo { get; set; }
    }
}
