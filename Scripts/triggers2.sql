select * from Sesion
select * from SesionxMascota

ALTER TRIGGER dbo.numMascotas
ON SesionxMascota
AFTER INSERT
AS
BEGIN
	DECLARE
		@SESIONID INT,
		@NUMMACOTA INT
	SET @SESIONID = (SELECT idSesion FROM inserted)
	SET @NUMMACOTA = (SELECT numMascotas FROM Sesion WHERE idSesion = @SESIONID)
	IF(@NUMMACOTA IS NULL)
	BEGIN
		SET @NUMMACOTA = 1
		UPDATE Sesion SET numMascotas = @NUMMACOTA, estado = 'Creado' WHERE idSesion = @SESIONID
	END
	IF(@NUMMACOTA = 6)
	BEGIN
		UPDATE Sesion SET estado = 'Llenado' WHERE idSesion = @SESIONID
	END
	IF(@NUMMACOTA > 6)
	BEGIN
		ROLLBACK
	END
	IF(@NUMMACOTA > 1 AND  @NUMMACOTA < 6)
	BEGIN
		SET @NUMMACOTA = @NUMMACOTA + 1
		UPDATE Sesion SET numMascotas = @NUMMACOTA WHERE idSesion = @SESIONID
	END
END

select * from Cliente
select * from Lugar
drop table Sesion

SELECT * FROM Sesion
delete Sesion where idSesion = 2