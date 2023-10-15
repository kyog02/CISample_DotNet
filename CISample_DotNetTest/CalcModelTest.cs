namespace CISample_DotNetTest
{
    [TestClass]
    public class CalcModelTest
    {
        [TestMethod]
        public void Add_ê≥èÌån()
        {
            CalcModel.Add(1, 2).Is(3);

        }
    }
}