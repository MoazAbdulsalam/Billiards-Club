USE [PoolDB]
GO

/****** Object:  View [dbo].[PoolTable_View]    Script Date: 07/08/2026 08:10:32 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[PoolTable_View] AS
SELECT TableNumber,PaymentPerHour,
CASE 
	WHEN Exists (
	SELECT 1 from Payments Where Payments.TableID =PoolTables.TableID
	AND Payments.EndTime IS Null
	) then CAST(0 AS BIT)
	else CAST(1 AS BIT)
	end AS IsAvailable
From PoolTables

  
GO


