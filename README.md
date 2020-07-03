# Desafio técnico - .Net Core

Desenvolvimento de duas API's em Asp Net Core

## Configurando

API de Taxas será executada  na porta 5001.
API de Cálculos será executada na porta 5002.

## API Taxa Juros

- Retorna taxa de juros

Path relativo para chamada "/taxaJuros"
```
Retorno : "0,01"
```

## API de Cálculo de Juros

- Cálculo de Juros

Path relativo para chamada "/calculajuros". Executado um cálculo de juros compostos com os parâmetros passados(Valor inicial e meses). Retorno truncado em duas casas decimais.

```
Exemplo: /calculajuros?valorinicial=100&meses=5
Retorno: "105,10"
```
- ShowMeTheCode

Retorna o github do autor. 
```
https://github.com/debritoleo
```

## Tests

Testes unitários incluídos nas duas API's.
