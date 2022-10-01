using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMaker
{
    public class StarBuckStore
    {
        private readonly IMakeACoffee service;
        public StarBuckStore(IMakeACoffee service)
        {
            this.service = service;
        }
        public string OrderCoffee(int suggerPerSpone, int CoffeeCount)
        {
            if (service.CheckIngridentAvalability())
            {
                return service.CoffeeMaking(suggerPerSpone, CoffeeCount);
            }
            else
            {
                return "Sorry! Coffee is not available.";
            }
        }
    }
}
