using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso___Essencial_em_5_Horas.fundamentos {
    class Array1 {
        public static void Executar() {

            /*string produto1 = "Sea of thieves";
            string produto2 = "FIFA";
            string produto3 = "Minecraft";
            string produto4 = "Half life";
            string produto5 = "Portal";
            string produto6 = "Cs";*/

            // Array serve para efetuar a criação dessas variaveis de uma forma menos repetitiva!

            string[] produtos = new string[5] {
                "Sea of thieves",
                "FIFA",
                "Half life",
                "Portal",
                "Cs"
            };
            // Arrey de números inteiros

            int[] valores = { 1, 2, 3, 4, 5 };


            produtos[1] = "FIFA 2022";
            Console.WriteLine(produtos[1]);
        }
    }
}
