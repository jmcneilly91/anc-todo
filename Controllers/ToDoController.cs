using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreToDo.Controllers
{
    public class ToDoController : Controller
    {
        public IActionResult Index()
        {
            //Get items from the db

            //Pass items to a model

            //Render a view with the model data
            return View();
        }
    }
}