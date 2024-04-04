using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;


namespace CursoCSharp.Colecoes {
    class ColecaoDictionary {

        /*A Dictionary<TKey, TValue>é uma coleção genérica que armazena pares de valores-chave 
        sem nenhuma ordem específica.*/

        /* ======== Características do dicionário ====== */

        /*  Dictionary<TKey, TValue> armazena pares de valores-chave.
        //Vem no System.Collections.Genericnamespace.
        //Implementa a interface IDictionary<TKey, TValue> .
        //As chaves devem ser exclusivas e não podem ser nulas.
        //Os valores podem ser nulos ou duplicados.
        //Os valores podem ser acessados ​​passando a chave associada no indexador, por exemplomyDictionary[key]
        Os elementos são armazenados como objetos KeyValuePair<TKey, TValue>.*/
        public static void Executar() {
            var filmes = new Dictionary<int, string>();

            filmes.Add(2000, "Gladiador");
            filmes.Add(2022, "Homem -Aranha");
            filmes.Add(2016, "Ninja kamui");
            filmes.Add(2021, "Invencivel");
            filmes.Add(2018, "Terra Vermelha");

            if (filmes.ContainsKey(2021)) { //Metodo infrpma se contem o dado
                Console.WriteLine($"{filmes[2018]}");
                Console.WriteLine($"{filmes.GetValueOrDefault(2021)}");
            }
            Console.WriteLine("--------------------------");

            Console.WriteLine($"{filmes.ContainsValue("Rock VI")}");

            Console.WriteLine($"{filmes.Remove(2000)}");
            Console.WriteLine("--------------------------");
            filmes.TryGetValue(2018, out string filme2018);

            Console.WriteLine("--------------------------");

            Console.WriteLine($"Existe esse filme ? {filme2018}");
            foreach (var filme in filmes.Values) {
                Console.WriteLine(filme);
            }
            // Percorre  usando a chave
            foreach (var chave in filmes.Keys) {
                Console.WriteLine($"Percorre  usando a chave{ chave}");
            Console.WriteLine("--------------------------");

            }
            //Percorer usando o valor

            foreach (var valor in filmes.Values) { 
                Console.WriteLine($" Percorer usando o valor{valor}");
            }
            Console.WriteLine("--------------------------");

            // pecorre chave e valor ao meso tempo
            foreach (KeyValuePair<int, string> filme in filmes) {
                Console.WriteLine($"{filme.Value} é de {filme.Key}");
            }
        }
    }
}
