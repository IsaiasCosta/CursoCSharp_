using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Classes_Metodos {
      class DesafioAcessarAtributo {
        int a = 10;
        public static void Executar() {

            var letraA = new DesafioAcessarAtributo();
            Console.WriteLine(letraA.a);

            // Resposta  do curso

            DesafioAcessarAtributo result = new DesafioAcessarAtributo();
            Console.WriteLine(result.a);

        }
    }
}
