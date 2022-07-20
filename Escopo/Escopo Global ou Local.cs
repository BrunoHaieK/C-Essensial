using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso___Essencial_em_5_Horas.Escopo {
     class Escopo_Global_ou_Local {

        //Escopo Global

        static string meuNomeCompleto = "Bruno Haiek 2";

        public static void Executar() 
        {
            //Escopo Local
            string nome = "Bruno";
            string nomeCompleto = "Bruno Haiek";
            Console.WriteLine(nomeCompleto);
            Console.WriteLine(nome);


        }
    }
}
