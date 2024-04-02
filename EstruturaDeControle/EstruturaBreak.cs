using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle {
    internal class EstruturaBreak {
        public static void Executar() { 
            Random random = new Random();
            int num = random.Next(1, 51);
            Console.WriteLine(num);

            for (int i = 0; i <= 50; i++) {
                Console.Write($"O numero que queremos é {i} " );
                if (i == num) {
                    Console.WriteLine("Sim");
                }else {
                    Console.WriteLine("Não ");
                }
            }
        }
    }
}
