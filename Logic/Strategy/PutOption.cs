using System;
using Logic.Interfaces;
using Models;

namespace Logic
{
    /// <summary>
    ///     European put option, can only be exercised on a specific date, compared to an American call option that can be exercised anytime
    /// </summary>
    public class PutOption : IOptionStrategy
    {
        /// <summary>
        ///     Prices a put
        /// </summary>
        /// <param name="option"></param>
        /// <returns></returns>
        public double Price(Option option)
        {
            // TODO : Implement
            throw new NotImplementedException();
        }

    }
}