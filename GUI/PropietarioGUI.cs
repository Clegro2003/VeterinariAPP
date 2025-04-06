using BLL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace GUI
{
    public class PropietarioGUI
    {
        private PropietarioService servicePropietario = new PropietarioService();

        public void Consultar_Y_Mostrar()
        {
            char eleccion = 'S';

            while (eleccion == 'S' || eleccion == 's')
            {
                ConsultarPropietarios();
                RegistrarPropietario();

                Console.SetCursorPosition(50, 20);
                Console.Write("¿Desea registrar otro propietario? (S/N): ");
                eleccion = Console.ReadKey().KeyChar;
                Console.Clear();
            }
        }

        public void RegistrarPropietario()
        {
            //Console.Clear();

            Propietario propietario = new Propietario();
            //Console.SetCursorPosition(40, 2); Console.WriteLine("=== REGISTRO DE PROPIETARIO ===");

            Console.SetCursorPosition(20, 4); Console.Write("Cédula: ");
            Console.SetCursorPosition(40, 4); Console.Write("Nombre: ");
            Console.SetCursorPosition(60, 4); Console.Write("Apellido: ");
            Console.SetCursorPosition(80, 4); Console.Write("Teléfono: ");
            
            Console.SetCursorPosition(28, 4); propietario.Cedula = int.Parse(Console.ReadLine());
            Console.SetCursorPosition(48, 4); propietario.Nombre = Console.ReadLine();
            Console.SetCursorPosition(70, 4); propietario.Apellido = Console.ReadLine();
            Console.SetCursorPosition(90, 4); propietario.Telefono = long.Parse(Console.ReadLine());

            var resultado = servicePropietario.Guardar(propietario);

            Console.WriteLine(resultado);
        }

        public void ConsultarPropietarios(List<Propietario> lista = null)
        {
            if (lista == null)
            {
                lista = servicePropietario.Consultar();
            }
            Console.Clear();
            Console.SetCursorPosition(40, 2); Console.Write("SISTEMAS DE PROCESAMIENTO DE PROPPIETARIOS");
            int i = 0;
            foreach (var item in lista)
            {
                Console.SetCursorPosition(20, 8); Console.Write("Cédula");
                Console.SetCursorPosition(35, 8); Console.Write("Nombre");
                Console.SetCursorPosition(50, 8); Console.Write("Apellido");
                Console.SetCursorPosition(68, 8); Console.Write("Teléfono");

                Console.SetCursorPosition(19, 9); Console.Write("======================================================================");

                Console.SetCursorPosition(20, 10 + i); Console.Write(item.Cedula);
                Console.SetCursorPosition(35, 10 + i); Console.Write(item.Nombre);
                Console.SetCursorPosition(50, 10 + i); Console.Write(item.Apellido);
                Console.SetCursorPosition(68, 10 + i); Console.Write(item.Telefono);

                i++;
            }

            Console.SetCursorPosition(19, 9 + i); Console.Write("======================================================================");
            //Console.ReadKey();
        }
    }
}
