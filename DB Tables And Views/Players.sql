USE [PoolDB]
GO

/****** Object:  Table [dbo].[Players]    Script Date: 07/08/2026 08:08:43 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Players](
	[PlayerID] [int] IDENTITY(1,1) NOT NULL,
	[PersonID] [int] NOT NULL,
	[DateOfJoin] [date] NOT NULL,
	[CreatedByUserID] [int] NOT NULL,
	[IsActive] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[PlayerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Players] ADD  DEFAULT (getdate()) FOR [DateOfJoin]
GO

ALTER TABLE [dbo].[Players] ADD  DEFAULT ((1)) FOR [IsActive]
GO

ALTER TABLE [dbo].[Players]  WITH CHECK ADD  CONSTRAINT [FK_Players_People] FOREIGN KEY([PersonID])
REFERENCES [dbo].[People] ([PersonID])
GO

ALTER TABLE [dbo].[Players] CHECK CONSTRAINT [FK_Players_People]
GO

ALTER TABLE [dbo].[Players]  WITH CHECK ADD  CONSTRAINT [FK_Players_Users] FOREIGN KEY([CreatedByUserID])
REFERENCES [dbo].[Users] ([UserID])
GO

ALTER TABLE [dbo].[Players] CHECK CONSTRAINT [FK_Players_Users]
GO


