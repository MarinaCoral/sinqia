USE DB_VENDAS;
GO

CREATE TABLE TB_CLIENTES
(
   Documento Varchar(14) Primary Key,
   Nome	Varchar(60) not null,
   Telefone	Varchar(20) not null,
   Email Varchar not null,
);
GO

CREATE TABLE TB_PEDIDOS
(
   Id int Primary Key Identity (1,1),
   Doc_Cliente Varchar(14) not null,
   Data datetime not null,
   Numero_Pedido Varchar(20) not null,

	  
   FOREIGN KEY (Doc_Cliente) REFERENCES TB_CLIENTES(Documento),
);
GO 

CREATE TABLE TB_CATEGORIAS

(
   Id int Primary Key Identity (1,1),
   Descicao Varchar(20) not null,
)

GO

CREATE TABLE TB_PRODUTOS
(
   Id int Primary Key Identity (1,1),
   Id_Categoria int not null,
   Descricao Varchar(50) not null,
   Unidade Varchar(10) not null,
   Foto Varbinary(MAX) not null,
   Mime_Type Varchar(20) not null,
   FOREIGN KEY (Id_Categoria) REFERENCES TB_CATEGORIAS (Id),
)
GO

CREATE TABLE TB_ITENS
(
   Id int Primary Key Identity (1,1),
   Id_Pedido int not null,
   Id_Produto int not null,
   Qualidade float not null,
   FOREIGN KEY (Id_Pedido) REFERENCES TB_PEDIDOS(Id),
   FOREIGN KEY (Id_Produto) REFERENCES TB_PRODUTOS (Id),
)
GO