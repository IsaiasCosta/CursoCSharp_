using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
    internal class EstruturaSwitch {
        public static void Executar() {

            Console.WriteLine(" Avalie o meu atendiemento com as notas de 1 a 5");
            int.TryParse(Console.ReadLine(), out int nota);
            switch (nota)
            {
                case 1:
                    Console.WriteLine("Atendimento Pessimo ");
                    break;

                case 2:
                    Console.WriteLine("Atendimento Ruim ");
                    break;

                case 3:
                    Console.WriteLine("Atendimento Buim ");
                    break;
                case 4:
                    Console.WriteLine("Atendimento Otimo ");
                    break;
                case 5:
                    Console.WriteLine("Atendimento Execelente ");
                    break;
                    default:
                    Console.WriteLine("Nota invalida !!");
                    break;
            }        
        }
    }
}
