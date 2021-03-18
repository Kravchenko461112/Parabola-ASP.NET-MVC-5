using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1;
using WebApplication1.Models;

using static WebApplication1.Models.FunctionData;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult JsonOrdersData(FunctionData model)   // В этом методе сериализация происходит автоматически

        {
            MassiveParabolaChartPoints mas = new MassiveParabolaChartPoints();

            mas.MassivePoints(model);


            return Json(model.Points, JsonRequestBehavior.AllowGet);

        }
    }
}