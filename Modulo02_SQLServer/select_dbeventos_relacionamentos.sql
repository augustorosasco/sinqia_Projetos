USE DB_EVENTOS
GO

--INSERIR DADOS NA TABELA EVENTOS--
-- As datas podem ser fornecidas nos formatos: mês/dia/ano ou ano/mes/dia -- 
INSERT INTO TBEventos(Descricao, Responsavel, Data, Preco, Id)
VALUES 
('Palestra JavaScript', 'Prof. Joao', '08/12/2019', 500, 1),
('Palestra .Net', 'Prof Rosangela', '08/13/2019', 600, 2),
('Palestra Java', 'Prof Ricardo', '08/14/2019', 450, 3),
('Curso Big Data', 'Prof Fabio', '08/15/2019', 1000, 4)

INSERT INTO TBConvidados (Cpf, IdEvento, Nome, Telefone, Email)
VALUES 
('43782682921', 1, 'Ana', '11-3252-9812', 'ana23465@gmail.com'),
('23787392921', 2, 'Renato', '11-3467-9364', 'Renato24523@gmail.com'),
('98782682923', 4,'Juliano', '11-3278-1288', 'Juliano345457@Hotmail.com'),
('23482682921', 3,'fabiana', '11-3348-1288', 'fabiana345a37@Hotmail.com'),
('43782423292', 1,'Julio', '11-3234-1288', 'Julio234214@Hotmail.com'),
('43234568292', 4,'Adriano', '11-2348-1288', 'Adriano345457@Hotmail.com'),
('53452368291', 1,'Enzo', '11-2348-3288', 'Enzo36757@Hotmail.com'),
('34254435921', 2,'Cintia', '11-8674-1338', 'Enzo36757@Hotmail.com')

-- Tranferindo dados da tabela TBEventosBackup para a tabela --
-- TBEventos, mediante consulta -- 
INSERT INTO TBEventos(Descricao, Responsavel, Data, Preco)
SELECT Descricao, Resposavel, Data, Preco FROM TBEventosBackup

SELECT * FROM TBEventos

-- REMOVENDO OS ELEMENTOS ADICIONADOS A MAIS --
DELETE FROM TBEventos 
WHERE Id >= 11 
