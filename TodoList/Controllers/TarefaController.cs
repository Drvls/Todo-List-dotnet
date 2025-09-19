using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TodoList.DTO;
using TodoList.Entities;
using TodoList.Enuns;
using TodoList.Interfaces;
using TodoList.ModelViews;
using TodoList.Services;

namespace TodoList.Controllers;

[ApiController]
[Route("[controller]")]
public class TarefaController(ITarefaService service) : ControllerBase
{
    ValidationError ValidarErros(TarefaDto tarefa)
    {
        var erros = new ValidationError
        {
            Mensagens = new List<string>()
        };
        
        if(string.IsNullOrEmpty(tarefa.Titulo)) erros.Mensagens.Add("O titulo é necessário");
        if(tarefa?.Data == null) erros.Mensagens.Add("A data é necessária");
        if (tarefa?.Status == null) erros.Mensagens.Add("O status é necessário");
        
        return erros;
    }
    
    [HttpPost]
    public ActionResult Add(TarefaDto tarefa)
    {
        var tarefaValidation = ValidarErros(tarefa);
        if(tarefaValidation.Mensagens.Count > 0) return BadRequest(tarefaValidation.Mensagens);

        var sucesso = service.Add(tarefa);
        if (sucesso == null) return BadRequest();
        return Created("api/tarefa", sucesso);
    }

    [HttpGet("{id:int}")]
    public ActionResult<Tarefa> GetById(int id)
    {
        var tarefa = service.GetById(id);
        if(tarefa == null) return NotFound();
        return Ok(tarefa);
    }

    [HttpGet("ObterTodos")]
    public ActionResult<IEnumerable<Tarefa>> GetAll()
    {
        var tarefas = service.GetAll();
        if(!tarefas.Any()) return NotFound();
        return Ok(tarefas);
    }

    [HttpGet("ObterPorTitulo")]
    public ActionResult<IEnumerable<Tarefa>> GetByTitulo(string titulo)
    {
        var tarefas = service.GetAllByTitulo(titulo.ToLower());
        if(!tarefas.Any()) return NotFound();
        return Ok(tarefas);
    }
    
    [HttpGet("ObterPorData")]
    public ActionResult<IEnumerable<Tarefa>> GetByDate(DateTime data)
    {
        var tarefas = service.GetAllByDate(data);
        if(!tarefas.Any()) return NotFound();
        return Ok(tarefas);
    }
    
    [HttpGet("ObterPorStatus")]
    public ActionResult<IEnumerable<Tarefa>> GetByStatus(Status status)
    {
        var tarefas = service.GetAllByStatus(status);
        if(!tarefas.Any()) return NotFound();
        return Ok(tarefas);
    }

    [HttpPut("{id:int}")]
    public ActionResult Update(int id, TarefaDto tarefa)
    {
        var sucesso = service.Update(id, tarefa);
        if (!sucesso) return NotFound();
        return Ok(tarefa);
    }

    [HttpDelete("{id:int}")]
    public ActionResult Delete(int id)
    {
        var sucesso = service.Delete(id);
        if (!sucesso) return NotFound();
        return NoContent();
    }
}