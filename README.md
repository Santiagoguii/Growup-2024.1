# Sistema de Gerenciamento de Biblioteca

Este é um projeto de sistema de gerenciamento de biblioteca desenvolvido em C# utilizando o framework ASP.NET Core.

## Descrição Geral

O sistema permite operações de CRUD (Criar, Ler, Atualizar, Deletar) de livros e usuários, além de funcionalidades avançadas como empréstimo e devolução de livros, aplicação de multas por atrasos, e restrições para usuários com históricos de atrasos recorrentes.

## Funcionalidades 

Este projeto de Gerenciamento de Biblioteca tem as seguintes funções:

- Gerenciamento de livros
- Gerenciamneto de usuários 
- Gerenciamento de empréstimo
- Gerenciamento de devolução
- Registro de atividades
- Pesquisa de livro

## Requisitos Não Funcionais

- API RESTful: Exposição de uma API RESTful.
- Segurança: Implementação de autenticação JWT para proteger a API.
- Banco de Dados: Utilização do Entity Framework Core para integração com um banco de dados SQL.
- Validação de Dados: Validação de dados de entrada para garantir precisão e integridade.
- Testes Unitários: Desenvolvimento de testes unitários para assegurar a corretude do código.

## Desafios Adicionais

- Documentação da API: Uso do Swagger para documentar a API, facilitando seu uso por outros desenvolvedores.
- Relatórios Avançados: Geração de relatórios sobre livros mais populares, usuários mais ativos, histórico de atrasos, etc.
- Funcionalidade de Multa Progressiva por Atraso: Multas incrementais por dia de atraso na devolução, não excedendo o dobro do valor do livro.
- Funcionalidade de Penalidades para Atrasos Recorrentes: Restrições como limitar o empréstimo a um livro por vez para usuários com histórico de atrasos.

## Orientações para Implementação

A implementação do Sistema de Gerenciamento de Biblioteca deve seguir as seguintes etapas:

1. **Organização do Projeto e Configuração do Ambiente de Desenvolvimento:**
   
   * Estabelecer a estrutura do projeto e as ferramentas de desenvolvimento a serem utilizadas.
   * Configurar o ambiente de desenvolvimento, incluindo banco de dados, IDE e ferramentas de controle de código-fonte.
   
2. **Desenvolvimento das Funcionalidades Fundamentais:**
   
   * Realizar a implementação das funcionalidades CRUD para livros e usuários.
   * Criar as funcionalidades de empréstimo e devolução de livros.
   * Integração do sistema com um banco de dados SQL por meio do Entity Framework Core.
   
3. **Implementação das Funcionalidades Extras:**
   
   * Desenvolver a API RESTful e garantir a segurança com autenticação JWT.
   * Aplicar validação de dados em todas as entradas do sistema.
   * Criar testes unitários para assegurar a confiabilidade do código.
   
4. **Desenvolvimento dos Desafios Suplementares:**
   
   * Elaborar a documentação da API utilizando o Swagger para facilitar sua utilização por outros desenvolvedores.
   * Implementar funcionalidades para geração de relatórios avançados.
   * Estabelecer multas progressivas por atraso na devolução.
   * Aplicar sanções para usuários com histórico de atrasos frequentes.




## Tecnologias utilizadas

- C#
- Swagger
- API RESTful
- .NET Framework
- Autenticação JWT
- Banco de dados SQL
- Entity Framework Core


## Equipe

- ALAN VITOR VITORINO GALDINO
- ANDRÉ LUIS DA SILVA DE BARROS
- CLARICE RODRIGUES OLIVEIRA DA SILVA
- GUILHERME PEREIRA DA SILVA SANTIAGO
- GRAZIELLY FERNANDA FELIX DA SILVA
- MATEUS PEREIRA DIZEU
- MELKSEDEC ANTÔNIO DA SILVA

