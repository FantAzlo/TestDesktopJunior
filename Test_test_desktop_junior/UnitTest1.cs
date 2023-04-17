using Microsoft.VisualStudio.TestTools.UnitTesting;
using test_desktop_junior;

namespace Test_test_desktop_junior
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Тест для функции:
        /// F(x,y) = 5*x^2 + 3*y + 10
        /// при x = 2, y = 3
        /// Ожидаемый резульат:
        /// F(x,y) = 20 + 9 + 10 = 39
        /// </summary>
        [TestMethod]
        public void TestMethod1()
        {
         
            double expected = 39;

            XYFunc s = new XYFunc("sd", 2);

            s.A = 5;
            s.B = 3;
            s.C = 0; // _cVariants[0] = 10
            
            s.Data[0].X = 2;
            s.Data[0].Y = 3;

            s.Calculate();

            double actual = s.Data[0].Res;

            Assert.AreEqual(expected, actual, "Некорректные вычисления");
        }
    }
}