using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Classes_Metodos {
    internal class Propriedade {

        public class CarroOpcional {
            double desconto = 0.1;

            string nome;

            public string Nome {
                get {
                    return "Opcional" + nome;
                }
                set {
                    nome = value;
                }
            }
            //Exemplo de Propriedade autoimplementadas
            public double Preco { get; set; }

            //Somente leitura
            public double PrecoComDesconto {
                // get => Preco - (desconto * Preco); //notação lambda
                get {  
                    return Preco - (desconto * Preco);
                }
            }
            public CarroOpcional() {

            }
            public CarroOpcional(string nome, double preco) { 
                Nome = nome;
                Preco = preco;
            }

        }
        public static void Executar() {
            var precoOpcional1 = new CarroOpcional("travas eletrica", 1680.80);
            Console.WriteLine($" Preço com desconto = R${precoOpcional1.PrecoComDesconto} - " +
                $"Preço sem desconto = R${precoOpcional1.Preco}");
        }
    }
}
