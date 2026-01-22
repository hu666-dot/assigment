using Assigment2_Calculate.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1.Controllers
{
    public class CalculatorController : Controller
    {
        // GET: /Calculator
        public IActionResult Index()
        {
            return View();
        }

        // Core function – mỗi branch chỉ sửa hàm này
        public int Calculate(SIGN sign,int a, int b)
        {
            switch (sign)
            {
                case SIGN.PLUS:
                    return a + b;
            }
            return 0;
        }

        // POST: /Calculator/Result
        [HttpPost]
        public IActionResult Result(int a, int b,SIGN sign)
        {
            int result = Calculate(sign,a, b);
            ViewBag.Result = result;
            return View("Index");
        }
    }
}
