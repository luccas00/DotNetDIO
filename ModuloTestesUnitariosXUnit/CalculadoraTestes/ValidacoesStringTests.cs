using Calculadora.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraTestes
{
    public class ValidacoesStringTests
    {
        private ValidacoesString _validacoes;

        public ValidacoesStringTests()
        {
            _validacoes = new ValidacoesString();
        }

        [Fact]
        public void ContarCaracteres()
        {
            //Arrange
            string texto = "texto";
            
            //Act
            int result = _validacoes.ContarCaracteres(texto);

            //Assert
            Assert.Equal(5, result);
        }


    }
}
