using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class LendoDados {
        public static void Executar() {
            Console.WriteLine("Informe o seu nome !!!");
            string nome = Console.ReadLine();
            Console.WriteLine("Sua idade por gentileza");
            int idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual é o seu salario mensal ?");
            double salario = double.Parse(Console.ReadLine());
            Console.WriteLine($"Meu nome é {nome} eu tenho {idade} anos e ganho de salario R${salario}.00",nome,idade,salario);
        }
    }
}
