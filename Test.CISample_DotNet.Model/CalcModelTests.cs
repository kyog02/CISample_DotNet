using CISample_DotNet.Moidel;

namespace Test.CISample_DotNet.Model
{
    [TestClass]
    public class CalcModelTests
    {
        [TestMethod]
        public void Add_ê≥èÌån()
        {
            // Arrange
            int input1 = 1;
            int input2 = 2;
            int expected = 3;

            // Act
            int actual = CalcModel.Add(input1, input2);

            // Assert
            Assert.AreEqual(expected, actual); 
        }
    }
}