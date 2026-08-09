

Use PoolDB;
GO
CREATE VIEW PoolTablesStatusView AS
	SELECT 
		T.TableID,T.TableNumber,T.PaymentPerHour,
		CASE 
			  WHEN Py.PaymentID IS NULL
			  then CAST(1 AS BIT)
			  else 
			  CAST(0 AS BIT)
			  end AS IsAvailable,
		Py.PaymentID AS CurrentPaymentID ,
		Py.PlayerID	 AS CurrentPlayerID,
		Pv.FullName  AS CurrentPlayerName,
		Py.StartTime
	From 
	PoolTables T
	Left  Join Payments Py
	On
	Py.TableID =T.TableID
	AND Py.EndTime IS NULL
	Left join PlayersView Pv
	on
	Py.PlayerID = Pv.PlayerID
GO
CREATE PROCEDURE SP_GetAllPoolTablesStatus
AS
BEGIN
  Select * From PoolTablesStatusView
END;

GO
CREATE PROCEDURE SP_GetPoolTableStatusByID
	@TableID INT
AS
BEGIN
  Select * From PoolTablesStatusView
	Where TableID =@TableID
END;
GO
CREATE PROCEDURE SP_GetPoolTableByID
		@TableID INT

AS
BEGIN 
	SELECT * FROM PoolTables Where TableID = @TableID
END;
GO
CREATE PROCEDURE SP_AddNewPoolTable
		@TableNumber INT,
		@PaymentPerHour decimal(10,2),
		@NewTableID INT OUTPUT
AS
BEGIN
	INSERT INTO PoolTables(TableNumber,PaymentPerHour)
	Values(@TableNumber,@PaymentPerHour)
	SET @NewTableID = CAST(SCOPE_IDENTITY() AS INT);
END;
GO 
CREATE PROCEDURE SP_UpdatePoolTable
		@TableNumber INT,
		@PaymentPerHour decimal,
		@TableID INT
AS
BEGIN
	Update PoolTables 
	SET 
	PaymentPerHour =@PaymentPerHour,
	TableNumber =@TableNumber
	Where TableID=@TableID;
END;
GO
CREATE PROCEDURE SP_GetAllPoolTables
AS
BEGIN
	SELECT * FROM PoolTables
END;
GO
Alter PROCEDURE SP_StartSession
	@PlayerID INT,
	@TableID INT,
	@CreatedByUserID INT,
	@NewPaymentID INT
AS
BEGIN
	
	IF EXISTS (
	SELECT 1 FROM Payments Where TableID =@TableID AND EndTime IS NULL 
	)
	BEGIN
		RETURN
	END


	INSERT INTO Payments (PlayerID,TableID,StartTime,EndTime,DateOfPayment,CreatedByUserID,Fees)
	Values(@PlayerID,@TableID,GETDATE(),null,null,@CreatedByUserID,null)
	set @NewPaymentID = cAST(Scope_Identity() AS INT);
END;

GO
CREATE PROCEDURE SP_EndSession
		@PaymentID INT,
		@Fees decimal(10,2)
AS
BEGIN
	Update Payments
	Set
	EndTime =GETDATE(),
	DateOfPayment =GetDate(),
	Fees =@Fees
	WHERE PaymentID =@PaymentID
	AND EndTime IS NULL
END;



