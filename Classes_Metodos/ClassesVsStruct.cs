using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Classes_Metodos {
    internal class ClassesVsStruct {

        public struct SPonto { // por valor sendo struct 
            public int X;
            public int Y;
        }
        public class CPonto2 { // por refencia sem uma classe
            public int X;
            public int Y;
        }

        public static void Executar() { 
            SPonto ponto1 = new SPonto {X=1, Y=4};
            SPonto copiaPonto1 = ponto1; //Atribuição por Valor
            ponto1.X = 8;
            Console.WriteLine("{0}",ponto1.X);
            Console.WriteLine("{0}",copiaPonto1.X);

            CPonto2 ponto2 = new CPonto2 {X=4, Y=8};
            CPonto2 copiaPonto2 = ponto2; //Atribuição por Referencia
            ponto2.X = 9;
            Console.WriteLine("{0}", ponto2.X);
            Console.WriteLine("{0}", copiaPonto2.X);

        }
    }
}
