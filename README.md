# EcommerceCheckout

Projeto desenvolvido como parte da disciplina de **Garantia e Gestão da Qualidade de Software** (Prof. Daniel Henrique Matos de Paiva - Ânima Educação).

---

## 👤 Identificação do Aluno

- **Nome:** Fernando Almeida de Oliveira Braga  
- **RA:** 326132695  
- **Disciplina:** Garantia da Qualidade de Software / Gestão e Qualidade de Software  
- **Professor:** Daniel Henrique Matos de Paiva  

---

## 🛠️ Tecnologias Utilizadas

- **C# / .NET 10** (Console Application)
- **xUnit** (Framework de Testes Unitários)
- **Microsoft.NET.Test.Sdk**
- **Git / GitHub**

---

## 📁 Estrutura da Solução

```text
EcommerceCheckout/
├── EcommerceCheckout.sln                 # Arquivo de solução que vincula os projetos
├── EcommerceCheckout.App/               # Projeto da Aplicação (Código de Produção)
│   ├── EcommerceCheckout.App.csproj
│   ├── PedidoService.cs                 # Classe com as regras de negócio
│   └── Program.cs                       # Ponto de entrada e demonstração
├── EcommerceCheckout.Tests/             # Projeto de Testes Unitários (xUnit)
│   ├── EcommerceCheckout.Tests.csproj
│   └── PedidoServiceTests.cs            # Suíte de testes unitários com xUnit
├── .gitignore                           # Gitignore oficial para .NET / Visual Studio
├── LICENSE                              # Licença pública MIT
└── README.md                            # Documentação do projeto
```

---

## ⚙️ Métodos Implementados (`PedidoService.cs`)

A classe `PedidoService` implementa as três regras de negócio solicitadas:

### 1. `GerarCodigoRastreio(string regiao, int numeroPedido) : string`
- **Regra:** Retorna uma string formatada unindo a região em maiúsculas com o número do pedido preenchido com zeros à esquerda (4 dígitos fixos).
- **Exemplo:** `GerarCodigoRastreio("sudeste", 42)` &rarr; `"SUDESTE-0042"`

### 2. `CalcularPontosFidelidade(int valorTotal) : int`
- **Regra:** Para cada R$ 10 em compras, o cliente ganha 2 pontos de fidelidade (`(valorTotal / 10) * 2`).
- **Exemplo:** `CalcularPontosFidelidade(150)` &rarr; `30` pontos (15 parcelas de R$ 10 &times; 2)

### 3. `TemDireitoAFreteGratis(int valorTotal, bool eClienteVIP) : bool`
- **Regra:** O frete é grátis se o valor total for maior ou igual a R$ 200 **OU** se o comprador for um cliente VIP (`valorTotal >= 200 || eClienteVIP`).
- **Exemplos:**
  - `TemDireitoAFreteGratis(150, true)` &rarr; `true` (Compra VIP abaixo de R$ 200)
  - `TemDireitoAFreteGratis(150, false)` &rarr; `false` (Compra não-VIP abaixo de R$ 200)
  - `TemDireitoAFreteGratis(200, false)` &rarr; `true` (Compra não-VIP com valor &ge; R$ 200)

---

## 🧪 Cobertura dos Testes Unitários (`PedidoServiceTests.cs`)

Os testes foram escritos no xUnit utilizando o atributo `[Fact]` e as asserções solicitadas:

| Teste | Método Testado | Cenário | Asserção Utilizada | Resultado Esperado |
| :--- | :--- | :--- | :--- | :--- |
| **Teste 1 (string)** | `GerarCodigoRastreio` | Região `"sudeste"`, Pedido `42` | `Assert.Equal("SUDESTE-0042", resultado)` | `"SUDESTE-0042"` |
| **Teste 2 (int)** | `CalcularPontosFidelidade` | Compra de R$ 150 | `Assert.Equal(30, resultado)` | `30` pontos |
| **Teste 3 (bool)** | `TemDireitoAFreteGratis` | Compra VIP de R$ 150 (&lt; R$ 200) | `Assert.True(resultado)` | `true` |
| **Teste 3 (bool)** | `TemDireitoAFreteGratis` | Compra não-VIP de R$ 150 (&lt; R$ 200) | `Assert.False(resultado)` | `false` |
| **Bônus (bool)** | `TemDireitoAFreteGratis` | Compra não-VIP de R$ 200 (&ge; R$ 200) | `Assert.True(resultado)` | `true` |

---

## 🚀 Instruções de Execução

### Pré-requisitos
- [.NET 10 SDK](https://dotnet.microsoft.com/download) instalado.

### 1. Clonar o repositório
```bash
git clone https://github.com/vivoeasy100/ecommerce-checkout-xunit-.git
cd ecommerce-checkout-xunit-
```

### 2. Restaurar dependências e compilar a solução
```bash
dotnet build
```

### 3. Executar os Testes Unitários
Para rodar a suíte completa de testes unitários com o xUnit:
```bash
dotnet test
```

Saída esperada:
```text
Aprovado!  – Com falha: 0, Aprovado: 5, Ignorado: 0, Total: 5
```

### 4. Executar a Aplicação Console (Demonstração)
```bash
dotnet run --project EcommerceCheckout.App
```

---

## 📄 Licença

Este projeto está licenciado sob a licença pública **MIT** - consulte o arquivo [LICENSE](LICENSE) para obter mais detalhes.
