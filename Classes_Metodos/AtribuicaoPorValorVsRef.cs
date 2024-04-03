using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Classes_Metodos {
    public class Dependente {  // Sendo classe a passagem é por valor , sendo Strucg a passem é por referencia
        public string Nome;
        public int Idade;
    }
     class AtribuicaoPorValorVsRef { 
        public static void Executar() {
            int numero = 9;
            int copiaNumero = numero;
            Console.WriteLine($"{numero} {copiaNumero}");
            numero++;
            Console.WriteLine($"{numero} {copiaNumero}");

            Dependente dep = new Dependente {
                Nome = "Luiza",
                Idade = 25,
            };

            Dependente copiaDep = dep;
            Console.WriteLine($"{dep.Nome} {copiaDep.Nome}");
            Console.WriteLine($"{dep.Idade}{copiaDep.Idade}");
            Console.WriteLine();
            copiaDep.Nome = "Ana";
            dep.Idade = 45;

            Console.WriteLine($"{dep.Nome} {copiaDep.Nome}");
            Console.WriteLine($"{dep.Idade}{copiaDep.Idade}");

        }             
    }
}
