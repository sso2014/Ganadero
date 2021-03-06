USE [Ganaderia]
GO
/****** Object:  Table [dbo].[Animal_Categoria]    Script Date: 20/05/2015 05:32:05 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Animal_Categoria](
	[Animal_Categoria] [int] NULL,
	[Descripcion] [nchar](50) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Bovino]    Script Date: 20/05/2015 05:32:06 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bovino](
	[Bovino_id] [int] IDENTITY(1,1) NOT NULL,
	[Categoria] [int] NULL,
	[Campo] [int] NULL,
	[Rp] [nvarchar](50) NULL,
	[Apodo] [nvarchar](50) NULL,
	[Color] [int] NULL,
	[Sexo] [int] NULL,
	[Edad] [int] NULL,
	[Peso] [float] NULL,
	[Raza] [int] NULL,
	[Establecimiento_id] [int] NULL,
 CONSTRAINT [PK_Bovino] PRIMARY KEY CLUSTERED 
(
	[Bovino_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Bovino_Categoria]    Script Date: 20/05/2015 05:32:06 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bovino_Categoria](
	[Categoria_id] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nchar](20) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Bovino_Detalle]    Script Date: 20/05/2015 05:32:06 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bovino_Detalle](
	[Rp] [nvarchar](50) NOT NULL,
	[Padre] [nvarchar](50) NULL,
	[Madre] [nvarchar](50) NULL,
	[Fecha_Nacimiento] [datetime] NULL,
	[Peso_Nacimiento] [float] NOT NULL,
	[Campo] [int] NULL CONSTRAINT [DF_Bovino_Detalle_Campo]  DEFAULT ((0)),
 CONSTRAINT [PK_Bovino_Detalle] PRIMARY KEY CLUSTERED 
(
	[Rp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Bovino_Raza]    Script Date: 20/05/2015 05:32:06 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bovino_Raza](
	[Bovino_Raza_id] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nchar](10) NOT NULL,
 CONSTRAINT [PK_Bovino_Raza] PRIMARY KEY CLUSTERED 
(
	[Bovino_Raza_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Bovino_Sexo]    Script Date: 20/05/2015 05:32:06 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bovino_Sexo](
	[Sexo_id] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nchar](30) NULL,
 CONSTRAINT [PK_Bovino_Sexo] PRIMARY KEY CLUSTERED 
(
	[Sexo_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Campo]    Script Date: 20/05/2015 05:32:06 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Campo](
	[Campo_id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nchar](10) NOT NULL,
	[Renspa] [nchar](50) NOT NULL,
	[Razon] [nchar](50) NULL,
	[cuil] [nchar](50) NULL,
	[Renspa_Ganadero] [nchar](50) NULL,
	[Direccion] [nchar](50) NULL,
	[Localidad] [nchar](50) NULL,
	[Partido] [nchar](50) NULL,
	[Provincia] [nchar](50) NULL,
 CONSTRAINT [PK_Campo] PRIMARY KEY CLUSTERED 
(
	[Campo_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Categoria_Bovina]    Script Date: 20/05/2015 05:32:06 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categoria_Bovina](
	[Categoria_Bovina_id] [int] IDENTITY(1,1) NOT NULL,
	[Desxcripcion] [nchar](50) NOT NULL,
	[Codigo] [nchar](4) NULL,
 CONSTRAINT [PK_Categoria_Bovina] PRIMARY KEY CLUSTERED 
(
	[Categoria_Bovina_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Categoria_Equina]    Script Date: 20/05/2015 05:32:06 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categoria_Equina](
	[Categoria_Equina_id] [int] IDENTITY(1,1) NOT NULL,
	[Descipcion] [nchar](50) NOT NULL,
	[Codigo] [nchar](5) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Establecimiento]    Script Date: 20/05/2015 05:32:06 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Establecimiento](
	[Establecimiento_id] [int] IDENTITY(1,1) NOT NULL,
	[Campo_id] [int] NOT NULL,
	[Nombre] [nchar](50) NOT NULL,
	[Localidad] [nchar](50) NULL,
	[Partido] [nchar](50) NULL,
	[Provincia] [nchar](50) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Servicio]    Script Date: 20/05/2015 05:32:06 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Servicio](
	[Servicio_id] [int] IDENTITY(1,1) NOT NULL,
	[Codigo] [nchar](2) NOT NULL,
	[Descripcion] [nchar](30) NOT NULL,
 CONSTRAINT [PK_Servicio] PRIMARY KEY CLUSTERED 
(
	[Servicio_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  StoredProcedure [dbo].[DELETE_CAMPO]    Script Date: 20/05/2015 05:32:06 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DELETE_CAMPO] @campo_id int as
DELETE from Campo
where Campo_id = @campo_id
GO
/****** Object:  StoredProcedure [dbo].[DELETE_ESTABLECIMIENTO]    Script Date: 20/05/2015 05:32:06 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DELETE_ESTABLECIMIENTO] @id int as
delete Establecimiento 
where Establecimiento_id = @id
GO
/****** Object:  StoredProcedure [dbo].[INSERT_BOVINO]    Script Date: 20/05/2015 05:32:06 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[INSERT_BOVINO] @RP INT, @APODO NCHAR, @FECHA_NACIMIENTO DATETIME, @SEXO INT, @COLOR INT, @PESO FLOAT, @EDAD INT, @MADRE INT, @PADRE INT, @RAZA INT AS
INSERT INTO Bovino (Rp, Apodo, Fecha_Nacimiento, Sexo, Color, Peso, Edad, Madre, Padre, Raza_id) VALUES (@RP, @APODO, @FECHA_NACIMIENTO, @SEXO, @COLOR, @PESO, @EDAD, @MADRE, @PADRE, @RAZA)
   
GO
/****** Object:  StoredProcedure [dbo].[INSERT_CAMPO]    Script Date: 20/05/2015 05:32:06 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[INSERT_CAMPO] 
@Nombre nchar(50),
@Renspa nchar(50),
@Razon nchar(50),
@Cuil nchar(50),
@Renspa_Ganadero nchar(50),
@Direccion nchar(50),
@Localidad nchar(50),
@Partido nchar(50),
@Provincia nchar(50)
as
INSERT INTO Campo (
Nombre,
Renspa,
Razon,
cuil,
Renspa_Ganadero,
Direccion,
Localidad,
Partido,
Provincia)
VALUES(@Nombre,
@Renspa,
@Razon,
@Cuil,
@Renspa_Ganadero,
@Direccion,
@Localidad,
@Partido,
@Provincia);

GO
/****** Object:  StoredProcedure [dbo].[INSERT_ESTABLECIMIENTO]    Script Date: 20/05/2015 05:32:06 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[INSERT_ESTABLECIMIENTO] @campo_id int, @nombre nchar, @localidad nchar, @partido nchar, @provincia nchar as
INSERT INTO Establecimiento (Campo_id, Nombre, Localidad, Partido, Provincia) values(@campo_id, @nombre, @localidad, @partido, @provincia)

GO
/****** Object:  StoredProcedure [dbo].[INSERT_SEXO]    Script Date: 20/05/2015 05:32:06 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[INSERT_SEXO] @descripcion NCHAR as 
INSERT INTO Bovino_Sexo (Descripcion) VALUES (@descripcion)
GO
/****** Object:  StoredProcedure [dbo].[SELECT_ALL_BOVINOS]    Script Date: 20/05/2015 05:32:06 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[SELECT_ALL_BOVINOS] AS
SELECT b.Bovino_id, b.Rp,b.Establecimiento_id, b.Apodo, b.Color, b.Peso , b.Edad, BS.Descripcion AS Sexo, br.Descripcion as Raza, bc.Descripcion as Categoria, bd.Fecha_Nacimiento, bd.Madre, bd.Padre, bd.Peso_Nacimiento from Bovino b
inner join Bovino_Sexo bs on
b.Sexo = BS.Sexo_id
inner join Bovino_Raza br on
b.Raza = br.Bovino_Raza_id
inner join Bovino_Categoria bc on
b.Categoria = bc.Categoria_id
left join Bovino_Detalle bd on
b.Rp = bd.Rp


GO
/****** Object:  StoredProcedure [dbo].[SELECT_ALL_CAMPOS]    Script Date: 20/05/2015 05:32:06 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SELECT_ALL_CAMPOS] AS
SELECT * from campo
GO
/****** Object:  StoredProcedure [dbo].[SELECT_ALL_ESTABLECIMIENTOS]    Script Date: 20/05/2015 05:32:06 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SELECT_ALL_ESTABLECIMIENTOS] AS
SELECT * FROM Establecimiento
GO
/****** Object:  StoredProcedure [dbo].[SELECT_ALL_SEXOS]    Script Date: 20/05/2015 05:32:06 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SELECT_ALL_SEXOS] AS
SELECT * FROM Bovino_Sexo
GO
/****** Object:  StoredProcedure [dbo].[SELECT_ULTIMO_BOVINO]    Script Date: 20/05/2015 05:32:06 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SELECT_ULTIMO_BOVINO]AS
SELECT MAX(Bovino_id) as id FROM BOVINO

GO
/****** Object:  StoredProcedure [dbo].[UPDATE_CAMPO]    Script Date: 20/05/2015 05:32:06 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[UPDATE_CAMPO] @campo_id as int, @nombre nchar, @renspa nchar, @razon nchar, @cuil nchar, @renspa_ganadero nchar, @direccion nchar, @localidad nchar, @partido nchar, @provincia nchar as
UPDATE Campo
SET Nombre = @nombre, Renspa = @renspa, Razon = @razon, cuil = @cuil, Renspa_Ganadero = @renspa_ganadero, Direccion = @direccion, Localidad = @localidad, Partido = @partido, Provincia = @provincia
where Campo_id = @campo_id
GO
/****** Object:  StoredProcedure [dbo].[UPDATE_ESTABLECIMIENTO]    Script Date: 20/05/2015 05:32:06 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[UPDATE_ESTABLECIMIENTO] @id int, @campo_id int, @nombre nchar, @localidad nchar, @partido nchar, @provincia nchar as
update Establecimiento 
set Campo_id = @campo_id, Nombre = @nombre, Localidad = @localidad, Partido = @partido, Provincia = @provincia
GO
