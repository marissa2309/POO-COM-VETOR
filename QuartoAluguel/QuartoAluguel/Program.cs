//using System;

//namespace QuartoAluguel
//{
//    class Programa
//    {

//        static void Main(string[] args)
//        {
//            Cliente A = new Cliente();
//            char Alugar;

//            Console.WriteLine("******* RELATÓRIO DA HOSPEDAGEM *******");
//            Console.WriteLine("NOME: ");
//            A.Nome = Console.ReadLine();
//            Console.WriteLine("CPF: ");
//            A.CPF = Console.ReadLine();
//            Console.WriteLine("TELEFONE: ");
//            A.Telefone = Console.ReadLine();
//            Console.WriteLine("ENDEREÇO: ");
//            A.Endereco = Console.ReadLine();
//            Console.WriteLine("DATA DE NASCIMENTO: ");
//            A.DataNasc = Console.ReadLine();
//            Console.WriteLine("EMAIL: ");
//            A.email = Console.ReadLine();

//            Console.WriteLine(); Console.WriteLine();
//            Console.WriteLine("POR QUANTOS MESES DESEJA ALUGAR O QUARTO?: ");
//            A.Periodo = float.Parse(Console.ReadLine());
//            Console.WriteLine("QUAL O VALOR DO QUARTO POR MÊS: " + A.ValorQuarto);



//            Console.WriteLine("DESEJA ALUGAR O QUARTO S/N: ");
//            Alugar = char.Parse(Console.ReadLine());


//            if(Alugar == 's' || Alugar == 'S')
//            {
//                Console.WriteLine(A);
//            }
//            else
//            {
//                Console.WriteLine(" SE PRECISAR DE ALGUMA COISA ESTAMOS A SUA DISPOSIÇÃO ");
//            }


//        }
//    }
//}

using System;

namespace QuartoAluguel
{
    class Principal
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DIGITE A QUANTIDADE DE QUARTOS DISPONIVEIS: ");// pede para você informar a quantidade de quartos
            int qtd_quartos = int.Parse(Console.ReadLine());//guarda a quantidade de quartos
            //armazena o tamanho do vetor em variavel
            Cliente[] quarto = new Cliente[qtd_quartos];//declara a instancia o vetor do objeto "quarto" relacionado a classe "cliente"
            Quartos[]quartos = new Quartos[qtd_quartos];//declara a instancia o vetor do objeto "quartos" relacionado a classe "Quartos"
            

            //inicia a "manipulação" ou navegação entre os indices do vetor 
            //primeiro parametro:
            //inicializa e atribui o valor ZERO (para acessar o indice ZERO - primeira linha )
            for (int i = 0; i < qtd_quartos; i++)
            {
                Console.WriteLine();
                Console.WriteLine("*** DADOS DO HÓSPEDE " + (i + 1));
                Console.WriteLine("NOME....: ");
                string nome = Console.ReadLine();
                Console.WriteLine("CPF: ");
                string cpf = Console.ReadLine();
                Console.WriteLine("TELEFONE: ");
                string telefone = Console.ReadLine();
                Console.WriteLine("ENDEREÇO: ");
                string endereco = Console.ReadLine();
                Console.WriteLine("DATA DE NASCIMENTO: ");
                string dataNasc = Console.ReadLine();
                Console.WriteLine("EMAIL: ");
                string email = Console.ReadLine();

                Console.WriteLine("POR QUANTOS MESES DESEJA ALUGAR O QUARTO?: ");
                float Periodo = float.Parse(Console.ReadLine());// armazena o tanto de mese que você digitou
                Console.WriteLine("QUAL O VALOR DO QUARTO POR MÊS?: ");
                float ValorQuarto = float.Parse(Console.ReadLine());// armazena o valor do quarto por mês
                quartos[i] = new Quartos(Periodo, ValorQuarto);
                quarto[i] = new Cliente(nome, cpf, telefone, endereco, dataNasc, email);

            }
            for (int i = 0; i < qtd_quartos; i++)
            {
                Console.WriteLine();
                Console.WriteLine("*** DADOS DO HÓSPEDE " + (i + 1));
                Console.WriteLine(quarto[i]);
                Console.WriteLine(quartos[i]);
      

                Console.WriteLine(); Console.WriteLine();
               
              

            }
        }
    }
}