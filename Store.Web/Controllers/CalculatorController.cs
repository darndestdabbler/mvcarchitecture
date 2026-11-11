using Store.Service;
using System.Web.Mvc;

namespace Store.Web.Controllers
{
    public class CalculatorController : Controller
    {
        private readonly ICalculatorService calculatorService;

        public CalculatorController(ICalculatorService calculatorService)
        {
            this.calculatorService = calculatorService;
        }

        // GET: Calculator
        public ActionResult Index()
        {
            return View();
        }

        // POST: Calculator
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(decimal left, decimal right)
        {
            ViewBag.Left = left;
            ViewBag.Right = right;
            ViewBag.Sum = calculatorService.Add(left, right);
            ViewBag.Difference = calculatorService.Subtract(left, right);

            return View();
        }
    }
}
