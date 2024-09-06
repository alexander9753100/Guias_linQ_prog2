using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqGuias
{
    public class Casa
    {
        // Clase que representa una casa.
        public int Id { get; set; }
        // ID único de la casa.

        public string Direccion { get; set; }
        // Dirección de la casa.

        public string Ciudad { get; set; }
        // Ciudad donde se ubica la casa.

        public int numeroHabitaciones { get; set; }
        // Número de habitaciones.

        public string dameDatosCasa()
        {
            // Método que devuelve los datos de la casa.

            return $"Direcion es {Direccion} en la ciudad de {Ciudad} con numero de habitaciones {numeroHabitaciones}";
            // Retorna una cadena con los datos de la casa.
        }
    }


}
