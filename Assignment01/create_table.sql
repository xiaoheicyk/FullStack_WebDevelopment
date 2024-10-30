CREATE DATABASE MovieShop

USE MovieShop

DROP TABLE Genres

CREATE TABLE [dbo].[Genres] (
    [Id] INT IDENTITY(1,1) PRIMARY KEY,
    [Name] NVARCHAR(50)
);

--------


CREATE TABLE [dbo].[Movies] (
    [Id] INT IDENTITY(1,1) PRIMARY KEY,
    [TmdbUrl] NVARCHAR(500),
    [Title] NVARCHAR(500) ,
    [OverView] NVARCHAR(MAX),
    [Tagline] NVARCHAR(500) NULL,
    [Runtime] INT NULL,
    [Budget] BIGINT NULL,
    [Revenue] BIGINT NULL,
    [BackdropUrl] NVARCHAR(500) NULL,
    [PosterUrl] NVARCHAR(500) NULL,
    [ImdbUrl] NVARCHAR(500) NULL,
    [OriginalLanguage] NVARCHAR(10) NULL,
    [ReleaseDate] DATE NULL
);


CREATE TABLE [dbo].[MovieGenres] (
    [MovieId] INT NOT NULL,
    [GenreId] INT NOT NULL,
    PRIMARY KEY ([MovieId], [GenreId]),
    FOREIGN KEY ([MovieId]) REFERENCES [Movies](Id),
    FOREIGN KEY ([GenreId]) REFERENCES [Genres](Id)
);


CREATE TABLE [dbo].[Casts] (
    [Id] INT IDENTITY(1,1) PRIMARY KEY,
    [Name] NVARCHAR(255),
    [Gender] NVARCHAR(10),
    [TmdbUrl] NVARCHAR(255),
    [ProfilePath] NVARCHAR(255) NULL
);

