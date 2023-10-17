using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Musical.Models.ViewModels
{
    public class ListTablaViewModel
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Genero { get; set; }
        public string Instrumentos { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
    }
}