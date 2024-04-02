using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    internal class OperadoresRelacionais {
        public static void Executar() {
            //double nota;
            Console.WriteLine("INFORME A NOTA DO ALUNO " );
            double.TryParse(Console.ReadLine(),out double nota);
            Console.WriteLine($"NOTA INFORMADA {nota>10.0 } nota invalida - Operador >");
            Console.WriteLine($"NOTA INFORMADA {nota < 10.0 } nota invalida - Operador <");
            Console.WriteLine($"NOTA INFORMADA {nota == 10.0 } nota perfeita - Operador ==");
            Console.WriteLine($"NOTA INFORMADA {nota == 7.0 } nota de corte - Operador ==");
            Console.WriteLine($"NOTA INFORMADA {nota != 10.0 } tem que melhorar a nota - Operador !=");
            Console.WriteLine($"NOTA INFORMADA {nota >= 7.0 } passou por media - Operador >=");
            Console.WriteLine($"NOTA INFORMADA {nota < 7.0 } Recuperação- Operador <");
            Console.WriteLine($"NOTA INFORMADA {nota <= 3.0 } Reprovadoo - Operador <=");
            
        }
    }
}
