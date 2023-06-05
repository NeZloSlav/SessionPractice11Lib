using SessionPractice11Lib;

namespace MethodsUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        #region AdditionTwoNumbers
        [TestMethod]
        public void AdditionTwoNumbersTest1()
        {
            //Arrange

            int a = 0;
            int b = 0;

            int result = 0;

            //Act

            int methodRes = Methods.AdditionTwoNumbers(a, b);

            //Assert

            Assert.AreEqual(result, methodRes);

        }

        [TestMethod]
        public void AdditionTwoNumbersTest2()
        {
            //Arrange

            int a = 1;
            int b = 6;

            int result = 7;

            //Act

            int methodRes = Methods.AdditionTwoNumbers(a, b);

            //Assert

            Assert.AreEqual(result, methodRes);

        }

        [TestMethod]
        public void AdditionTwoNumbersTest3()
        {
            //Arrange

            int a = -4;
            int b = -3;

            int result = -7;

            //Act

            int methodRes = Methods.AdditionTwoNumbers(a, b);

            //Assert

            Assert.AreEqual(result, methodRes);

        }

        [TestMethod]
        public void AdditionTwoNumbersTest4()
        {
            //Arrange

            int a = 2;
            int b = -3;

            int result = -1;

            //Act

            int methodRes = Methods.AdditionTwoNumbers(a, b);

            //Assert

            Assert.AreEqual(result, methodRes);

        }

        [TestMethod]
        public void AdditionTwoNumbersTest5()
        {
            //Arrange

            int a = 0;
            int b = -3;

            int result = -3;

            //Act

            int methodRes = Methods.AdditionTwoNumbers(a, b);

            //Assert

            Assert.AreEqual(result, methodRes);

        }
        #endregion

        #region CountSpecChar
        [TestMethod]
        public void CountSpecCharTest1()
        {
            //Arrange

            string text = @"eufwbf']";

            int result = 2;

            //Act
            int methodRes = Methods.CountSpecChar(text);

            //Assert   

            Assert.AreEqual(result, methodRes);
        }

        [TestMethod]
        public void CountSpecCharTest2()
        {
            //Arrange

            string text = @"eufwbf']";

            int result = 2;

            //Act
            int methodRes = Methods.CountSpecChar(text);

            //Assert   

            Assert.AreEqual(result, methodRes);
        }

        [TestMethod]
        public void CountSpecCharTest3()
        {
            //Arrange

            string text = @"eufwÚÕ\f']";

            int result = 3;

            //Act
            int methodRes = Methods.CountSpecChar(text);

            //Assert   

            Assert.AreEqual(result, methodRes);
        }

        [TestMethod]
        public void CountSpecCharTest4()
        {
            //Arrange

            string text = @"eu()bf']";

            int result = 4;

            //Act
            int methodRes = Methods.CountSpecChar(text);

            //Assert   

            Assert.AreEqual(result, methodRes);
        }

        [TestMethod]
        public void CountSpecCharTest5()
        {
            //Arrange

            string text = @"Ïðèâåò";

            int result = 0;

            //Act
            int methodRes = Methods.CountSpecChar(text);

            //Assert   

            Assert.AreEqual(result, methodRes);
        }
        #endregion


    }
}