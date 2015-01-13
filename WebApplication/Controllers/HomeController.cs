using GrainInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ActionResult> Index()
        {
            var grain = Grain1Factory.GetGrain(0);
            ViewBag.GrainMachineName = await grain.GetMachineName();
            ViewBag.MvcMachineName = Environment.MachineName;
            return View();
        }
    }
}