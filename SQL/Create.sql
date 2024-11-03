CREATE Database MovieShop

USE MovieShop

CREATE TABLE [dbo].[Genres] (
    [Id] INT IDENTITY(1,1) PRIMARY KEY,
    [Name] NVARCHAR(50) NOT NULL
);

CREATE TABLE [dbo].[Movies] (
    [Id] INT IDENTITY(1,1) PRIMARY KEY,
    [TmdbUrl] NVARCHAR(500),
    [Title] NVARCHAR(500) NOT NULL,
    [OverView] NVARCHAR(2000), 
    [Tagline] NVARCHAR(500),
    [Runtime] INT,
    [Budget] BIGINT,
    [Revenue] BIGINT,
    [BackdropUrl] NVARCHAR(500),
    [PosterUrl] NVARCHAR(500),
    [ImdbUrl] NVARCHAR(500),
    [OriginalLanguage] NVARCHAR(10),
    [ReleaseDate] DATE
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
    [Name] NVARCHAR(255) NOT NULL,
    [Gender] NVARCHAR(10),
    [TmdbUrl] NVARCHAR(255),
    [ProfilePath] NVARCHAR(255)
);

CREATE TABLE [dbo].[MovieCasts] (
    [MovieId] INT NOT NULL,
    [CastId] INT NOT NULL,
    [Character] NVARCHAR(255),
    PRIMARY KEY ([MovieId], [CastId]),
    FOREIGN KEY ([MovieId]) REFERENCES [Movies](Id),
    FOREIGN KEY ([CastId]) REFERENCES [Casts](Id)
);

CREATE TABLE [dbo].[Trailers] (
    [Id] INT IDENTITY(1,1) PRIMARY KEY,
    [MovieId] INT NOT NULL,
    [TrailerUrl] NVARCHAR(255) NOT NULL,
    [Name] NVARCHAR(255) NOT NULL,
    FOREIGN KEY ([MovieId]) REFERENCES [Movies](Id)
);



