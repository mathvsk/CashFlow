<h1 align="center">
  CashFlow
</h1>

![.Net](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)
![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=csharp&logoColor=white)
![Static Badge](https://img.shields.io/badge/MIT-maker?style=for-the-badge&label=License&labelColor=%23303030&color=%23808080)

CashFlow é uma API (CRUD) referente a despesas financeiras, desenvolvida em C#/.Net, aplicando conceitos de DDD, SOLID e CleanCode.

## Como usar
Faça um clone do projeto.

### Visual Studio
Basta abrir o projeto no Visual Studio e executar a aplicação.

### VS Code
Navegue até `src/CashFlow.API` e execute o comando `dotnet run`.

## API Endpoints

|Rota  | Descrição |
|--|--|
| <kbd>GET /</kbd> | Recupera todas as despesas  |
| <kbd>GET /{id}</kbd> | Recupera uma despesa |
| <kbd>POST /</kbd> | Cadastra uma despesa |
| <kbd>DELETE /{id}</kbd> | Deleta uma despesa |
| <kbd>PUT /{id}</kbd> | Atualiza uma despesa |

Para visualizar a documentação completa dos endpoints, rode o projeto e acesse a rota: `localhost{PORT}/swagger/index.html`.