using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ADSEvaluacion1.Models;

namespace ADSEvaluacion1.Controllers
{
    public class OperacionesController : Controller
    {
        // GET: Operaciones
        public ActionResult Operaciones_Aritmeticas()
        {
            var operacion = new Operacion()
            {
                valor1 = 30,
                valor2 = 2,
            };
            return View(operacion);
        }
    }
}