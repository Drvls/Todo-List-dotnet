# 🚀 API de Gerenciamento de Tarefas - .Net e Entity Framework
![.NET](https://img.shields.io/badge/.NET-8.0-blue)
![MySQL](https://img.shields.io/badge/MySQL-8-orange)


## 📌 Sobre o projeto
API desenvolvida como desafio do bootcamp .NET da DIO
.
Embora o desafio original trouxesse parte do código pronto, optei por construir a aplicação do zero, apenas com base nos diagramas e endpoints fornecidos.

- Código atualizado para .NET 8 LTS
- Estruturado com Repository Pattern e boas práticas (separação Controller > Service > Repository)
- Documentado com Swagger

![Diagrama da classe Tarefa](assets/diagrama.png)

# 🛠️ Tecnologias
- **.NET 8 LTS (C#)**
- **MySQL 8** + Workbench
- **Entity Framework Core** (Migrations, Tools, Design)
- **Swagger UI** para documentação interativa da API

📂 **Estrutura do Projeto**
```
📦 Todo-List
 ┣ 📂 Controllers     → Endpoints (entrada/saída da API)
 ┣ 📂 Db              → Configuração do contexto de banco
 ┣ 📂 DTO             → Objetos de transferência de dados
 ┣ 📂 Entities        → Modelos principais (persistência)
 ┣ 📂 Enuns           → Definições de enums (ex.: Status)
 ┣ 📂 Interfaces      → Contratos de Repositories/Services
 ┣ 📂 ModelViews      → Representações de resposta
 ┣ 📂 Repositories    → Acesso ao banco de dados (EF Core)
 ┣ 📂 Services        → Regras de negócio
 ┣ appsettings.json   → Configurações da aplicação
 ┗ Program.cs         → Configuração inicial da API
```

✅ **Seguindo Repository Pattern para garantir desacoplamento:**
```
Controller → Service → Repository
```
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


## 📑 Exemplo de saída (JSON)

```json
{
  "id": 0,
  "titulo": "Estudar .NET",
  "descricao": "Terminar o desafio de projeto",
  "data": "2025-09-19 12:13:42.748000",
  "status": "Concluido"
}
```
