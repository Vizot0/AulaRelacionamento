using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AulaRelacionamento.Models
{
    public class MeusFavoritosModel
    {
        public int UsuarioId { get; set; }
        public List<Entidades.Filme> todosFilmes { get; set; }


        public List<Entidades.Usuarios_Filmes> favoritos { get; set; }
    }
}
