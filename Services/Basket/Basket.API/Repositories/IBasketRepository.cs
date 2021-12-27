using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Basket.API.Entities;

namespace Basket.API.Repositories
{
    public interface IBasketRepository
    {
        Task<ShoppingCart> GetBusket(string userName);
        Task<ShoppingCart> UpdateBusket(ShoppingCart shoppingCart);

        Task DeleteBusket(string userName);
    }
}