use DB_ESCOLA

CREATE TABLE TB_Escolas
(
   Id int Primary key identity,
   Descricao varchar (50),
   Endereco varchar (50),
   Telefone varchar (50),
)

CREATE TABLE TB_Cursos
(
   Id int Primary key identity,
   Descricao varchar (50),
   Carga_Horaria int,
   Preco float,
)