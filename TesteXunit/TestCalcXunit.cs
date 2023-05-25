using ProjetoTeste;

namespace TesteXunit
{
    public class TestCalcXunit
    {
        [Fact]
        public void SomarDoisNumeros()
        {
            double pNum = 1;

            double sNum = 1;

            double rNum = 2;

            //Act

            double resultado = Calculadora.Somar(pNum, sNum);


            //Aassert

            Assert.Equal(rNum, resultado);

        }

        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(2, 2, 4)]
        [InlineData(2, 3, 4)]
        [InlineData(3, 3, 6)]

        public void SomarNumerosLista2(double pNum, double sNum, double rNum)
        {
            double resultado = Calculadora.Somar(pNum, sNum);

            Assert.Equal(rNum, resultado);
        }
    }
}