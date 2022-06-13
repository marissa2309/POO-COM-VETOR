using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Dados_funcionario
{
    //classe onde está declarada as variaveis
    class Dados
    {
        public string Nome { get; set; }
        public double SalarioB { get; set; }
        public double Imposto { get; set; }



        public Dados(string nome, double salariob, double imposto)
        {
            Nome = nome;
            SalarioB = salariob;
            Imposto = imposto;
        }
        //método para calcular o salarioL
        public double SalarioL()
        {
            return SalarioB - Imposto;
        }
        //método para mostrar o quanto será o aumento de salário
        public void AumentarSlr(double aumento)
        {
            SalarioB = SalarioB + (SalarioB * aumento / 100);
        }
        //impressão padrão
        public override string ToString()
        {
            return "Funcionário: "
            + Nome.ToUpper()
            + ",\n R$ "
            + SalarioL().ToString("F2");
        }
    }
}
