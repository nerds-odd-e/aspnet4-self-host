using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Http;

namespace ConsoleApp1
{
    public class IapAlarmManagerController : ApiController
    {
        public List<string> GetAllAlarmIds()
        {
            return new List<string>{ "123" };
        }

    }
}
