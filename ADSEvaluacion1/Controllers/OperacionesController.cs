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
        public ActionResult Operaciones_Aritmeticas(Int32 opc = 0, Double v1=0, Double v2=0)
        {
            var operacion = new Operacion() { };

            switch (opc)
            {
                case 1:
                    operacion.ope = "Suma";
                    operacion.res = v1 + v2;
                    break;
                case 2:
                    operacion.ope = "Resta";
                    operacion.res = v1 - v2;
                    break;
                case 3:
                    operacion.ope = "Multiplicación";
                    operacion.res = v1 * v2;
                    break;
                case 4:
                    operacion.ope = "División";
                    operacion.res = v1 / v2;
                    break;
                default:
                    operacion.ope = "No definida";
                    operacion.res = 0;
                    break;
            } 
            return View(operacion);
        }
    }
}