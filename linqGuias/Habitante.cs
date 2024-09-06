using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqGuias
{
    public class Habitante
    {
        // Clase que representa a un habitante.
        public int IdHabitante { get; set; }
        // ID del habitante.

        public string Nombre { get; set; }
        // Nombre del habitante.

        public int Edad { get; set; }
        // Edad del habitante.

        public int IdCasa { get; set; }
        // ID de la casa en la que vive.

        public string datosHabitante()
        {
            // Método que devuelve los datos del habitante.

            return $"Soy {Nombre} con edad de {Edad} años vividos en {IdCasa}";
            // Retorna una cadena con los datos del habitante.
        }
    }

}

