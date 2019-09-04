USE DB_Cadastro
GO

CREATE TABLE TBConvenio
(
CodDeConvenio			varchar(14) not null,
DocPaciente			    varchar(11) not null, 
ValorTotalConsumido     varchar(20) not null, 
ValorTotalASerPago      varchar(20) not null, 
PRIMARY KEY (CodDeConvenio)
);
GO

CREATE TABLE TBPaciente
(
Cpf						varchar(11) not null,
CodPaciente			    varchar(11) not null,
Nome					varchar(50) not null,
DataDeNascimento	    datetime not null,
Telefone				varchar(20) not null,
Email					varchar(60) not null,
Endereco				varchar(200) not null, 
PRIMARY KEY (Cpf),
FOREIGN KEY (CodPaciente) REFERENCES TBConvenio (CodDeConvenio)
);
GO

CREATE TABLE TBTratamento1
(
CodigoTratamento		varchar(14) not null,
CpfPaciente				varchar(11) not null,
Descricao				varchar(2000) not null, 
Preco					varchar(50) not null,
PRIMARY KEY (CodigoTratamento)
);
GO

CREATE TABLE TBMaterial1
(
CodDeBarras			   varchar(50) not null,
ProcedimentoUsuario	   varchar(14) not null,
DataProcedimento       datetime not null,
DescricaoMedicamento   varchar(50) not null,
DescricaoMaterial      varchar(50) not null, 
QuantidadeMedicamento  int not null, 
QuantidadeMaterial     int not null, 
PrecoMedicamento       float not null, 
PrecoMaterial          float not null,  
PRIMARY KEY (CodDeBarras)
);
GO



CREATE TABLE TBPacienteTratamento
(
Id					INT IDENTITY not null,
CpfPaciente			varchar(11) not null,
CodTratamento		varchar(14) not null,
dataTratamento      datetime not null,
PRIMARY KEY (Id),
FOREIGN KEY(CpfPaciente) REFERENCES TBPaciente (Cpf),
FOREIGN KEY(CodTratamento) REFERENCES TBTratamento1 (CodigoTratamento)
);
GO


CREATE TABLE TBTratamentoMaterial1
(
Id					INT IDENTITY not null,
CodTratamento		varchar(14) not null,
CodMaterial         varchar(50) not null,
DataMaterial        datetime not null,
PRIMARY KEY (Id),
FOREIGN KEY (CodTratamento) REFERENCES TBTratamento1 (CodigoTratamento),
FOREIGN KEY (CodMaterial) REFERENCES TBMaterial1 (CodDeBarras)
);
GO
