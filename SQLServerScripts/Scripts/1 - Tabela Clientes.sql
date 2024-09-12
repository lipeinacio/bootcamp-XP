-- Criação da tabela
CREATE TABLE [dbo].[Clientes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](155) NULL,
	[Sobrenome] [varchar](155) NULL,
	[Email] [varchar](155) NULL,
	[AceitaComunicados] [int] NULL,
	[DataCadastro] [datetime2](7) NULL

) ON [PRIMARY]
GO

-- Inserção de dados
INSERT INTO Clientes VALUES ('Ken','Sánchez','email@email.com',0,'Jan  7 2009 11:00AM')
INSERT INTO Clientes VALUES ('Terri','Duffy','email@email.com',1,'Jan 14 2008 11:00AM')
INSERT INTO Clientes VALUES ('Roberto','Tamburello','email@email.com',0,'Nov  4 2007 11:00AM')
INSERT INTO Clientes VALUES ('Rob','Walters','email@email.com',0,'Nov 18 2007 11:00AM')
INSERT INTO Clientes VALUES ('Gail','Erickson','email@email.com',0,'Dec 30 2007 11:00AM')
INSERT INTO Clientes VALUES ('Jossef','Goldberg','email@email.com',0,'Dec 16 2013 11:00AM')
INSERT INTO Clientes VALUES ('Dylan','Miller','email@email.com',1,'Feb  1 2009 11:00AM')
INSERT INTO Clientes VALUES ('Diane','Margheim','email@email.com',0,'Dec 11 2008 11:00AM')
INSERT INTO Clientes VALUES ('Gigi','Matthew','email@email.com',0,'Jan  9 2009 11:00AM')
INSERT INTO Clientes VALUES ('Michael','Raheem','email@email.com',1,'Apr 16 2009 11:00AM')
INSERT INTO Clientes VALUES ('Ovidiu','Cracium','email@email.com',0,'Nov 18 2010 11:00AM')
INSERT INTO Clientes VALUES ('Thierry','DHers','email@email.com',1,'Dec  4 2007 11:00AM')
INSERT INTO Clientes VALUES ('Janice','Galvin','email@email.com',1,'Dec 16 2010 11:00AM')
INSERT INTO Clientes VALUES ('Michael','Sullivan','email@email.com',1,'Dec 13 2010 11:00AM')
