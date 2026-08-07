
GO
ALTER PROCEDURE SP_AddNewPlayer
		@NewPlayerID int output,
		@PersonID int,
		@DateOfJoin DateTime,
		@CreatedByUserID int
AS
BEGIN
		INSERT INTO Players(PersonID,DateOfJoin,CreatedByUserID,IsActive)
		Values (@PersonID,@DateOfJoin,@CreatedByUserID,1)
		SET @NewPlayerID = CAST(SCOPE_IDENTITY() AS INT)
END;

GO
ALTER PROCEDURE SP_GetPlayerInfoByID
	@PlayerID INT
AS
Begin
	Select *
	From Players P
	inner join People ppl 
	on p.PersonID = ppl.PersonID
	Where p.PlayerID = @PlayerID
	and IsActive = 1;
END; 
GO
ALTER PROCEDURE SP_GetPlayerInfoByPersonID
	@PersonID INT
AS
Begin
	Select *
	From Players P
	inner join People ppl 
	on p.PersonID = ppl.PersonID
	Where p.PersonID = @PersonID
	and IsActive = 1;
END; 

GO
ALTER PROCEDURE SP_IsPersonPlayer
	@PersonID INT
AS
BEGIN
		if exists(	SELECT 1 FROM Players WHere  PersonID =@PersonID )
		BEGIN
			return 1
		END

		ELSE
		BEGIN
			RETURN 0
		END

END; 

GO
ALTER PROCEDURE SP_IsPlayerExists
		@PlayerID int
AS
BEGIN
		if exists(	SELECT 1 FROM Players WHere  PlayerID =@PlayerID AND IsActive = 1)
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
---------------------------------
CREATE PROCEDURE SP_DeletePlayer
		@PlayerID INT
AS
BEGIN
	DELETE FROM Players Where PlayerID = @PlayerID
END; 
GO
---تفاصيل اللاعب وسجل الحجوزات بتاعته لما يضغط عرض تفاصيل اللاعب فوق هيبقى كرت اللاعب وتحت التفاصيل دي
ALTER PROCEDURE SP_GetPlayerPayments
	@PlayerID INT
AS
BEGIN
	SELECT pys.PaymentID,
		   pys.DateOfPayment,
		   T.TableNumber,
		   T.PaymentPerHour,
		   
			CAST(
				CASE
					WHEN pys.EndTime IS NULL
					THEN DATEDIFF(MINUTE, pys.StartTime, GETDATE()) / 60.0
					ELSE DATEDIFF(MINUTE, pys.StartTime, pys.EndTime) / 60.0
				END
			AS DECIMAL(5,2)) AS TimePlayed,
			 pys.Fees
			 
		   

	FROM
	Players P
	inner join Payments pys
	ON pys.PlayerID =p.PlayerID
	inner join PoolTables T
	ON pys.TableID =T.TableID
	Where P.PlayerID =@PlayerID
	AND P.IsActive =1;
	


END;

GO
ALTER PROCEDURE SP_GetAllPlayers
AS
BEGIN
	SELECT V.* FROM
	PlayersView V 
	INNER JOIN Players P
	ON V.PlayerID = P.PlayerID 
	WHERE 
	P.IsActive = 1;
END;
GO
ALTER PROCEDURE SP_UpdatePlayer
    @PlayerID INT,
    @DateOfJoin DATE
AS
BEGIN
    UPDATE Players
    SET
        DateOfJoin = @DateOfJoin
    WHERE PlayerID = @PlayerID
	AND IsActive = 1;
END;

GO
ALTER PROCEDURE SP_GetPlayerStatistics
	@PlayerID INT
AS
BEGIN
	SELECT
	TotalHoursPlayed,
	TotalMoneyPaid,
	MostPlayedTable
	FROM
	PlayersView V 
	INNER JOIN Players P
	ON V.PlayerID = P.PlayerID 
	WHERE 
	V.PlayerID =@PlayerID
	AND P.IsActive = 1;

END;


GO
CREATE PROCEDURE SP_RestorePlayer
    @PlayerID INT
AS
BEGIN
    UPDATE Players
    SET IsActive = 1
    WHERE PlayerID = @PlayerID
	AND IsActive =0;
END;
GO
CREATE PROCEDURE SP_GetInactivePlayerByPersonID
    @PersonID INT
AS
BEGIN
    SELECT V.* , P.IsActive
    FROM Players P
	inner join 
	PlayersView V
	on P.PlayerID =V.PlayerID
    WHERE P.PersonID = @PersonID AND
     P.IsActive = 0;
END;

GO
CREATE PROCEDURE SP_GetInactivePlayers

AS
BEGIN
    SELECT V.* , P.IsActive
    FROM Players P
	inner join 
	PlayersView V
	on P.PlayerID =V.PlayerID
    WHERE 
     P.IsActive = 0;
END;

GO
CREATE TRIGGER  TR_Players_SoftDelete
ON Players
INSTEAD OF DELETE
AS
BEGIN
	Update Players
	SET IsActive =0
	From Players P inner join deleted d
	on P.PlayerID =d.PlayerID
END;


