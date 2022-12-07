using Projeto_Teste;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMSTest
{
    [TestClass]
    public class TesteUnitario
    {
        [TestMethod]
        public void SomarDoisNumeros ()
        {
            //Arrage - Preparação
            double pNum = 1;
            double sNum = 1;
            double rNum = 2;


            //Act - Ação/Execução
            var Resultado = operacoes.Somar(pNum, sNum);


            //Assert - Verificação
            Assert.AreEqual(rNum, Resultado);
        }

        //Fim Primeira Parte
        
        //Arrange -II
        [DataTestMethod]
        [DataRow(1, 1, 2)]
        [DataRow(2, 2, 4)]
        [DataRow(2, 1, 3)]
        [DataRow(3, 3, 6)]
        [DataRow(4, 1, 5)]
       
        public void SomarDoisNumerosLista(double pNum, double sNum, double rNum)
        {
            //Act-II
            var resultado = operacoes.Somar(pNum, sNum);

            //Assert-II
            Assert.AreEqual(rNum, resultado);

        }            
    }
}
