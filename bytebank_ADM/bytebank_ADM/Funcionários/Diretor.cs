using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionários
{
    public class Diretor : FuncionarioAutenticavel
    {

        public override double Bonificar()
        {
            return this.Salario * 0.5;
        }
        public Diretor(string cpf) : base(cpf, 5000)
        {

        }

        public override void Aumento()
        {
            this.Salario += this.Salario * 0.15;
        }

    }
}
