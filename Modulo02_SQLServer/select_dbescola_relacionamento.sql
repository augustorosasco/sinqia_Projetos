-- LISTANDO TODOS OS CURSOS DE TODAS AS ESCOLAS --
USE DB_ESCOLA
SELECT * FROM TBEscolas, TBCursos

--LISTANDO COM RESTRI��ES -- 
SELECT * FROM TBEscolas, TBCursos 
WHERE 
	TBEscolas.ID = TBCursos.IDEscola

--LISTANDO COM RESTRI��ES -- 
SELECT * FROM TBEscolas, TBCursos 
WHERE 
	TBEscolas.ID = TBCursos.IDEscola

-- LISTA COM RELACIONAMENTO PERMITINDO SELE��O DE CAMPOS -- 
-- usando uma varaivel como base de pesquisa -- 

DECLARE @Valor FLOAT;

SET @Valor = 1500;

SELECT
	E.Descricao AS Escola,
	C.Descricao AS Curso,
	E.Endereco AS Endere�o,
	C.Preco AS Pre�o
	FROM TBEscolas E, TBCursos C
WHERE 
	E.Id = C.IdEscola 
	AND C.Preco >= @Valor             


-- CONSULTAS EVOLVENDO AGRUPAMENTOS E FUN��ES DE AGREGA��O --
-- APRESENTAR AS ESCOLAS E A QUANTIDADE DE CURSO POR ESCOLA --
SELECT 
	E.Descricao AS Escola,
	E.Telefone AS Telefone,
	Count (C.Descricao) AS QuantCursos,
	Sum(C.Preco) AS Total 

FROM 
	TBEscolas E, TBCursos C 
WHERE 
	E.ID = C.IDEscola

GROUP BY 
	E.Descricao,
	E.Telefone
