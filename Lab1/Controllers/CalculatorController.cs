﻿using Lab1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Numerics;

namespace Lab1.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Form()
        {
            return View();
        }
        public IActionResult Result(Calculator model)
        {
          if (!model.IsValid())
            {
                return BadRequest();
            }
          return View(model);
        }
    }
}
