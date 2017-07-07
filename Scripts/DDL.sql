
Create DAtabase TesteDB;
GO

use TesteDB

Create table Contato
(
	ContatoID int identity(1,1) primary key,
	Nome varchar(300) not null,
	SobreNome varchar(300) not null,
	Telefone varchar(20) not null,
	Ativo bit not null
)