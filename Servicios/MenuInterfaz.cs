using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionClinicaVeterinaria.Servicios
{
    /// <summary>
    /// Interfaz que corresponde a la funcionalidad del menu
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Muestra el mensaje de bienvenida
        /// 270923 - MDN
        /// </summary>
        public void mensajeBienvenida();
        /// <summary>
        /// Muestra el menú de la aplicación
        /// 270923 - MDN
        /// </summary>
        /// <returns></returns>
        public int mostrarMenu();
    }
}
