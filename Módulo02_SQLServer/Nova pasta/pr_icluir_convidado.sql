--Criar uma stored procedure capaz de incluir ou alterar um
--convidado. A alteração ocorrerá se o CPF informado
--já estiver vadastrado

USE DB_EVENTOS
GO
ALTER PROC pr_icluir_convidado
(
   @cpf varchar(11),
   @idevento int,
   @nome varchar(50),
   @telefone varchar(20),
   @email varchar(60),
   @status int output   --0 = incluido, 1 = alterado
)
AS
BEGIN
   IF EXISTS(SELECT CPF from TBConvidados WHERE CPF = @cpf)
       BEGIN
	        UPDATE TBConvidados SET IdEvento = @idevento, Nome = @nome, 
			Telefone = @telefone, Email = @email WHERE CPF = @cpf

			set @status = 1
	   END
   ELSE
       BEGIN
	        INSERT INTO TBConvidados (CPF, IdEvento, Nome, Email, Telefone)
			VALUES (@cpf, @idevento, @nome, @email, @telefone)

			set @status = 0
       END
END