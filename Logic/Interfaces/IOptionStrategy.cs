using Models;

namespace Logic.Interfaces
{
    public interface IOptionStrategy
    {
        double Price(Option option);
    }
}