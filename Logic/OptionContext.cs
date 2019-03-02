using System.Collections.Generic;
using Logic.Interfaces;
using Models;

namespace Logic
{
    public class OptionContext : IOptionContext
    {
        /// <summary>
        ///     Switches the pricing implementation based on if a call or put is requested
        /// </summary>
        /// <param name="option"></param>
        /// <returns></returns>
        public double Price(Option option)
        {
            Dictionary<OptionType, IOptionStrategy> strategies = new Dictionary<OptionType, IOptionStrategy>()

            {
                {OptionType.Put, new PutOption()},
                {OptionType.Call, new CallOption()}
            };


            IOptionStrategy selectedStrategy = strategies[option.OptionType];
            return selectedStrategy.Price(option);
        }
    }
}