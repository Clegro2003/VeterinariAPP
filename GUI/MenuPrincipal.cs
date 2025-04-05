using BLL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    public class MenuPrincipal
    {
        private PropietarioGUI propietarioGUI = new PropietarioGUI();
        private MascotaGUI mascotaGUI = new MascotaGUI();
        private ConsultaVeterinariaGUI consultaVeterinariaGUI = new ConsultaVeterinariaGUI();

        public void Menu()
        {
            bool continuar = true;

            while (continuar)
            {
                MostrarMenu();
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        //propietarioGUI.RegistrarPropietario();
                        break;
                    case "2":
                        //mascotaGUI.RegistrarMascota();
                        break;
                    case "3":
                        consultaVeterinariaGUI.RegistrarConsulta();
                        break;
                    case "4":
                        //mascotaGUI.ConsultarMascotasPorPropietario();
                        break;
                    case "5":
                        consultaVeterinariaGUI.ConsultarHistorialMascota();
                        break;
                    case "6":
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente nuevamente.");
                        break;
                }

                Console.WriteLine("\nPresione cualquier tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        private void MostrarMenu()
        {
            Console.WriteLine("=== Sistema de Gestión de Mascotas - VetVida ===");
            Console.WriteLine("1. Registrar Propietario");
            Console.WriteLine("2. Registrar Mascota");
            Console.WriteLine("3. Registrar Consulta Veterinaria");
            Console.WriteLine("4. Consultar Mascotas por Propietario");
            Console.WriteLine("5. Consultar Historial de Consultas de una Mascota");
            Console.WriteLine("6. Salir");
            Console.Write("Seleccione una opción: ");
        }
    }

}

