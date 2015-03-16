using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tela_de_erro_customizavel.Controllers
{
    public class ErroController : Controller
    {
        public ActionResult Index()
        {
            int x = 0;

            if (Request.QueryString["c"] != null)
                int.TryParse(Request.QueryString["c"], out x);

            ViewBag.CodigoErro = x;

            return View();
        }
    }
}
