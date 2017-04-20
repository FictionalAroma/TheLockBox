using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace LockBoxAPI.Controllers
{
    public class LockSessionController : ApiController
    {
        // GET: LockSession
        public ActionResult GetEndDateTime()
        {
            return new JsonResult {Data = DateTime.Now};
        }
    }
}