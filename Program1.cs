//using System;

//namespace Dados_funcionario
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {

//            float aumento;
//            Funcionario a = new Funcionario();

//            Console.WriteLine("NOME: ");
//            a.nome = Console.ReadLine();
//            Console.WriteLine("SALÁRIO BRUTO: ");
//            a.salarioBruto = double.Parse(Console.ReadLine());
//            Console.WriteLine("QUAL O IMPOSTO: ");
//            a.imposto = double.Parse(Console.ReadLine());

//            Console.WriteLine("NOME: " + a.nome + " SALÁRIO BRUTO: " + a.salarioBruto + " SALÁRIO LIQUIDO: " + (a.salarioBruto - a.imposto));

//            Console.WriteLine("QUANTO VAI SER SEU AUMENTO EM % SOBRE O SALÁRIO BRUTO: ");
//            aumento = float.Parse(Console.ReadLine());

//            aumento = aumento / 100;

//            Console.WriteLine("O SEU SALÁRIO COM O AUMENTO É DE: " + (a.salarioBruto +(a.salarioBruto * aumento)));

//            Console.WriteLine();
//            Console.WriteLine("Pressione ENTER encerrar");
//            Console.ReadLine();
//        }
//    }
//}

using System;

namespace Dados_funcionario
{
    class Program
    {
       
       
            static void Main(string[] args)
            {
                Console.WriteLine("Quantos funcionários deseja digitar? ");//pergunta a quantidade de funcionarios
                int qtd_f = int.Parse(Console.ReadLine());//guarda a quantidade de funcionarios


                // armazena o tamanho do vetor em variavel
                Dados[] dados = new Dados[qtd_f];



                for (int i = 0; i < qtd_f; i++)
                {
                    Console.WriteLine("NOME: ");//pergunta o nome 
                    String nome = Console.ReadLine();//guarda o nome digitado
                    Console.WriteLine("SALÁRIO BRUTO: ");//pergunta o salario bruto
                    double salariob = double.Parse(Console.ReadLine());//guarda o salario bruto
                    Console.WriteLine("IMPOSTO: ");
                    double imposto = double.Parse(Console.ReadLine());



                    dados[i] = new Dados(nome, salariob, imposto);

                    Console.WriteLine(dados[i]);//mostra os dados
                    Console.WriteLine();
                    Console.WriteLine("Quanto vai ser o aumento em % sobre o salário bruto: ");
                    dados[i].AumentarSlr(double.Parse(Console.ReadLine()));
                    Console.WriteLine(dados[i]);
                }
            }
    }
}
