using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionários
{
    public class Designer:Funcionario
    {
        public Designer(string cpf):base(cpf,3000)
        {
            
        }
        public override void Aumento()
        {
            this.Salario *= 1.11;
        }
        public override double Bonificar()
        {
            return this.Salario * 0.17;
        }
    }
}
