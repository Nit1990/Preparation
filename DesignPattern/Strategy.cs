namespace DesignPattern
{

    // Context class - Vehicle 
    public class Context
    {
        private IStrategy _stratergy; // interface Object to make code dynamic

        public Context() { }
       
        public void SetStrategy(IStrategy strategy)
        {
            this._stratergy = strategy;
        }

        public void DoSomeBusinessLogic()
        {
            var result = this._stratergy.DoAlgorithm(new List<string> { "a", "b", "c" });
            string resultstr = string.Empty;
            // Logic
        }

    }

 // Drive Strategy
    public interface IStrategy 
    {
        object DoAlgorithm(object data);
    }

    // SportsCar Strategy
    public class ConcreteStrategyA : IStrategy
    {
        public object DoAlgorithm(object data)
        {
             var list = data as List<string>;
            list.Sort();

            return list;
        }
    }

    // Normalar Strategy
    public class ConcreteStrategyB : IStrategy
    {
        public object DoAlgorithm(object data)
        {
            var list = data as List<string>;
            list.Sort();
            list.Reverse();

            return list;
        }

    }

}