# DesafioApi01
Desafio API 01 - Retorno de taxa de juros

## Descrição
Esta API está disposta no serviço de nuvem Azure para livre utilização, seu principal e único endpoint é chamado via `/taxaJuros` e possui um retorno no seguinte formato:

```json
{
  "valorTaxa": 0.01
}
```

O desenvolvimento se deu sob ASP.NET Core Web API 3.1, a escolha desta versão se deu pela sua característa LTS, garantindo suporte de longo prazo. A documentação da API se deu a partir do Swagger.

## Entrega

### Requisitos mínimos
- [x] Código fonte ASP.NET Core Web API
- [x] Testes unitários utilizando-se do MSTest

### Requisitos extrs
- [x] Construção da aplicação utilizando Docker
- [ ] Teste de integração da API / Pirâmide de testes
- [x] Utilização do Swagger
