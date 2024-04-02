using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace CursoCSharp.Classes_Metodos {


    class Carro {
        public string Modelo;
        public string Fabricante;
        public int Ano;


        // Dentro do construtor posso passar parametros

        public Carro(string modelo, string fabricante, int ano) {
            this.Modelo = modelo;
            this.Fabricante = fabricante;
            this.Ano = ano;
        }
        public Carro() { }
    }
    class Construtores {
        public static void Executar() {
            var carro1 = new Carro();
            carro1.Fabricante = "GM";
            carro1.Modelo = "Colat";
            carro1.Ano = 2020;
            Console.WriteLine($"{carro1.Fabricante} - {carro1.Modelo} - {carro1.Ano}");

            var carro2 = new Carro("Ka","ford",2021);

            Console.WriteLine( $"{carro2.Modelo} - {carro2.Fabricante} - {carro2.Ano}" );
        }
        
    }
}
