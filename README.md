<h1 align="center">
  CashFlow
</h1>

![Static Badge](https://img.shields.io/badge/MIT-maker?style=for-the-badge&label=License&labelColor=%23303030&color=%23808080)

CashFlow é uma API (CRUD) referente despesas financeiras, desenvolvida em C#/.Net, aplicando conceitos de DDD, SOLID e CleanCode.

## Como usar
### Visual Studio
Basta abrir o projeto no Visual Studio e executar a aplicação.

### VS Code
Faça o clone do repositório e execute o comando `dotnet run` na raiz do projeto.

## API Endpoints

|Rota  | Descrição |
|--|--|
| <kbd>GET /</kbd> | Recupera todas as despesas  |
| <kbd>GET /{id}</kbd> | Recupera uma despesa |
| <kbd>POST /</kbd> | Cadastra uma despesa |
| <kbd>DELETE /{id}</kbd> | Deleta uma despesa |
| <kbd>PUT /{id}</kbd> | Atualiza uma despesa |

Para visualizar a documentação completa dos endpoints, rode o projeto e acesse a rota <kbd>localhost{PORT}/swagger/index.html</kbd>.