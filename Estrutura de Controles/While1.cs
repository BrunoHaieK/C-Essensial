using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso___Essencial_em_5_Horas.fundamentos {
    class While1 {
        public static void Executar() {

           // while// Enquanto for verdade faça (repetição)

            int contador = 0;
            while (contador < 10) 
            {
                Console.WriteLine(contador + 1);
                Console.WriteLine("Rodando o While");
                //contador = contadotr +1
                //contador += 1;
                contador++;
                
            }

        }
    }
}
