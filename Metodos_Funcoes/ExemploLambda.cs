namespace CursoCSharp.Metodos_Funcoes {
    internal class ExemploLambda {
        public static void Executar() { //Action não tem retorno
            Action algoNoconsole = () => { //função anonima 

                Console.WriteLine("Lambda no CSharp !!!");
            };
            algoNoconsole();

            Func<int> jograDado = () => { // Func: permiti retorno 
                Random random = new Random();
                return random.Next(1,10);
            };
            Console.WriteLine(jograDado());

            Func<int, string> conversorHex = numero => numero.ToString("X");
            Console.WriteLine(conversorHex(1234));

            Func<int,int,int,string> formatData = (dia, mes, ano) =>
            String.Format("{0:D2}/{1:D2}/{2:D4}",dia,mes,ano);
            Console.WriteLine($"{formatData(4,4,2024)}");

        }
    }
}
