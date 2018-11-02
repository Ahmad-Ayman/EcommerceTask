using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Task1.Controllers
{
    public class HelloController : Controller
    {
        public String Index()
        {
            return "Welcome to Main Screen for Hello Controller";
        }
        public String Welcome()
        {
            return "Welcome Page";
        }
    }
}