use DB_EVENTOS;
go

-- criando a tabela TBEventos com uma PK autoincremento 
CREATE TABLE TBEventos
(
 Id			 int not null IDENTITY(1,1),
 Descricao	 varchar(100) not null,	
 Responsavel varchar(50) not null,
 Data		 datetime not null,
 Preco		 float not null,
 PRIMARY KEY(Id)
);
go

CREATE TABLE TBConvidados
(
Cpf			varchar(11) not null,
IdEvento	int not null,
nome		varchar(50) not null,
Telefone	varchar(20) not null,
Email		varchar(60) not null,
PRIMARY KEY (Cpf),
FOREIGN KEY (IdEvento) REFERENCES TBEventos(Id)

);
go