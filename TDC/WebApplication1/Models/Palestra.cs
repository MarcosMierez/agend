using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Palestra
    {
        public string Titulo { get; set; }
        public string Codigo { get; set; }
        public string Nivel { get; set; }
        public string Descricao { get; set; }
        public Trilha Trilha { get; set; }
        public Sala Sala { get; set; }
        public DateTime Horario { get; set; }
        public Palestrante Palestrante { get; set; }
    }
}