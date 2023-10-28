using Calculadora.Services;

namespace CalculadoraTestes;

public class CalculadoraTests
{
    private CalculadoraImp calculadora;

    public CalculadoraTests()
    {
        calculadora = new CalculadoraImp();
    }

    [Fact]
    public void DeveSomar5Com10ERetornar15()
    {
        //Arrange
        int number1 = 5;
        int number2 = 10;

        //Act
        int result = calculadora.somar(number1, number2);

        //Assert
        Assert.Equal(15, result);
    }

    [Fact]
    public void DeveMultiplicar3Com10ERetornar30()
    {
        //Arrange
        int number1 = 3;
        int number2 = 10;

        //Act
        int result = calculadora.multiplicar(number1, number2);

        //Assert
        Assert.Equal(30, result);
    }

    [Fact]
    public void MetodoEhPar()
    {
        //Arrange
        int number1 = 6;

        //Act
        bool result = calculadora.EhPar(number1);

        //Assert
        Assert.True(result);
    }

    [Theory]
    [InlineData(2)]
    [InlineData(12)]
    [InlineData(22)]
    [InlineData(20)]
    [InlineData(4)]
    [InlineData(6)]
    [InlineData(8)]
    [InlineData(10)]
    public void VerificarMetodoEhPar(int number)
    {
        //Arrange
        // [InlineData(n)]

        //Act
        bool result = calculadora.EhPar(number);

        //Assert
        Assert.True(result);
    }

    [Theory]
    [InlineData(9)]
    [InlineData(7)]
    [InlineData(3)]
    [InlineData(11)]
    public void VerificarMetodoEhParNegativo(int number)
    {
        //Arrange
        // [InlineData(n)]

        //Act
        bool result = calculadora.EhPar(number);

        //Assert
        Assert.False(result);
    }


    //[Fact]
    //public void Teste1()
    //{
    //    //Arrange
    //    //Act
    //    //Assert
    //}
}