
GO
CREATE PROCEDURE SP_AddNewPlayer
		@NewPlayerID int output,
		@PersonID int,
		@DateOfJoin DateTime,
		@CreatedByUserID int
AS
BEGIN
		INSERT INTO Players(PersonID,DateOfJoin,CreatedByUserID)
		Values (@PersonID,@DateOfJoin,@CreatedByUserID)
		SET @NewPlayerID = CAST(SCOPE_IDENTITY() AS INT)
END;
GO
CREATE PROCEDURE SP_GetPlayerInfoByID
	@PlayerID INT
AS
Begin
	Select *
	From Players P
	inner join People ppl 
	on p.PersonID = ppl.PersonID
	Where p.PlayerID = @PlayerID
END; 
GO
CREATE PROCEDURE SP_GetPlayerInfoByPersonID
	@PersonID INT
AS
Begin
	Select *
	From Players P
	inner join People ppl 
	on p.PersonID = ppl.PersonID
	Where p.PersonID = @PersonID
END; 

GO
CREATE PROCEDURE SP_IsPersonPlayer
	@PersonID INT
AS
BEGIN
		if exists(	SELECT 1 FROM Players WHere  PersonID =@PersonID)
		BEGIN
			return 1
		END

		ELSE
		BEGIN
			RETURN 0
		END

END; 

GO
CREATE PROCEDURE SP_IsPlayerExists
		@PlayerID int
AS
BEGIN
		if exists(	SELECT 1 FROM Players WHere  PlayerID =@PlayerID)
		BEGIN
			return 1
		END

		ELSE
		BEGIN
			RETURN 0
		END
END;
 --
GO
CREATE PROCEDURE SP_DeletePlayer
		@PlayerID INT
AS
BEGIN
	DELETE FROM Players Where PlayerID = @PlayerID
END; 
GO
---تفاصيل اللاعب وسجل الحجوزات بتاعته لما يضغط عرض تفاصيل اللاعب فوق هيبقى كرت اللاعب وتحت التفاصيل دي
CREATE PROCEDURE SP_GetPlayerPayments
	@PlayerID INT
AS
BEGIN
	SELECT pys.PaymentID,
		   pys.DateOfPayment,
		   T.TableNumber,
		   T.PaymentPerHour,
		   
		    CASE
			
			WHEN pys.EndTime IS NULL 
			THEN DATEDIFF(MINUTE, pys.StartTime, GETDATE()) / 60.0
			ELSE DATEDIFF( MINUTE, pys.StartTime, pys.EndTime) / 60.0
				 
			 END AS TimePlayed,
			 pys.Fees
			 
		   

	FROM
	Players P
	inner join Payments pys
	ON pys.PlayerID =p.PlayerID
	inner join PoolTables T
	ON pys.TableID =T.TableID
	Where P.PlayerID =@PlayerID


END;

GO
CREATE PROCEDURE SP_GetAllPlayers
AS
BEGIN
	SELECT * FROm PlayersView
END;