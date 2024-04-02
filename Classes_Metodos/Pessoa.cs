using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Classes_Metodos {
    class Pessoa {
        // atributo
        public string Nome;
        public int Idade;
        //Metodo com retorno
        public string Apresentar() {
            return string.Format($"Olá ! Me chamo {Nome} e tenho {Idade} anos de  Idade");
        }

        // Metodo sem retorno
        public void ApresentarNoConsole() {
            Console.WriteLine(Apresentar()); //chamar um metodo dentro de outro metodo
        }


    }
}
