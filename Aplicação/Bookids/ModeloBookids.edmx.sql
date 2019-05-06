
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/29/2019 14:30:03
-- Generated from EDMX file: C:\Users\Fernando Correia\source\repos\Bookids\Bookids\ModeloBookids.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [BDBookids];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_InscricoesFilhos]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[InscricoesSet] DROP CONSTRAINT [FK_InscricoesFilhos];
GO
IF OBJECT_ID(N'[dbo].[FK_InscricoesEventos]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[InscricoesSet] DROP CONSTRAINT [FK_InscricoesEventos];
GO
IF OBJECT_ID(N'[dbo].[FK_ColaboracoesAnimadores]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ColaboracoesSet] DROP CONSTRAINT [FK_ColaboracoesAnimadores];
GO
IF OBJECT_ID(N'[dbo].[FK_ParticipacoesEventos]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ParticipacoesSet] DROP CONSTRAINT [FK_ParticipacoesEventos];
GO
IF OBJECT_ID(N'[dbo].[FK_FilhosEscolas]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PessoasSet_Filhos] DROP CONSTRAINT [FK_FilhosEscolas];
GO
IF OBJECT_ID(N'[dbo].[FK_ClientesCompras]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ComprasSet] DROP CONSTRAINT [FK_ClientesCompras];
GO
IF OBJECT_ID(N'[dbo].[FK_DetalheComprasProdutos]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DetalheComprasSet] DROP CONSTRAINT [FK_DetalheComprasProdutos];
GO
IF OBJECT_ID(N'[dbo].[FK_ComprasDetalheCompras]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DetalheComprasSet] DROP CONSTRAINT [FK_ComprasDetalheCompras];
GO
IF OBJECT_ID(N'[dbo].[FK_ColaboracoesEventos]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ColaboracoesSet] DROP CONSTRAINT [FK_ColaboracoesEventos];
GO
IF OBJECT_ID(N'[dbo].[FK_EscolasParticipacoes]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ParticipacoesSet] DROP CONSTRAINT [FK_EscolasParticipacoes];
GO
IF OBJECT_ID(N'[dbo].[FK_ProdutosTipoProduto]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProdutosSet] DROP CONSTRAINT [FK_ProdutosTipoProduto];
GO
IF OBJECT_ID(N'[dbo].[FK_ProdutosSet_ProdutosSet]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProdutosSet] DROP CONSTRAINT [FK_ProdutosSet_ProdutosSet];
GO
IF OBJECT_ID(N'[dbo].[FK_Filhos_inherits_Pessoas]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PessoasSet_Filhos] DROP CONSTRAINT [FK_Filhos_inherits_Pessoas];
GO
IF OBJECT_ID(N'[dbo].[FK_Animadores_inherits_Pessoas]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PessoasSet_Animadores] DROP CONSTRAINT [FK_Animadores_inherits_Pessoas];
GO
IF OBJECT_ID(N'[dbo].[FK_Clientes_inherits_Pessoas]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PessoasSet_Clientes] DROP CONSTRAINT [FK_Clientes_inherits_Pessoas];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[PessoasSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PessoasSet];
GO
IF OBJECT_ID(N'[dbo].[InscricoesSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[InscricoesSet];
GO
IF OBJECT_ID(N'[dbo].[EventosSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EventosSet];
GO
IF OBJECT_ID(N'[dbo].[ColaboracoesSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ColaboracoesSet];
GO
IF OBJECT_ID(N'[dbo].[ParticipacoesSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ParticipacoesSet];
GO
IF OBJECT_ID(N'[dbo].[EscolasSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EscolasSet];
GO
IF OBJECT_ID(N'[dbo].[ComprasSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ComprasSet];
GO
IF OBJECT_ID(N'[dbo].[DetalheComprasSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DetalheComprasSet];
GO
IF OBJECT_ID(N'[dbo].[ProdutosSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ProdutosSet];
GO
IF OBJECT_ID(N'[dbo].[TipoProdutoSet1]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TipoProdutoSet1];
GO
IF OBJECT_ID(N'[dbo].[PessoasSet_Filhos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PessoasSet_Filhos];
GO
IF OBJECT_ID(N'[dbo].[PessoasSet_Animadores]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PessoasSet_Animadores];
GO
IF OBJECT_ID(N'[dbo].[PessoasSet_Clientes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PessoasSet_Clientes];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'PessoasSet'
CREATE TABLE [dbo].[PessoasSet] (
    [IdPessoa] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Morada] nvarchar(max)  NOT NULL,
    [Localidade] nvarchar(max)  NOT NULL,
    [CodPostal] nvarchar(max)  NOT NULL,
    [Telefone] nvarchar(max)  NOT NULL,
    [Telemovel] nvarchar(max)  NOT NULL,
    [Mail] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'InscricoesSet'
CREATE TABLE [dbo].[InscricoesSet] (
    [Confirmada] bit  NOT NULL,
    [IdFilho] int  NOT NULL,
    [NrEvento] int  NOT NULL,
    [Filhos_IdPessoa] int  NOT NULL,
    [Eventos_NrEvento] int  NOT NULL
);
GO

-- Creating table 'EventosSet'
CREATE TABLE [dbo].[EventosSet] (
    [NrEvento] int IDENTITY(1,1) NOT NULL,
    [Descricao] nvarchar(max)  NOT NULL,
    [Local] nvarchar(max)  NOT NULL,
    [DataHora] datetime  NOT NULL,
    [LimiteParticipacoes] nvarchar(max)  NOT NULL,
    [IdadeInferior] nvarchar(max)  NOT NULL,
    [IdadeSuperior] nvarchar(max)  NOT NULL,
    [ColaboracoesId] int  NOT NULL,
    [TipoEvento] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ColaboracoesSet'
CREATE TABLE [dbo].[ColaboracoesSet] (
    [NrEvento] int IDENTITY(1,1) NOT NULL,
    [IdAnimador] int  NOT NULL,
    [Animadores_IdPessoa] int  NOT NULL,
    [Eventos_NrEvento] int  NOT NULL
);
GO

-- Creating table 'ParticipacoesSet'
CREATE TABLE [dbo].[ParticipacoesSet] (
    [NrEvento] int  NOT NULL,
    [IdEscola] int  NOT NULL,
    [Eventos_NrEvento] int  NOT NULL
);
GO

-- Creating table 'EscolasSet'
CREATE TABLE [dbo].[EscolasSet] (
    [IdEscola] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Morada] nvarchar(max)  NOT NULL,
    [Telefone] nvarchar(max)  NOT NULL,
    [Mail] nvarchar(max)  NOT NULL,
    [CodPostal] nvarchar(max)  NOT NULL,
    [Localidade] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ComprasSet'
CREATE TABLE [dbo].[ComprasSet] (
    [Data] datetime  NOT NULL,
    [UtilizouCartao] bit  NOT NULL,
    [NrCompra] int  NOT NULL,
    [IdCliente] int  NOT NULL,
    [Clientes_IdPessoa] int  NOT NULL
);
GO

-- Creating table 'DetalheComprasSet'
CREATE TABLE [dbo].[DetalheComprasSet] (
    [Quantidade] int  NOT NULL,
    [CodProduto] int  NOT NULL,
    [NrCompra] int  NOT NULL,
    [Produtos_CodProduto] int  NOT NULL
);
GO

-- Creating table 'ProdutosSet'
CREATE TABLE [dbo].[ProdutosSet] (
    [CodProduto] int IDENTITY(1,1) NOT NULL,
    [Designacao] nvarchar(max)  NOT NULL,
    [Preco] decimal(18,0)  NOT NULL,
    [StockExistente] int  NOT NULL,
    [TipoProdutoCodTipoProduto] int  NOT NULL
);
GO

-- Creating table 'TipoProdutoSet1'
CREATE TABLE [dbo].[TipoProdutoSet1] (
    [CodTipoProduto] int IDENTITY(1,1) NOT NULL,
    [Tipo] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'PessoasSet_Filhos'
CREATE TABLE [dbo].[PessoasSet_Filhos] (
    [Sexo] nvarchar(max)  NOT NULL,
    [DataNascimento] datetime  NOT NULL,
    [IdProgenitor] int  NOT NULL,
    [IdPessoa] int  NOT NULL,
    [Escolas_IdEscola] int  NOT NULL
);
GO

-- Creating table 'PessoasSet_Animadores'
CREATE TABLE [dbo].[PessoasSet_Animadores] (
    [Especialidade] nvarchar(max)  NOT NULL,
    [IdPessoa] int  NOT NULL
);
GO

-- Creating table 'PessoasSet_Clientes'
CREATE TABLE [dbo].[PessoasSet_Clientes] (
    [ValorOferta] decimal(18,0)  NOT NULL,
    [NrCartao] int  NOT NULL,
    [IdPessoa] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [IdPessoa] in table 'PessoasSet'
ALTER TABLE [dbo].[PessoasSet]
ADD CONSTRAINT [PK_PessoasSet]
    PRIMARY KEY CLUSTERED ([IdPessoa] ASC);
GO

-- Creating primary key on [IdFilho], [NrEvento] in table 'InscricoesSet'
ALTER TABLE [dbo].[InscricoesSet]
ADD CONSTRAINT [PK_InscricoesSet]
    PRIMARY KEY CLUSTERED ([IdFilho], [NrEvento] ASC);
GO

-- Creating primary key on [NrEvento] in table 'EventosSet'
ALTER TABLE [dbo].[EventosSet]
ADD CONSTRAINT [PK_EventosSet]
    PRIMARY KEY CLUSTERED ([NrEvento] ASC);
GO

-- Creating primary key on [NrEvento], [IdAnimador] in table 'ColaboracoesSet'
ALTER TABLE [dbo].[ColaboracoesSet]
ADD CONSTRAINT [PK_ColaboracoesSet]
    PRIMARY KEY CLUSTERED ([NrEvento], [IdAnimador] ASC);
GO

-- Creating primary key on [NrEvento], [IdEscola] in table 'ParticipacoesSet'
ALTER TABLE [dbo].[ParticipacoesSet]
ADD CONSTRAINT [PK_ParticipacoesSet]
    PRIMARY KEY CLUSTERED ([NrEvento], [IdEscola] ASC);
GO

-- Creating primary key on [IdEscola] in table 'EscolasSet'
ALTER TABLE [dbo].[EscolasSet]
ADD CONSTRAINT [PK_EscolasSet]
    PRIMARY KEY CLUSTERED ([IdEscola] ASC);
GO

-- Creating primary key on [NrCompra] in table 'ComprasSet'
ALTER TABLE [dbo].[ComprasSet]
ADD CONSTRAINT [PK_ComprasSet]
    PRIMARY KEY CLUSTERED ([NrCompra] ASC);
GO

-- Creating primary key on [CodProduto], [NrCompra] in table 'DetalheComprasSet'
ALTER TABLE [dbo].[DetalheComprasSet]
ADD CONSTRAINT [PK_DetalheComprasSet]
    PRIMARY KEY CLUSTERED ([CodProduto], [NrCompra] ASC);
GO

-- Creating primary key on [CodProduto] in table 'ProdutosSet'
ALTER TABLE [dbo].[ProdutosSet]
ADD CONSTRAINT [PK_ProdutosSet]
    PRIMARY KEY CLUSTERED ([CodProduto] ASC);
GO

-- Creating primary key on [CodTipoProduto] in table 'TipoProdutoSet1'
ALTER TABLE [dbo].[TipoProdutoSet1]
ADD CONSTRAINT [PK_TipoProdutoSet1]
    PRIMARY KEY CLUSTERED ([CodTipoProduto] ASC);
GO

-- Creating primary key on [IdPessoa] in table 'PessoasSet_Filhos'
ALTER TABLE [dbo].[PessoasSet_Filhos]
ADD CONSTRAINT [PK_PessoasSet_Filhos]
    PRIMARY KEY CLUSTERED ([IdPessoa] ASC);
GO

-- Creating primary key on [IdPessoa] in table 'PessoasSet_Animadores'
ALTER TABLE [dbo].[PessoasSet_Animadores]
ADD CONSTRAINT [PK_PessoasSet_Animadores]
    PRIMARY KEY CLUSTERED ([IdPessoa] ASC);
GO

-- Creating primary key on [IdPessoa] in table 'PessoasSet_Clientes'
ALTER TABLE [dbo].[PessoasSet_Clientes]
ADD CONSTRAINT [PK_PessoasSet_Clientes]
    PRIMARY KEY CLUSTERED ([IdPessoa] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Filhos_IdPessoa] in table 'InscricoesSet'
ALTER TABLE [dbo].[InscricoesSet]
ADD CONSTRAINT [FK_InscricoesFilhos]
    FOREIGN KEY ([Filhos_IdPessoa])
    REFERENCES [dbo].[PessoasSet_Filhos]
        ([IdPessoa])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_InscricoesFilhos'
CREATE INDEX [IX_FK_InscricoesFilhos]
ON [dbo].[InscricoesSet]
    ([Filhos_IdPessoa]);
GO

-- Creating foreign key on [Eventos_NrEvento] in table 'InscricoesSet'
ALTER TABLE [dbo].[InscricoesSet]
ADD CONSTRAINT [FK_InscricoesEventos]
    FOREIGN KEY ([Eventos_NrEvento])
    REFERENCES [dbo].[EventosSet]
        ([NrEvento])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_InscricoesEventos'
CREATE INDEX [IX_FK_InscricoesEventos]
ON [dbo].[InscricoesSet]
    ([Eventos_NrEvento]);
GO

-- Creating foreign key on [Animadores_IdPessoa] in table 'ColaboracoesSet'
ALTER TABLE [dbo].[ColaboracoesSet]
ADD CONSTRAINT [FK_ColaboracoesAnimadores]
    FOREIGN KEY ([Animadores_IdPessoa])
    REFERENCES [dbo].[PessoasSet_Animadores]
        ([IdPessoa])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ColaboracoesAnimadores'
CREATE INDEX [IX_FK_ColaboracoesAnimadores]
ON [dbo].[ColaboracoesSet]
    ([Animadores_IdPessoa]);
GO

-- Creating foreign key on [Eventos_NrEvento] in table 'ParticipacoesSet'
ALTER TABLE [dbo].[ParticipacoesSet]
ADD CONSTRAINT [FK_ParticipacoesEventos]
    FOREIGN KEY ([Eventos_NrEvento])
    REFERENCES [dbo].[EventosSet]
        ([NrEvento])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ParticipacoesEventos'
CREATE INDEX [IX_FK_ParticipacoesEventos]
ON [dbo].[ParticipacoesSet]
    ([Eventos_NrEvento]);
GO

-- Creating foreign key on [Escolas_IdEscola] in table 'PessoasSet_Filhos'
ALTER TABLE [dbo].[PessoasSet_Filhos]
ADD CONSTRAINT [FK_FilhosEscolas]
    FOREIGN KEY ([Escolas_IdEscola])
    REFERENCES [dbo].[EscolasSet]
        ([IdEscola])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FilhosEscolas'
CREATE INDEX [IX_FK_FilhosEscolas]
ON [dbo].[PessoasSet_Filhos]
    ([Escolas_IdEscola]);
GO

-- Creating foreign key on [Clientes_IdPessoa] in table 'ComprasSet'
ALTER TABLE [dbo].[ComprasSet]
ADD CONSTRAINT [FK_ClientesCompras]
    FOREIGN KEY ([Clientes_IdPessoa])
    REFERENCES [dbo].[PessoasSet_Clientes]
        ([IdPessoa])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClientesCompras'
CREATE INDEX [IX_FK_ClientesCompras]
ON [dbo].[ComprasSet]
    ([Clientes_IdPessoa]);
GO

-- Creating foreign key on [Produtos_CodProduto] in table 'DetalheComprasSet'
ALTER TABLE [dbo].[DetalheComprasSet]
ADD CONSTRAINT [FK_DetalheComprasProdutos]
    FOREIGN KEY ([Produtos_CodProduto])
    REFERENCES [dbo].[ProdutosSet]
        ([CodProduto])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DetalheComprasProdutos'
CREATE INDEX [IX_FK_DetalheComprasProdutos]
ON [dbo].[DetalheComprasSet]
    ([Produtos_CodProduto]);
GO

-- Creating foreign key on [NrCompra] in table 'DetalheComprasSet'
ALTER TABLE [dbo].[DetalheComprasSet]
ADD CONSTRAINT [FK_ComprasDetalheCompras]
    FOREIGN KEY ([NrCompra])
    REFERENCES [dbo].[ComprasSet]
        ([NrCompra])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ComprasDetalheCompras'
CREATE INDEX [IX_FK_ComprasDetalheCompras]
ON [dbo].[DetalheComprasSet]
    ([NrCompra]);
GO

-- Creating foreign key on [Eventos_NrEvento] in table 'ColaboracoesSet'
ALTER TABLE [dbo].[ColaboracoesSet]
ADD CONSTRAINT [FK_ColaboracoesEventos]
    FOREIGN KEY ([Eventos_NrEvento])
    REFERENCES [dbo].[EventosSet]
        ([NrEvento])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ColaboracoesEventos'
CREATE INDEX [IX_FK_ColaboracoesEventos]
ON [dbo].[ColaboracoesSet]
    ([Eventos_NrEvento]);
GO

-- Creating foreign key on [IdEscola] in table 'ParticipacoesSet'
ALTER TABLE [dbo].[ParticipacoesSet]
ADD CONSTRAINT [FK_EscolasParticipacoes]
    FOREIGN KEY ([IdEscola])
    REFERENCES [dbo].[EscolasSet]
        ([IdEscola])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EscolasParticipacoes'
CREATE INDEX [IX_FK_EscolasParticipacoes]
ON [dbo].[ParticipacoesSet]
    ([IdEscola]);
GO

-- Creating foreign key on [TipoProdutoCodTipoProduto] in table 'ProdutosSet'
ALTER TABLE [dbo].[ProdutosSet]
ADD CONSTRAINT [FK_ProdutosTipoProduto]
    FOREIGN KEY ([TipoProdutoCodTipoProduto])
    REFERENCES [dbo].[TipoProdutoSet1]
        ([CodTipoProduto])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProdutosTipoProduto'
CREATE INDEX [IX_FK_ProdutosTipoProduto]
ON [dbo].[ProdutosSet]
    ([TipoProdutoCodTipoProduto]);
GO

-- Creating foreign key on [IdPessoa] in table 'PessoasSet_Filhos'
ALTER TABLE [dbo].[PessoasSet_Filhos]
ADD CONSTRAINT [FK_Filhos_inherits_Pessoas]
    FOREIGN KEY ([IdPessoa])
    REFERENCES [dbo].[PessoasSet]
        ([IdPessoa])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdPessoa] in table 'PessoasSet_Animadores'
ALTER TABLE [dbo].[PessoasSet_Animadores]
ADD CONSTRAINT [FK_Animadores_inherits_Pessoas]
    FOREIGN KEY ([IdPessoa])
    REFERENCES [dbo].[PessoasSet]
        ([IdPessoa])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdPessoa] in table 'PessoasSet_Clientes'
ALTER TABLE [dbo].[PessoasSet_Clientes]
ADD CONSTRAINT [FK_Clientes_inherits_Pessoas]
    FOREIGN KEY ([IdPessoa])
    REFERENCES [dbo].[PessoasSet]
        ([IdPessoa])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------