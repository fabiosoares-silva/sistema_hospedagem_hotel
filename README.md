# Sistema de Hospedagem Hotel

Sistema de gerenciamento de reservas hoteleiras desenvolvido em C# com .NET 8,
criado como desafio prático do bootcamp Akad Fullstack Developer (DIO).

## Sobre o projeto

Aplicação console que simula o fluxo de reserva de um hotel, permitindo
cadastrar hóspedes, associar uma suíte e calcular o valor total da hospedagem
com aplicação automática de desconto.

## Funcionalidades

- Cadastro de hóspedes com validação de capacidade da suíte
- Cadastro de suíte com tipo, capacidade e valor de diária
- Cálculo do valor total da reserva
- Desconto de 10% aplicado automaticamente para reservas de 10 dias ou mais
- Exibição de resumo completo da hospedagem

## Tecnologias

- C# / .NET 8
- Programação Orientada a Objetos: Uso de classes, construtores e encapsulamento.
- Lógica de Negócio: Validação de regras de ocupação e cálculos condicionais.
- Separação de Responsabilidades: Organização estruturada entre modelos de dados e serviços.

## Como executar
```bash
# Clone o repositório
git clone https://github.com/fabiosoares-silva/sistema-hospedagem-hotel.git

# Entre na pasta do projeto
cd sistema-hospedagem-hotel

# Execute
dotnet run
```

## Exemplo de saída
```
===========================================
           RESUMO DA HOSPEDAGEM           
===========================================
Hóspedes cadastrados: HÓSPEDE 1
Suíte:                Premium
Período:              5 dias
Valor total:          R$ 150,00
===========================================
```

## Próximos passos

- Menu interativo para entrada de dados pelo usuário
- Suporte a múltiplos hóspedes no resumo
- Persistência de dados
