CREATE TABLE [dbo].[Comidas]
(
	[NombreEmpleado] VARCHAR(50) NOT NULL PRIMARY KEY, 
    [NúmeroEmpleado] INT NOT NULL, 
    [NúmeroCliente] INT NOT NULL, 
    [Menu] VARCHAR(50) NOT NULL, 
    [Ubicación] VARCHAR(100) NOT NULL, 
    [Calificación] INT NOT NULL
)
