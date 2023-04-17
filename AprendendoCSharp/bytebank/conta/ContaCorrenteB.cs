using bytebank.titular;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.conta
{
    public class ContaCorrenteB
    {
        public int nmr_agencia;
        public Cliente titular;
        public string conta;
        public double saldo;

        public ContaCorrenteB(Cliente pessoa, int nAgencia, string contaP, double saldoP)
        {
            Cliente titular = pessoa;
            nmr_agencia = nAgencia;
            conta = contaP;
            saldo = saldoP;
        }
    }
}
