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
        public int Calculate(int a, int b)
        {
            return 0; // TODO: implement theo từng branch
        }

        // POST: /Calculator/Result
        [HttpPost]
        public IActionResult Result(int a, int b)
        {
            int result = Calculate(a, b);
            ViewBag.Result = result;
            return View("Index");
        }
    }
}
