USE [PoolDB]
GO

/****** Object:  View [dbo].[PlayersView]    Script Date: 07/08/2026 08:09:49 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE View [dbo].[PlayersView] AS
Select 
 People.PersonID, Players.PlayerID,
 People.FirstName + 
 ' ' + People.SecondName + 
 ' ' + ISNULL(People.ThirdName, '') 
 + ' ' + People.LastName
 AS FullName,Players.DateOfJoin,
 SUM(
    CASE 
        WHEN Payments.EndTime IS NULL 
        THEN 0
        ELSE DATEDIFF(
                MINUTE, 
                Payments.StartTime, 
                Payments.EndTime
             ) / 60.0
    END
) AS TotalHoursPlayed,

 Sum(Payments.Fees) As TotalMoneyPaid,
 (
 Select Top 1 PoolTables.TableNumber
 From Payments inner join PoolTables on PoolTables.TableID=Payments.TableID
 Where Payments.PlayerID =Players.PlayerID
 group By PoolTables.TableNumber
 Order by Count(*) DESC
 ) AS MostPlayedTable
 
From
People inner join 
Players on 
People.PersonID =Players.PersonID
Left Join Payments on
Payments.PlayerID=Players.PlayerID
GROUP BY
    People.PersonID,
    Players.PlayerID,
    People.FirstName,
    People.SecondName,
    People.ThirdName,
    People.LastName,
    Players.DateOfJoin;
GO


