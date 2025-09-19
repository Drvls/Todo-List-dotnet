using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using TodoList.Entities;

namespace TodoList.Db;

public class DbContexto(IConfiguration configuration) : DbContext
{
    private readonly IConfiguration _configuration = configuration;

    public DbSet<Tarefa>? Tarefas { set; get; } = default;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            var connectionAddress = _configuration.GetConnectionString("mysql");

            if (!string.IsNullOrEmpty(connectionAddress))
            {
                optionsBuilder.UseMySql(connectionAddress, ServerVersion.AutoDetect(connectionAddress));
            }
        }
    }
}