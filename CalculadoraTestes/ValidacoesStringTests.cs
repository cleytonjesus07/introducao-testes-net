using Calculadora.Services;

namespace CalculadoraTestes;

public class ValidacoesStringTests
{
    private ValidacoesString _validacoes = new();

    [Fact]
    public void DeveContarTresEmOlaERetornarTres(){
        string texto = "Olá";
        int resultado = _validacoes.ContarCaracteres(texto);
        Assert.Equal(3,resultado);
    }
}
