using ProjetoTeste;

namespace TesteMstest
{
    [TestClass]
    public class TesteCalculadoraMstest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //arrange
            double pNum = 1;

            double sNum = 1;

            double rNum = 2;

            //Act
            
            double resultado = Calculadora.Somar(pNum, sNum);


            //Aassert

            Assert.AreEqual(rNum, resultado);

        }

        
        ///
        [DataTestMethod]
        [DataRow(1, 2, 3)]
        [DataRow(2, 2, 4)]
        [DataRow(3, 2, 4)]
        [DataRow(3, 3, 6)]

        public void SomarNumerosLista( double pNum, double sNum , double rNum)
        {
            double resultado = Calculadora.Somar( pNum , sNum);

            Assert.AreEqual(rNum, resultado);
        }
    }
}