# CrudPets

> **Language note:** The application output is in Brazilian Portuguese, as it is my native language and this is a personal learning project.

A console-based pet management system built with C# and .NET, developed as a learning project during my transition from customer service to software development.

---

## About

CrudPets is a CRUD (Create, Read, Update, Delete) application that runs in the terminal. It allows users to register pets, manage their vaccination records and medical procedures, edit their information, and remove them from the system.

This project was built to practice object-oriented programming, encapsulation, separation of concerns, input validation, and basic project architecture in C#.

---

## Features

- Register a new pet (name, species, age)
- List all registered pets with vaccinations and procedures
- Edit a pet's name, species, or age
- Add vaccinations to a pet (name and date)
- Add medical procedures to a pet (name and date)
- Delete a pet from the system
- Interactive menu with input validation

---

## How to Run

**Prerequisites:** [.NET SDK 8.0+](https://dotnet.microsoft.com/download)

```bash
git clone https://github.com/danmedol/CrudPets.git
cd CrudPets
dotnet run
```

---

## Design Decisions

- **In-memory storage:** Data is stored in a List held in memory for the duration of the session. No database integration — intentional decision to keep focus on OOP and C# fundamentals.
- **Controller pattern:** Business logic and user interaction are handled by PetController, keeping Program.cs clean and focused on the main menu flow.
- **Encapsulation:** All entity properties use get with private set. Mutation is only allowed through dedicated methods on the Pet class.
- **Input validation:** Age validation uses TryParse with loop-based retry. Some fields (vaccination name, procedure name) have no full validation — a known and documented limitation.

---

## What I Learned

- Object-oriented programming in C# (classes, encapsulation, inheritance, interfaces)
- Separation of concerns with a controller pattern
- Input validation with TryParse and loop-based retry
- Working with List, DateTime, and enums
- Git version control with descriptive commit history
- Project structure with multiple files and single-responsibility classes

---

## Author

**Daniel** — transitioning from customer service to backend .NET development.

[GitHub](https://github.com/danmedol)

---

---

# CrudPets (Português)

> **Nota sobre o idioma:** O output da aplicação está em português brasileiro, pois é meu idioma nativo e este é um projeto pessoal de aprendizado.

Sistema de gerenciamento de pets via console, desenvolvido em C# e .NET como projeto de aprendizado durante minha transição do atendimento ao cliente para o desenvolvimento de software.

---

## Sobre

CrudPets é uma aplicação CRUD (Create, Read, Update, Delete) que roda no terminal. Permite cadastrar pets, gerenciar vacinas e procedimentos médicos, editar informações e remover animais do sistema.

Este projeto foi desenvolvido para praticar programação orientada a objetos, encapsulamento, separação de responsabilidades, validação de input e arquitetura básica de projetos em C#.

---

## Funcionalidades

- Cadastrar um novo pet (nome, espécie, idade)
- Listar todos os pets cadastrados com vacinas e procedimentos
- Editar nome, espécie ou idade de um pet
- Adicionar vacinas a um pet (nome e data)
- Adicionar procedimentos médicos a um pet (nome e data)
- Deletar um pet do sistema
- Menu interativo com validação de input

---

## Como Executar

**Pré-requisitos:** [.NET SDK 8.0+](https://dotnet.microsoft.com/download)

```bash
git clone https://github.com/danmedol/CrudPets.git
cd CrudPets
dotnet run
```

---

## Decisões de Design

- **Armazenamento em memória:** Os dados ficam em uma List durante a sessão. Sem banco de dados — decisão intencional para manter o foco em POO e fundamentos do C#.
- **Padrão controller:** A lógica de negócio e interação com o usuário são tratadas pelo PetController, mantendo o Program.cs focado no fluxo do menu principal.
- **Encapsulamento:** Todas as propriedades usam get com private set. A mutação só é permitida através de métodos dedicados na classe Pet.
- **Validação de input:** A validação de idade usa TryParse com retry em loop. Alguns campos (nome da vacina, nome do procedimento) não têm validação completa — limitação conhecida e documentada.

---

## O que Aprendi

- Programação orientada a objetos em C# (classes, encapsulamento, herança, interfaces)
- Separação de responsabilidades com padrão controller
- Validação de input com TryParse e retry em loop
- Trabalho com List, DateTime e enums
- Controle de versão com Git e histórico de commits descritivos
- Estrutura de projeto com múltiplos arquivos e classes de responsabilidade única

---

## Autor

**Daniel** — em transição do atendimento ao cliente para o desenvolvimento backend .NET.

[GitHub](https://github.com/danmedol)
