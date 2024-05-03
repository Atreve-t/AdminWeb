using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AtreveteEsta.Models
{
    public class Horario
    {
        public int Año { get; set; }
        public int Dia { get; set; }
        public int Mes { get; set; }
        public List<PeriodoHorario> Horarios { get; set; }
    }
}