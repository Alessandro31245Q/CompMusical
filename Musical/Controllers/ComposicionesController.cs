using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.DynamicData;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using Musical.Models;
using Musical.Models.ViewModels;

namespace Musical.Controllers
{
    public class ComposicionesController : Controller
    {
        // GET: Composiciones
        public ActionResult Index()
        {
            List<ListTablaViewModel> lst;

            using (musicEntities db = new musicEntities())
            {
                lst = (from d in db.Composiciones
                          select new ListTablaViewModel
                          {
                              Id = d.ID,
                              Titulo = d.Titulo,
                              Autor = d.Autor,
                              Genero = d.Genero,
                              Instrumentos = d.Instrumentos,
                              Fecha = (DateTime)d.Fecha,
                              Descripcion = d.Descripcion
                          }).ToList();
            }

            return View(lst);
        }
        public ActionResult Nuevo() 
        {
            return View();
        }
        [HttpPost]
        public ActionResult Nuevo(TablaViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (musicEntities db = new musicEntities())
                    {
                        var oTabla = new Composiciones();
                        oTabla.Titulo = model.Titulo;
                        oTabla.Autor = model.Autor;
                        oTabla.Genero = model.Genero;
                        oTabla.Instrumentos = model.Instrumentos;
                        oTabla.Fecha = model.Fecha;
                        oTabla.Descripcion = model.Descripcion;

                        db.Composiciones.Add(oTabla);
                        db.SaveChanges();
                    }
                    return Redirect("~/Composiciones/");
                }
                
                   return View(model);
                
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}