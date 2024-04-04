namespace CursoCSharp.POO {


    public class Comida {
        public double Peso;
        public Comida(double peso) {
            this.Peso = peso;
        }
        public Comida() { }
    }

    public class Feijao : Comida {

    }
    public class Arroz : Comida {

    }
    public class Carne : Comida {

    }
    public class Pessoa {
        public double Peso;
        ////public void Comer(Feijao feijao) {
        //Peso+=feijao.Peso;
        ////}
        ////public void Comer(Arroz arroz) {
        //Peso+=Arroz.Peso;
        ////}
        ////public void Comer(Carne carne) {
        //Peso+=carne.Peso;
        ////} 
        public void Comer(Comida comida) {
            Peso += comida.Peso;
        }

    }
    class Polimorfismo {
        public static void Executar() {
            Feijao porcao1 = new Feijao();
            porcao1.Peso = 0.2;
            Arroz porcao2 = new Arroz();
            porcao2.Peso = 0.3;
            Carne porcao3 = new Carne();
            porcao3.Peso = 0.4;

            Pessoa cliente = new Pessoa();
            cliente.Peso = 96.2;

            cliente.Comer(porcao1);
            cliente.Comer(porcao2);
            cliente.Comer(porcao3);

            Console.WriteLine($"O cliente comeu {cliente.Peso.ToString("F2")}");



        }
    }
}
