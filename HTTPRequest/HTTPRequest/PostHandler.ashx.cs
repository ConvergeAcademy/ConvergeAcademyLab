using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace HTTPRequest
{
    /// <summary>
    /// Summary description for PostHandler
    /// </summary>
    public class PostHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string firstName = context.Request["FirstName"].ToString();
            string lastName = context.Request["LastName"].ToString();
            var log = String.Format("FirstName={0} and LastName={1}: CreationTime :1{2}", firstName, lastName, DateTime.Now.ToString());

            using (StreamWriter _testData = new StreamWriter(System.Web.HttpContext.Current.Server.MapPath("~/data.txt"), true))
            {
                _testData.WriteLine(log); // Write the file.
            }  
           
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}