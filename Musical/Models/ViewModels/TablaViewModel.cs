using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Musical.Models.ViewModels
{
    public class TablaViewModel
    {
        public int Id { get; set; }
        [Required]
        [Display(Name ="Titulo")]
        public string Titulo { get; set; }
        [Required]
        [Display(Name = "Autor")]
        public string Autor { get; set; }
        [Required]
        [Display(Name = "Genero")]
        public string Genero { get; set; }
        [Required]
        [Display(Name = "Instrumentos")]
        public string Instrumentos { get; set; }
        [Required]
        [Display(Name = "Fecha")]
        public DateTime Fecha { get; set; }
        [Required]
        [Display(Name = "Descripcion")]
        public string Descripcion { get; set; }
    }
}