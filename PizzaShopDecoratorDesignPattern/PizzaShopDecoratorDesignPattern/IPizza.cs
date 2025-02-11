using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaShopDecoratorDesignPattern
{
    public interface IPizza
    {
        public double GetCost();
        public List<string> GetToppingList();
    }
}
