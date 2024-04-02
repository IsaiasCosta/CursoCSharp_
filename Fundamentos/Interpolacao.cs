using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class Interpolacao {
        public static void Executar() {

            string nome = " Notebook";
            string marca = "Samsung";
            double preco = 7_800.00;

            Console.WriteLine(" O "+nome + " da marca "+marca+ " custa R$"+preco+".00");
            Console.WriteLine(" O {0} da marca {1} custa R${2}.00",nome,marca,preco);
            Console.WriteLine($" O {nome} da marca {marca} custa R${preco}.00");
        }
    }
}
