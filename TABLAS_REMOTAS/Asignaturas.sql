USE [Trabajo_Crud_Remoto]
GO

/****** Object:  Table [dbo].[Asignaturas]    Script Date: 20-11-24 1:37:10 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Asignaturas](
	[CodigoAsignatura] [int] IDENTITY(1,1) NOT NULL,
	[NombreAsignatura] [nvarchar](50) NOT NULL,
	[Creditos] [int] NOT NULL,
 CONSTRAINT [PK_Asignaturas] PRIMARY KEY CLUSTERED 
(
	[CodigoAsignatura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

