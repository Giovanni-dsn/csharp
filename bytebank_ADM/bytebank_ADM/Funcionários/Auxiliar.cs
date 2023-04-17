using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionários
{
    public class Auxiliar:Funcionario
    {
        public Auxiliar(string cpf) : base(cpf, 2000)
        {

        }
        public override void Aumento()
        {
            this.Salario *= 1.10;
        }
        public override double Bonificar()
        {
            return this.Salario * 0.20;
        }
    }
}
