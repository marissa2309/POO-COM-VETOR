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
