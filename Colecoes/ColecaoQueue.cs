using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes {
    class ColecaoQueue {
        /* FIFO: First in first out : primeiro a enrar peimeiro a sair*/
        public static void Executar() {
            var fila = new Queue<string>();// Usando Generic
            // Adiciona um elemento ao final do Queue<T>.

            fila.Enqueue("Luiza");
            fila.Enqueue("Carla");
            fila.Enqueue("Antonia");
            fila.Enqueue("Marluse");

            /*Peek retorna o elemento mais antigo 
             * que está no início do , mas não o remove do .
             */
            Console.WriteLine($"{fila.Peek()}");
            Console.WriteLine(fila.Count);
            //remove o elemento mais antigo do início do fila/
            Console.WriteLine($"{fila.Dequeue()}");
            Console.WriteLine(fila.Count);

            foreach (var pessoa in fila) {
                Console.WriteLine(pessoa);
            }
            Console.WriteLine("----------------------------");
            var saladaDeTipo = new Queue(); //Sem usar generic
            saladaDeTipo.Enqueue(4);
            saladaDeTipo.Enqueue("texto");
            saladaDeTipo.Enqueue(5.7);
            saladaDeTipo.Enqueue(false);
            saladaDeTipo.Enqueue('k');
            foreach (var salada in saladaDeTipo) { 
                Console.WriteLine(salada);
                Console.WriteLine(saladaDeTipo.Contains('k'));
            }
       
        }
    }
}
