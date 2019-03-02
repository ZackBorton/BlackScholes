using System;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    /// <summary>
    ///     The basic components of how to calculate the value of an option
    /// </summary>
    public class Option
    {
        public OptionType OptionType { get; set; }
        
        /// <summary>
        ///     The price of the underlying stock (options are derivatives meant to hedge an asset)
        /// </summary>
        [Required(ErrorMessage="The price of the asset is required.")]
        public double CurrentUnderlyingPrice { get; set; }
        
        /// <summary>
        ///     
        /// </summary>
        [Required(ErrorMessage="The strike price is required.")]
        public double StrikePrice { get; set; }
        
        /// <summary>
        ///     
        /// </summary>
        [Required(ErrorMessage="The term in days is required")]
        public double Term { get; set; }
        
        /// <summary>
        ///     Standard deviation of log returns, this is important as when volatility increases then hedging the risk of that volatility
        ///     gives the option a greater values I.E. price
        /// </summary>
        [Required(ErrorMessage="The implied volatility is required")]
        public double ImpliedVolatility { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        [Required]
        public double RiskFreeInterestRates { get; set; }
    }
}