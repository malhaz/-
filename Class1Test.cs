using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class Class1Test
    {
        DLL.Class1 class1 = new DLL.Class1();

        [TestMethod]
        public void CirleArea()
        {
            //входные данные
            double x = 4;
             
            //ожидаемый результат
            double expres = 16 * Math.PI;

            //тест
            double actual = class1.Area(x);

            Assert.AreEqual(expres, actual);
        }

        [TestMethod]
        public void RectArea()
        {
            //входные данные
            double x = 3;
            double y = 4;
            double z = 5;

            //ожидаемый результат
            double expres = 6;

            //тест
            double actual = class1.Area(x,y,z);

            Assert.AreEqual(expres, actual);
        }

        [TestMethod]
        public void Rornot() 
        {
            //входные данные
            double x = 3;
            double y = 4;
            double z = 5;

            //ожидаемый результат
            bool expres = true;

            //тест
            bool actual = class1.Rornot(x, y, z);

            Assert.AreEqual(expres, actual);          
        }
    }
}
