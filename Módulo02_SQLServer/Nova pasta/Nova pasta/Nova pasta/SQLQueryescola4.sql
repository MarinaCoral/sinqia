--Listando todas as escolas

SELECT * FROM TB_Escolas


--Listando apenas nome e telefone

1° forma:

SELECT Descricao AS Descrição
       Telefone AS Fone

FROM TB_Escolas


2° forma:

SELECT E.Descricao

FROM TB_Escolas E


--a letra E é apenas um apelido para a tabela e facilita a manutenção



--RESTRIÇÕES


SELECT * FROM TB_Escolas WHERE Descricao LIKE 'F%'
SELECT * FROM TB_Escolas WHERE Descricao = 'UNA'
SELECT * FROM TB_Escolas WHERE 
    Id BETWEEN 2 AND 5 
	AND Endereco LIKE 'Av%'
