using System;
using System.Collections.Generic;
using TodoList.Entities;
using TodoList.Enuns;

namespace TodoList.Interfaces;

public interface ITarefaRepository
{
    Tarefa Add(Tarefa tarefa);
    Tarefa GetById(int id);
    IEnumerable<Tarefa> GetAll();
    IEnumerable<Tarefa> GetAll(Func<Tarefa, bool> info);
    bool Update(Tarefa tarefa);
    bool Delete(int id);
}

// Trocar Func por Expression Tree