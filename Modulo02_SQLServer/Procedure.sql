USE DB_EVENTOS
GO

-- CRIAR UMA STORED PROCEDURE CAPAZ DE INCLUIR OU ALTERAR UM CONVIDADO. A ALTERAÇÃO OCORRERÁ SE O CPF JÁ ESTIVER CADASTRADO 

ALTER PROCEDURE pr_incluir_convidado
(
	@cpf varchar(11),
	@idevento int,
	@nome varchar(50),
	@telefone varchar(20),
	@email varchar(60),
	@status int output --0: incluido, 1: alterado
)
AS 
BEGIN
	IF EXISTS(SELECT Cpf FROM TBConvidados WHERE Cpf = @cpf)
		BEGIN
			UPDATE TBConvidados SET IdEvento = @idevento, nOME= @nome, Telefone=@telefone, Email=@email 
			WHERE Cpf=@cpf
			
			set @status = 1                         
		END
	
	ELSE
		BEGIN 
			INSERT INTO TBConvidados(Cpf, IdEvento, nome, Email, Telefone)
			VALUES (@cpf, @idevento, @nome, @email, @telefone)

			set @status = 0
		END
	
END