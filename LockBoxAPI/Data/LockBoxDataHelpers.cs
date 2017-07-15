using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LockBoxAPI.Data
{
    public class LockBoxDataAccess
    {
        private readonly LockboxEntities _dataContext;

        public LockBoxDataAccess(LockboxEntities dataContext)
        {
            _dataContext = dataContext;
        }

        public LockSession GetSession(string guid)
        {
            return _dataContext.LockSessions.FirstOrDefault(x => x.SessionKey.ToString() == guid);
        }
    }
}