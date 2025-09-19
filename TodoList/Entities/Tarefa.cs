using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TodoList.Enuns;

namespace TodoList.Entities;

public class Tarefa
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    [Required]
    [MaxLength(50)]
    public string Titulo { get; set; }
    
    [MaxLength(200)]
    public string Descricao { get; set; }
    
    [Required]
    public DateTime Data { get; set; }

    [Required] 
    [MaxLength(10)]
    public string Status { get; set; }
}