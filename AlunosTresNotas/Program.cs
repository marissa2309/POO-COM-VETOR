using System;

namespace AlunosTresNotas
{

    class AlunosTresNotas
    {

        static void Main(string[] args)
        {
            // aqui é para você informar de quantos alunos você quer saber as notas
            Console.WriteLine("As notas de quantos alunos voce quer ? ");
            int qtdAlunos = int.Parse(Console.ReadLine());

            //armazena o tamanho do vetor em variavel
            Alunos[] alunos = new Alunos[qtdAlunos];

            for (int i = 0; i < qtdAlunos; i++)
            {

                Console.WriteLine(" ************DADOS DO " + (i + 1) + "° ALUNO ***********");
                Console.WriteLine("Digite o nome do aluno : ");//pede para você digitar o nome do aluno
                string nome = Console.ReadLine();//guarda o nome do aluno

                Console.WriteLine("Digite a nota do 1º trimestre : (limite maximo da nota é 30)");//pede para digitar a nota do 1º trimestre
                double nota1 = double.Parse(Console.ReadLine());//guarda a nota do 1º trimestre

                while (nota1 > 30)
                {

                    if (nota1 > 30)
                    {
                        Console.WriteLine("Nota inválida, nota máxima é 30, digite novamente! ");
                        Console.WriteLine("Digite a nota do 1º trimestre : (limite maximo da nota é 30)");
                        nota1 = double.Parse(Console.ReadLine());
                    }
                }

                Console.WriteLine("Digite a nota do 2º trimestre : (limite maximo da nota é 35)");//pede para digitar a nota do 2º trimestre
                double nota2 = double.Parse(Console.ReadLine());//guarda a nota do 2º trimestre

                while (nota2 > 35)
                {

                    if (nota2 > 35)
                    {
                        Console.WriteLine("Nota inválida, nota máxima é 35, digite novamente! ");
                        Console.WriteLine("Digite a nota do 2º trimestre : (limite maximo da nota é 35)");
                        nota2 = double.Parse(Console.ReadLine());
                    }
                }

                Console.WriteLine("Digite a nota do 3º trimestre : (limite maximo da nota é 35)");//pede para digitar a nota do 3º trimestre
                double nota3 = double.Parse(Console.ReadLine());//guarda a nota do 3º trimestre

                while (nota3 > 35)
                {
                   
                    if (nota3 > 35)
                    {
                        Console.WriteLine("Nota inválida, nota máxima é 35, digite novamente! ");
                        Console.WriteLine("Digite a nota do 3º trimestre : (limite maximo da nota é 35)");
                        nota3 = double.Parse(Console.ReadLine());
                    }
                }
                Console.WriteLine();
                Console.WriteLine();

                alunos[i] = new Alunos(nome, nota1, nota2, nota3);
            }

            for (int i = 0; i < qtdAlunos; i++)
            {
                Console.WriteLine();
                Console.WriteLine(" ************NOTA FINAL DO " + (i + 1) + "° ALUNO ***********");//mostra a nota  final do aluno
                Console.WriteLine();

                Console.WriteLine();
                Console.WriteLine(alunos[i]);
                Console.WriteLine();

            }

        }
    }
}