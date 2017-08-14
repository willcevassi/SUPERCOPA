
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 08/13/2017 21:19:06
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [DB_SUPERCOPA];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Agentes'
CREATE TABLE [dbo].[Agentes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(100)  NOT NULL,
    [Endereco] nvarchar(255)  NULL,
    [Telefone] nvarchar(25)  NULL
);
GO

-- Creating table 'Equipes'
CREATE TABLE [dbo].[Equipes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(100)  NOT NULL,
    [TreinadorId] int  NULL
);
GO

-- Creating table 'Treinadores'
CREATE TABLE [dbo].[Treinadores] (
    [Id] int  NOT NULL,
	[FormacaoFormal] bit null
);
GO

-- Creating table 'Jogadores'
CREATE TABLE [dbo].[Jogadores] (
    [PosicaoPrincipal] varchar(50) NULL,
    [Id] int  NOT NULL,
    [Equipe_Id] int  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Agentes'
ALTER TABLE [dbo].[Agentes]
ADD CONSTRAINT [PK_Agentes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Equipes'
ALTER TABLE [dbo].[Equipes]
ADD CONSTRAINT [PK_Equipes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Treinadores'
ALTER TABLE [dbo].[Treinadores]
ADD CONSTRAINT [PK_AgenteSet_Treinador]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Jogadores'
ALTER TABLE [dbo].[Jogadores]
ADD CONSTRAINT [PK_Jogadores]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [TreinadorId] in table 'Equipes'
ALTER TABLE [dbo].[Equipes]
ADD CONSTRAINT [FK_TreinadorEquipe]
    FOREIGN KEY ([TreinadorId])
    REFERENCES [dbo].[Treinadores] ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TreinadorEquipe'
CREATE INDEX [IX_FK_TreinadorEquipe]
ON [dbo].[Equipes]
    ([TreinadorId]);
GO

-- Creating foreign key on [Equipe_Id] in table 'Jogadores'
ALTER TABLE [dbo].[Jogadores]
ADD CONSTRAINT [FK_EquipeDoJogador]
    FOREIGN KEY ([Equipe_Id])
    REFERENCES [dbo].[Equipes] ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_JogadorEquipe'
CREATE INDEX [IX_FK_EquipeDoJogador]
ON [dbo].[Jogadores]
    ([Equipe_Id]);
GO

-- Creating foreign key on [Id] in table 'Treinadores'
ALTER TABLE [dbo].[Treinadores]
ADD CONSTRAINT [FK_Treinador_inherits_Agente]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[Agentes]([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'Jogadores'
ALTER TABLE [dbo].[Jogadores]
ADD CONSTRAINT [FK_Jogador_inherits_Agente]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[Agentes]([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------