using Store.Service;
using System.Web.Mvc;

namespace Store.Web.Controllers
{
    /// <summary>
    /// The calculator page, reached as /Calculator by the default route.
    /// </summary>
    public class CalculatorController : Controller
    {
        private readonly ICalculatorService calculatorService;

        /// <summary>Creates the controller over the calculator's arithmetic.</summary>
        /// <param name="calculatorService">The service that adds and subtracts.</param>
        public CalculatorController(ICalculatorService calculatorService)
        {
            this.calculatorService = calculatorService;
        }

        // GET: Calculator
        /// <summary>Shows the calculator form with no result.</summary>
        /// <returns>The calculator view.</returns>
        public ActionResult Index()
        {
            return View();
        }

        // POST: Calculator
        /// <summary>Shows the sum and the difference of the two numbers submitted.</summary>
        /// <param name="left">The first number.</param>
        /// <param name="right">The second number.</param>
        /// <returns>The calculator view, carrying both numbers and both results.</returns>
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
