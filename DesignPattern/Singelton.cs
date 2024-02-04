namespace DesignPattern
{
    public class Singelton
    {
        private static Singelton? Instance = null;
        private static readonly Object _lock = new();
        public static Singelton GetInstance()
        {

            if (Instance == null)
            {
                lock (_lock)
                {

                    Instance = new Singelton();
                }
            }
            return Instance;
        }
        private Singelton() { }

    }
}