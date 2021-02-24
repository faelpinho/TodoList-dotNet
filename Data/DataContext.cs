//using MySql.Data.EntityFrameworkCore.Design; // usando inmemory ao invés de MySQL
using Microsoft.EntityFrameworkCore;
using TodoList.Models;

namespace TodoList.Data {

    public class DataContext : DbContext {

        public DataContext(DbContextOptions<DataContext> options) : base(options){
        }

        public DbSet<Categoria> Categoria { get; set; }

        public DbSet<Lista> Lista { get; set; }

        public DbSet<Tarefa> Tarefa { get; set; }

        public DbSet<Usuario> Usuario { get; set; }
    }

}
