using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AtreveteEsta.Models
{
    public class Usuario
    {
 
        public string email { get; set; }
        public string Password { get; set; }

        public string Tipo { get; set; }
        public int calificacion { get; set; }
    }
}