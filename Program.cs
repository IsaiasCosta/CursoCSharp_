using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturaDeControle;
using CursoCSharp.Classes_Metodos;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos",PrimeiroPrograma.Executar},
                {"VariaveisEConstantes - Fundamentos",VariaveisEConstantes.Executar},
                {"Operador deAtribuição - Fundamentos",OperadorAtribuicao.Executar},
                {"Operador Unario - Fundamentos",OperadorUnario.Executar},
                {"Operador Ternario - Fundamentos",OperadorTernario.Executar},
                {"Inferencia de Tipos - Fundamentos", InferenciaDeTipos.Executar},
                {"Interpolação - Fundamentos", Interpolacao.Executar},
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo Dados - Fundamentos", LendoDados.Executar},
                {"FormatandoNumero - Fundamentos", FormatandoNumero.Executar},
                {"Conversao - Fundamentos", Conversao.Executar},
                {"Operadores Aritmeticos - Fundamentos", OperadoresAritmeticos.Executar},
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Logicos  - Fundamentos", OperadoresLogicos.Executar},

                /*Estrutura de Controle*/
                {"EstruturaIF - Estrutura De Controle",EstruturaIF.Executar},
                {"Estrutura If e Else - Estrutura De Controle",EstruturaIfElse.Executar},
                {"Estrutura If/  Else If - Estrutura De Controle",EstruturaIfElseIf.Executar},
                {"Estrutura Switch -  Estrutura De Controle",EstruturaSwitch.Executar},
                {"Estrutura While -  Estrutura De Controle",EstruturaWhile.Executar},
                {"Estrutura DoWhile -  Estrutura De Controle",EstruturaDoWhile.Executar},
                {"Estrutura For   -  Estrutura De Controle",EstruturaFor.Executar},
                {"Estrutura Foreach -  Estrutura De Controle",EstruturaForeach.Executar},
                {"Estrutura Break   -  Estrutura De Controle",EstruturaBreak.Executar},
                {"UsandoConinue     -  Estrutura De Controle",UsandoContinue.Executar},

                /*Classes E  Metodos*/

                {"Membros - Classes e Metodos",Membros.Executar },
                {"Construtores - Classes e Metodos",Construtores.Executar },
                {"Metodos com Retorno -  Classes e Metodos",MetodosComRetorno.Executar },

            });

            central.SelecionarEExecutar();
        }
    }
}