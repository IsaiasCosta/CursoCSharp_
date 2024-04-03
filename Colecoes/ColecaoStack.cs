using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes {
    class ColecaoStack {
        /*Stacké um tipo especial de coleção que armazena elementos no estilo LIFO (Last In First Out).
         * C# inclui as classes de coleção genéricas Stack<T>e não genéricas Stack. 
         * Recomenda-se usar a Stack<T>coleção genérica.
         * Stack é útil para armazenar dados temporários no estilo LIFO, 
         * e você pode querer excluir um elemento após recuperar seu valor.
         */
        public static void Executar() {
            var pilha = new Stack();

            pilha.Push("texto");
            pilha.Push(4.5);
            pilha.Push(3.1f);
            pilha.Push(false);
            pilha.Push('d');
            foreach (var item in pilha) {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------------------");
            
            Console.WriteLine("retorna o último elemento e o remove de uma pilha", pilha.Pop());
            Console.WriteLine("método retorna o último valor adicionado da pilha, mas não o remove.", pilha.Peek());
            
            Console.WriteLine(pilha.Contains("texto"));
            
            
            
          
        }
    }
}
