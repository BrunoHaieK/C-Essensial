using System;
using System.Collections.Generic;

using Curso___Essencial_em_5_Horas.fundamentos;
using Curso___Essencial_em_5_Horas.Estrutura_de_Controles;
using Curso___Essencial_em_5_Horas.Escopo;

namespace Curso___Essencial_em_5_Horas {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Variaveis - Fundamentos", variaveis.Executar},
                {"Operadores_Aritimeticos - Fundamentos", Operadores_Aritimeticos.Executar},
                {"Condição - Controles", Condição.Executar},
                {"PrimeiroPrograma_Condição - Controles",PrimeiroPrograma_Condição.Executar},
                {"Funções - Fundamentos",Funções.Executar},
                {"Array - Fundamentos",Array1.Executar},
                {"Switch - Controles",Switch1.Executar},
                {"Enum - Fundamentos",Enum1.Executar},
                {"Menu - Controles",Menu.Executar},
                {"Estrutura de Repetição While - Controles",While1.Executar},
                {"Estrutura de Repetição Do While - Controles",Do_while.Executar},
                {"Estrutura de Repetição Foreach - Controles",Foreach1.Executar},
                {"Estrutura de Repetição For - Controles",For1.Executar},
                {"Escopo",Escopo_Global_ou_Local.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}