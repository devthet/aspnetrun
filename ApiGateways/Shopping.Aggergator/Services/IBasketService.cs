using Shopping.Aggergator.Models;
using System.Threading.Tasks;

namespace Shopping.Aggergator.Services
{
    public interface IBasketService
    {
        Task<BasketModel> GetBasket(string userName);
    }
}
