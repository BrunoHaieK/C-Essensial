using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso___Essencial_em_5_Horas.Estrutura_de_Controles {
     class For1 {

        public static void Executar() 
        {
            string[] palavras = { "victor", "Bruno", "Vinicus", "Arisio" };

            for(int contador = 0; contador < palavras.Length ; contador++) 
            {
                Console.WriteLine(contador);
                Console.WriteLine(palavras[contador]);
            }

            //ou

            Console.WriteLine("================");
            for(int contador2 = palavras.Length-1; contador2 > 0; contador2--) 
            {
                Console.WriteLine(contador2);
                Console.WriteLine(palavras[contador2]);
            }

            Console.WriteLine("FIM DA LINHA!");
            Console.ReadLine(); 
        }
    }
}
