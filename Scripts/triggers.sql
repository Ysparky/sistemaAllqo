--TRIGGERS-
drop trigger dbo.create_Sesion
ALTER TRIGGER create_Sesion
ON RESERVA
FOR INSERT
AS 
BEGIN
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
		SET @SESIONID = (SELECT idSesion FROM Sesion WHERE fechaSesion = @FECHA_SESION AND lugar = @LUGAR)
		UPDATE Reserva SET idSesion = @SESIONID WHERE idReserva = @RESERVAID

	END
ELSE
	BEGIN
		UPDATE Reserva SET idSesion = @FIND_SESION WHERE idReserva = @RESERVAID
	END
END



INSERT INTO Reserva(fechaReservada,fechaSesion,estado,idCliente,idServicio,idTrabajador,idSesion) VALUES('2019-04-15 11:30:00','2022-05-16 13:00:00','Creado',3,2,6,NULL)

select * from Sesion
select * from Reserva
SELECT * FROM SesionxMascota
SELECT * FROM Sesion
DROP TRIGGER numMascotas
ALTER TRIGGER numMascotas
ON SESION
AFTER INSERT
AS
BEGIN
DECLARE
@NMASCOTAS INT,
@SESIONID INT
SET @SESIONID = (SELECT idSesion FROM inserted)
SET @NMASCOTAS = (SELECT numMascotas FROM Sesion WHERE idSesion = @SESIONID)
IF(@NMASCOTAS > 6)
BEGIN
	ROLLBACK
END
ELSE IF(@NMASCOTAS IS NULL)
BEGIN
UPDATE Sesion SET numMascotas = 1 WHERE idSesion = @SESIONID
END
ELSE
BEGIN
	SET @NMASCOTAS = @NMASCOTAS + 1
	UPDATE Sesion SET numMascotas = @NMASCOTAS WHERE idSesion = @SESIONID
END
END


SELECT * FROM Trabajador (5,6,7,8)
SELECT * FROM Cliente (1,2,3,4,5,6)
INSERT INTO Reserva 