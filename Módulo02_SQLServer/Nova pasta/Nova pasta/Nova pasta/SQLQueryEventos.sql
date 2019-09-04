CREATE DATABASE DB_EVENTOS

USE DB_EVENTOS

CREATE TABLE TBEventos(
	Id          int not null primary key IDENTITY(1,1),
	Descricao   varchar(100) not null,
	responsavel varchar(50) not null,
	Data        datetime not null,
	Preco       float not null 
)
GO

CREATE TABLE TBConvidados(
	CPF         varchar(11) not null primary key,
	IdEvento    int not null,	
	Nome        varchar(50) not null,
	Telefone    varchar(20) not null,
	email       varchar(60) not null,
	FOREIGN KEY (IdEvento)  references TBEventos(Id)
)
GO
