using System.Data;

namespace Test_test_desktop_junior
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Тестирование с использованием DataRow
        /// </summary>
        [DataTestMethod]
        
        [DataRow(0, 0, 0, 0, 0, 0)]
        [DataRow(1, 1, 1, 1, 1, 1)]
        [DataRow(123, 4, 2, 0, 2, 2)]
        [DataRow(213, 3, 3, 2, 19, 3)]
        [DataRow(23, 5, 4, 0, 13, 4)]

        [DataRow(12, 8, 1, 99, 41, 0)]
        [DataRow(45, 7, 2, 7, 0, 1)]
        [DataRow(7, 5, 3, 8, 3, 2)]
        [DataRow(5, 4, 4, 6, 2, 3)]
        [DataRow(7, 2, 0, 4, 4, 4)]


        public void TestMethod0(double a, double b, int c, double x, double y, int pow)
        {
           

            Function s = new Function("", "", pow);
            s.A = a;
            s.B = b;
            s.C = c; // _cVariants[0] = 10

            s.Data[0].X = x;
            s.Data[0].Y = y;

            s.Calculate();
            double actual = s.Data[0].Result;

            double expected = a * Math.Pow(x, pow) + b * Math.Pow(y, pow - 1) + s.CVariants[c];//Вычисление результата

            Assert.AreEqual(expected, actual, "Некорректные вычисления");
        }

    }
}