// Aluno: Fernando Almeida de Oliveira Braga
// RA: 326132695
// Disciplina: Garantia e Gestão da Qualidade de Software - Prof. Daniel Henrique Matos de Paiva

using EcommerceCheckout.App;

Console.WriteLine("=== EcommerceCheckout ===");
var pedidoService = new PedidoService();

// Exemplo 1: Código de Rastreio
string codigo = pedidoService.GerarCodigoRastreio("sudeste", 42);
Console.WriteLine($"Código de Rastreio: {codigo}");

// Exemplo 2: Pontos de Fidelidade
int pontos = pedidoService.CalcularPontosFidelidade(150);
Console.WriteLine($"Pontos de Fidelidade (R$ 150): {pontos}");

// Exemplo 3: Frete Grátis
bool freteVip = pedidoService.TemDireitoAFreteGratis(150, true);
Console.WriteLine($"Frete Grátis (R$ 150, VIP): {freteVip}");

bool freteNaoVip = pedidoService.TemDireitoAFreteGratis(150, false);
Console.WriteLine($"Frete Grátis (R$ 150, Não VIP): {freteNaoVip}");
