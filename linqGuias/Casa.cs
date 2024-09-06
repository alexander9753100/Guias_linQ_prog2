using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqGuias
{
    public class Casa
    {
        // Declaración de la clase Casa, que representa una estructura de datos para almacenar información de una casa.
        public int Id { get; set; }
        // Propiedad pública que almacena el identificador único de la casa. Es de tipo entero y tiene get (para obtener el valor) y set (para asignar el valor).
        public string Direccion { get; set; }
        // Propiedad pública para almacenar la dirección de la casa, de tipo string. También tiene métodos get y set.
        public string Ciudad { get; set; }
        // Propiedad pública para almacenar el nombre de la ciudad donde se ubica la casa, de tipo string.
        public int numeroHabitaciones { get; set; }
        // Propiedad pública que almacena el número de habitaciones de la casa, de tipo entero.
        public string dameDatosCasa()
        // Método público que no recibe parámetros y devuelve un string con los datos de la casa (dirección, ciudad y número de habitaciones).
        {

            return $"Direcion es {Direccion} en la ciudad de {Ciudad} con numero de habitaciones {numeroHabitaciones}";
            // Devuelve una cadena con los datos concatenados usando interpolación de strings, mostrando la dirección, ciudad y número de habitaciones.
        }

    }
}
