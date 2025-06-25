namespace TestProject1
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Calcolatrice.Calcolatrice calcolatrice =new Calcolatrice.Calcolatrice();
            double ris = calcolatrice.somma(2, 3);
            Assert.AreEqual(5, ris,"la sooma deve essere 5");
        }
        [TestMethod]
        public void TestMethod2() 
        {
            Calcolatrice.Calcolatrice calcolatrice = new Calcolatrice.Calcolatrice();
            double ris = calcolatrice.somma(0, 3);
            Assert.AreEqual(3, ris, "la sooma deve essere 5");
        }

    }
}
