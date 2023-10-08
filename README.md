# wsPersona
Api para el guardado de la informacion de personas
=================================================================================================================================================================================
#para la correcta funcionalidad del webService se debe crear una tabla llamada 'Persona' con los siguientes Datos:

CREATE TABLE [dbo].[Persona](
	[personaId] [int] IDENTITY(1,1) NOT NULL,
	[cedula] [varchar](30) NULL,
	[nombre] [varchar](30) NULL,
	[apellido1] [varchar](30) NULL,
	[apellido2] [varchar](30) NULL,
	[fechaNacimiento] [datetime] NULL,
	[edad] [int] NULL,
	[Email] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[personaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

***********************************(  NOTA IMPORTANTE !!!!! )*************************************************
*ESTE WEB API ESTA SUJETO A POSIBLES CAMBIOS, ESTAR PENDIENTE PARA ACTUALIZACION DE LA MISMA*
