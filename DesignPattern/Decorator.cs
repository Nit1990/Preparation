namespace ConsoleApp.DesignPattern
{
    public abstract class BasePizza
    {
        public abstract int Cost();
    }

    // These are 3 base Pizzas 
    public class MargheritaPizza : BasePizza
    {
        public override int Cost()
        {
            return 200;
        }
    }

    public class VeggiePizza : BasePizza
    {
        public override int Cost()
        {
            return 120;
        }
    }

    public class PepperoniPizza : BasePizza
    {
        public override int Cost()
        {
            return 100;
        }
    }

    // Decorator Class

    public abstract class PizzaDecorator : BasePizza
    {
        public BasePizza _basePizza;

        public PizzaDecorator(BasePizza basePizza)
        {
                _basePizza = basePizza;
        }

        public override int Cost() => _basePizza.Cost();
       
    }

    public class CheeseDecorator : PizzaDecorator
    {
        public CheeseDecorator(BasePizza basePizza) : base(basePizza)
        {
        }

        public override int Cost()
        {
            return _basePizza.Cost() + 12; 
        }
    }

    public class OliveDecorator : PizzaDecorator
    {
        public OliveDecorator(BasePizza basePizza) : base(basePizza)
        {
                
        }
        public override int Cost()
        {
            return _basePizza.Cost() + 17;
        }
    }

    public class Decorator
    {
        public Decorator()
        {
            BasePizza pizza = new MargheritaPizza();
            Console.WriteLine($"Margherita pizza cost {pizza.Cost()}");

            pizza = new CheeseDecorator(pizza);
            Console.WriteLine($"Margherita pizza with cheese cost {pizza.Cost()}");

            pizza = new OliveDecorator(pizza);
            Console.WriteLine($"Margherita pizza with cheese with Olive cost {pizza.Cost()}");
        }

    }

}
