using Calculadora;
using Microsoft.AspNetCore.Mvc;

namespace SimpleCalculatorWeb.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Calculate(string display, string number1, string number2, string operation)
        {

            try
            {
                double result = CalculatorLogic.Calcute(number1, number2, operation);
                ViewData["Result"] = result.ToString();
                ViewData["Number1"] = number1;
                ViewData["Number2"] = number2;
                ViewData["Operation"] = operation;
            }
            catch (Exception ex) 
            {
                ViewData["ErrorMessage"] = ex.Message;
            }


           
            return View("Index");
        }
    }
}
