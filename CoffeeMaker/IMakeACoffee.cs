using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMaker
{
    public interface IMakeACoffee
    {
        bool CheckIngridentAvalability();
        string CoffeeMaking(int suggerPerSpone, int CoffeePack);
    }
}
