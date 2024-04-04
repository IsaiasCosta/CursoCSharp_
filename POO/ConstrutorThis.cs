


namespace CursoCSharp.POO {

    public class Animal {
        public string Nome { get; set; }
        public Animal(string Nome) {
            this.Nome = Nome;
        }
    }
        public class Cachorro : Animal {
            public double Altura { get; set; }
            public Cachorro(string nome) : base(nome) {
                Console.WriteLine($" Nome do Cachorro: {nome}");// chamada do construtor Pai ou raiz
            }
            public Cachorro(string nome, float altura) : this(nome) {// chamada do construtor local
                Altura = altura;
            Console.WriteLine($" Nome do Cachorro: {nome} altura cm {altura}");
        }
        public override string ToString() {
            return $"{Nome} Tem {Altura} cm altura";
        }
    }
    
    class ConstrutorThis {
        public static void Executar() {
            var caramelo = new Cachorro("caramelo");
            var coca = new Cachorro("coca",26f);


            Console.WriteLine($" Nome : {caramelo.Nome} Altura:{caramelo.Altura}");
            Console.WriteLine($" Nome : {coca.Nome} Altura: {coca.Altura}");
        }
    }
}
