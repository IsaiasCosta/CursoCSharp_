using System.Globalization;

namespace CursoCSharp.Fundamentos {
    internal class FormatandoNumero {
        public static void Executar() {
            double valor = 15.485;
            Console.WriteLine("Formatando casas decimais", valor.ToString("F2"));
            Console.WriteLine("Formando a moeda corrente", valor.ToString("C"));
            Console.WriteLine("Formatando o percentual", valor.ToString("P"));
            Console.WriteLine("Formatando casas decimais com cerquihas", valor.ToString("#.##"));

            CultureInfo cultura = new CultureInfo("pt-BR");
            Console.WriteLine("Formanto moeda correta, conforme a cultra do País", valor.ToString("C0",cultura));
            
            // Adicionar  zero a esquerda de um valor usa a letra D e a quantidade todas de elementos a serem impressos
            int inteiro = 250;
            Console.WriteLine(inteiro.ToString("D5"));
        }
    }
}
