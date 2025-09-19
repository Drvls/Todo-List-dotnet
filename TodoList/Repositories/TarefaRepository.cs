using System;
using System.Collections.Generic;
using System.Linq;
using TodoList.Db;
using TodoList.Entities;
using TodoList.Interfaces;

namespace TodoList.Repositories;

public class TarefaRepository(DbContexto context) : ITarefaRepository
{
    public Tarefa Add(Tarefa tarefa)
    {
        context.Tarefas.Add(tarefa);
        context.SaveChanges();
        return tarefa;
    }

    public Tarefa GetById(int id)
    {
        return context.Tarefas.Find(id);
    }

    public IEnumerable<Tarefa> GetAll()
    {
        return context.Tarefas.ToList();
    }

    public IEnumerable<Tarefa> GetAll(Func<Tarefa, bool> info)
    {
        return context.Tarefas.Where(info).ToList();
    }

    public bool Update(Tarefa tarefa)
    {
        context.Tarefas.Update(tarefa);
        return context.SaveChanges() > 0;
    }

    public bool Delete(int id)
    {
        context.Tarefas.Remove(GetById(id));
        return context.SaveChanges() > 0;
    }
}