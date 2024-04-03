using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes {
    /*
     O List<T>é uma coleção de objetos fortemente tipados que podem ser acessados ​​​​por índice e 
     possuem métodos para classificar, pesquisar e modificar lista.
    */
    public class Produto {
        public string Nome;
        public double Preco;

        public Produto(string nome, double preco) {
            this.Nome = nome;
            this.Preco = preco;
        }
    }
    class Lista {
        public static void Executar() {
            var livro = new Produto("A Casa do Dragão", 75.4);
            var carrinhoProduto = new List<Produto>();
            carrinhoProduto.Add(livro);

            var comboProduto = new List<Produto> {
                new Produto("Camisa", 55.9),
                new Produto("Boné", 12.0),
                new Produto("Sato",158.9),
            };
            carrinhoProduto.AddRange(comboProduto);
            Console.WriteLine(carrinhoProduto.Count);
            carrinhoProduto.RemoveAt(3);
            foreach (var item in carrinhoProduto) {
                Console.Write(carrinhoProduto.IndexOf(item) + " ");
                Console.WriteLine($"{item.Nome} - {item.Preco.ToString("F2")}");
            }
        }
    }
}
