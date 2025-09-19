using System;
using TodoList.Enuns;

namespace TodoList.DTO;

public class TarefaDto
{
    public string Titulo { get; set; }
    public string Descricao { get; set; }
    public DateTime Data { get; set; } 
    public Status Status { get; set; } 
}