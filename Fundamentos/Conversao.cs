using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class Conversao {
        public static void Executar() {

            //Conversão implicita
            int inteiro = 10;
            double quebrado = inteiro;
            Console.WriteLine(quebrado);

            //Conversão explicita
            double nota = 9.7;
            int notaTruncada = (int)nota;
            Console.WriteLine(notaTruncada);

            //Conventendo valores  entre tipos de variaveis

            Console.WriteLine("Informa a sua idade");
            string idadeString = Console.ReadLine();
            int idadeInteiro = int.Parse(idadeString);
            Console.WriteLine(idadeInteiro);

            //conventendo valores com o convert

            idadeInteiro = Convert.ToInt32(idadeString);
            Console.WriteLine($"conversão {idadeInteiro}");

            //Forma mais segura

            Console.WriteLine("Digite 1º nº ");
            string palavra = Console.ReadLine();
            int numero1;
            int.TryParse(palavra, out numero1);
            Console.WriteLine($"Usando o Tryparse 1º resultado {numero1}");

            Console.WriteLine("Digite 2º nº ");
            int.TryParse(Console.ReadLine(), out int numero2);
            Console.WriteLine($"Usando o Tryparse 2º resultado {numero2}");



        }
    }
}
