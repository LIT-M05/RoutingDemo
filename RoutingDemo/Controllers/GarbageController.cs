using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RoutingDemo.Controllers
{
    [RoutePrefix("notgarbage")]
    [Route("{action}")]
    public class GarbageController : Controller
    {
        public void Index()
        {
            Response.Write("<h1>Not garbage page<h1>");
        }

        public void About()
        {
            Response.Write("<h1>We do garbage stuffs<h1>");
        }

    }
}