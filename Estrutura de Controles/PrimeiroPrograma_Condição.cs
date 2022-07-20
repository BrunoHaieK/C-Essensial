using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso___Essencial_em_5_Horas.fundamentos {
     class PrimeiroPrograma_Condição {
        public static void Executar() {

            Console.WriteLine("Qual sua Idade?");
            int idade = int.Parse(Console.ReadLine());

            if (idade >= 0 && idade <= 11)
            {
                Console.WriteLine("Você é uma Criança!");
            }
            else if (idade >= 12 && idade <= 18)
            {
                Console.WriteLine("Você é um Adolecente");
            }

            else if (idade >= 18 && idade <= 60) 
            {
                Console.WriteLine("Você é um adulto");
            }
            else 
            {
                Console.WriteLine("Você é um Idoso");
            }



        }
    }
}
