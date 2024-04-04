using CursoCSharp.Classes_Metodos;

namespace CursoCSharp.POO {
   // O polimorfismo em tempo de execução também é conhecido como polimorfismo baseado em herança
   // Ou substituição de método.
   //A herança permite herdar uma classe base em uma classe derivada e todos os membros públicos da classe
   //Base tornam-se automaticamente membros da classe derivada. entretanto, você pode redefinir o membro da
   //Classe base na classe derivada para fornecer uma implementação diferente da classe base. isso é chamado
   //De substituição de método, também conhecido como polimorfismo de tempo de execução.

   //Em c#, por padrão, todos os membros de uma classe são lacrados e não podem ser redefinidos na classe
   //Derivada. use a virtualpalavra-chave com um membro da classe base para torná-la substituível e use a
   //override palavra-chave na classe derivada para indicar que esse membro da classe base está sendo
   //redefinido na classe derivada

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
