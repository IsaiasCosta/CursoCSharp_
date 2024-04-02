using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Classes_Metodos {


    public class CalculadoraEstatica {

        // Metodo de Classe ou Méto de estático
        public static int Multiplicacao(int num1, int num2) {
            return num1 * num2;
        }


        // Método de instância
        public int Somar(int num1, int num2) {
            return num1 + num2;
        }
    }
    class MetodosEstaticos {


        public static void Executar() {
            // saida Metodo de Classe ou Méto de estático
            var resultado = CalculadoraEstatica.Multiplicacao(1, 2);
            Console.WriteLine(resultado);
            //saida Metodo de Classe ou Méto de estático
            CalculadoraEstatica calc = new CalculadoraEstatica();
            calc.Somar(1, 2);
            Console.WriteLine($" Somando o metodo não estatico apenas estanciando o objeto : {calc.Somar(2, 3)}");

        }
    }
}
