--Listando todas as escolas

SELECT * FROM TB_Escolas


--Listando apenas nome e telefone

1� forma:

SELECT Descricao AS Descri��o
       Telefone AS Fone

FROM TB_Escolas


2� forma:

SELECT E.Descricao

FROM TB_Escolas E


--a letra E � apenas um apelido para a tabela e facilita a manuten��o



--RESTRI��ES


SELECT * FROM TB_Escolas WHERE Descricao LIKE 'F%'
SELECT * FROM TB_Escolas WHERE Descricao = 'UNA'
SELECT * FROM TB_Escolas WHERE 
    Id BETWEEN 2 AND 5 
	AND Endereco LIKE 'Av%'
