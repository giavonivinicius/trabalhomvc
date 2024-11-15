Projeto MVC .NET de acesso via login e senha com validação no SQL srver. O script do banco segue abaixo:
________________________________________________________________________________________________________
CREATE DATABASE NP2;
 
USE np2;
 
CREATE TABLE Usuarios(

	Usuario VARCHAR(14) UNIQUE, 

    Senha 	VARCHAR(14) NOT NULL,

    PRIMARY KEY(Usuario)

);
 
CREATE TABLE Endereco(

    IdEndereco 	INT NOT NULL IDENTITY(1, 1),

	Rua    	   	VARCHAR(50) NOT NULL,

    Bairro     	VARCHAR(50) NOT NULL,

    Numero 		INT,

    Complemento VARCHAR(50) NOT NULL,

    PRIMARY KEY(IdEndereco)

);
 
CREATE TABLE Cliente(

	NomeCompleto VARCHAR(50) NOT NULL,

    Documento 	 VARCHAR(20) NOT NULL,

    Telefone 	 VARCHAR(20),

    IdEndereco 	 INT, 	 

    PRIMARY KEY(Documento),

   	FOREIGN KEY(IdEndereco)  REFERENCES Endereco(IdEndereco)

);
 
CREATE TABLE Venda(

	IdVenda 	 		INT 		NOT NULL,

    DocumentoCliente 	VARCHAR(20) NOT NULL,

    FOREIGN KEY(DocumentoCliente) 	REFERENCES Cliente(Documento),

    PRIMARY KEY(IdVenda)

);
 
CREATE TABLE Produto(

	SKU 			  INT 	  	NOT NULL,

    Nome 			  VARCHAR(30) 	NOT NULL,

    QuantidadeEstoque INT,

    PrecoUnitario	  DECIMAL(5,2) 	NOT NULL,

    UnidadeMedida	  VARCHAR(30) 		NOT NULL,

    PRIMARY KEY(SKU)

);
 
CREATE TABLE ProdutoVenda(

	IdVenda    INT		NOT NULL,

    SKU        INT 		NOT NULL,

    Quantidade INT 		NOT NULL,

    FOREIGN KEY(IdVenda) 	REFERENCES Venda(IdVenda),

    FOREIGN KEY(SKU) 		REFERENCES Produto(SKU),

    PRIMARY KEY (IdVenda, SKU)

);
