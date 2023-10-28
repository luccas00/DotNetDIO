--select Id, Nome, Sobrenome, Email from Clientes
--where Nome like '%Lu%'
--order by Nome, Email

--insert into Clientes values('Gandalf', 'The Gray', 'gandalf@middleearth.eru', 1, GETDATE())
--insert into Clientes values('Saruman', 'The White', 'saruman@middleearth.eru', 1, GETDATE())
--insert into Clientes values('Mithrandir', '', 'gandalf@middleearth.eru', 1, GETDATE())
--insert into Clientes values('Galadriel', 'Lady Of Lorien', 'galadriel@valinor.eru', 1, GETDATE())
--insert into Clientes values('Elrond', '', 'elrond@imladris.eru', 0, GETDATE())
--insert into Clientes values('Aragorn', 'Elessar', 'elendil@dunedain.eru', 1, GETDATE())
--insert into Clientes values('Legolas', '', 'legolas@mirkwood.middleearth.eru', 1, GETDATE())
--insert into Clientes values('Samwise', 'Gamgee', 'sam@shire.middleearth.eru', 1, GETDATE())
--insert into Clientes values('Meriadoc', 'Brandebuque', 'merry@shire.middleearth.eru', 1, GETDATE())
--insert into Clientes values('Peregrin', 'Took', 'pipin@shire.middleearth.eru', 1, GETDATE())

--INSERT INTO Clientes VALUES ('Bob','Black','email@email.com',0,GETDATE())
--INSERT INTO Clientes VALUES ('Terri','Jones','email@email.com',1,GETDATE())
--INSERT INTO Clientes VALUES ('Nikolar','Joam','email@email.com',0,GETDATE())
--INSERT INTO Clientes VALUES ('Walters', 'Dante','email@email.com',0,GETDATE())
--INSERT INTO Clientes VALUES ('Abigail','Walker','email@email.com',0,GETDATE())
--INSERT INTO Clientes VALUES ('Joss','Goerg','email@email.com',0,GETDATE())
--INSERT INTO Clientes VALUES ('Ian','Nilker','email@email.com',2,GETDATE())
--INSERT INTO Clientes VALUES ('Karen','Lattheim','email@email.com',0,GETDATE())
--INSERT INTO Clientes VALUES ('Hanso','Hasse','email@email.com',0,GETDATE())
--INSERT INTO Clientes VALUES ('Jokans','Kroas','email@email.com',2,GETDATE())
--INSERT INTO Clientes VALUES ('Yawrs','Caas','email@email.com',0,GETDATE())

--insert into Clientes values ('Kronos','','',1, GETDATE())

--select * from Clientes
--where Nome like '%L%'

--update Clientes
--set Email = 'meuNovoEmail@gmail.com',
--	AceitaComunicados = 1,
--	DataCadastro = GETDATE()
--where Nome like '%L%'

--begin tran
--rollback

--delete Clientes
--where Id = 3



--select * from Clientes
--order by Nome


--update Clientes
--set Email = 'email',
--	AceitaComunicados = 0,
--	Sobrenome = 'Sobrenome'

--select * from Clientes


--CREATE TABLE Enderecos (
--	Id int PRIMARY KEY IDENTITY(1,1) NOT NULL,
--	IdCliente int NULL,
--	Rua varchar(255) NULL,
--	Bairro varchar(255) NULL,
--	Cidade varchar(255) NULL,
--	Estado varchar(2)null,

--	CONSTRAINT FK_Enderecos_Clientes FOREIGN KEY (IdCliente)
--	REFERENCES Clientes(Id)

--)

--Select * from Clientes
--Select * from Enderecos

--INSERT INTO Enderecos VALUES (36, 'Rua 1', 'Bairo 2', 'Cidade', 'AA')


--SELECT COUNT (*) Number FROM Produtos WHERE Tamanho = 'M'

--SELECT SUM(Preco) FROM Produtos WHERE Tamanho = 'M'

--SELECT MAX(Preco) FROM Produtos

--SELECT MIN(Preco) FROM Produtos

--SELECT AVG(Preco) FROM Produtos

--SELECT * FROM Produtos
--WHERE Preco = (SELECT MIN(Preco) FROM Produtos)

--SELECT UPPER(Nome) FROM Produtos
--SELECT LOWER(Nome) FROM Produtos

--SELECT *,
--	FORMAT(DataVencimento, 'dd/MM/yyyy hh:MM') AS FormattedDataVencimento,
--	FORMAT([Data Cadastro], 'dd/MM/yyyy') AS FormattedDataVencimento
--FROM Produtos;

--ALTER TABLE Produtos
--ADD DataVencimento DATETIME2

--UPDATE Produtos
--SET [Data Cadastro] = GETDATE(),
--DataVencimento = GETDATE()

--SELECT
--	Tamanho,
--	COUNT(*) Quantidade
--FROM Produtos
--WHERE Tamanho <> ''
--GROUP BY Tamanho
--ORDER BY Quantidade DESC

--CREATE TABLE Aluno (
--	Id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
--	Nome VARCHAR(255) NOT NULL,
--	Cpf varchar(15) NOT NULL,
--	Nota1 decimal (2,2),
--	Nota2 decimal (2,2),
--	Nota3 decimal (2,2),
--	Turma char (1) NOT NULL
--)

--SELECT * FROM Aluno

--select
--	Clientes.Nome,
--	Clientes.Sobrenome,
--	Clientes.Email,
--	Enderecos.Rua,
--	Enderecos.Cidade
--from Clientes
--inner join Enderecos on Clientes.Id = Enderecos.IdCliente
--where Clientes.Id = 36


--Select * from Clientes
--Select * from Enderecos

--INSERT INTO Enderecos VALUES (36, 'Rua 1', 'Bairo 2', 'Cidade', 'AA')

--INSERT INTO Enderecos VALUES (39, 'Rua 2', 'Bairo 22', 'CidadeA', 'BA')