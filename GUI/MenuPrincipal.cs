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
        private readonly MenuPopietario menuPopietario = new MenuPopietario();
        private ConsultaVeterinariaGUI consultaVeterinariaGUI = new ConsultaVeterinariaGUI();

        public void Menu()
        {
            bool continuar = true;

            while (continuar)
            {
                MostrarMenu();

               Console.SetCursorPosition(73, 19); string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        menuPopietario.Menu();
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
            Console.SetCursorPosition(50, 12); Console.WriteLine("=== Sistema de Gestión de Mascotas - VetVida ===".ToUpper());
            Console.SetCursorPosition(50, 13); Console.WriteLine("1. Registrar Propietario");
            Console.SetCursorPosition(50, 14); Console.WriteLine("2. Registrar Mascota");
            Console.SetCursorPosition(50, 15); Console.WriteLine("3. Registrar Consulta Veterinaria");
            Console.SetCursorPosition(50, 16); Console.WriteLine("4. Consultar Mascotas por Propietario");
            Console.SetCursorPosition(50, 17); Console.WriteLine("5. Consultar Historial de Consultas de una Mascota");
            Console.SetCursorPosition(50, 18); Console.WriteLine("6. Salir");
            Console.SetCursorPosition(50, 19); Console.Write("Seleccione una opción: ");

        }
    }

}

