Create database POO_F3
go
use POO_F3
go

CREATE TABLE Pais ( 
Codigo_Pais VARCHAR (100),
Pais VARCHAR (50),
Codigo_Salida VARCHAR (50)
) 
GO

Insert Into Pais  Values 
('P0001', 'Nicaragua','505'),
('P0002', 'Brazil','55'),
('P0003', 'Costa Rica','506')

select * from Pais

--VER DATOS

CREATE PROC SP_Mostrar
AS
SELECT * FROM Pais
GO

----Insertar

CREATE PROC SP_Insertar
@Codigo_Pais  VARCHAR (100),
@Pais VARCHAR (50),
@Codigo_Salida VARCHAR (50)
AS
INSERT INTO PAIS VALUES(@CODIGO_PAIS,@PAIS,@CODIGO_SALIDA)
GO

--ACTUALIZAR DATOS

CREATE PROC SP_Modificar
@Codigo_Pais  VARCHAR (100),
@Pais VARCHAR (50),
@Codigo_Salida VARCHAR (50)
AS
UPDATE Pais SET Pais = @Pais, Codigo_Salida = @Codigo_Salida WHERE Codigo_Pais = @Codigo_Pais
GO


--ELIMINAR REGISTROS

CREATE PROC SP_Eliminar
@Codigo_Pais VARCHAR (100)
AS
DELETE Pais WHERE Codigo_Pais = @Codigo_Pais
GO


--BUSCAR DATOS

CREATE PROC SP_Buscar
@Buscar NVARCHAR(30)
AS
SELECT * FROM PAIS
WHERE Pais LIKE @Buscar + '%' 
GO