using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShopDecoratorDesignPattern
{
    public class DiscountDecorator(IPizza pizza) : PizzaDecorator(pizza)
    {
        public override double GetCost()
        {
            double cost = _pizza.GetCost();
            if (cost > 10)
                cost = cost * 0.9;
            return cost;
        }
    }
}
