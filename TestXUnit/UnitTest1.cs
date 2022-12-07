using Projeto_Teste;

namespace TestXUnit
{
    public class UnitTest1
    {
        [Fact]
        public void SomarDoisNumeros()
        {
            //Arrage - Preparação
            double pNum = 1;
            double sNum = 1;
            double rNum = 2;


            //Act - Ação/Execução
            var Resultado = operacoes.Somar(pNum, sNum);


            //Assert - Verificação
            Assert.Equal(rNum, Resultado);
        }

        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(2, 2, 4)]
        [InlineData(2, 1, 3)]

        public void SomarDoisNumerosLista(double pNum, double sNum, double rNum)
        {
            //Act-II
            var resultado = operacoes.Somar(pNum, sNum);

            //Assert-II
            Assert.Equal(rNum, resultado);

        }

    }
}