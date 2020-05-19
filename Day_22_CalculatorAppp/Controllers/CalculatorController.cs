using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day_22_CalculatorAppp.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Day_22_CalculatorAppp.Controllers
{
    public class CalculatorController : Controller
    {
        // GET: /<controller>/
        public IActionResult Calculator()
        {
            return View();
        }

        //when you build a new Controller, the models aren't automatically brought over,
        //so you need to include a using namespaceNameblahblah.Models statement
        public IActionResult Calculate(Calculator calculator)
        {
            if(calculator.Operator == '+')
            {
                calculator.Result = calculator.Number1 + calculator.Number2;
            } 
            else if (calculator.Operator == '-')
            {
                calculator.Result = calculator.Number1 - calculator.Number2;
            } 
            else if (calculator.Operator == '*')
            {
                calculator.Result = calculator.Number1 * calculator.Number2;
            }
            else if (calculator.Operator == '/')
            {
                calculator.Result = calculator.Number1 / calculator.Number2;
            }

            return View("Calculator", calculator);
        }
    }
}
