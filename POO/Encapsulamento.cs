using Encapsulamento;
namespace CursoCSharp.POO {
    //   Encapsulamento é uma técnica para implementar abstração em código.
    //   Crie classes e seus membros com modificadores de acesso apropriados
    //   para mostrar ou ocultar detalhes e complexidade.

    //   public => Todos
    //   internal =>  somente dentro do  projeto
    //   protected => herança
    //   private => visivel somente dentro da Classe
    //   private e protectec  pode ser feita somnte da versão 7.2 acima


    public class FilhoNaoReconhecido : SubCelebridade {
        public new void MeusAcessos() {
            Console.WriteLine(" Filho não reconhecido tem acessso ");
            Console.WriteLine($"{InfoPublica}");
            Console.WriteLine($"{CorDoOlho}");
            //Console.WriteLine($"{NumeroCel}");
            Console.WriteLine($"{JeitoDeFalar}");
            // Console.WriteLine($"{SegredoFamilia}");
            //Console.WriteLine($"{UsaMuitoTiktoc}");
        }
    }

    public class AmigoDistante {
        public readonly SubCelebridade amigo = new SubCelebridade();
        public void MeusAcessos() {
            Console.WriteLine(" Amigo distante tem acessso ");
            Console.WriteLine($"{amigo.InfoPublica}");
            //Console.WriteLine($"{amigo.CorDoOlho}");
            //Console.WriteLine($"{amigo.NumeroCel}");
            //Console.WriteLine($"{amigo.JeitoDeFalar}");
            //Console.WriteLine($"{amigo.SegredoFamilia}");
            //Console.WriteLine($"{amigo.UsaMuitoTiktoc}");
        }
    }

    class Encapsulamento {
        public static void Executar() {
            SubCelebridade sub = new SubCelebridade();
            sub.Meusacessos();

            new FilhoReconhecido().MeusAcessos();

            new FilhoNaoReconhecido().MeusAcessos();

            new AmigoProximo().MeusAcesos();

            new AmigoDistante().MeusAcessos();
        }
    }
}
