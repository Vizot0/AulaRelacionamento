using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AulaRelacionamento.Entidades
{
    public class Usuarios_Filmes
    {
        public int Id { get; set; }

        public int UsuarioId { get; set; }

        public int FilmeId { get; set; }

        public Filme filme { get; set; }

        public Usuario usuarios{ get; set; }
    }
}
