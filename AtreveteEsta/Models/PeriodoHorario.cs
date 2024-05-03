using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AtreveteEsta.Models
{
    public class PeriodoHorario
    {
        public int HoraFin { get; set; }
        public int HoraInicio { get; set; }
        public int MinutoFin { get; set; }
        public int MinutoInicio { get; set; }
    }
}