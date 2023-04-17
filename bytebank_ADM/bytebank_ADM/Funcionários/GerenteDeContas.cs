using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionários
{
    public class GerenteDeContas : FuncionarioAutenticavel
    {
        public GerenteDeContas(string cpf) : base(cpf, 4000)
        {

        }

        public override void Aumento()
        {
            this.Salario *= 1.05;
        }
        public override double Bonificar()
        {
            return this.Salario * 0.25;
        }
    }
}
