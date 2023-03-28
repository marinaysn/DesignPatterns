// See https://aka.ms/new-console-template for more information
using BuilderRealExample;


    Beverage beverage;
    BeverageDirector beverageDirector = new BeverageDirector();

    TeaBuider tea = new TeaBuider();
    beverage = beverageDirector.MakeBeverage(tea);
    Console.WriteLine(beverage.ShowBeverage());

    CoffeeBuilder coffee = new CoffeeBuilder();
    beverage = beverageDirector.MakeBeverage(coffee);
    Console.WriteLine(beverage.ShowBeverage());

    LemonadeBuilder lemonade = new LemonadeBuilder();
    beverage = beverageDirector.MakeBeverage(lemonade);
    Console.WriteLine(beverage.ShowBeverage());

    Console.ReadKey();
