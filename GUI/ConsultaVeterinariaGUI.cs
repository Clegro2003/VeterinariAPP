using BLL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace GUI
{
    public class ConsultaVeterinariaGUI
    {
        private readonly ConsultaVeterinariaSevice consultaService;
        private readonly MascotaService mascotaService;

        public void RegistrarConsulta()
        {
            ConsultaVeterinaria consulta = new ConsultaVeterinaria();
            Console.WriteLine("\n=== Registrar Consulta Veterinaria ===");
            Console.Write("Ingrese el nombre de la mascota: ");
            consulta.Mascota.Nombre = Console.ReadLine();
            //Validar que existe Mascota en la BLL

            Console.Write("Fecha (YYYY-MM-DD): ");
            consulta.Fecha = DateTime.Parse(Console.ReadLine());
            Console.Write("Nombre del Veterinario: ");
            consulta.Veterinario.Nombre = Console.ReadLine();
            Console.Write("Diagnóstico: ");
            consulta.Diagnostico = Console.ReadLine();
            Console.Write("Tratamiento: ");
            consulta.Tratamiento = Console.ReadLine();
            var resultado = consultaService.Guardar(consulta);

            Console.WriteLine(resultado);
        }

        public void ConsultarHistorialMascota()
        {
            Console.WriteLine("\n=== Historial de Consultas ===");
            Console.Write("Ingrese el nombre de la mascota: ");
            //string nombreMascota = Console.ReadLine();

            var historial = consultaService.Consultar();
            if (historial.Count() == 0)
            {
                Console.WriteLine("No hay consultas registradas para esta mascota.");
            }
            else
            {
                Console.WriteLine("Historial de consultas:");
                foreach (var consulta in historial)
                {
                    Console.WriteLine($"- {consulta.Fecha}: {consulta.Diagnostico} (Tratamiento: {consulta.Tratamiento})");
                }
            }
        }
    }
}