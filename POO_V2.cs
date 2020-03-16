using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicav02
{
    class Program
    {
        static void Main(string[] args)
        {
            Apartamento apartamento = new Apartamento();
            Console.WriteLine("Agregar datos de Apartamento: ");
            Console.WriteLine("Direccion: ");
            apartamento.direccion = Console.ReadLine();
            Console.WriteLine("Color: ");
            apartamento.Color = Console.ReadLine();
            Console.WriteLine("Area de construccion: ");
            apartamento.AreaConstruccion = Console.ReadLine();
            Console.WriteLine("Parqueo: ");
            apartamento.parqueo = Console.ReadLine();
            Console.WriteLine("Habitaciones: ");
            apartamento.habitacion = Console.ReadLine();
            Console.WriteLine("Baños: ");
            apartamento.banos = Console.ReadLine();



        }

        public class Apartamento
        {

            string direccion { get; set; }
            string Color { get; set; }
            string AreaConstruccion { get; set; }
            string parqueo { get; set; }
            string habitacion { get; set; }
            string bano { get; set; }



            public Apartamento(string di, string co, string area, string par, string habi, string bano)
            {
                this.direccion = di;
                this.color = co;
                this.AreaConstruccion = area;
                this.parqueo = par;
                this.habitacion = habi;
                this.bano = bano;

            }


            public void Imprimir()
            {
                Console.WriteLine("Caracteristicas: ");
                Console.WriteLine("Direccion ", direccion);
                Console.WriteLine("Color ", Color);
                Console.WriteLine("Area de Construccion ", AreaConstruccion);
                Console.WriteLine("Parqueo ", parqueo);
                Console.WriteLine("Habitaciones ", habitacion);
                Console.WriteLine(" Baños ", bano);
                Console.ReadLine();
            }
            public void vender()
            {
                Console.WriteLine("Caracteristicas: ");
                Console.WriteLine("Direccion ", direccion);
                Console.WriteLine("Color ", Color);
                Console.WriteLine("Area de Construccion ", AreaConstruccion);
                Console.WriteLine("Parqueo ", parqueo);
                Console.WriteLine("Habitaciones ", habitacion);
                Console.WriteLine(" Baños ", bano);
                Console.ReadLine();
            }
        }
    }

}
