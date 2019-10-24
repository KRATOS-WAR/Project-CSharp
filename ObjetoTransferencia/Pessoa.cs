using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class Pessoa
    {
        public int IDPessoa { get; set; }
        public string Nome { get; set; }
        public string CpfCnpj { get; set; }
        public PessoaTipo PessoaTipo { get; set; }
    }
}
