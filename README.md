CrudPets

Sistema de gerenciamento de pets via console, desenvolvido em C# e .NET como projeto de aprendizado durante minha transição do atendimento ao cliente para o desenvolvimento de software.

Nota sobre o idioma: O output da aplicação está em português brasileiro, pois é meu idioma nativo e este é um projeto pessoal de aprendizado.

Sobre o Projeto

CrudPets é uma aplicação CRUD (Create, Read, Update, Delete) que roda no terminal. Permite cadastrar pets, gerenciar vacinas e procedimentos médicos, editar informações e remover animais do sistema.

Este projeto foi desenvolvido como parte do meu roadmap de aprendizado para me tornar desenvolvedor backend .NET, cobrindo programação orientada a objetos, encapsulamento, herança, interfaces, validação de input e arquitetura básica de projetos.

Funcionalidades
Cadastrar um novo pet (nome, espécie, idade)
Listar todos os pets cadastrados com suas vacinas e procedimentos
Editar nome, espécie ou idade de um pet
Adicionar vacinas a um pet (nome e data)
Adicionar procedimentos médicos a um pet (nome e data)
Deletar um pet do sistema
Menu interativo com validação de input
Estrutura do Projeto
CrudPets/
├── Program.cs          # Ponto de entrada e menu principal
├── Menu.cs             # Enum do menu principal
├── SubMenu.cs          # Enum do submenu de edição
├── Pet.cs              # Classe da entidade Pet
├── Vacina.cs           # Classe da entidade Vacina
├── Procedimento.cs     # Classe da entidade Procedimento
└── PetController.cs    # Lógica de negócio e interação com o usuário
Decisões de Design
Arquitetura

O projeto segue um padrão simples de controller, separando o fluxo do menu principal (Program.cs) da lógica de negócio (PetController.cs). Cada entidade tem seu próprio arquivo seguindo as convenções do C#.

Armazenamento em memória

Os dados são armazenados em uma List<Pet> mantida em memória durante a sessão do programa. Não há integração com banco de dados — essa foi uma decisão intencional para manter o foco em POO e nos fundamentos do C#. Uma versão futura poderá integrar Entity Framework Core e SQL Server.

Validação de input

A maioria dos inputs é validada com int.TryParse e DateTime.TryParse com lógica de retry em loop. Alguns campos (nome da vacina, nome do procedimento) não possuem validação completa — essa foi uma decisão deliberada para manter o andamento do projeto, documentada aqui como limitação conhecida.

Encapsulamento

Todas as propriedades das entidades usam { get; private set; }. A mutação só é permitida através de métodos dedicados (EditarNome, EditarEspecie, EditarIdade) na classe Pet, mantendo a modificação de dados controlada e intencional.

Como Executar
Pré-requisitos
.NET SDK 8.0+
Passos
bash
git clone https://github.com/danmedol/CrudPets.git
cd CrudPets
dotnet run
O que Aprendi
Programação orientada a objetos em C# (classes, encapsulamento, herança, interfaces)
Separação de responsabilidades com padrão controller
Validação de input com TryParse e retry em loop
Trabalho com List<T>, DateTime e enums
Controle de versão com Git e histórico de commits descritivos
Estrutura de projeto com múltiplos arquivos e classes de responsabilidade única
