# API de Gerenciamento de Tarefas - .Net e Entity Framework
![.NET](https://img.shields.io/badge/.NET-8.0-blue)
![MySQL](https://img.shields.io/badge/MySQL-8-orange)

Este é um desafio de projeto do bootcamp de .NET da  [DIO](www.dio.me).

O desafio em si se baseia em completar o código do [projeto](https://github.com/digitalinnovationone/trilha-net-api-desafio/tree/main) de API, maior parte já feito, faltando apenas o CRUD.

Como desafio próprio e profissional, esta API foi feita totalmente do zero, usando apenas os digramas e endpoints como base. Código totalmente diferente e atualizado para .NET 8, mas mantendo suas funcionalidades.

# Tecnologias
- .NET 8 LTS (C#)
- MySQL + Workbench
- EntityFrameWorkCore +  Tools + Design
- Swagger para documentação

![Diagrama da classe Tarefa](assets/diagrama.png)

## Métodos 

**Swagger**


![Métodos Swagger](assets/swagger.png)


**Endpoints**


| Verbo  | Endpoint                | Parâmetro | Body          |
|--------|-------------------------|-----------|---------------|
| GET    | /Tarefa/{id}            | id        | N/A           |
| PUT    | /Tarefa/{id}            | id        | Schema Tarefa |
| DELETE | /Tarefa/{id}            | id        | N/A           |
| GET    | /Tarefa/ObterTodos      | N/A       | N/A           |
| GET    | /Tarefa/ObterPorTitulo  | titulo    | N/A           |
| GET    | /Tarefa/ObterPorData    | data      | N/A           |
| GET    | /Tarefa/ObterPorStatus  | status    | N/A           |
| POST   | /Tarefa                 | N/A       | Schema Tarefa |

Saída esperada em JSON.

```json
{
  "id": 0,
  "titulo": "string",
  "descricao": "string",
  "data": "2022-06-08T01:31:07.056Z",
  "status": "Pendente"
}
```