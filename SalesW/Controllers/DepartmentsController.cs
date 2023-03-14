﻿using Microsoft.AspNetCore.Mvc;
using SalesW.Models;

namespace SalesW.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> list = new List<Department>();

            list.Add(new Department { Id = 1, Name = "Eletronicos" });
            list.Add(new Department { Id = 2, Name = "Rouparia" });

            return View(list);
        }
    }
}