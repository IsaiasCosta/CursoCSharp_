using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Classes_Metodos {

    interface Ponto {
        void MoverNaDiagonal(int delta);
    }
    struct Coodernada : Ponto {
        public int X;
        public int Y;

        public Coodernada(int x, int y) {
            X = x;
            Y = y;
        }
        public void MoverNaDiagonal(int delta) {
            X += delta;
            Y += delta;
        }
    }
    class MetodoStruct {

        public static void Executar() {
            Coodernada coodenadaInicial;
            coodenadaInicial.X = 2;
            coodenadaInicial.Y = 2;
            Console.WriteLine($"CoodernadaInicia do X = {coodenadaInicial.X}-CoodernadaInicia.Y = {coodenadaInicial.Y}");
            var coodenadaFinal = new Coodernada(x:7, y:3);
            coodenadaFinal.MoverNaDiagonal(15);
            Console.WriteLine("Coodernada Final ");
            Console.WriteLine($"X = {coodenadaFinal.X}");
            Console.WriteLine($"Y = {coodenadaFinal.Y}");

        }
    }
}
