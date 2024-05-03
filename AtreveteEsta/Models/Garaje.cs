using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AtreveteEsta.Models
{
    public class Garaje
    {
        
        public string PropietarioId { get; set; }
        public string Direccion { get; set; }
        public double Latitud { get; set; }
        public double Longitud { get; set; }
        public double Alto { get; set; }
        public double Ancho { get; set; }
        public double Largo { get; set; }
        public string Estado { get; set; }
        
        public string Precio { get; set; }
    }
}