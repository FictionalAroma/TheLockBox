using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using LockBoxAPI.Data;
using LockBoxAPI.Handlers.Interfaces;
using LockBoxAPI.Models;

namespace LockBoxAPI.Handlers
{
    public class LockSessionHandler : ILockSessionHandler
    {
        private readonly LockBoxDataAccess _dataLayer;

        public LockSessionHandler(LockBoxDataAccess dataLayer)
        {
            _dataLayer = dataLayer;
        }

        public LockSessionModel GetSession(string guid)
        {
            var rawSession =_dataLayer.GetSession(guid);
            return rawSession == null ? null : new LockSessionModel(rawSession);
        }
    }
}