
SET IDENTITY_INSERT [dbo].[Genres] ON 

INSERT [dbo].[Genres] ([Id], [Name]) VALUES (1, N'Adventure')
INSERT [dbo].[Genres] ([Id], [Name]) VALUES (2, N'Fantasy')
INSERT [dbo].[Genres] ([Id], [Name]) VALUES (3, N'Animation')
INSERT [dbo].[Genres] ([Id], [Name]) VALUES (4, N'Drama')
INSERT [dbo].[Genres] ([Id], [Name]) VALUES (5, N'Horror')
INSERT [dbo].[Genres] ([Id], [Name]) VALUES (6, N'Action')
INSERT [dbo].[Genres] ([Id], [Name]) VALUES (7, N'Comedy')
INSERT [dbo].[Genres] ([Id], [Name]) VALUES (8, N'History')
INSERT [dbo].[Genres] ([Id], [Name]) VALUES (9, N'Western')
INSERT [dbo].[Genres] ([Id], [Name]) VALUES (10, N'Thriller')
INSERT [dbo].[Genres] ([Id], [Name]) VALUES (11, N'Crime')
INSERT [dbo].[Genres] ([Id], [Name]) VALUES (12, N'Documentary')
INSERT [dbo].[Genres] ([Id], [Name]) VALUES (13, N'Science Fiction')
INSERT [dbo].[Genres] ([Id], [Name]) VALUES (14, N'Mystery')
INSERT [dbo].[Genres] ([Id], [Name]) VALUES (15, N'Music')
INSERT [dbo].[Genres] ([Id], [Name]) VALUES (16, N'Romance')
INSERT [dbo].[Genres] ([Id], [Name]) VALUES (17, N'Family')
INSERT [dbo].[Genres] ([Id], [Name]) VALUES (18, N'War')
INSERT [dbo].[Genres] ([Id], [Name]) VALUES (19, N'Foreign')
INSERT [dbo].[Genres] ([Id], [Name]) VALUES (20, N'TV Movie')
SET IDENTITY_INSERT [dbo].[Genres] OFF



INSERT INTO [Movies] ([TmdbUrl], [Title], [OverView], [Tagline], [Runtime], [Budget], [Revenue], [BackdropUrl], [PosterUrl], [ImdbUrl], [OriginalLanguage], [ReleaseDate]) VALUES ('https://www.themoviedb.org/movie/27205', 'Inception', 'Cobb, a skilled thief who commits corporate espionage by infiltrating the subconscious of his targets is offered a chance to regain his old life as payment for a task considered to be impossible: "inception", the implantation of another person''s idea into a target''s subconscious.', 'Your mind is the scene of the crime.', 148, 160000000, 825532764, 'https://image.tmdb.org/t/p/original//s3TBrRGB1iav7gFOCNx3H31MoES.jpg', 'https://image.tmdb.org/t/p/w342//9gk7adHYeDvHkCSEqAvQNLV5Uge.jpg', 'https://www.imdb.com/title/tt1375666', 'en', '2010-07-15')
INSERT INTO [Movies] ([TmdbUrl], [Title], [OverView], [Tagline], [Runtime], [Budget], [Revenue], [BackdropUrl], [PosterUrl], [ImdbUrl], [OriginalLanguage], [ReleaseDate]) VALUES ('https://www.themoviedb.org/movie/157336', 'Interstellar', 'The adventures of a group of explorers who make use of a newly discovered wormhole to surpass the limitations on human space travel and conquer the vast distances involved in an interstellar voyage.', 'Mankind was born on Earth. It was never meant to die here.', 169, 165000000, 675120017, 'https://image.tmdb.org/t/p/original//xJHokMbljvjADYdit5fK5VQsXEG.jpg', 'https://image.tmdb.org/t/p/w342//gEU2QniE6E77NI6lCU6MxlNBvIx.jpg', 'https://www.imdb.com/title/tt0816692', 'en', '2014-11-05')
INSERT INTO [Movies] ([TmdbUrl], [Title], [OverView], [Tagline], [Runtime], [Budget], [Revenue], [BackdropUrl], [PosterUrl], [ImdbUrl], [OriginalLanguage], [ReleaseDate]) VALUES ('https://www.themoviedb.org/movie/155', 'The Dark Knight', 'Batman raises the stakes in his war on crime. With the help of Lt. Jim Gordon and District Attorney Harvey Dent, Batman sets out to dismantle the remaining criminal organizations that plague the streets. The partnership proves to be effective, but they soon find themselves prey to a reign of chaos unleashed by a rising criminal mastermind known to the terrified citizens of Gotham as the Joker.', 'Why So Serious?', 152, 185000000, 1004558444, 'https://image.tmdb.org/t/p/original//hkBaDkMWbLaf8B1lsWsKX7Ew3Xq.jpg', 'https://image.tmdb.org/t/p/w342//qJ2tW6WMUDux911r6m7haRef0WH.jpg', 'https://www.imdb.com/title/tt0468569', 'en', '2008-07-16')
INSERT INTO [Movies] ([TmdbUrl], [Title], [OverView], [Tagline], [Runtime], [Budget], [Revenue], [BackdropUrl], [PosterUrl], [ImdbUrl], [OriginalLanguage], [ReleaseDate]) VALUES ('https://www.themoviedb.org/movie/293660', 'Deadpool', 'Deadpool tells the origin story of former Special Forces operative turned mercenary Wade Wilson, who after being subjected to a rogue experiment that leaves him with accelerated healing powers, adopts the alter ego Deadpool. Armed with his new abilities and a dark, twisted sense of humor, Deadpool hunts down the man who nearly destroyed his life.', 'Witness the beginning of a happy ending', 108, 58000000, 783100000, 'https://image.tmdb.org/t/p/original//en971MEXui9diirXlogOrPKmsEn.jpg', 'https://image.tmdb.org/t/p/w342//yGSxMiF0cYuAiyuve5DA6bnWEOI.jpg', 'https://www.imdb.com/title/tt1431045', 'en', '2016-02-09')
INSERT INTO [Movies] ([TmdbUrl], [Title], [OverView], [Tagline], [Runtime], [Budget], [Revenue], [BackdropUrl], [PosterUrl], [ImdbUrl], [OriginalLanguage], [ReleaseDate]) VALUES ('https://www.themoviedb.org/movie/24428', 'The Avengers', 'When an unexpected enemy emerges and threatens global safety and security, Nick Fury, director of the international peacekeeping agency known as S.H.I.E.L.D., finds himself in need of a team to pull the world back from the brink of disaster. Spanning the globe, a daring recruitment effort begins!', 'Some assembly required.', 143, 220000000, 1519557910, 'https://image.tmdb.org/t/p/original//kwUQFeFXOOpgloMgZaadhzkbTI4.jpg', 'https://image.tmdb.org/t/p/w342//RYMX2wcKCBAr24UyPD7xwmjaTn.jpg', 'https://www.imdb.com/title/tt0848228', 'en', '2012-04-25')
INSERT INTO [Movies] ([TmdbUrl], [Title], [OverView], [Tagline], [Runtime], [Budget], [Revenue], [BackdropUrl], [PosterUrl], [ImdbUrl], [OriginalLanguage], [ReleaseDate]) VALUES ('https://www.themoviedb.org/movie/19995', 'Avatar', 'In the 22nd century, a paraplegic Marine is dispatched to the moon Pandora on a unique mission, but becomes torn between following orders and protecting an alien civilization.', 'Enter the World of Pandora.', 162, 237000000, 2787965087, 'https://image.tmdb.org/t/p/original//AmHOQ7rpHwiaUMRjKXztnauSJb7.jpg', 'https://image.tmdb.org/t/p/w342//6EiRUJpuoeQPghrs3YNktfnqOVh.jpg', 'https://www.imdb.com/title/tt0499549', 'en', '2009-12-10')
INSERT INTO [Movies] ([TmdbUrl], [Title], [OverView], [Tagline], [Runtime], [Budget], [Revenue], [BackdropUrl], [PosterUrl], [ImdbUrl], [OriginalLanguage], [ReleaseDate]) VALUES ('https://www.themoviedb.org/movie/118340', 'Guardians of the Galaxy', 'Light years from Earth, 26 years after being abducted, Peter Quill finds himself the prime target of a manhunt after discovering an orb wanted by Ronan the Accuser.', 'All heroes start somewhere.', 121, 170000000, 772776600, 'https://image.tmdb.org/t/p/original//mZSAu5acXueGC4Z3S5iLSWx8AEp.jpg', 'https://image.tmdb.org/t/p/w342//r7vmZjiyZw9rpJMQJdXpjgiCOk9.jpg', 'https://www.imdb.com/title/tt2015381', 'en', '2014-07-30')
INSERT INTO [Movies] ([TmdbUrl], [Title], [OverView], [Tagline], [Runtime], [Budget], [Revenue], [BackdropUrl], [PosterUrl], [ImdbUrl], [OriginalLanguage], [ReleaseDate]) VALUES ('https://www.themoviedb.org/movie/550', 'Fight Club', 'A ticking-time-bomb insomniac and a slippery soap salesman channel primal male aggression into a shocking new form of therapy. Their concept catches on, with underground "fight clubs" forming in every town, until an eccentric gets in the way and ignites an out-of-control spiral toward oblivion.', 'Mischief. Mayhem. Soap.', 139, 63000000, 100853753, 'https://image.tmdb.org/t/p/original//52AfXWuXCHn3UjD17rBruA9f5qb.jpg', 'https://image.tmdb.org/t/p/w342//8kNruSfhk5IoE4eZOc4UpvDn6tq.jpg', 'https://www.imdb.com/title/tt0137523', 'en', '1999-10-15')
INSERT INTO [Movies] ([TmdbUrl], [Title], [OverView], [Tagline], [Runtime], [Budget], [Revenue], [BackdropUrl], [PosterUrl], [ImdbUrl], [OriginalLanguage], [ReleaseDate]) VALUES ('https://www.themoviedb.org/movie/299536', 'Avengers: Infinity War', 'As the Avengers and their allies have continued to protect the world from threats too large for any one hero to handle, a new danger has emerged from the cosmic shadows: Thanos. A despot of intergalactic infamy, his goal is to collect all six Infinity Stones, artifacts of unimaginable power, and use them to inflict his twisted will on all of reality. Everything the Avengers have fought for has led up to this moment - the fate of Earth and existence itself has never been more uncertain.', 'An entire universe. Once and for all.', 149, 300000000, 2046239637, 'https://image.tmdb.org/t/p/original//lmZFxXgJE3vgrciwuDib0N8CfQo.jpg', 'https://image.tmdb.org/t/p/w342//7WsyChQLEftFiDOVTGkv3hFpyyt.jpg', 'https://www.imdb.com/title/tt4154756', 'en', '2018-04-25')
INSERT INTO [Movies] ([TmdbUrl], [Title], [OverView], [Tagline], [Runtime], [Budget], [Revenue], [BackdropUrl], [PosterUrl], [ImdbUrl], [OriginalLanguage], [ReleaseDate]) VALUES ('https://www.themoviedb.org/movie/680', 'Pulp Fiction', 'A burger-loving hit man, his philosophical partner, a drug-addled gangster''s moll and a washed-up boxer converge in this sprawling, comedic crime caper. Their adventures unfurl in three stories that ingeniously trip back and forth in time.', 'Just because you are a character doesn''t mean you have character.', 154, 8000000, 214179088, 'https://image.tmdb.org/t/p/original//w7RDIgQM6bLT7JXtH4iUQd3Iwxm.jpg', 'https://image.tmdb.org/t/p/w342//plnlrtBUULT0rh3Xsjmpubiso3L.jpg', 'https://www.imdb.com/title/tt0110912', 'en', '1994-09-10')

SELECT *
FROM Movies


INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (1, 6)
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (1, 13)
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (1, 1)
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (2, 1)
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (2, 4)
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (2, 13)
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (3, 4)
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (3, 6)
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (3, 11)
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (3, 10)
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (4, 6)
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (4, 1)
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (4, 7)
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (5, 13)
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (5, 6)
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (5, 1)
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (6, 6)
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (6, 1)
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (6, 2)
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (6, 13)
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (7, 6)
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (7, 13)
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (7, 1)
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (8, 4)
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (9, 1)
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (9, 6)
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (9, 13)
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (10, 10)
INSERT INTO [MovieGenres] ([MovieId], [GenreId]) VALUES (10, 11)




SELECT *
FROM MovieGenres


