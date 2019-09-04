USE DB_EVENTOS
GO

--Inserir dados na tabela TB_Eventos (4 eventos)

--OBS: As datas podem ser fornecidas nos formatos:
--MM/dd/yyyy  ou  yyyy-MM-dd

INSERT INTO TBEventos (Descricao, Responsavel, Data, Preco)
VALUES
  ('Palestra Javascript', 'Prof. João', '2019-08-12', 500)

INSERT INTO TBEventos (Descricao, Responsavel, Data, Preco)
VALUES
  ('Palestra C#', 'Prof. Alex', '2019-09-01', 390),
  ('Palestra Meio Ambiente', 'Prof. Maria', '2019-08-10', 0),
  ('Palestra Sinqia', 'Prof. José', '2019-10-25', 700)

  INSERT INTO TBConvidados (CPF, IdEvento, Nome, Telefone, Email)
VALUES
  ('00968180855', 1, 'Samantha', '2461-7981', 'sam@gmail.com'),
  ('00968180854', 3, 'Steve', '2461-7785', 'steve@gmail.com'),
  ('00968180777', 2, 'Thiago', '2669-5912', 'thiago@gmail.com'),
  ('00968180991', 3, 'Mauricio', '2381-9255', 'mauricio@gmail.com'),
  ('00968122102', 4, 'Ethelyn', '2479-6637', 'ethelyn@gmail.com'),
  ('00968179477', 1, 'Pedro', '2479-6666', 'pedro@gmail.com'),
  ('00968857925', 2, 'Beatriz', '2337-1234', 'beatriz@gmail.com'),
  ('00968857924', 4, 'Juliana', '2337-7983', 'Juliana@gmail.com')


--Transferindo daods da tabela TB_EventoBackup para a tabela
--TB_Eventos, mediante consulta

INSERT INTO TBEventos (Descricao, Responsavel, Data, Preco)
SELECT Descricao, Responsavel, Data, Preco FROM TB_EventosBackup

SELECT * FROM TBEventos

--Removendo os elementos adicionados a mais

DELETE FROM TBEventos WHERE Id>= 16

--Selecionar todos os eventos cujo preço esteja 
--entre 500 e 1000 reais

SELECT * FROM TBEventos
WHERE Preco BETWEEN 500 AND 1000

--Selecionar todos os convidados (nome, email)
--que estiverem inscritos em eventos gratis

SELECT 
  Nome AS Convidados,
  Email AS Convidados,
  Descricao AS Eventos
FROM 
  TBConvidados, TBEventos
WHERE
  Id = IdEvento AND Preco = 0


--Apresentar a quantidade de convidados por evento
--(exibir o nome do evento e a quantidade de convidados)

SELECT 
  E.Descricao AS Eventos,
  COUNT (C.CPF) AS Quant_Convidados
FROM
  TBEventos E, TBConvidados C
WHERE
  E.Id = C.IdEvento
GROUP BY
  E.Descricao


--Apresentar o valor arrecadado por evento
--(apresentar o nome do evento e o total pago pelos convidados)

SELECT 
  E.Descricao AS Eventos,
  SUM (E.Preco) AS Valor_Total
FROM
  TBEventos E, TBConvidados C
WHERE
  E.Id = C.IdEvento
GROUP BY
  E.Descricao


