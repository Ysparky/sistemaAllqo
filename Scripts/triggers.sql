--TRIGGERS-
CREATE TRIGGER create_Sesion
ON RESERVA
AFTER INSERT
AS BEGIN
DECLARE @RESERVAID INT,
@CLIENTEID INT,
@LUGARID INT,
@LUGAR VARCHAR(50),
@FECHA_SESION DATETIME,
@SESIONID INT,
@BUSCAFECHA INT
SET @FECHA_SESION = (SELECT fechaSesion FROM inserted)
SET @CLIENTEID = (SELECT idCliente FROM inserted)
SET @LUGARID = (SELECT idLugar FROM Cliente WHERE idCliente = @CLIENTEID)
SET @LUGAR = (SELECT nombre FROM Lugar WHERE idLugar = @LUGARID)
SET @BUSCAFECHA = (SELECT idSesion FROM Sesion WHERE fechaSesion = @FECHA_SESION)
IF(@BUSCAFECHA = NULL)
BEGIN
INSERT INTO Sesion(fechaSesion,lugar) VALUES(@FECHA_SESION,@LUGAR)
SET @SESIONID = (SELECT idSesion FROM inserted)
UPDATE Reserva SET idSesion = @SESIONID WHERE idReserva = @RESERVAID
END
ELSE
BEGIN
UPDATE Reserva SET idSesion = @BUSCAFECHA WHERE idReserva = @RESERVAID
END
END


go
create function hola(@lugar int)
returns int
as
begin
declare @id int
set @id = (SELECT idSesion FROM SESION where lugar = @lugar)
return @id 
end
go


select dbo.hola(2)

