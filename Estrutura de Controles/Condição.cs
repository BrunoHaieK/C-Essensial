using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso___Essencial_em_5_Horas.fundamentos {
    class Condição {

        public static void Executar() {

            // Condição 

            //operadores logicos
            // &&(e ou and)  //Ex: para ter entrada gratuita:
            //SerMulher && idade >= 25 anos

            //&& (e ou and)
            //true  && true = true
            //true  && false = false
            //false && true = false
            //false && false = false

            // || (ou/or) //Ex: entrar no jogo gratuitamente (true)
            //LevarAlimento(F) || LevarBrinquedo(V) => Entrar no jogo

            //true || true => true
            //false || true => true
            //true || false => true
            //false || false => false

            int a = 10;
            int b = 20;
            int c = 30;

            if (a > c || b < c) // SE
            {
                Console.WriteLine("É verdade!");
            }
            else if (b == c) {
                Console.WriteLine(" Executou Elseif!");
            }
            else //SE NÃO
            {
                Console.WriteLine("É mentira");

            }
        }
    }
}
