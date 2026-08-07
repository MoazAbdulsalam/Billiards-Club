USE [PoolDB]
GO

/****** Object:  Table [dbo].[Payments]    Script Date: 07/08/2026 08:06:33 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Payments](
	[PaymentID] [int] IDENTITY(1,1) NOT NULL,
	[PlayerID] [int] NOT NULL,
	[TableID] [int] NOT NULL,
	[StartTime] [datetime] NOT NULL,
	[EndTime] [datetime] NULL,
	[DateOfPayment] [datetime] NOT NULL,
	[CreatedByUserID] [int] NOT NULL,
	[Fees] [decimal](10, 2) NOT NULL,
 CONSTRAINT [PK__Payments__9B556A5837344B23] PRIMARY KEY CLUSTERED 
(
	[PaymentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Payments] ADD  CONSTRAINT [DF__Payments__DateOf__49C3F6B7]  DEFAULT (getdate()) FOR [DateOfPayment]
GO

ALTER TABLE [dbo].[Payments]  WITH CHECK ADD  CONSTRAINT [FK_Payments_Players] FOREIGN KEY([PlayerID])
REFERENCES [dbo].[Players] ([PlayerID])
GO

ALTER TABLE [dbo].[Payments] CHECK CONSTRAINT [FK_Payments_Players]
GO

ALTER TABLE [dbo].[Payments]  WITH CHECK ADD  CONSTRAINT [FK_Payments_Tables] FOREIGN KEY([TableID])
REFERENCES [dbo].[PoolTables] ([TableID])
GO

ALTER TABLE [dbo].[Payments] CHECK CONSTRAINT [FK_Payments_Tables]
GO

ALTER TABLE [dbo].[Payments]  WITH CHECK ADD  CONSTRAINT [FK_Payments_Users] FOREIGN KEY([CreatedByUserID])
REFERENCES [dbo].[Users] ([UserID])
GO

ALTER TABLE [dbo].[Payments] CHECK CONSTRAINT [FK_Payments_Users]
GO


