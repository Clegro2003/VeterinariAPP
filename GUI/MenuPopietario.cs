using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    public class MenuPopietario
    {
        private PropietarioGUI propietarioGUI = new PropietarioGUI();
        public void Menu()
        {
            bool continuar = true;

            while (continuar)
            {
                MostrarMenu();
                Console.SetCursorPosition(74, 20); string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        propietarioGUI.RegistrarPropietario();
                        break;
                    case "2":
                        propietarioGUI.ConsultarPropietarios();
                        break;
                    case "3":
                        break;
                    case "4":
                        continuar = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Opción no válida. Intente nuevamente.");
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }
        }

        private void MostrarMenu()
        {
            Console.Clear();
            Console.SetCursorPosition(50, 12); Console.WriteLine("=== Sistema de Gestión de Mascotas - VetVida ===".ToUpper());
            Console.SetCursorPosition(50, 14); Console.Write("1. Registrar Propietario");
            Console.SetCursorPosition(50, 16); Console.Write("2. Consultar Propietario");
            Console.SetCursorPosition(50, 18); Console.Write("4. Salir");
            Console.SetCursorPosition(50, 20); Console.Write("Seleccione una opción: ");
        }
    }
}
