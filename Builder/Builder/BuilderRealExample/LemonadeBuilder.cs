using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderRealExample
{

    public class LemonadeBuilder : BeverageBuilder
    {
        public override void SetWater()
        {
            Console.WriteLine("Step 1 : Cold water");
            GetBeverage().Water = 50;
        }
        public override void SetMilk()
        {
            Console.WriteLine("Step 2 : No milk");
            GetBeverage().Milk = 0;
        }
        public override void SetSugar()
        {
            Console.WriteLine("Step 3 : Adding Sugar");
            GetBeverage().Sugar = 15;
        }
        public override void SetPowderQuantity()
        {
            Console.WriteLine("Step 4 : Adding 20 Grams of Lemonade powder");
            GetBeverage().PowderQuantity = 20;
        }
        public override void SetBeverageType()
        {
            Console.WriteLine("Lemonade");
            GetBeverage().BeverageName = "Lemonade";
        }
    }
}
