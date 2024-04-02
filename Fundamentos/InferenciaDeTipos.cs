using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class InferenciaDeTipos {
       public static void Executar() {
            // VArialvel com inferencia tem que ter o vaor atribuido a mesma
            var nome = "Isaias";
            Console.WriteLine(" conteudo dentro da varialvel " + nome);
            var idade = 47;
            Console.WriteLine(" Idade " + idade);
        }
    }
}
