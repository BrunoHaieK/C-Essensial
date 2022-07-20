using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso___Essencial_em_5_Horas.fundamentos {
    class variaveis {

        public static void Executar() {

            // Variaveis Pratica 

            var bemVindo = "Helo World! - feliz natal";
            Console.WriteLine(bemVindo);
            Console.WriteLine(bemVindo);
            Console.WriteLine(bemVindo);
            Console.WriteLine(bemVindo);
            Console.WriteLine(bemVindo);

            var idade = 19;
            Console.WriteLine(idade);

            // Variavel imutavel

            // const float = 1999.99f; 

            // Caturando entrada de usuario 

            var nome = "";
            Console.WriteLine("Escreva seu nome");
            nome = Console.ReadLine();
            Console.WriteLine("Seu nome é");
            Console.WriteLine(nome);
        }

    }
}
