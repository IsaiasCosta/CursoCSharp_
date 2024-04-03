using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes {
    class Igualdade {
        public static void Executar() {
            var p1 = new Produto("Casaco",550.80);
            var p2 = new Produto("Casaco",550.80);
       
            Console.WriteLine(p1==p2);
            Console.WriteLine(p1.Equals(p2));

        }
    }
}
