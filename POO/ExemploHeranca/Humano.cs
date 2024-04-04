namespace CursoCSharp.POO.ExemploHeranca
{
    class Humano : Animal
    {

        public static void Executar()
        {

            Humano res = new Humano();
            res.Respirar();

            Console.WriteLine($"{res.Respirar}");
        }
    }
}
