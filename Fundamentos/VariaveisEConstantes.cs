using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class VariaveisEConstantes {
        public static void Executar() {
            // area da circunferencia
            double raio;
            Console.WriteLine("Digite o valor do raio ");
            raio = double.Parse(Console.ReadLine());

            double area = Math.PI * (Math.Pow(raio, 2));
            Console.WriteLine("Circunferencia do area " + area);

            //Tipos  internos

            bool estaChovendo = true;
            Console.WriteLine("Sim esta chovendo " + estaChovendo);

            // byte

            byte idade = 45;
            Console.WriteLine("Idade" + idade);

            //sbyte
            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("Saldo Gols " + saldoDeGols);

            //short
            short salario = short.MaxValue;
            Console.WriteLine("Salario " + salario);

            //int

            int menorValor = int.MinValue;
            Console.WriteLine("Menor valor " + menorValor);

            //uint

            uint populacaoBrasileira = 203_062_512;
            Console.WriteLine("População Brasileira " + populacaoBrasileira);

            //long
            long menorValorLong = long.MaxValue;
            Console.WriteLine("Menor valor long " + menorValorLong);

            //ulong
            ulong populacaoMundial = 8_000_000_000;
            Console.WriteLine(populacaoMundial + " é a População Mundial atualmente ");

            //float
            float precoComputador = 1299.99f;
            Console.WriteLine("Preço do computador " + precoComputador);

            //double
            double valorDeMercadoDaApple = 3_000_000_000_000.00;
            Console.WriteLine("Valor de Mercado da Apple " + valorDeMercadoDaApple);

            //decimal
            decimal distanciaEntreAsEstrelas = decimal.MaxValue;
            Console.WriteLine("Distancia entre as Estrelas " +distanciaEntreAsEstrelas);

            //char
            char letra = 'b';
              Console.WriteLine(" Letra " + letra);

            string texto = "Seja bem vindo ao Curso de C# ";
            Console.WriteLine("texto " + texto);

        }
    }
}
