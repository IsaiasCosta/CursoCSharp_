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
        public virtual int Acelerar() { // Metodo com virtual pode serr sobre escrito, com a notação override
            return AlterarVelocidade(5);
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
        public Lamborguine() : base(380) {

        }
        //Sobre escrever o metodo Acelerar, mas ou sobre escrever não esqueça de ir ao metodo
        //e alterar o metodo da classe Pai com a notação virtual
        public override int Acelerar() {
            return AlterarVelocidade(50);
        }
        // notação new oculta da classe Pai
        public new int Frear() {
            return AlterarVelocidade(-5);
        }
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

            Console.WriteLine("Lamborguine com o tipo Carro");

            Carro carro3 = new Lamborguine();
            Console.WriteLine($"Acelerando {carro3.Acelerar()} ");
            Console.WriteLine($"Acelerando {carro3.Acelerar()} ");
            Console.WriteLine($"Acelerando {carro3.Acelerar()} ");
            Console.WriteLine($"Acelerando {carro3.Acelerar()} ");
            Console.WriteLine($"Freiando {carro3.Freiar()}");
            Console.WriteLine($"Freiando {carro3.Freiar()}");
            Console.WriteLine($"Freiando {carro3.Freiar()}");
            Console.WriteLine($"Freiando {carro3.Freiar()}");

            //Polimorfismo
            Console.WriteLine("Uno com tipo carro");
            carro3 = new Uno();
            Console.WriteLine($"Acelerando {carro3.Acelerar()} ");
            Console.WriteLine($"Acelerando {carro3.Acelerar()} ");
            Console.WriteLine($"Acelerando {carro3.Acelerar()} ");
            Console.WriteLine($"Acelerando {carro3.Acelerar()} ");
            Console.WriteLine($"Freiando {carro3.Freiar()}");
            Console.WriteLine($"Freiando {carro3.Freiar()}");
            Console.WriteLine($"Freiando {carro3.Freiar()}");
            Console.WriteLine($"Freiando {carro3.Freiar()}");
        }
    }
}
