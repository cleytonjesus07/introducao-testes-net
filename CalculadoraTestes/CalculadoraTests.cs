using Calculadora.Services;
namespace CalculadoraTestes;

public class CalculadoraTests
{
    private CalculadoraImp _calc = new();
    /* 
       Nomear testes: O que tem que fazer, o que está sendo passado e também o que está retornando.
     */
    [Fact] //Define o que é teste
    public void DeveSomarCincoComDezERetornarQuinze ()
    {
        /* 
        
            Arrange: Prepara o cenário.
            Act: Executa a ação.
            Assert: Valida o resultado esperado. 
        
        */

        //Arrange
        int num1 = 5,num2 = 10;

        //Act
        int resultado = _calc.Somar(num1, num2);

        //Assert
        Assert.Equal(15,resultado);
    }

    [Fact]
    public void DeveSomarDezComDezERetornarVinte ()
    {
        //Arrange
        int num1 = 10,num2 = 10;

        //Act
        int resultado = _calc.Somar(num1, num2);

        //Assert
        Assert.Equal(20,resultado);
    }
    [Fact]
    public void DeveRetornarSeONumeroQuatroEhPar()
    {
        //Arrange
        int num = 4;

        //Act
        bool resultado = _calc.EhPar(num);

        //Assert
        // .True | .False para valores booleanos.
        Assert.True(resultado);
    }

    [Theory] 
    [InlineData(new int[] {2,4})] //Dados a serem testados
    [InlineData(new int[] {6,8,10})] //Dados a serem testados
    public void DeveVerificarSeOsNumerosSaoParesERetornarVerdadeiro(int[] numeros){
       //ACT + ASSERT
    Assert.All(numeros,n => Assert.True(_calc.EhPar(n)));
    }
}