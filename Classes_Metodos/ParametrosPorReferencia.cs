using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Classes_Metodos {

 
     class ParametrosPorReferencia {
        public static void AlterarRef(ref int num) {
            num = num + 2900;
        }  public static void AlterarOut(out int num) { //out é uni lateral, ele passa por referencia não por valor
            num = 0;
            num = num + 240;
        }

        public static void Executar() {
            int testeA = 50;
            AlterarRef(ref testeA);
            Console.WriteLine("Por referencia {0}",testeA);
            //int testeB = 82;
            AlterarOut(out int testeB);
            Console.WriteLine("Por Out {0}",testeB);
        }
    }
}
