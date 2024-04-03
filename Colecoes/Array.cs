using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes {
    internal class Array {
        public static void Executar() {
            /*Array e uma estrutura homogenia tosoa os dados são do mesmo tipo, 
             * Estatico mantem a quantidade iniciada, 
             * 
             */
            string[] alunos = new string[5];
            alunos[0] = "Isa";
            alunos[1] = "Lui";
            alunos[2] = "Fra";
            alunos[3] = "bui";
            alunos[4] = "Kill";
            foreach (string aluno in alunos) {
                Console.WriteLine($"{aluno}");
            }
            double somatoria = 0;
            double[] notas = { 7.8,9.3,5.4,15,8,5.3};
            foreach (var nota in notas) {
                somatoria += nota;
                Console.WriteLine($" Soma das notas = {somatoria.ToString("F2")}");
            }
            double media =somatoria / notas.Length;
            Console.WriteLine($"Media das notas{media.ToString("F2")}");

        }
    }
}
