using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_POO_v02
{
    class Apartamento
    {
        static void Main(string[] args)
        {
            Apartamento edificio = new Apartamento();
            bool seguir = true;
            string entrada = "";

            while (seguir)
            {
                Console.Clear();
                
                Console.WriteLine("Elija la opcion que desee: ");
                Console.WriteLine("1 Datos apartamento ");
                Console.WriteLine("2 Vender Apartamento ");
                Console.WriteLine("3 Alquilar apartamento");
                entrada = Console.ReadLine();
                switch (entrada)
                {

                    case "1":
                        Console.Clear();

                        Console.WriteLine("Agregar datos de Apartamento: ");
                        Console.WriteLine("Direccion: ");
                        edificio.Direccion = Console.ReadLine();
                        Console.WriteLine("Color: ");
                        edificio.Color = Console.ReadLine();
                        Console.WriteLine("Area de construccion: ");
                       edificio.ConstruccionArea = Console.ReadLine();
                        Console.WriteLine("Parqueo: ");
                       edificio.Garage = Console.ReadLine();
                        Console.WriteLine("Habitaciones: ");
                        edificio.Habitaciones = Console.ReadLine();
                        Console.WriteLine("Baños: ");
                        edificio.Baños = Console.ReadLine();
                        edificio.Imprimir();
                      
                        break;

                    case "2":

                        Console.Clear();
                        edificio.Sell();
                        break;

                    case "3":
                        Console.Clear();

                        edificio.Rent();
                        break;
                    

                    default:
                        Console.WriteLine("Algo anda mal :( elija la opcion correcta :)");
                        Console.ReadLine();
                        break;
                     
                }
                Console.ReadKey();
            }
        }
    }

}