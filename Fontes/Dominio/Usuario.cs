﻿using System;

namespace Dominio
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Cpf { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Cep { get; set; }
        public string Complemento { get; set; }
        public string Endereco { get; set; }
        public DateTime DataNascimento { get; set; }
        public int Numero { get; set; }
    }
}
