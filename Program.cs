using System;

namespace Dados_retangulo
{
    class Program
    {
        static void Main(string[] args)
        {

            //aqui pede para você digitar quantos retangulos você quer
            Console.WriteLine("QUANTOS RETANGULOS SERÃO DIGITADOS:");
            int qtd_retangulos = int.Parse(Console.ReadLine());

            //armazena o tamanho do vetor em variavel
            Retangulo1[] retangulo = new Retangulo1[qtd_retangulos];
            //declara a instancia o vetor do objeto"retangulo" relacionado a classe "Retangulo1"


            for (int i = 0; i < qtd_retangulos; i++)
            {
                // aqui pede para você digitar altura e largura do retangulo
                Console.WriteLine("Digite a Altura e a Largura do Retangulo " + (i + 1) + ":");
                float altura = float.Parse(Console.ReadLine());
                float largura = float.Parse(Console.ReadLine());



                retangulo[i] = new Retangulo1(altura, largura);
            }
            for (int i = 0; i < qtd_retangulos; i++)
            {
                Console.WriteLine();
                Console.WriteLine("**** Dados do " + (i + 1) + " retangulo ****");
                Console.WriteLine(retangulo[i]);
            }
        }
    }
}
