using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_exception.Contas
{
    public class SaldoInsuficienteException : OperacaoFinanceiraException
    {
        public SaldoInsuficienteException()
        {
        }
        public SaldoInsuficienteException(string msg):base(msg)
        {
        }

        public SaldoInsuficienteException(string msg, Exception excecaointerna) : base(msg, excecaointerna)
        {
        }
    }
}
