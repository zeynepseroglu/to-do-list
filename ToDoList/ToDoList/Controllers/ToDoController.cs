using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ToDoList.Controllers
{
    public class ToDoController : Controller
    {
        public IActionResult Index()
        {
      

            //TODO APi
            string clientid = "cbec1395efbe41b89e2f82797180df98";
            string clientsecret = "2164b1937b62436ebbd7c8c3b1622e83";
            string connection = "https://todoist.com/oauth/authorize?client_id="+clientid+"&scope=data:read,data:delete&state="+clientsecret;
            XDocument document = XDocument.Load(connection);
            

            return View();
        }
    }
}
