using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso___Essencial_em_5_Horas.fundamentos {
    class Funções {
        public static void Executar() {

            // Return ao chamar a função previsa definir uma variavel que recebem os valores!
            int soma1 = Somar (10, 20, 30);
            int soma2 = Somar(100, 200, 300);
            int soma3 = Somar(1000, 200, 300);

            Console.WriteLine(soma1);
            Console.WriteLine(soma2);
            Console.WriteLine(soma3);


            /*GerarPreco(19, " Preço do Curso de Node,js");
            GerarPreco(200, "Preço do Curso de C#");
            GerarPreco(-400, "Preço do Curso FullStack");*/

            //ExibirMsg();
            //ExibirMsg();
            //ExibirMsg();

        }

        static void ExibirMsg() {
            Console.WriteLine("Teste");
            Console.WriteLine("Teste");

        }

        static void GerarPreco(int preco, string nome) 
        {

            // função + Concatenação
            //Console.WriteLine(" Nome do produto " + nome);
           // Console.WriteLine(preco);


            //função ABS converte valores negativos para positivos!
            int precoAbs = Math.Abs(preco);
            int Valorfinal = precoAbs + (2 * precoAbs);
            Console.WriteLine("Valor final: " + Valorfinal);
        }

        static int Somar(int a, int b, int c) 
        {
            int resultadofinal = a + b + c;
           return resultadofinal;
        }

      }
}