using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Classes_Metodos {


    class CalculadoraComum {
        public int Somar(int num1, int num2) {
            return num1 + num2;
        }

        public int Subtrair(int num1, int num2) {

            return num1 - num2;
        }
        public int Multiplicar(int num1, int num2) {
            return num1 * num2;
        }
        public int Divisao(int num1, int num2) {
            return num1 / num2;
        }
    }
    class MetodosComRetorno {
        public static void Executar() {
            var calculadoraComum = new CalculadoraComum();
  
            Console.WriteLine($"{calculadoraComum.Somar(6, 2)} - {calculadoraComum.Subtrair(81, 2)} - " +
                $"{calculadoraComum.Multiplicar(50, 2)} - {calculadoraComum.Divisao(154, 2)}");


        }
    }
}
