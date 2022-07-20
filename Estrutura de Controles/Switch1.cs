using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso___Essencial_em_5_Horas.fundamentos {
    class Switch1 {
        public static void Executar() {


            string cor = "verde";

            switch (cor) {
                case "Vermelho":
                    Console.WriteLine("Sua cor favorita é vermelho!"); 
                    break;
                case "Amarelo":
                    Console.WriteLine("Sua cor favorita é amarelo!");
                    break;
                    

                 default: Console.WriteLine("sua cor favorita não está dentre essas cores ");
                    break;



                }
            }

        }
}

