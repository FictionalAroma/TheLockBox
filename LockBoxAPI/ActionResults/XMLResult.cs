using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Serialization;

namespace LockBoxAPI.ActionResults
{
    public class XmlResult<T>: ActionResult
    {
        private readonly T _data;

        public XmlResult(T obj)
        {
            _data = obj;
        }

        public override void ExecuteResult(ControllerContext context)
        {
            WriteToStream(context.HttpContext.Response.OutputStream);
        }

        private void WriteToStream(Stream stream)
        {
            var serializer = new XmlSerializer(typeof(T));
            serializer.Serialize(stream, _data);
        }

        public static XmlResult<T> Create(T obj)
        {
            return new XmlResult<T>(obj);
        }


    }
}