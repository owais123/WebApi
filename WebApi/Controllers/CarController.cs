using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using System.Web;
namespace WebApi.Controllers
{
    public class CarController : ApiController
    {
        public ActionResult Car()
        {
            return View("CarStock");
        } 
    }
}
