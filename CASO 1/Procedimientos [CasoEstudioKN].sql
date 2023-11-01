USE [CasoEstudioKN]
GO

CREATE PROCEDURE [dbo].[ConsultarMovimientos_SP]

AS
BEGIN

	SELECT	M.Fecha,
			M.Monto,
			T.DescripcionTipoMovimiento,
			M.Descripcion
	FROM		dbo.Movimientos M
	INNER JOIN	dbo.TiposMovimientos T ON M.TipoMovimiento = T.TipoMovimiento

END
GO

CREATE PROCEDURE [dbo].[RegistrarMovimientos_SP]
	@Descripcion	VARCHAR(255),
	@Monto			DECIMAL(10,2),
	@TipoMovimiento	INT
AS
BEGIN

	DECLARE @ingresos DECIMAL(10,2),
			@egresos  DECIMAL(10,2)

	SELECT @ingresos = SUM(Monto)
	FROM Movimientos WHERE TipoMovimiento = 1

	SELECT @egresos = SUM(Monto)
	FROM Movimientos WHERE TipoMovimiento = 2

	IF(@TipoMovimiento = 2)
	BEGIN
		
		IF(@Monto <= (@ingresos - @egresos))
		BEGIN
			INSERT INTO dbo.Movimientos (Descripcion,Fecha,Monto,TipoMovimiento)
			VALUES (@Descripcion,GETDATE(),@Monto,@TipoMovimiento)
		END

	END
	ELSE BEGIN

		INSERT INTO dbo.Movimientos (Descripcion,Fecha,Monto,TipoMovimiento)
		VALUES (@Descripcion,GETDATE(),@Monto,@TipoMovimiento)
		
	END

END
GO
