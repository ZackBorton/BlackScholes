using System;
using Logic.Interfaces;
using Models;

namespace Logic
{
    /// <summary>
    ///     European call option, can only be exercised on a specific date, compared to an American call option that can be exercised anytime
    /// </summary>
    public class CallOption : IOptionStrategy
    {
        /// <summary>
        ///     ///     Prices a call
        /// </summary>
        /// <param name="option"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public double Price(Option option)
        {
            // TODO: Clean up/verify/write tests 
            var d1 = CalcOne(option);
            var d2 = CalcTwo(option);
            double power = - option.RiskFreeInterestRates * option.Term;
            return option.CurrentUnderlyingPrice * d1 - option.StrikePrice *
                   Math.Pow(Math.E, power) * d2;
            //* ;
        }

        /// <summary>
        ///     The cumulative distribution function for standard normal distribution
        ///     The probability that a random variable is less then or equal to x
        /// </summary>
        /// <param name="option"></param>
        /// <returns></returns>
        private double CalcOne(Option option)
        {
            var numerator = Math.Log((option.CurrentUnderlyingPrice / option.StrikePrice)) + (option.RiskFreeInterestRates + Math.Pow(option.ImpliedVolatility, 2) / 2) * option.Term;
            var denominator = option.ImpliedVolatility * Math.Sqrt(option.Term);
            return numerator / denominator;
        }
        
        /// <summary>
        ///     
        /// </summary>
        /// <param name="option"></param>
        /// <returns></returns>
        public double CalcTwo(Option option)
        {
            var numerator = Math.Log((option.CurrentUnderlyingPrice / option.StrikePrice)) + (option.RiskFreeInterestRates - Math.Pow(option.ImpliedVolatility, 2) / 2) * option.Term;
            var denominator = option.ImpliedVolatility * Math.Sqrt(option.Term);
            return numerator / denominator;
        }
    }
}