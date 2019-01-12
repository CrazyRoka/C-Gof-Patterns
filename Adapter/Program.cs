using System;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Driver driver = new Driver();

            ITransport car = new Car();
            driver.Travel(car);

            Camel camel = new Camel();
            ITransport adapter = new CamelToTransportAdapter(camel);
            driver.Travel(adapter);
        }
    }
}
