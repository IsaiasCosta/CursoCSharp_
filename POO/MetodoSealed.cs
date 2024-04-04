namespace CursoCSharp.POO {
    //Quando aplicado a uma classe, o modificador sealed impede que outras classes herdem dela.

    sealed class SemFilho {
        public double ValorDaFortuna() {
            return 5_655_125_080.090;
        }
    }
    //class SouFilho : SemFilho {
    //}

    class Avo {
        public virtual bool HonrarNomeFamilia() {  // virtual permite ser sobescrito
            return true;
        }
    }

    class Pai : Avo {
        public override sealed bool HonrarNomeFamilia() { // selado e permite sobescrever
            return true;
        }
    }

    class FilhoRebelde : Pai {
        //public override bool HonrarNomeFamilia() { // A classe Pai é selada, não permite sobre escrever
        //return false;
        //}
    }
    internal class MetodoSealed {
        public static void Executar() {
            SemFilho semFilho = new SemFilho();
            Console.WriteLine($"{semFilho.ValorDaFortuna()}");
            FilhoRebelde fihorebelde = new FilhoRebelde();
            Console.WriteLine($"{fihorebelde.HonrarNomeFamilia()}");
        }
    }
}
