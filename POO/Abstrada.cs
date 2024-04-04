namespace CursoCSharp.POO {

    //O significado de abstração no dicionário é "existir como uma ideia, sentimento ou qualidade,
    //não como um objeto material" (Fonte ).

    //Abstração é um conceito de nível superior ou uma forma de pensar quando você começa a projetar
    //seu aplicativo a partir dos requisitos de negócios.Abstração é um processo de identificação de
    //entidades essenciais(classes) e suas características(membros da classe) e de deixar informações
    //irrelevantes dos requisitos de negócios para preparar um design de aplicativo de nível superior.

    internal class Abstrada {
        public abstract class Celular {
            public abstract string Assistente();
            public string Tocar() {

                return " rim trim trim";
            }
        }
        public class Samsung : Celular {
            public override string Assistente() {
                return "Olá! Meu nome  é Bixby";
            }
        }
        public class IPhone : Celular {
            public override string Assistente() {
                return "Olá! Meu meu nome é Siri";
            }
        }
        public static void Executar() {

            var celulares = new List<Celular> {
                new Samsung(),
                new IPhone(),
            };
            foreach (var celular in celulares) {
                Console.WriteLine($"{celular.Assistente()}");
            }
        }
    }
}
