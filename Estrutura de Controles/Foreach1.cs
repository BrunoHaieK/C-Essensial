using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso___Essencial_em_5_Horas.Estrutura_de_Controles {
     class Foreach1 {
        public static void Executar() {
            //Foreach percorre todos os elementos Arrays

            string[] palavras = { "victor", "Lima", "Bruno" };

            foreach(string palavra in palavras)// Para cada palavra no array palavras, repita o bloco de codigo
            {
                Console.WriteLine("Foreach Rodando!");
                Console.WriteLine(palavra);
            }

                Console.WriteLine("FIM DA LINHA");
        }
    }
}
