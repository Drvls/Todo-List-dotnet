using System;
using System.Collections.Generic;
using TodoList.DTO;
using TodoList.Entities;
using TodoList.Enuns;

namespace TodoList.Interfaces;

public interface ITarefaService
{
    Tarefa Add(TarefaDto tarefa);
    Tarefa? GetById(int id);

    IEnumerable<Tarefa> GetAll();
    IEnumerable<Tarefa> GetAllByTitulo(string titulo);
    IEnumerable<Tarefa> GetAllByDate(DateTime date);
    IEnumerable<Tarefa> GetAllByStatus(Status status);
    bool Update(int id, TarefaDto dto);
    bool Delete(int id);
}