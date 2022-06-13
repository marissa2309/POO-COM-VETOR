using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados_retangulo
{
    class Retangulo1
    {
        public double Largura { get; set; }
        public double Altura { get; set; }

        public Retangulo1(double largura, double altura)
        {
            Largura = largura;
            Altura = altura;
        }

        public double area()
        {
            return Largura * Altura;
        }

        public double perimetro()
        {
            return 2 * (Largura + Altura);
        }

        public double diagonal()
        {
            return (double)Math.Sqrt((Largura * Largura) + (Altura * Altura));
        }
        //impressão padrão
        public override string ToString()
        {
            return "\n AREA: "
                + area()
                + "\n PERIMETRO: "
                + perimetro()
                + "\n DIAGONAL: "
                + diagonal();

        }
    }
}
