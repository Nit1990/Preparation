namespace DesignPattern
{

    // Context class
    public class Context
    {
        private IStrategy _stratergy;

        public Context() { }
        public Context(IStrategy strategy)
        {
            _stratergy = strategy;

        }
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

    public interface IStrategy
    {
        object DoAlgorithm(object data);
    }

    public class ConcreteStrategyA : IStrategy
    {
        public object DoAlgorithm(object data)
        {
            var list = data as List<string>;
            list.Sort();

            return list;
        }
    }

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