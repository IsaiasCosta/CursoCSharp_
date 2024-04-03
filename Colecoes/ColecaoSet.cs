using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes {
    internal class ColecaoSet {
        public static void Executar() {

            var livro = new Produto("A Casa do Dragão", 75.4);
            var carrinhoProduto = new HashSet<Produto>();
            carrinhoProduto.Add(livro);

            var comboProduto = new HashSet<Produto> { 
                // Hash : é uma estrutura não indexada, não remove o index, não adicona do index
                new Produto("Camisa", 55.9),
                new Produto("Boné", 12.0),
                new Produto("Sato",158.9),
                new Produto("Sato",158.9),
            };
            carrinhoProduto.UnionWith(comboProduto);
            Console.WriteLine(carrinhoProduto.Count);
            //carrinhoProduto.RemoveAt(3);
            foreach (var item in carrinhoProduto) {
               // Console.Write(carrinhoProduto.IndexOf(item) + " ");
                Console.WriteLine($"{item.Nome} - {item.Preco.ToString("F2")}");
            }
            Console.WriteLine(carrinhoProduto.Count);
            carrinhoProduto.Add(livro);
            Console.WriteLine(carrinhoProduto.Count);
        }
    }
}
