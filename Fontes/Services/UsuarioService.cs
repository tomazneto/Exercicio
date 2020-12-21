using Data;
using Dominio;
using Dominio.Models;
using Services.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Services
{
    public class UsuarioService : IUsuarioService
    {
        private Contexto _con;

        public UsuarioService(Contexto con)
        {
            _con = con;
        }

        public void Inserir(Usuario entity)
        {
            _con.Usuarios.Add(entity);
            _con.SaveChanges();
        }

        public List<UsuarioModel> ObterTodos()
        {
            var consulta = (from u in _con.Usuarios
                            select new UsuarioModel
                            {
                                Nome = u.Nome,
                                Endereco = u.Endereco,
                                Cpf = u.Cpf,
                                Cep = u.Cep,
                                Cidade = u.Cidade,
                                Complemento = u.Complemento,
                                DataNascimento = u.DataNascimento,
                                Estado = u.Estado,
                                Numero = u.Numero,
                                Sobrenome = u.Sobrenome
                            }).ToList();

            return consulta;
        }
    }
}
