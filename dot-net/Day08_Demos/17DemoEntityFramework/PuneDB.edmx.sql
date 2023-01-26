
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 01/03/2023 12:36:16
-- Generated from EDMX file: C:\Users\mahes\OneDrive\Desktop\DNETPune\DNETPune\17DemoEntityFramework\PuneDB.edmx
-- --------------------------------------------------

USE [punedb];



-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------



-- Creating table 'Trainers'
CREATE TABLE [dbo].[Trainers] (
    [TrainerID] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Topics'
CREATE TABLE [dbo].[Topics] (
    [TopicID] int IDENTITY(1,1) NOT NULL,
    [Title] nvarchar(max)  NOT NULL,
    [Desc] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'TrainerTopic'
CREATE TABLE [dbo].[TrainerTopic] (
    [Trainers_TrainerID] int  NOT NULL,
    [Topics_TopicID] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [TrainerID] in table 'Trainers'
ALTER TABLE [dbo].[Trainers]
ADD CONSTRAINT [PK_Trainers]
    PRIMARY KEY CLUSTERED ([TrainerID] ASC);
GO

-- Creating primary key on [TopicID] in table 'Topics'
ALTER TABLE [dbo].[Topics]
ADD CONSTRAINT [PK_Topics]
    PRIMARY KEY CLUSTERED ([TopicID] ASC);
GO

-- Creating primary key on [Trainers_TrainerID], [Topics_TopicID] in table 'TrainerTopic'
ALTER TABLE [dbo].[TrainerTopic]
ADD CONSTRAINT [PK_TrainerTopic]
    PRIMARY KEY CLUSTERED ([Trainers_TrainerID], [Topics_TopicID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Trainers_TrainerID] in table 'TrainerTopic'
ALTER TABLE [dbo].[TrainerTopic]
ADD CONSTRAINT [FK_TrainerTopic_Trainer]
    FOREIGN KEY ([Trainers_TrainerID])
    REFERENCES [dbo].[Trainers]
        ([TrainerID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Topics_TopicID] in table 'TrainerTopic'
ALTER TABLE [dbo].[TrainerTopic]
ADD CONSTRAINT [FK_TrainerTopic_Topic]
    FOREIGN KEY ([Topics_TopicID])
    REFERENCES [dbo].[Topics]
        ([TopicID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TrainerTopic_Topic'
CREATE INDEX [IX_FK_TrainerTopic_Topic]
ON [dbo].[TrainerTopic]
    ([Topics_TopicID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------