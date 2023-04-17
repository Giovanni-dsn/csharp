using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDeClasse.Retangulo
{
    public class Retangulo
    {
        public double Altura { get; set; }

        public double Largura { get; set; }

        public double GetArea()
        {
            double area = this.Altura * this.Largura;
            return area;
        }
    }
}
