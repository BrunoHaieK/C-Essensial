using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso___Essencial_em_5_Horas.fundamentos {
    class Enum1 {

        //Enum serve para enumerar cada valores que estão dentro do parentes
        //Você pode determinar a numeração de cada valor
        enum cor { Azul = 33, Verde, Amarelo, Vermelho }


        public static void Executar() {

            cor corFavorita = cor.Vermelho;
            cor corFavoritaDaCarla = cor.Amarelo;

            Console.WriteLine((cor)2);
            Console.WriteLine(corFavoritaDaCarla);
            Console.WriteLine("Sua cor favotira é:" + corFavorita);


        }


    }
}



