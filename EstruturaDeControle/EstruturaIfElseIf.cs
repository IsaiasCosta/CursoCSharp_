using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
    internal class EstruturaIfElseIf
    {
        public static void Executar() {
         
            Console.WriteLine("Entre com a nota do Aluno ");
            string entrada =Console.ReadLine();
             Double.TryParse(entrada, out double nota);

            if (nota > 0 && nota <=3.0) {
                Console.WriteLine($"Aluno esta Reprovado {nota}");
            }else if (nota > 3 && nota <6.0) {
                Console.WriteLine($"Aluno esta de Recuperação {nota} ");
            } else if (nota>7.0) {
                Console.WriteLine($"Aluno esta de Aprovado {nota} ");
            }
        }
    }
}
