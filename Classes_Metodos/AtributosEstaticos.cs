using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Classes_Metodos {

    public class Produto {
        //Atributos
        public string Nome;
        public double Preco;
        public double Desconto = 0.1;

        //Construtor

        public Produto(string nome, double preco, double desconto) {
            Nome = nome;
            Preco = preco;
            Desconto = desconto;

        }// Construtor vazio
        public Produto() {
        }

        // Metodo publico 
        public double CalcularDesconto() {
            return Preco - Preco * Desconto;
        }

    }

    class AtributosEstaticos {

        public static void Executar() {

            var produto1 = new Produto("Caneta", 3.2, 0.1);

            var produto2 = new Produto() {
                Nome = "Bolaja",
                Preco = 6.5,
                Desconto = 0.1,
            };
            Console.WriteLine($"Preço com desconto 1º produto {produto1.CalcularDesconto()}");
            Console.WriteLine($"Preço com desconto 1º produto {produto2.CalcularDesconto()}");
        }
    }
}
