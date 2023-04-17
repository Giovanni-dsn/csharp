using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.titular
{
    public class Cliente
    {
        public static int TotalClientes { get; private set; }
        public string nome;
        public string cpf;

        public Cliente()
        {
            TotalClientes++;
        }
    }
}
