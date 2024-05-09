# Projeto - Sistema de Hospedagem
## Feito durante o Bootcamp de .NET developer da DIO

[Desafio original](https://github.com/digitalinnovationone/trilha-net-explorando-desafio).

[README original](Desafio.md).

## Sobre o projeto:

O desafio consiste na criação de um programa de hospedagem para um Hotel, utilizando a classe `Pessoa`, para representar o hóspede, `Suíte`, para o quarto, e a classe `Reserva`, que fará um relacionamento entre as duas classes.

O programa precisa calcular corretamente as diárias, e conceder um desconto de 10% no valor quando a quantidade de diárias fosse maior ou igual a 10.

## Regras:

1. Não deve ser possível realizar uma reserva de uma suíte com capacidade menor do que a quantidade de hóspedes. Exemplo: Se é uma suíte capaz de hospedar 2 pessoas, então ao passar 3 hóspedes deverá retornar uma exception.

2. O método `ObterQuantidadeHospedes` da classe `Reserva` deverá retornar a quantidade total de hóspedes, enquanto que o método `CalcularValorDiaria` deverá retornar o valor da diária (Dias reservados x valor da diária).

3. Caso seja feita uma reserva igual ou maior que 10 dias, deverá ser concedido um desconto de 10% no valor da diária.

## Solução

O código originalmente estava feito pela metade, então fiz as devidas correções, e além disso, fiz a criação de um menu, onde o usuário pode escolher a suíte que deseja e inserir a quantidade de hóspedes que serão adicionados. Caso seja maior que a quantidade limite do quarto, a Exception é retornada da mesma forma. 