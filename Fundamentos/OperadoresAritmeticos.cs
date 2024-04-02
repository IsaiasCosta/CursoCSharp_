using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class OperadoresAritmeticos {
        public static void Executar() {
            var preco = 1000.0;
            var imposto = 355;
            var desconto = 0.1;

            double total = preco + imposto;
            var totalComDesconto = total - (total * desconto);
            Console.WriteLine($" Preço total com o desconto {totalComDesconto}");
            Console.WriteLine($" Preço total com o desconto {total - totalComDesconto}");
            //IMC
            Console.Write("Informe o seu peso ");
            double.TryParse(Console.ReadLine(), out double peso);
            Console.Write("Informe a susa altura  ");
            double.TryParse(Console.ReadLine(), out double altura);
            double imc = peso / Math.Pow(altura, 2);
            if (imc <= 18.50) {
                Console.WriteLine($" Seu indice de massa corporica {imc.ToString("F2")} vocÊ é uma pessoa magra");
            }
            if ((imc > 18.50) && (imc <= 24.99)) {
                Console.WriteLine($" Seu indice de massa corporica {imc.ToString("F2")} vocÊ é uma pessoa Normal");
            }
            if ((imc > 25) && (imc <= 29.99)) {
                Console.WriteLine($" Seu indice de massa corporica {imc.ToString("F2")} vocÊ é uma pessoa Sobrepeso");
            }
            if ((imc > 30) && (imc <= 34.99)) {
                Console.WriteLine($" Seu indice de massa corporica {imc.ToString("F2")} vocÊ é uma pessoa Obesidade grau I");
            }
            if ((imc > 35) && (imc <= 39.99)) {
                Console.WriteLine($" Seu indice de massa corporica {imc.ToString("F2")} vocÊ é uma pessoa Obesidade grau II");
            }
            if (imc > 40) {
                Console.WriteLine($" Seu indice de massa corporica {imc.ToString("F2")} vocÊ é uma pessoa Obesidade grau III");
            }

            // Numero pr e Impar

            Console.WriteLine("Informe um numero inteiro ");
            int.TryParse(Console.ReadLine(), out int numInteiro);
            if (numInteiro % 2 == 0) {
                Console.WriteLine($" Numero {numInteiro} é  Par ");
            } else {
                Console.WriteLine($" Numero {numInteiro} é  Impar ");
            }
        }
    }
}
