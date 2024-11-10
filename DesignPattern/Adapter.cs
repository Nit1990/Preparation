namespace PracticeProject.DesignPattern
{
    public interface IWeatherProviderCelcius
    {
        double GetTempratureCelcius();
    }

    public interface IWeatherProviderFarenheit
    {
        double GetTempratureFerenheit();
    }

    // Target interface that client expects
    public interface IWeatherClient
    {
        double DisplayWeatherInfo();
    }

    // Adapter class that adapts the WeatherProviderCelsius interface to IweatherCLient
    public class WeatherServiceAdapter : IWeatherClient
    {
        private IWeatherProviderCelcius _weatherProviderCelcius;

        public WeatherServiceAdapter(IWeatherProviderCelcius weatherProviderCelcius)
        {
            _weatherProviderCelcius = weatherProviderCelcius;
        }
        public double DisplayWeatherInfo()
        {
            return _weatherProviderCelcius.GetTempratureCelcius();
        }
    }

    // We can do similar to WeatherProviderFarenheit

    // CLient Code using IWeatherClient
    public class WeatherClient
    {
        private IWeatherClient _weatherClient;

        public WeatherClient(IWeatherClient weatherClient)
        {
            _weatherClient = weatherClient;
        }

        public void DisplayTemperature()
        {
            double temp = _weatherClient.DisplayWeatherInfo();
            Console.WriteLine($"Current Temperature: {temp}°C");
        }
    }

    // Concrete implementation of WeatherProviderCelsius
    public class WeatherProviderCelsius : IWeatherProviderCelcius
    {
        public double GetTempratureCelcius()
        {
            return 25.5;
        }
    }

    // Main Code
    public class AdapterExample
    {
        public AdapterExample()
        {
            // create instance of WeatherProviderCelsius
            IWeatherProviderCelcius providerCelcius = new WeatherProviderCelsius();

            // create Adapter for both providers
            IWeatherClient celsiusClientAdapter = new WeatherServiceAdapter(providerCelcius);

            // create WeatherCLient to display temperature
            WeatherClient weatherClient = new WeatherClient(celsiusClientAdapter);

            // Display temperature
            weatherClient.DisplayTemperature();
        }
    }
}

namespace PracticeProject.DesignPattern
{

    // Target interface that the client expects
    public interface ITarget
    {
        void Request();
    }

    // Adaptee (existing class) with a different interface
    public class Adaptee
    {
        public void SpecificRequest()
        {

            Console.WriteLine("Adaptee's specific request");
        }
    }

    public class Adapter : ITarget
    {
        private Adaptee _adaptee;

        public Adapter(Adaptee adaptee)
        {
            _adaptee = adaptee;
        }
        public void Request()
        {
            _adaptee.SpecificRequest();
        }
    }

    public class AdapterEx
    {
        public AdapterEx()
        {
            // Create an instance of Adaptee
            Adaptee adaptee = new Adaptee();

            // Create an instance of the Adapter, passing Adaptee to it
            ITarget adapter = new Adapter(adaptee);

            // Call the Request method on the adapter, which internally calls Adaptee's SpecificRequest
            adapter.Request();
        }
    }
}