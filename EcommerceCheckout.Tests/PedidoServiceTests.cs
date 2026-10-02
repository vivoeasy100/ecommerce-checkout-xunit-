// Aluno: Fernando Almeida de Oliveira Braga
// RA: 326132695
// Disciplina: Garantia e Gestão da Qualidade de Software - Prof. Daniel Henrique Matos de Paiva

using EcommerceCheckout.App;
using Xunit;

namespace EcommerceCheckout.Tests;

public class PedidoServiceTests
{
    private readonly PedidoService _pedidoService;

    public PedidoServiceTests()
    {
        _pedidoService = new PedidoService();
    }

    [Fact]
    public void Teste1_GerarCodigoRastreio_DeveGerarMascaraExata()
    {
        // Arrange
        string regiao = "sudeste";
        int numeroPedido = 42;

        // Act
        string resultado = _pedidoService.GerarCodigoRastreio(regiao, numeroPedido);

        // Assert
        Assert.Equal("SUDESTE-0042", resultado);
    }

    [Fact]
    public void Teste2_CalcularPontosFidelidade_DeveCalcularPontosCorretamente()
    {
        // Arrange
        int valorTotal = 150;

        // Act
        int resultado = _pedidoService.CalcularPontosFidelidade(valorTotal);

        // Assert
        Assert.Equal(30, resultado);
    }

    [Fact]
    public void Teste3_TemDireitoAFreteGratis_CompraVIPAbaixoDe200_DeveRetornarTrue()
    {
        // Arrange
        int valorTotal = 150;
        bool eClienteVIP = true;

        // Act
        bool resultado = _pedidoService.TemDireitoAFreteGratis(valorTotal, eClienteVIP);

        // Assert
        Assert.True(resultado);
    }

    [Fact]
    public void Teste3_TemDireitoAFreteGratis_CompraNaoVIPAbaixoDe200_DeveRetornarFalse()
    {
        // Arrange
        int valorTotal = 150;
        bool eClienteVIP = false;

        // Act
        bool resultado = _pedidoService.TemDireitoAFreteGratis(valorTotal, eClienteVIP);

        // Assert
        Assert.False(resultado);
    }

    [Fact]
    public void Teste3_TemDireitoAFreteGratis_CompraAcimaOuIgualA200_DeveRetornarTrue()
    {
        // Arrange
        int valorTotal = 200;
        bool eClienteVIP = false;

        // Act
        bool resultado = _pedidoService.TemDireitoAFreteGratis(valorTotal, eClienteVIP);

        // Assert
        Assert.True(resultado);
    }
}
