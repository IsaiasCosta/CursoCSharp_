using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Classes_Metodos {

    public class Moto {

        private string Marca;
        private string Modelo;
        private uint Cilindrada;


        public Moto(string marca, string modelo, uint cilindrada) {
            Marca = marca;
            Modelo = modelo;
            Cilindrada = cilindrada;
        }
        public Moto() {

        }
        public string GetMarca() {
            return Marca;
        }
        public void SetMarca(string marca) {
            Marca = marca;
        }
        public string GetModelo() {
            return Modelo;
        }
        public void SetModelo(string modelo) {
            Modelo = modelo;
        }
        public uint GetCilindrada() {
            return Cilindrada;
        }
        public void SetCilindrada(uint cilindrada) {
            Cilindrada = cilindrada;
        }

    }
    internal class GetSet {
        public static void Executar() {
            var moto1 = new Moto("Honda","CB300",300);
            var moto2 = new Moto("Yamaha", "DT", 180);

            Console.WriteLine($"{moto1.GetMarca()} - {moto1.GetModelo()} - {moto1.GetCilindrada()}");
            Console.WriteLine($"{moto2.GetMarca()} - {moto2.GetModelo()} - {moto2.GetCilindrada()}");
        }
    }
}
