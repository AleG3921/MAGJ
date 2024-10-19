using MAGJ.Temperatura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAGJ.Temperatura.UnitTest.AppMSTest
{
    [TestClass]
    public class TemperatureConverterTest
    {
        [TestMethod]
        public void CelsiusToFahrenheit()
        {
           TemperatureConverter converter = new TemperatureConverter();

            double temperature = converter.CelsiusToFahrenheit(88);

            Assert.AreEqual(0.0, temperature);

        }
        public void FahrenheitToCelsius()
        {
            TemperatureConverter converter = new TemperatureConverter();

            double temperature = converter.CelsiusToFahrenheit(100);

            Assert.AreEqual(0.0, temperature);

        }
    }
}
