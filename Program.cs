using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturaDeControle;
using CursoCSharp.Classes_Metodos;
using CursoCSharp.Colecoes;
using System.Threading.Channels;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {

                 /*Fundamentos*/
                { "Primeiro Programa - Fundamentos",PrimeiroPrograma.Executar},
                {"Variaveis E Constantes - Fundamentos",VariaveisEConstantes.Executar},
                {"Operador de Atribuição - Fundamentos",OperadorAtribuicao.Executar},
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

                {"Estrutura IF - Estrutura De Controle",EstruturaIF.Executar},
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
                {"Metodos Estatico -  Classes e Metodos",MetodosEstaticos.Executar },
                {"Atributos Estatico -  Classes e Metodos",AtributosEstaticos.Executar },
                {"Desafio Atributo -  Classes e Metodos",DesafioAcessarAtributo.Executar },
                {"Parametros e Variaveis  -  Classes e Metodos",ParametrosVariaveis.Executar },
                {"Parametros Nomeados -  Classes e Metodos",ParametrosNomeados.Executar },
                {"Metodos Getters e Setters -  Classes e Metodos",GetSet.Executar },
                {"Propriedade -  Classes e Metodos",Propriedade.Executar },
                {"Readonly -  Classes e Metodos",AtributosReadonly.Executar },
                {"Enum -  Classes e Metodos",MetodoEnum.Executar },
                {"Struct -  Classes e Metodos",MetodoStruct.Executar },
                {"Classes Vs Struct -  Classes e Metodos",ClassesVsStruct.Executar },
                {"Atribuicao Por Valor Vs Referencia -  Classes e Metodos",AtribuicaoPorValorVsRef.Executar },
                {"Parametros Por Referencia Referencia -  Classes e Metodos",ParametrosPorReferencia.Executar },
                {"ParametroPadrao -  Classes e Metodos",ParametroPadrao.Executar },

                //Coleções
                
                {"Array - Coleçoes",Colecoes.Array.Executar},
                {"Lista  - Coleçoes",Colecoes.Lista.Executar},

            }) {

            };
            central.SelecionarEExecutar();
        }
    }
}