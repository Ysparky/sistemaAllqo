--TRIGGERS-
ALTER TRIGGER create_Sesion
ON RESERVA
AFTER INSERT
AS BEGIN
DECLARE 
@RESERVAID INT,
@CLIENTEID INT,
@LUGARID INT,
@LUGAR VARCHAR(50),
@FECHA_SESION DATETIME,
@SESIONID INT,
@FIND_SESION INT
--Obtengo la fecha de sesion ingresada por el usuario
SET @FECHA_SESION = (SELECT fechaSesion FROM inserted)
--Obtengo el nombre del lugar del cliente por medio de su id
SET @CLIENTEID = (SELECT idCliente FROM inserted)
SET @LUGARID = (SELECT idLugar FROM Cliente WHERE idCliente = @CLIENTEID)
SET @LUGAR = (SELECT nombre FROM Lugar WHERE idLugar = @LUGARID)
--Obtengo el id de la reserva
SET @RESERVAID = (SELECT idReserva FROM inserted)
--Obtiene la sesion en la cual existe una fecha de sesion y un lugar
SET @FIND_SESION = (SELECT idSesion FROM Sesion WHERE Lugar = @LUGAR AND fechaSesion = @FECHA_SESION)
--Si no existen fechas con ese id
IF(@FIND_SESION IS NULL)
BEGIN
INSERT INTO Sesion(fechaSesion,lugar) VALUES(@FECHA_SESION,@LUGAR)

SET @SESIONID = (SELECT idSesion FROM inserted)
UPDATE Reserva SET idSesion = @SESIONID WHERE idReserva = @RESERVAID
END
ELSE
BEGIN
UPDATE Reserva SET idSesion = @FIND_SESION WHERE idReserva = @RESERVAID
END
END

DROP TRIGGER dbo.updated_Reserva
CREATE OR ALTER TRIGGER updated_Reserva
ON SESION
AFTER INSERT
AS BEGIN
DECLARE
@idReserva int,
@idSesion int
SET @idReserva = (SELECT TOP(1) idReserva FROM Reserva WHERE idSesion IS NULL)
SET @idSesion = (SELECT TOP(1) idSesion FROM inserted)
UPDATE Reserva SET idSesion = @idSesion WHERE idReserva = @idReserva
END

delete Reserva where idReserva = 61
delete Sesion where idSesion= 7
SELECT * FROM Reserva
SELECT * FROM Sesion
INSERT INTO Reserva(fechaReservada,fechaSesion,estado,idCliente,idServicio,idTrabajador,idSesion) VALUES('2019-04-15 11:30:00','2019-05-16 13:00:00','Creado',3,2,6,NULL)
SELECT * FROM Cliente


SELECT idSesion FROM Sesion WHERE Lugar = 'Miraflores' AND fechaSesion = '2019-04-13 11:00:00'
select dbo.hola(2)

--Creo mi sesion siempre y cuando no exista una sesion con esa fecha y en el mismo lugar

select idReserva from Reserva where idSesion is null