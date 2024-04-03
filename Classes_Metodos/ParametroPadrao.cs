using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Classes_Metodos {
    internal class ParametroPadrao {

        public static int  Somar(int num1 =5, int num2=87 ) { 
            return num1 + num2;
        }
        public static void Executar() {
            Console.WriteLine(Somar(89,59));
            Console.WriteLine(Somar(75));
            Console.WriteLine(Somar());
            Console.WriteLine(Somar(num2:9));
        }
    }
}
