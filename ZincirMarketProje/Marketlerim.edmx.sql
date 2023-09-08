
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 08/19/2023 11:09:53
-- Generated from EDMX file: C:\Users\Acer\Desktop\C# Kurs projeleri\ZincirMarketProje\ZincirMarketProje\Marketlerim.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Marketlerim];
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

-- Creating table 'PersonellerSet'
CREATE TABLE [dbo].[PersonellerSet] (
    [personelId] int IDENTITY(1,1) NOT NULL,
    [AdSoyad] nvarchar(max)  NOT NULL,
    [Sehir] nvarchar(max)  NOT NULL,
    [Maas] int  NOT NULL,
    [iseGirisTarihi] datetime  NOT NULL,
    [MagazaId] int  NOT NULL
);
GO

-- Creating table 'MagazalarSet'
CREATE TABLE [dbo].[MagazalarSet] (
    [MagazaId] int IDENTITY(1,1) NOT NULL,
    [Sehir] nvarchar(max)  NOT NULL,
    [Telefon] nvarchar(max)  NOT NULL,
    [Ulke] nvarchar(max)  NOT NULL,
    [AracPlaka] int  NOT NULL
);
GO

-- Creating table 'SevkiyatSet'
CREATE TABLE [dbo].[SevkiyatSet] (
    [AracPlaka] int IDENTITY(1,1) NOT NULL,
    [SürücüAdSoyad] int  NOT NULL,
    [Telefon] nvarchar(max)  NOT NULL,
    [Maas] int  NOT NULL,
    [Vardiya] nvarchar(max)  NOT NULL,
    [DepoId] int  NOT NULL
);
GO

-- Creating table 'DepolarSet'
CREATE TABLE [dbo].[DepolarSet] (
    [DepoId] int IDENTITY(1,1) NOT NULL,
    [ürünIsimleri] nvarchar(max)  NOT NULL,
    [DepoSorumlusu] nvarchar(max)  NOT NULL,
    [ürünId] int  NOT NULL
);
GO

-- Creating table 'UrünlerSet'
CREATE TABLE [dbo].[UrünlerSet] (
    [ürünId] int IDENTITY(1,1) NOT NULL,
    [ürünCinsi] nvarchar(max)  NOT NULL,
    [ürünFiyati] int  NOT NULL,
    [müsteriId] int  NOT NULL
);
GO

-- Creating table 'MüsteriSet'
CREATE TABLE [dbo].[MüsteriSet] (
    [müsteriId] int IDENTITY(1,1) NOT NULL,
    [AdSoyad] nvarchar(max)  NOT NULL,
    [Telefon] nvarchar(max)  NOT NULL,
    [Sehir] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [personelId] in table 'PersonellerSet'
ALTER TABLE [dbo].[PersonellerSet]
ADD CONSTRAINT [PK_PersonellerSet]
    PRIMARY KEY CLUSTERED ([personelId] ASC);
GO

-- Creating primary key on [MagazaId] in table 'MagazalarSet'
ALTER TABLE [dbo].[MagazalarSet]
ADD CONSTRAINT [PK_MagazalarSet]
    PRIMARY KEY CLUSTERED ([MagazaId] ASC);
GO

-- Creating primary key on [AracPlaka] in table 'SevkiyatSet'
ALTER TABLE [dbo].[SevkiyatSet]
ADD CONSTRAINT [PK_SevkiyatSet]
    PRIMARY KEY CLUSTERED ([AracPlaka] ASC);
GO

-- Creating primary key on [DepoId] in table 'DepolarSet'
ALTER TABLE [dbo].[DepolarSet]
ADD CONSTRAINT [PK_DepolarSet]
    PRIMARY KEY CLUSTERED ([DepoId] ASC);
GO

-- Creating primary key on [ürünId] in table 'UrünlerSet'
ALTER TABLE [dbo].[UrünlerSet]
ADD CONSTRAINT [PK_UrünlerSet]
    PRIMARY KEY CLUSTERED ([ürünId] ASC);
GO

-- Creating primary key on [müsteriId] in table 'MüsteriSet'
ALTER TABLE [dbo].[MüsteriSet]
ADD CONSTRAINT [PK_MüsteriSet]
    PRIMARY KEY CLUSTERED ([müsteriId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [MagazaId] in table 'PersonellerSet'
ALTER TABLE [dbo].[PersonellerSet]
ADD CONSTRAINT [FK_MagazalarPersoneller]
    FOREIGN KEY ([MagazaId])
    REFERENCES [dbo].[MagazalarSet]
        ([MagazaId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MagazalarPersoneller'
CREATE INDEX [IX_FK_MagazalarPersoneller]
ON [dbo].[PersonellerSet]
    ([MagazaId]);
GO

-- Creating foreign key on [AracPlaka] in table 'MagazalarSet'
ALTER TABLE [dbo].[MagazalarSet]
ADD CONSTRAINT [FK_SevkiyatMagazalar]
    FOREIGN KEY ([AracPlaka])
    REFERENCES [dbo].[SevkiyatSet]
        ([AracPlaka])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SevkiyatMagazalar'
CREATE INDEX [IX_FK_SevkiyatMagazalar]
ON [dbo].[MagazalarSet]
    ([AracPlaka]);
GO

-- Creating foreign key on [DepoId] in table 'SevkiyatSet'
ALTER TABLE [dbo].[SevkiyatSet]
ADD CONSTRAINT [FK_DepolarSevkiyat]
    FOREIGN KEY ([DepoId])
    REFERENCES [dbo].[DepolarSet]
        ([DepoId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DepolarSevkiyat'
CREATE INDEX [IX_FK_DepolarSevkiyat]
ON [dbo].[SevkiyatSet]
    ([DepoId]);
GO

-- Creating foreign key on [ürünId] in table 'DepolarSet'
ALTER TABLE [dbo].[DepolarSet]
ADD CONSTRAINT [FK_UrünlerDepolar]
    FOREIGN KEY ([ürünId])
    REFERENCES [dbo].[UrünlerSet]
        ([ürünId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UrünlerDepolar'
CREATE INDEX [IX_FK_UrünlerDepolar]
ON [dbo].[DepolarSet]
    ([ürünId]);
GO

-- Creating foreign key on [müsteriId] in table 'UrünlerSet'
ALTER TABLE [dbo].[UrünlerSet]
ADD CONSTRAINT [FK_MüsteriUrünler]
    FOREIGN KEY ([müsteriId])
    REFERENCES [dbo].[MüsteriSet]
        ([müsteriId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MüsteriUrünler'
CREATE INDEX [IX_FK_MüsteriUrünler]
ON [dbo].[UrünlerSet]
    ([müsteriId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------