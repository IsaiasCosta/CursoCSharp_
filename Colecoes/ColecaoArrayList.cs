using System;
using System.Collections;


namespace CursoCSharp.Colecoes {
    class ColecaoArrayList {
        public static void Executar() {
            var arraylist = new ArrayList{
                "Palavra",
                4,
                 false
            };
            arraylist.Add(6.7);

            foreach (var item in arraylist) {

                Console.WriteLine($" Conteudo do item = {item} - Tipo de dados do item = {item.GetType()}");
            }
        }

    }
}
