namespace CursoCSharp.POO {
    public class Carro {

        protected readonly int Velocidademaxima;

        int VelocidadeAtual;
        public Carro(int velocidademaxima) {
            Velocidademaxima = velocidademaxima;
        }
        protected int AlterarVelocidade(int delta) {
            int novaVelocidade = VelocidadeAtual + delta;

            if (novaVelocidade < 0) {
                VelocidadeAtual = 0;
            } else if (novaVelocidade > Velocidademaxima) {
                VelocidadeAtual = Velocidademaxima;
            } else {
                VelocidadeAtual = novaVelocidade;
            }
            return VelocidadeAtual;
        }
        public int Acelerar() {
            return AlterarVelocidade(5*5);
        }
        public int Freiar() {
            return AlterarVelocidade(-5);
        }
    }
    // Herança usando o construtr base, contrutor base é usando quando a classe pais não tem um cnstrutor vazio

    public class Uno : Carro {
        public Uno() : base(210) { }
    } 
    public class Lamborguine : Carro {
        public Lamborguine() : base(380) { }
    }
    internal class Heranca {

        public static void Executar() {
            Console.WriteLine("Uno....");
            Uno carro1 = new Uno();
            Console.WriteLine($"Acelerando {carro1.Acelerar()} ");
            Console.WriteLine($"Acelerando {carro1.Acelerar()} ");
            Console.WriteLine($"Freiando {carro1.Freiar()}");
            Console.WriteLine($"Freiando {carro1.Freiar()}");

            Console.WriteLine("Lamborguine....");
            Lamborguine carro2 = new Lamborguine();

            Console.WriteLine($"Acelerando {carro2.Acelerar()} ");
            Console.WriteLine($"Acelerando {carro2.Acelerar()} ");
            Console.WriteLine($"Acelerando {carro2.Acelerar()} ");
            Console.WriteLine($"Acelerando {carro2.Acelerar()} ");
            Console.WriteLine($"Freiando {carro1.Freiar()}"); 
            Console.WriteLine($"Freiando {carro1.Freiar()}");
            Console.WriteLine($"Freiando {carro1.Freiar()}");
            Console.WriteLine($"Freiando {carro1.Freiar()}");


        }
    }
}
