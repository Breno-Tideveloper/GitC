CREATE TABLE [dbo].[Livro]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [Registro] INT NOT NULL, 
    [Tittulo] VARCHAR(1200) NOT NULL, 
    [Isbn] VARCHAR(15) NOT NULL, 
    [Genero] INT NOT NULL, 
    [Editora] INT NOT NULL, 
    [sinopse] NVARCHAR(MAX) NOT NULL, 
    [Observacoes] VARCHAR(1000) NOT NULL, 
	Ativo BIT NOT NULL, 
    [UsuInc] INT NOT NULL, 
    [UsuAlt] INT NOT NULL, 
    [DatInc] DATETIME NOT NULL, 
    [DatAlt] DATETIME NOT NULL DEFAULT GETDATE(),
    CONSTRAINT [FK_Livro_to_genero] FOREIGN KEY ([Genero]) REFERENCES [Generos]([ID]), 
    CONSTRAINT [FK_Livro_To_Editoras] FOREIGN KEY ([Editora]) REFERENCES [Editoras]([id]), 
    CONSTRAINT [FK_Livro_To_usuariosInc] FOREIGN KEY ([Usuinc]) REFERENCES [usuarios]([id]), 
    CONSTRAINT [FK_Livro_To_usuariosalt] FOREIGN KEY ([usualt]) REFERENCES [usuarios]([id])
)
