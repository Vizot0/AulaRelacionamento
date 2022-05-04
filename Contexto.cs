using AulaRelacionamento.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AulaRelacionamento
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> opt) : base(opt) { }
        public DbSet<Usuario> USUARIOS { get; set; }
        public DbSet<Filme> FILMES { get; set; }
        public DbSet<Usuarios_Filmes> USUARIOS_FILMES { get; set; }
    }
}
