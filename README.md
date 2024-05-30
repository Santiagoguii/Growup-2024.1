# Sistema de Gerenciamento de Biblioteca

Este é um projeto de sistema de gerenciamento de biblioteca desenvolvido em C# utilizando o framework ASP.NET Core.

## Descrição Geral

O sistema permite operações de CRUD (Criar, Ler, Atualizar, Deletar) de livros e usuários, além de funcionalidades avançadas como empréstimo e devolução de livros e aplicação de multas por atrasos.

## Funcionalidades 

Este projeto de Gerenciamento de Biblioteca tem as seguintes funções:

- Gerenciamento de livros
- Gerenciamento de usuários 
- Gerenciamento de empréstimo
- Gerenciamento de devolução
- Registro de atividades
- Pesquisa de livro
- Funcionalidade de Multa Progressiva por Atraso: Multas incrementais por dia de atraso na devolução, não excedendo o dobro do valor do livro.

## Requisitos Não Funcionais

- API RESTful: Exposição de uma API RESTful.
- Segurança: Implementação de autenticação JWT para proteger a API.
- Banco de Dados: Utilização do Entity Framework Core para integração com um banco de dados SQL.
- Validação de Dados: Validação de dados de entrada para garantir precisão e integridade.
- Documentação da API: Uso do Swagger para documentar a API, facilitando seu uso por outros desenvolvedores.

## Processo de Desenvolvimento

O desenvolvimento do Sistema de Gerenciamento de Biblioteca contém as seguintes etapas:

1. **Organização do Projeto e Configuração do Ambiente de Desenvolvimento:**
   
   * Estabelecemos a estrutura do projeto e as ferramentas de desenvolvimento a serem utilizadas.
   * Configuramos o ambiente de desenvolvimento, incluindo banco de dados, IDE e ferramentas de controle de código-fonte.
   
2. **Desenvolvimento das Funcionalidades Fundamentais:**
   
   * Realizamos a implementação das funcionalidades CRUD para livros e usuários.
   * Criamos as funcionalidades de empréstimo e devolução de livros.
   * Integramos o sistema com um banco de dados SQL por meio do Entity Framework Core.
   
3. **Implementação das Funcionalidades Extras:**
   
   * Desenvolvemos a API RESTful e garantimos a segurança com autenticação JWT.
   * Aplicamos validação de dados em todas as entradas do sistema.
   
4. **Desenvolvimento dos Desafios Suplementares:**
   
   * Elaboramos a documentação da API utilizando o Swagger para facilitar sua utilização por outros desenvolvedores.
   * Estabelecemos multas progressivas por atraso na devolução.
   

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

