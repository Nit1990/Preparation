namespace PracticeProject.OOPS
{
    public class Engine
    {

        public void Start()
        {
            Console.WriteLine("Engine Started");
        }

        public void Stop()
        {
            Console.WriteLine("Engine Stopped");
        }

    }

    // Car class with composition relationship with Engine class
    public class Car
    {

        // Composition: Car "has-a" Engine
        private Engine engine;

        // Constructor to initialize the composition relationship
        public Car()
        {
            engine = new Engine();
        }

        //Method to Start the car deligating to Engine
        public void Start()
        {
            engine.Start();
        }

        //Method to Stop the car deligating to Engine
        public void Stop()
        {
            engine.Stop();
        }
    }

    public class CompositionExample
    {
        // Creation a Car with Composition
        Car myCar = new Car();

        public CompositionExample()
        {

            myCar.Start();
            myCar.Stop();
        }
    }
}