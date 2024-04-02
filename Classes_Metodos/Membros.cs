using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Classes_Metodos {
    class Membros {
        // Metodo sem retorno
        public static void Executar() {

            // Criando o Objeto da classe
            Pessoa sicrano = new Pessoa();
            sicrano.Nome = "Isaias";
            sicrano.Idade = 48;
            //Console.WriteLine($" Nome do sicrano {sicrano.Nome} a Idade do sicrano é {sicrano.Idade}");

            //sicrano.ApresentarNoConsole();

            var fulano = new Pessoa();
            fulano.Nome = "Fulano B";
            fulano.Idade = 56;
            var apresentacaoDoFulano = fulano.Apresentar();
            Console.WriteLine(apresentacaoDoFulano);
        }
    }
}
