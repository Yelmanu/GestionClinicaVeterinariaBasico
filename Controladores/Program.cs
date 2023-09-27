using GestionClinicaVeterinaria.Servicios;

namespace GestionClinicaVeterinaria
{
    /// <summary>
    /// Clase que controla el flujo de procedimientos de la aplicación
    /// </summary>
    class Program
    {
        /// <summary>
        /// Método de entrada de la aplicación
        /// Contiene el procedimiento de la aplicación
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Instanciamos la clase que contiene los métodos de la aplicación
            MenuInterfaz aplicacionClinicaVeterinaria = new MenuImplementacion();

            aplicacionClinicaVeterinaria.mensajeBienvenida();
            //Creamos una variable bool y una variable int para el menu (bool para el control
            //de flujo while e int para capturar la opcion introducida por el usuario)
            bool cerrarMenu = false;
            int opcionIntroducida;

            //Bucle while para controlar cuando se muestra o se cierra el menú
            while(!cerrarMenu)
            {
                opcionIntroducida = aplicacionClinicaVeterinaria.mostrarMenu();
                Console.WriteLine("[INFO] Has seleccionado la opción {0}", opcionIntroducida);

                switch(opcionIntroducida )
                {
                    case 0:
                        Console.WriteLine("[INFO] Se cerrará la aplicación");
                        cerrarMenu = true;
                        break;
                    case 1:
                        Console.WriteLine("[INFO] Se ejecutará la opción 1");
                        break;
                    case 2:
                        Console.WriteLine("[INFO] Se ejecutará la opción 1");
                        break;
                    case 3:
                        Console.WriteLine("[INFO] Se ejecutará la opción 1");
                        break;
                    case 4:
                        Console.WriteLine("[INFO] Se ejecutará la opción 1");
                        break;
                    default:
                        Console.WriteLine("[INFO] La opción seleccionada no existe");
                        break;
                }
            }
        }
    }
}
