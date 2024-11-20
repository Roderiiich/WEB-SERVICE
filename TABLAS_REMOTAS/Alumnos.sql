USE [Trabajo_Crud_Remoto]
GO

/****** Object:  Table [dbo].[Alumnos]    Script Date: 20-11-24 1:36:58 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Alumnos](
	[IDAlumnos] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NULL,
	[ApellidoPAt] [nvarchar](50) NULL,
	[ApellidoMat] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[N_Matricula] [nvarchar](50) NULL,
 CONSTRAINT [PK_Alumnos] PRIMARY KEY CLUSTERED 
(
	[IDAlumnos] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

