using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LockBoxAPI.Data;

namespace LockBoxAPI.Models
{
    public class LockSessionModel
    {
        

        public LockSessionModel(LockSession rawSession)
        {
            EndTime = rawSession.EndDateTime;
            SessionFinished = rawSession.Finished;
        }

        public string SessionKey { get; set; }

        public bool SessionFinished { get; set; }

        public DateTime EndTime { get; set; }


        public object JsonOutput()
        {
            return new
            {   Key = SessionKey,
                Ended = SessionFinished,
                Date = EndTime.ToShortDateString(),
                Time = EndTime.ToShortTimeString(),
            };
        }
    }
}