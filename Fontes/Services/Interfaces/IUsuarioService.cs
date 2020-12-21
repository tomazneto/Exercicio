using Dominio;
using Dominio.Models;
using System.Collections.Generic;

namespace Services.Interfaces
{
    public interface IUsuarioService : IServiceBase<Usuario>
    {
        List<UsuarioModel> ObterTodos();
    }
}
