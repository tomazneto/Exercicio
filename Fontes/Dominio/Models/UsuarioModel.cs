using System;

namespace Dominio.Models
{
    public class UsuarioModel : Usuario
    {
        public string NomeCompleto
        {
            get
            {
                return string.Format("{0} {1}", Nome, Sobrenome);
            }
        }
        public string Nascimento
        {
            get
            {
                return DataNascimento.ToString("dd/MM/yyyy");
            }
        }

        public string CpfFormatado
        {
            get
            {
                return Convert.ToUInt64(Cpf).ToString(@"000\.000\.000\-00");
            }
        }

        private string CepFormatado
        {
            get
            {
                return Convert.ToUInt64(Cep).ToString(@"00000-000");
            }
        }

        public string EnderecoCompleto
        {
            get
            {
                return string.Format("{0}, {1}/{2} - {3}/{4} - {5}", Endereco, Numero, Complemento, Cidade, Estado, CepFormatado);
            }
        }

    }
}
