using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_exception.Contas
{
    public class OperacaoFinanceiraException : Exception
    {
        public OperacaoFinanceiraException()
        {
        }

        public OperacaoFinanceiraException(string msg):base(msg)
        {
        }

        public OperacaoFinanceiraException(string msg, Exception excecaointerna):base(msg, excecaointerna)
        {
        }
    }
}
