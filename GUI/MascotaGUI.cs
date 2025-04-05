using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace GUI
{
    public class MascotaGUI
    {
        private MascotaBLL mascotaBLL = new Mascota();
        private PropietarioBLL propietarioBLL = new PropietarioBLL();

        public void RegistrarMascota()
        {
            Console.WriteLine("\n=== Registro de Mascota ===");
            Console.Write("Nombre del Propietario (Cédula): ");
            string cedula = Console.ReadLine();

            Propietario propietario = propietarioBLL.ObtenerPropietario(cedula);
            if (propietario == null)
            {
                Console.WriteLine("Propietario no encontrado.");
                return;
            }

            Console.Write("Nombre de la Mascota: ");
            string nombre = Console.ReadLine();
            Console.Write("Especie: ");
            string especie = Console.ReadLine();
            Console.Write("Raza: ");
            string raza = Console.ReadLine();
            Console.Write("Edad: ");
            int edad = int.Parse(Console.ReadLine());

            Mascota mascota = new Mascota(nombre, especie, raza, edad, propietario);
            string resultado = mascotaBLL.AgregarMascota(mascota);

            Console.WriteLine(resultado);
        }

        public void ConsultarMascotasPorPropietario()
        {
            Console.WriteLine("\n=== Consultar Mascotas por Propietario ===");
            Console.Write("Ingrese la cédula del propietario: ");
            string cedula = Console.ReadLine();

            var mascotas = mascotaBLL.ObtenerMascotasPorPropietario(cedula);
            if (mascotas.Count == 0)
            {
                Console.WriteLine("No se encontraron mascotas para este propietario.");
            }
            else
            {
                Console.WriteLine("Mascotas registradas:");
                foreach (var mascota in mascotas)
                {
                    Console.WriteLine($"- {mascota.Nombre}, {mascota.Especie}, {mascota.Raza}, {mascota.Edad} años.");
                }
            }
        }
    }
}
