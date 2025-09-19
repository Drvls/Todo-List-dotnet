using System;
using System.Collections.Generic;
using TodoList.DTO;
using TodoList.Entities;
using TodoList.Enuns;
using TodoList.Interfaces;

namespace TodoList.Services;

public class TarefaService(ITarefaRepository tarefaRepository) : ITarefaService
{
    private readonly ITarefaRepository _repository = tarefaRepository;
    
    public Tarefa Add(TarefaDto tarefa)
    {
        var temp = new Tarefa
        {
            Titulo = tarefa.Titulo.ToLower(),
            Descricao = tarefa.Descricao,
            Data = tarefa.Data,
            Status = tarefa.Status.ToString()
        };
        return _repository.Add(temp);
    }

    public Tarefa GetById(int id)
    {
        return _repository.GetById(id);
    }

    public IEnumerable<Tarefa> GetAll()
    {
        return _repository.GetAll();
    }

    public IEnumerable<Tarefa> GetAllByTitulo(string titulo)
    {
        return _repository.GetAll(x => x.Titulo == titulo);
    }

    public IEnumerable<Tarefa> GetAllByDate(DateTime date)
    {
        return _repository.GetAll(x => x.Data == date);
    }

    public IEnumerable<Tarefa> GetAllByStatus(Status status)
    {
        return _repository.GetAll(x => x.Status == status.ToString());
    }

    public bool Update(int id, TarefaDto tarefa)
    {
        var tarefaExistente = _repository.GetById(id);
        if(tarefaExistente == null) return false;
        
        tarefaExistente.Titulo = tarefa.Titulo;
        tarefaExistente.Descricao = tarefa.Descricao;
        tarefaExistente.Data = tarefa.Data;
        tarefaExistente.Status = tarefa.Status.ToString();
        
        return _repository.Update(tarefaExistente);
    }

    public bool Delete(int id)
    {
        var idValidation = _repository.GetById(id);
        if(idValidation == null) return false;
        return _repository.Delete(id);
    }
}