namespace CursoCSharp.POO {
    //Uma interface contém definições para um grupo de funcionalidades relacionadas
    //que uma class ou um struct podem implementar.Uma interface pode definir métodos static,
    //que devem ter uma implementação.Uma interface pode definir uma implementação padrão para membros.
    //Uma interface pode não declarar dados de instância, como campos, propriedades implementadas
    //automaticamente ou eventos semelhantes a propriedades.
    //Usando interfaces, você pode, por exemplo, incluir o comportamento de várias fontes em uma classe.
    //Essa funcionalidade é importante em C# porque a linguagem não dá suporte a várias heranças de classes.
    //Além disso, use uma interface se você deseja simular a herança para structs, pois eles não podem herdar
    //de outro struct ou classe.


    interface OperacaoBinaria {
        int Operacao(int num1, int num2);
    }
    class Soma : OperacaoBinaria {
        public int Operacao(int num1, int num2) {
            return num1 + num2;
        }
    }
    class Subtracao : OperacaoBinaria {
        public int Operacao(int num1, int num2) {
            return num1 - num2;
        }
    }
    class Multiplicao : OperacaoBinaria {
        public int Operacao(int num1, int num2) {
            return num1 * num2;
        }
    }
    class Divisao : OperacaoBinaria {
        public int Operacao(int num1, int num2) {
            return num1 / num2;
        }
    }
    class Calculadora {
        List<OperacaoBinaria> operacoes = new List<OperacaoBinaria> {
            new Soma(),
            new Subtracao(),
            new Multiplicao(),
            new Divisao(),

        };
        public string ExecutarOperacao(int num1, int num2) {
            string resultado = "";
            foreach (var operacao in operacoes) {
                resultado += $"Usando {operacao.GetType().Name} = {operacao.Operacao(num1,num2)}\n";
            }
            return resultado;
        }
    }
    internal class Interface {
        public static void Executar() {
            var calc = new Calculadora();
            var resultado = calc.ExecutarOperacao(15,23);
            Console.WriteLine($"Resultado\n : {resultado}");
        }
    }
}
