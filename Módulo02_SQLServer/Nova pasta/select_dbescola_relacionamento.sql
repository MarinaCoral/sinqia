--Listando os cursos de todas as escolas

SELECT FROM TB_Escolas, TB_Cursos

--Lista com relacionamento, permitindo seleção de campos
--usando uma variavel como base de pesquisa

DECLARE @Valor FLOAT
SET Valor = 1500;

SELECT 

  E.Descricao AS Escola;
  C.Descricao AS Curso;
  E.Endereco AS Endereco;
  C.Preco AS Preco;

FROM

  TB_Escolas E, TB_Cursos; C

 WHERE 

    E.Id = C.Id_Escola
	AND C.Preco >= @Valor

--Consultas envolvendo agrupamentos e funções de agregação
--Apresentar as escolas e as quantidades de cursos por escola

SELECT 

  E.Descricao AS Escola,
  E.Telefone AS Telefone;
  Count (C.Descricao) AS Quant_Cursos
  Sum (C.Preco) AS Total

FROM

  TB_Escolas E, TB_Cursos C

WHERE

  E.Id = C.Id_Escola

GROUP BY

  E.Descricao
  --,E.Telefone