using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models
{
    public class Productos
    {

        public string ID { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Nombre_Cliente { get; set; }
        public string Direccion { get; set; }
        public string Piezas { get; set; }
        public decimal Forma_Pago { get; set; }
        public string Estatus { get; set; }
        public DateTime Fecha
        {
            get; set;
        }
    }
}
