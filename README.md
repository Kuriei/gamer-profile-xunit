# Gamer Profile - Testes Unitários com xUnit

## Aluno
Cauã Parreiras Vieira
RA: 32516918
Centro Universitário UNA

## Descrição

Este projeto foi desenvolvido para a disciplina de Gestão e Qualidade de Software.

O objetivo é implementar um serviço de cadastro de jogadores utilizando C# e .NET 10, além de realizar testes unitários com xUnit.

## Funcionalidades

O sistema possui três funcionalidades principais:

### Gerar Tag de Usuário

O método `GerarTagUsuario` recebe um nickname e um código e retorna os dois valores separados pelo caractere `#`.

Exemplo: `Nickname#0000`

### Calcular XP Total

O método `CalcularXPTotal` soma o XP obtido em duas fases e acrescenta um bônus fixo de 100 pontos.

Exemplo: 200 + 300 + 100 = 600.

### Verificar Elegibilidade para Ranked

O método `EEligivelParaRanked` verifica o nível do jogador. Jogadores com nível maior ou igual a 15 são elegíveis para partidas ranqueadas.

## Testes Unitários

Os testes foram desenvolvidos utilizando xUnit:

- `Assert.Equal` para validar a geração da tag do usuário.
- `Assert.Equal` para validar o cálculo do XP total.
- `Assert.True` para verificar um jogador elegível para ranked.
- `Assert.False` para verificar um jogador não elegível para ranked.

## Como executar os testes

No terminal, na pasta principal do projeto, execute:

```bash
dotnet test
