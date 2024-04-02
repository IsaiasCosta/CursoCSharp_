using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class OperadorTernario
    {
        public static void Executar() {
            /*  Veremos a 3 partes do operador ternario
             *  1 Expressão que torna verdadeiro ou falso 
             *  1 operado que ira atribuir  se sera verdadeira
             *  1 operado que ira atribuir  se sera falsa
             */


             bool bomCorptamento =true;
            Console.WriteLine("informe a  nota ");
            double.TryParse(Console.ReadLine(), out double nota);

            string resultado = nota >= 7.0 && bomCorptamento ? "Aprovado" : "Reprovado";

            Console.WriteLine($" Resultado {resultado}");


        }
    }
}
