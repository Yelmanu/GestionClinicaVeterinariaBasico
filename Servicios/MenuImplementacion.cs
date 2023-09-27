using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionClinicaVeterinaria.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        /// <summary>
        /// Método que muestra un mensaje de bienvenida a la clínica veterinaria
        /// 270923 - MDN
        /// </summary>
        public void mensajeBienvenida()
        {
            string mensajeBienvenida = "Bienvenido/a a la clinica veterinaria.";

            Console.WriteLine(mensajeBienvenida);
        }
        /// <summary>
        /// Método que muestra el menu de la aplicación
        /// 270923 - MDN
        /// </summary>
        /// <returns></returns>
        public int mostrarMenu()
        {
            int opcionSeleccionada;

            Console.Write("Elige una opción: ");
            Console.WriteLine("\n0.- Salir.");
            Console.WriteLine("1.- Darse de alta.");
            Console.WriteLine("2.- Pedir cita.");
            Console.WriteLine("3.- Cancelar cita.");
            Console.WriteLine("4.- Historial de citas.");

            opcionSeleccionada = Console.ReadKey(true).KeyChar - ('0');
            return opcionSeleccionada;
        }
    }
}
