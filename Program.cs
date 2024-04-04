using CursoCSharp.Classes_Metodos;
using CursoCSharp.Colecoes;
using CursoCSharp.EstruturaDeControle;
using CursoCSharp.Fundamentos;
using CursoCSharp.POO;
using CursoCSharp.POO.ExemploHeranca;

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

                {"Membros - Classes e Métodos",Membros.Executar },
                {"Construtores - Classes e Métodos",Construtores.Executar },
                {"Metodos com Retorno -  Classes e Métodos",MetodosComRetorno.Executar },
                {"Metodos Estatico -  Classes e Métodos",MetodosEstaticos.Executar },
                {"Atributos Estatico -  Classes e Métodos",AtributosEstaticos.Executar },
                {"Desafio Atributo -  Classes e Métodos",DesafioAcessarAtributo.Executar },
                {"Parametros e Variaveis  -  Classes e Métodos",ParametrosVariaveis.Executar },
                {"Parametros Nomeados -  Classes e Métodos",ParametrosNomeados.Executar },
                {"Metodos Getters e Setters -  Classes e Métodos",GetSet.Executar },
                {"Propriedade -  Classes e Métodos",Propriedade.Executar },
                {"Readonly -  Classes e Métodos",AtributosReadonly.Executar },
                {"Enum -  Classes e Métodos",MetodoEnum.Executar },
                {"Struct -  Classes e Métodos",MetodoStruct.Executar },
                {"Classes Vs Struct -  Classes e Metodos",ClassesVsStruct.Executar },
                {"Atribuicao Por Valor Vs Referência -  Classes e Métodos",AtribuicaoPorValorVsRef.Executar },
                {"Parametros Por Referencia Referência -  Classes e Métodos",ParametrosPorReferencia.Executar },
                {"ParametroPadrao -  Classes e Métodos",ParametroPadrao.Executar },

                //Coleções
                
                {"Array - Coleções",Colecoes.Array.Executar},
                {"Lista  - Coleções",Colecoes.Lista.Executar},
                {"Array de Lista  - Coleções",ColecaoArrayList.Executar},
                {"Colecao Set  - Coleções",ColecaoSet.Executar},
                {"Colecao Queue  - Coleções",ColecaoQueue.Executar},
                {"Igualdade  - Coleçoes",Igualdade.Executar},
                {"Colecão Stack  - Coleções",ColecaoStack.Executar},
                {"Colecão Dictionary  - Coleções",ColecaoDictionary.Executar},

                //POO

                {"Exemplo Herança  - POO",Humano.Executar},
                {"Herança  - POO",Heranca.Executar},
                {"Construtor com This - POO",ConstrutorThis.Executar},
                {"Encapsulamento - POO",POO.Encapsulamento.Executar},
                {"Polimorfismo- POO",Polimorfismo.Executar},
                {"Abstrata- POO",Abstrada.Executar},
                {"Interface- POO",Interface.Executar},
            }) {

            };
            central.SelecionarEExecutar();
        }
    }
}