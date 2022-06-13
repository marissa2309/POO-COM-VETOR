using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlunosTresNotas
{
    

    //classe que declara as variaveis
        internal class Alunos
        {
            public string NomeAluno { get; set; }
            public double Nota1 { get; set; }
            public double Nota2 { get; set; }
            public double Nota3 { get; set; }

            public Alunos(string nomeAluno, double nota1, double nota2, double nota3)
            {
                NomeAluno = nomeAluno;
                Nota1 = nota1;
                Nota2 = nota2;
                Nota3 = nota3;
            }

            // método para somar as notas
            public double SomaNotas()
            {
                return Nota1 + Nota2 + Nota3;
            }

            // metodo para ver se o aluno foi reprovado ou aprovado de acordo com a nota
            public string ReprovadoAprovado()
            {
                // se a soma da nota for maior ou igual a 60 
                if (SomaNotas() >= 60)
                {
                    // mostra essa mensagem
                    return "Parabéns voce foi APROVADO, sua nota final foi " + SomaNotas();
                } 
                // se a soma da nota for menor do que 60
                else
                {  
                    // mostra essa mensagem
                    return "Aluno REPROVADO, sua nota final foi " + SomaNotas() + " faltaram " + (60 - SomaNotas()) + " pontos para ser aprovado!";
                }
            }
            // impressão padrão
            public override string ToString()
            {
                return "***************DADOS DO ALUNO*****************\n"
                + "Aluno(a) "
                + NomeAluno.ToUpper() + "\n"
                + "\n Nota 1 "
                + Nota1.ToString("F2")
                + "\n Nota 2 "
                + Nota2.ToString("F2")
                + "\n Nota 3 "
                + Nota3.ToString("F2") + "\n\n"
                + "***************APROVADO OU REPROVADO*****************\n"
                + ReprovadoAprovado()
                + "\n\n";
            }
        }
}