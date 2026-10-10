USE [negocio]
GO
/****** Objeto: Table [dbo].[Usuarios] Fecha de script: 24/8/2026 12:15:34 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[ID_usuario] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Correo] [varchar](150) NULL,
	[Contraseña] [varchar](100) NOT NULL,
	[Rol] [varchar](45) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Usuarios] ON 

INSERT [dbo].[Usuarios] ([ID_usuario], [Nombre], [Correo], [Contraseña], [Rol]) VALUES (1, N'Manuel Dominguez', N'ManuelDomi@gmail.com', N'manu3030', N'Vendedor')
INSERT [dbo].[Usuarios] ([ID_usuario], [Nombre], [Correo], [Contraseña], [Rol]) VALUES (2, N'Miguel Moreno', N'Moreno@gmail.com', N'321023', N'Vendedor')
INSERT [dbo].[Usuarios] ([ID_usuario], [Nombre], [Correo], [Contraseña], [Rol]) VALUES (3, N'Mario Gonzalez', N'MarioGON@gmail.com', N'020232', N'Administrador')
INSERT [dbo].[Usuarios] ([ID_usuario], [Nombre], [Correo], [Contraseña], [Rol]) VALUES (4, N'Romulo Moreno', N'Romu@gmail.com', N'Password', N'Contador')
INSERT [dbo].[Usuarios] ([ID_usuario], [Nombre], [Correo], [Contraseña], [Rol]) VALUES (5, N'Karen Lantigua', N'KarenLantigua90@gmail.com', N'Karen', N'Encargado de inventario')
INSERT [dbo].[Usuarios] ([ID_usuario], [Nombre], [Correo], [Contraseña], [Rol]) VALUES (6, N'Michael Sanchez', N'Sanchez_09@gmail.com', N'Michael0912', N'Administrador')
INSERT [dbo].[Usuarios] ([ID_usuario], [Nombre], [Correo], [Contraseña], [Rol]) VALUES (7, N'Wendy Rodriguez', N'WEN80_@gmail.com', N'010201', N'Vendedor')
INSERT [dbo].[Usuarios] ([ID_usuario], [Nombre], [Correo], [Contraseña], [Rol]) VALUES (8, N'Emmanuel Peguero', N'Peguero230@gmail.com', N'3030', N'Encargado de Inventario')
INSERT [dbo].[Usuarios] ([ID_usuario], [Nombre], [Correo], [Contraseña], [Rol]) VALUES (12, N'Jose Martinez', N'jojoDs@gmail.com', N'Jojo001', N'Encargado de Inventario')
INSERT [dbo].[Usuarios] ([ID_usuario], [Nombre], [Correo], [Contraseña], [Rol]) VALUES (13, N'Manuel Emilio', N'manugmail.com', N'00001', N'Contador')
SET IDENTITY_INSERT [dbo].[Usuarios] OFF
GO
