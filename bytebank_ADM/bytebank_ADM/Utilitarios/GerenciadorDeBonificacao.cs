using bytebank_ADM.Funcionários;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Utilitarios
{
    public class GerenciadorDeBonificacao
    {
        public double TotalBonificacoes { get; private set; }

        public void Registrar(Funcionario funcionario)
        {
            this.TotalBonificacoes += funcionario.Bonificar();
        }
    }
}
