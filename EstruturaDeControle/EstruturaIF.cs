using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
    internal class EstruturaIF
    {
        public static void Executar()
        {

            bool bomcorpamento;
            string entrada;
            Console.WriteLine(" Informe a nota do aluno !!!");
            entrada = Console.ReadLine();

            Double.TryParse(entrada, out double nota);

            Console.WriteLine("O aluno em questão pussui bom corpamento Responad (S/N) ");
            entrada = Console.ReadLine();

            bomcorpamento = entrada.ToLower()=="s";
            if (nota>=9.0 && bomcorpamento) {
                Console.WriteLine($"Quadro de honra");
            }
            Console.WriteLine($" a nota do aluno é {nota}  seu comportamento {bomcorpamento} ");
        }
    }
}
