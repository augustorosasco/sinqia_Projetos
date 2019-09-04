/*
Trabalhando com colunas simples 
*/

USE DB_ESCOLA
GO

-- LISTANDO TODAS AS ESCOLAS -- 
SELECT * FROM TBEscolas

-- LISTANDO APENAS O NOME E O TELEFONE --
SELECT 
	Descricao AS Descrição, 
	Telefone 
FROM TBEscolas

--	FORMA 2 --
SELECT 
	Descricao AS Descrição, 
	Telefone AS Fone
FROM TBEscolas

--	FORMA 3 --
SELECT 
	Descricao Descrição, 
	Telefone Fone
FROM TBEscolas

-- FORMA 4 --
SELECT
	E.Descricao, E.Endereco
FROM TBEscolas E 

-- FORMA 5 (menos desejavel) --
SELECT 
	TBEscolas.Descricao, TBEscolas.Endereco
FROM TBEscolas 

-------------------- RESTRIÇÕES --------------------

SELECT * FROM TBEscolas WHERE Descricao LIKE 'F%'
SELECT * FROM TBEscolas WHERE Descricao = 'UNA'
SELECT * FROM TBEscolas WHERE ID BETWEEN 2 AND 5 AND Endereco lIKE 'Av%'
