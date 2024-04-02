using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle {
    internal class EstruturaFor {
        public static void Executar() {

            // Uma outra forma de  fazer uam estrutura de repetição
            /*int i = 1;
            while (i<=10) {
                Console.WriteLine($"Valor de i {i}");
                i++;
            }
            Console.WriteLine("==========================");

            // Usando o for

            for (int a = 0; a <=10; a++) {
                Console.WriteLine($"Valor de A = {a}");
            }*/

            double somatoria = 0;
            string entrada;
            Console.WriteLine("Qual é o tamanho da turma ?");
            entrada = Console.ReadLine();
            int.TryParse(entrada, out int tamanhoTurma);
            for (int i = 1; i <= tamanhoTurma; i++) {
                Console.WriteLine("Digite a nota do aluno - nota informada {0}");
                entrada += Console.ReadLine();
                double.TryParse(entrada, out double notaAtual);
                somatoria += notaAtual;
            }
            double media = tamanhoTurma > 0 ? somatoria/tamanhoTurma :0;
            Console.WriteLine(" Média da turma = {0}", media);

        }
    }
}
