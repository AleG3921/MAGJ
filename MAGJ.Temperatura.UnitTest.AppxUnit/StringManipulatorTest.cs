using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAGJ.Temperatura.UnitTest.AppxUnit
{ 
    public class StringManipulatorTest
    {
        [Fact]
        public void ReversaString()
        {
            StringManipulator manipulate = new StringManipulator();
            string caracter = "Hola Roma";

            string mani = manipulate.ReversaString(caracter);

            Assert.Equal("amoR aloH", mani);

        }
        [Fact]
        public void RemoveSpaces()
        {
            StringManipulator manipulate = new StringManipulator();
            string space = " ";

            string mani = manipulate.RemoveSpaces(space);

            Assert.Equal("", mani);
        }
    }
}
