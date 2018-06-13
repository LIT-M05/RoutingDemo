using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RoutingDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Url = Request.Url.AbsoluteUri.Replace(Request.Url.PathAndQuery, "");
            return View();
        }

        public void SomePage(int id)
        {
            Response.Write($"<h1>SomePage id: {id}</h1>");
        }

        [Route("baz/qux/avrumi")]
        public void Foobar()
        {
            Response.Write($"<h1>Foobar page</h1>");
        }

        [Route("simchas/{simchaId}/contributions")]
        public void Lamborghini(int simchaId)
        {
            Response.Write($"<h1>Contributions for the {simchaId} simcha</h1>");
        }


        [Route("{title}")]
        public void Story(string title)
        {
            Response.Write($"<h1>Story page for {title}</h1>");
        }
    }
}