CrudPets

Sistema de gerenciamento de pets via console, desenvolvido em C# e .NET como projeto de aprendizado durante minha transição do atendimento ao cliente para o desenvolvimento de software.

Nota sobre o idioma: O output da aplicação está em português brasileiro, pois é meu idioma nativo e este é um projeto pessoal de aprendizado.

Sobre

CrudPets é uma aplicação CRUD que roda no terminal. Permite cadastrar pets, gerenciar vacinas e procedimentos médicos, editar informações e remover animais do sistema.

Funcionalidades
Cadastrar um novo pet (nome, espécie, idade)
Listar todos os pets com vacinas e procedimentos
Editar nome, espécie ou idade de um pet
Adicionar vacinas a um pet (nome e data)
Adicionar procedimentos médicos a um pet (nome e data)
Deletar um pet do sistema
Menu interativo com validação de input
Como Executar

Pré-requisitos: .NET SDK 8.0+

bash
git clone https://github.com/danmedol/CrudPets.git
cd CrudPets
dotnet run
Decisões de Design
Armazenamento em memória: Os dados ficam em uma List durante a sessão. Sem banco de dados — decisão intencional para manter o foco em POO e fundamentos do C#.
Validação de input: A maioria dos inputs é validada com TryParse e retry em loop. Alguns campos (nome da vacina, nome do procedimento) não têm validação completa — limitação conhecida e documentada.
Encapsulamento: Todas as propriedades usam get com private set. A mutação só é permitida através de métodos dedicados na classe Pet.
O que Aprendi
Programação orientada a objetos em C# (classes, encapsulamento, herança, interfaces)
Separação de responsabilidades com padrão controller
Validação de input com TryParse e retry em loop
Trabalho com List, DateTime e enums
Controle de versão com Git e histórico de commits descritivos
