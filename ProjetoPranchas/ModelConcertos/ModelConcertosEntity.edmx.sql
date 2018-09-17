
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 09/16/2018 21:31:47
-- Generated from EDMX file: C:\Users\sanso\Source\Repos\ProjetoConcertoPranchas\ProjetoPranchas\ModelConcertos\ModelConcertosEntity.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [BDConcertos];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_ClienteOS]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[OSSet] DROP CONSTRAINT [FK_ClienteOS];
GO
IF OBJECT_ID(N'[dbo].[FK_PranchaOS]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[OSSet] DROP CONSTRAINT [FK_PranchaOS];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[ClienteSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ClienteSet];
GO
IF OBJECT_ID(N'[dbo].[OSSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[OSSet];
GO
IF OBJECT_ID(N'[dbo].[PranchaSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PranchaSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'PranchaSet'
CREATE TABLE [dbo].[PranchaSet] (
    [Id_Prancha] int IDENTITY(1,1) NOT NULL,
    [Marca] nvarchar(max)  NOT NULL,
    [Modelo] nvarchar(max)  NOT NULL,
    [Cor] nvarchar(max)  NOT NULL,
    [QtdQuilhas] int  NOT NULL,
    [Medida] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ClienteSet'
CREATE TABLE [dbo].[ClienteSet] (
    [Id_Cliente] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Sobrenome] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [Cpf] nvarchar(max)  NOT NULL,
    [Telefone] nvarchar(max)  NOT NULL,
    [Endereco] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'OSSet'
CREATE TABLE [dbo].[OSSet] (
    [Id_OS] int IDENTITY(1,1) NOT NULL,
    [Descricao] nvarchar(max)  NOT NULL,
    [Valor] decimal(18,0)  NOT NULL,
    [Data_Entrada] datetime  NOT NULL,
    [Data_Saida] datetime  NOT NULL,
    [Status] nvarchar(max)  NOT NULL,
    [Situacao] nvarchar(max)  NOT NULL,
    [ClienteId_Cliente] int  NOT NULL,
    [PranchaId_Prancha] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id_Prancha] in table 'PranchaSet'
ALTER TABLE [dbo].[PranchaSet]
ADD CONSTRAINT [PK_PranchaSet]
    PRIMARY KEY CLUSTERED ([Id_Prancha] ASC);
GO

-- Creating primary key on [Id_Cliente] in table 'ClienteSet'
ALTER TABLE [dbo].[ClienteSet]
ADD CONSTRAINT [PK_ClienteSet]
    PRIMARY KEY CLUSTERED ([Id_Cliente] ASC);
GO

-- Creating primary key on [Id_OS] in table 'OSSet'
ALTER TABLE [dbo].[OSSet]
ADD CONSTRAINT [PK_OSSet]
    PRIMARY KEY CLUSTERED ([Id_OS] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [ClienteId_Cliente] in table 'OSSet'
ALTER TABLE [dbo].[OSSet]
ADD CONSTRAINT [FK_ClienteOS]
    FOREIGN KEY ([ClienteId_Cliente])
    REFERENCES [dbo].[ClienteSet]
        ([Id_Cliente])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClienteOS'
CREATE INDEX [IX_FK_ClienteOS]
ON [dbo].[OSSet]
    ([ClienteId_Cliente]);
GO

-- Creating foreign key on [PranchaId_Prancha] in table 'OSSet'
ALTER TABLE [dbo].[OSSet]
ADD CONSTRAINT [FK_PranchaOS]
    FOREIGN KEY ([PranchaId_Prancha])
    REFERENCES [dbo].[PranchaSet]
        ([Id_Prancha])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PranchaOS'
CREATE INDEX [IX_FK_PranchaOS]
ON [dbo].[OSSet]
    ([PranchaId_Prancha]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------