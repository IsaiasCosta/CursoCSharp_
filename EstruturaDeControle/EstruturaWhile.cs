using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
    internal class EstruturaWhile    {
        public static void Executar() {

            int palpite = 0;
            Random random = new Random();

            int numSegreto = random.Next(1,16);
            bool numEncontrado =false;  
            int tentativasRestantes= 5;
            int tentativas = 0;
            while(tentativasRestantes >0 && !numEncontrado) {
                Console.WriteLine("Entre com o seu Palpite");
                string entrada =Console.ReadLine();
                int.TryParse(entrada, out palpite);
                tentativas++;   
                tentativasRestantes--;
                if (numSegreto == palpite) {
                    numEncontrado = true;
                    var corAnterior = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Numero encontrado em {tentativas} tentativas");
                    Console.BackgroundColor = corAnterior;
                 
                } else if (palpite>numSegreto) {
                    Console.WriteLine($"Menor .... Tente novamente, restão {tentativasRestantes}");
                }else{
                    Console.WriteLine($"Maior .... Tente novamente, restão {tentativasRestantes}");
                }
               
            }
            Console.WriteLine("Fim do Jogo");
        }
    }
}
