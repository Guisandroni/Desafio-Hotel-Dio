# 🏨 Sistema para Gerenciamento de Hotel

Este projeto é uma solução em C# para o desafio de projeto da trilha .NET da Digital Innovation One (DIO). O objetivo é construir um sistema de gerenciamento de reservas de hotel, aplicando os conceitos de Programação Orientada a Objetos (POO), classes, herança e coleções.

## 🚀 Funcionalidades

- **Cadastro de Hóspedes:** Permite adicionar hóspedes a uma reserva, garantindo que o número de hóspedes não exceda a capacidade da suíte.
- **Cadastro de Suítes:** Define o tipo de suíte, capacidade e valor da diária.
- **Criação de Reservas:** Permite criar reservas com um número de hóspedes e uma suíte específica, calculando o valor total.
- **Cálculo da Diária:** Calcula o valor da diária com base na suíte selecionada e aplica um desconto especial para reservas de 10 dias ou mais.

## 🛠️ Tecnologias Utilizadas

- **C#:** Linguagem principal do projeto.
- **.NET:** Framework utilizado para a construção do sistema.
- **Classes e Objetos:** Utilização de classes como `Reserva`, `Suite` e `Pessoa` para modelar o domínio do problema.
- **Encapsulamento:** Uso de propriedades (`get` e `set`) para proteger o estado interno dos objetos.
- **Coleções:** Uso de `List<T>` para gerenciar os hóspedes em uma reserva.
