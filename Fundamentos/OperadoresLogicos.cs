using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class OperadoresLogicos {
        public static void Executar() {

            // tabela verdade
            var executouTrabalho01 = true;
            var executouTrabalho02 = false;
            // AND
            bool comprouTv50 = executouTrabalho01 && executouTrabalho02;
            Console.WriteLine($"Comprou Tv de 50 ? {comprouTv50} - Operador AND (&&)");

            // OR
            bool comprouSorvete = executouTrabalho01 || executouTrabalho02;
            Console.WriteLine($"Comprou Sorvete? {comprouSorvete} - Operador OR (||)");
            Console.WriteLine($"Mais saldavel ?  {!comprouSorvete}- Operador OR (||)");

            //XOR exclusivo
            bool comprouTv32 = executouTrabalho01 ^ executouTrabalho02;
            Console.WriteLine($"Comprou Tv de 32 {comprouTv32} - Operador XOR (^)");
        }

    }
}
