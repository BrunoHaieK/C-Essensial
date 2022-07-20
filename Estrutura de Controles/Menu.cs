using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso___Essencial_em_5_Horas.fundamentos {
     class Menu {

        // Integrar enum + Switch para criação de menu (consoles)

        enum opcao { Criar = 1, Deletar, Editar, Listar, Atualizar}

        public static void Executar() {

            Console.WriteLine("Selecionja uma das opções abaixa: ");
            Console.WriteLine("1-Criar\n2-Deletar\n3-Editar\n4-Listar\n5-Atualizar ");

            Console.WriteLine("Digite qual opção deseja selecionar");
            int index = int.Parse(Console.ReadLine());
            opcao opcaoSelecionada = (opcao)index; // converto a variavel index para o tipo enum (opcao) e salvo em uma varivel do tipo opcao - opcaoSelecionada

            Console.WriteLine(opcaoSelecionada); // exibição da conversão

            switch (opcaoSelecionada) {

                case opcao.Criar:
                    Console.WriteLine("Você quer Criar algo?");
                    break;
                case opcao.Deletar:
                    Console.WriteLine("Você quer Deletar algo?");
                    break;
                case opcao.Editar:
                    Console.WriteLine("Você quer Editar algo?");
                    break;
                case opcao.Listar:
                    Console.WriteLine("Você quer Listar algo?");
                    break;
                case opcao.Atualizar:
                    Console.WriteLine("Você quer Atualizar os dados?");
                    break;
                 default:
                    Console.WriteLine("Opção não encontrada");
                    break;
            }


        }
    }
}
