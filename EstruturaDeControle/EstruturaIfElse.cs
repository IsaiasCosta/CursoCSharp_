using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
    internal class EstruturaIfElse
    {
        public static void Executar() {
        
            Console.WriteLine("Ente com a nota !!!");

            double.TryParse(Console.ReadLine(), out double nota);
            if (nota >= 7.0) { 
                Console.WriteLine($"{nota} Aprovado, vocÊ fez mais doque a sua obrigação "!);
            }else{
                Console.WriteLine($"{nota} Reprovado, você esta obrigado a estudar muito mais "!);
            }

        }
    }
}
