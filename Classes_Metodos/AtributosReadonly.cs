using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace CursoCSharp.Classes_Metodos {
    internal class AtributosReadonly {

        public class Cliente { 
            public string Nome;
           readonly DateTime Nascimento; // Readonly e avaliado e imutavel em tempo de executado do programa, obrigadorio iniciar a constante

            public Cliente(string nome, DateTime nascimento) { 
                Nome = nome;
                Nascimento = nascimento;
            }
            public string GetDatanascimento() {
                return string.Format("{0}/{1}/{2}", Nascimento.Day, Nascimento.Month,Nascimento.Year);
            }
        }
        public static void Executar() {
            var novoCliente = new Cliente("Isaias",new DateTime(1977,05,25));
            Console.WriteLine(novoCliente.Nome);
            Console.WriteLine(novoCliente.GetDatanascimento());
        }
    }
}
