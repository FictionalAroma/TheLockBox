

using System;
using System.Web.Helpers;
using System.Web.Http;
using System.Web.Mvc;
using LockBoxAPI.Handlers.Interfaces;
using LockBoxAPI.Models;

namespace LockBoxAPI.Controllers
{
    public class LockSessionController : ApiController
    {
        private readonly ILockSessionHandler _handler;

        public LockSessionController(ILockSessionHandler handler)
        {
            _handler = handler;
        }

        // GET: LockSession
        public ActionResult Get(string guid)
        {
            var sessionData = _handler.GetSession(guid);
            var data = sessionData != null ? sessionData.JsonOutput() : new { Error = $"None found for session{guid}"};
            return new JsonResult {Data = data};
        }

        public ActionResult CreateSession(CreateSessionModel creationInfo)
        {
            return new JsonResult {Data = new {Success = true}};
        }
    }
}