using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Classes_Metodos {

    public enum Genero {Acao, Aventura,Terror, Animacao, Comedia}

    public class Filme{
        public string Titulo;
        public Genero GeneroDoFilme;

    }
    class MetodoEnum {
        public static void Executar() {
            int id = (int)Genero.Aventura;
            Console.WriteLine(id);

            var filmeParaFamilia = new Filme();
            filmeParaFamilia.Titulo = "Piratas do Caribe";
            filmeParaFamilia.GeneroDoFilme = Genero.Acao;
            Console.WriteLine($" Nome do filme : {filmeParaFamilia.Titulo} qual é o genero: {filmeParaFamilia.GeneroDoFilme}");
        }
    }
}
