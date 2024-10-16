using Calculadora.Services;

namespace CalculadoraTestes;

public class CalculadoraTests
{
    private CalculadoraImp _calc;

    public CalculadoraTests()
    {
        _calc = new CalculadoraImp();
    }
    [Fact]
    public void DeveSomar5Com10ERetornar15()
    {
        // Arrange
        int num1 = 5;
        int num2 = 10;
        // Act
        int resultado = _calc.Somar(num1,num2);
        // Assert
        Assert.Equal(15,resultado);
    }
        [Fact]
    public void DeveSomar10Com10ERetornar20()
    {
        // Arrange
        int num1 = 10;
        int num2 = 10;
        // Act
        int resultado = _calc.Somar(num1,num2);
        // Assert
        Assert.Equal(20,resultado);
    }
        [Fact]
    public void DeveVerificarSeEhPar()
    {
        // Arrange
        int num = 4;
        // Act
        bool resultado = _calc.EhPar(num);
        // Assert
        Assert.True(resultado);
    }

        [Theory]
        [InlineData(2)]
        [InlineData(4)]
        [InlineData(6)]
        [InlineData(8)]
        [InlineData(10)]
    public void DeveVerificarSeTodosSaoPar(int num)
    {
        // Arrange
        // Act
        bool resultado = _calc.EhPar(num);
        // Assert
        Assert.True(resultado);
    }
}