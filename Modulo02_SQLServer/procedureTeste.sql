/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP 1000 [Cpf]
      ,[IdEvento]
      ,[nome]
      ,[Telefone]
      ,[Email]
  FROM [DB_EVENTOS].[dbo].[TBConvidados]

  exec pr_incluir_convidado '23482682921', 3, 'fabiana', '11-3348-1288', 'fabiana345a37@Hotmail.com'