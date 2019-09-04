USE DB_CLINICA

CREATE TABLE TB_Convenios
(
   Id int Primary Key Identity (1,1),
   Nome Varchar(20) not null,
   CNPJ Varchar(14) not null,
   Endereco Varchar(100) not null,
   Email Varchar(30) not null,
   Telefone Varchar(10) not null,
)

CREATE TABLE TB_Pacientes
(
   
   Id int Primary Key Identity (1,1),
   Id_Convenio int not null,
   Documento Varchar(11) not null,
   Nome_Paciente Varchar (60) not null,
   Endereco_Paciente Varchar(100) not null,
   Telefone_Paciente Varchar(10) not null,
   Email_Paciente Varchar(50) not null,
   Data_Entrada Datetime not null,
   FOREIGN KEY (Id_Convenio) REFERENCES TB_Convenios(Id),
)
GO

CREATE TABLE TB_Categorias
(
   Id int Primary Key Identity (1,1),
   Descricao Varchar(60) not null,
)


CREATE TABLE TB_Materiais_e_Medicamentos
(
   Id int Primary Key Identity (1,1),
   Id_Categoria int not null,
   Descricao Varchar(60) not null,
   Unidade Varchar(10) not null,
   Preco money not null,
   FOREIGN KEY (Id_Categoria) REFERENCES TB_Categorias(Id),
)


CREATE TABLE TB_Procedimentos
(
   Id int Primary Key Identity (1,1),
   Id_Paciente int not null,
   Id_Materiais_e_Medicamentos int not null,
   Descricao Varchar (100) not null,
   Preco money not null,
   Duracao_Inicio Datetime not null,
   Duracao_Fim Datetime not null,
   FOREIGN KEY (Id_Paciente) REFERENCES TB_Pacientes(Id),
   FOREIGN KEY (Id_Materiais_e_Medicamentos) REFERENCES TB_Materiais_e_Medicamentos(Id),

)

CREATE TABLE TB_Itens_Utilizados
(
   Id int Primary Key Identity (1,1),
   Id_Procedimento int not null,
   Id_Unidade int not null,
   FOREIGN KEY (Id_Unidade) REFERENCES TB_Procedimentos(Id),
)