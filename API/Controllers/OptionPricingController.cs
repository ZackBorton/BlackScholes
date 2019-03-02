using Logic.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace BlackScholes.Controllers
{
    [Route("api/[controller]")]
    public class OptionPricingController : Controller
    {
        private readonly IOptionContext _optionPricing;

        public OptionPricingController(IOptionContext optionPricing)
        {
            _optionPricing = optionPricing;
        }

        /// <summary>
        ///    Calculate an options price
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("")]
        [ProducesResponseType(typeof(double),200)] 
        public  IActionResult GetQuote([FromQuery] Option option)
        {
            
            return Ok(_optionPricing.Price(option));
        }
    }
}