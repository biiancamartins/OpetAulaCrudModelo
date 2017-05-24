using Bianca162a.Models;
using Bianca162a.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bianca162a.Controllers
{
    public class FabricantesController : Controller
    {
        private EFContexts context = new EFContexts();
        //	GET:	Fabricantes
        public ActionResult Index()
        {
            return View(context.Fabricantes.OrderBy(
                            c => c.Nome));
        }
    }

}

        