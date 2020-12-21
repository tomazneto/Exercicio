--necessário criar a instancia do banco com o nome (atividade)

CREATE TABLE usuarios (
    Id INT PRIMARY KEY IDENTITY (1, 1),
    Nome VARCHAR (100) NOT NULL,
	Sobrenome VARCHAR (100) NOT NULL,
	Cpf VARCHAR (11) NOT NULL,
	Cidade VARCHAR (100) NOT NULL,
	Estado VARCHAR (100) NOT NULL,
	Cep VARCHAR (10) NOT NULL,
	Complemento VARCHAR (100) NOT NULL,
	Endereco VARCHAR (100) NOT NULL,
    DataNascimento DATETIME,
    Numero int NOT NULL
);

insert into usuarios values ('Teste', 'Da Silva', '99999999999', 'Salvador', 'Bahia', '40000000', 'Quada 09', 'Rua da Macedônia', GETDATE(), 11)