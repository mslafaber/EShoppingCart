using EShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShoppingCart.Interfaces
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
    }
}
