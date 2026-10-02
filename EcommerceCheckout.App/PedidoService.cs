// Aluno: Fernando Almeida de Oliveira Braga
// RA: 326132695
// Disciplina: Garantia e Gestão da Qualidade de Software - Prof. Daniel Henrique Matos de Paiva

namespace EcommerceCheckout.App;

public class PedidoService
{
    /// <summary>
    /// Retorna uma string formatada unindo a região em maiúsculas com o número do pedido preenchido com zeros à esquerda (4 dígitos).
    /// Exemplo: Recebe "sudeste" e 42 -> Retorna "SUDESTE-0042".
    /// </summary>
    public string GerarCodigoRastreio(string regiao, int numeroPedido)
    {
        string regiaoFormatada = regiao?.ToUpper() ?? string.Empty;
        return $"{regiaoFormatada}-{numeroPedido:D4}";
    }

    /// <summary>
    /// Para cada R$ 10 em compras, o cliente ganha 2 pontos de fidelidade.
    /// Exemplo: Recebe 150 (150 / 10 = 15 * 2) -> Retorna 30.
    /// </summary>
    public int CalcularPontosFidelidade(int valorTotal)
    {
        return (valorTotal / 10) * 2;
    }

    /// <summary>
    /// O frete é grátis se o valor total for maior ou igual a R$ 200 OU se o comprador for um cliente VIP.
    /// Exemplo: Recebe 150 e true -> Retorna true. Recebe 150 e false -> Retorna false.
    /// </summary>
    public bool TemDireitoAFreteGratis(int valorTotal, bool eClienteVIP)
    {
        return valorTotal >= 200 || eClienteVIP;
    }
}
