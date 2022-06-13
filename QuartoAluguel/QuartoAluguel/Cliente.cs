//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace QuartoAluguel
//{
//    class Cliente
//    {
//        public string Nome, DataNasc, email,Endereco;
//        public string CPF;
//        public string Telefone;
//        public float Periodo;
//        public double ValorQuarto = 800;
//        public string quarto1,quarto2,quarto3;



//        public double ValorTotal()
//        {
//            return Periodo * ValorQuarto;   

//        }
//        public override string ToString()
//        {
//            return "O QUARTO FOI ALUGADO POR:  "
//                + Nome.ToUpper()
//                + "\n * CPF: " + CPF.ToUpper()
//                + "\n * TELEFONE: "
//                + Telefone.ToUpper()
//                + "\n * ENDEREÇO: "
//                + Endereco.ToUpper()
//                + "\n * DATA DE NASCIMENTO: "
//                + DataNasc.ToUpper()
//                + "\n * EMAIL: "
//                + email.ToUpper()
//                + "\n * VALOR MENSAL: "
//                + ValorQuarto.ToString("C")
//                + "\n * VALOR A PAGAR: "
//                + ValorTotal().ToString("C");
//        }
//    }
//}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuartoAluguel
{
    // classe onde é declarada as variaveis
    class Cliente
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public string DataNasc { get; set; }
        public string Email { get; set; }




        public Cliente(string nome, string cpf, string telefone, string endereco, string dataNasc, string email)
        {
            Nome = nome;
            CPF = cpf;
            Telefone = telefone;
            Endereco = endereco;
            DataNasc = dataNasc;
            Email = email;
           
        }

        // impressão padrão
        public override string ToString()
        {

            return "O QUARTO FOI ALUGADO POR:  "
                + Nome.ToUpper()
                + "\n * CPF: " + CPF.ToUpper()
                + "\n * TELEFONE: "
                + Telefone.ToUpper()
                + "\n * ENDEREÇO: "
                + Endereco.ToUpper()
                + "\n * DATA DE NASCIMENTO: "
                + DataNasc.ToUpper()
                + "\n * EMAIL: "
                + Email.ToUpper();
             
        }
    }
    // classe onde é declarado as variaveis
    class Quartos
    {
        public float Periodo { get; set; }
        public float ValorQuarto { get; set; }

        public Quartos(float periodo, float valorQuarto)
        {
            Periodo = periodo;
            ValorQuarto = valorQuarto;
        }
        // metodo para calcular o valor total
        public double ValorTotal()
        {
            return Periodo * ValorQuarto;


        }
        // impressão padrão
        public override string ToString()
        {
            return "\n * VALOR MENSAL: "
                    + ValorQuarto.ToString("C")
                    + "\n * VALOR A PAGAR: "
                     + ValorTotal().ToString("C");
        }
    }
 
}

