USE [PoolDB]
GO

/****** Object:  Table [dbo].[People]    Script Date: 07/08/2026 08:08:10 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[People](
	[PersonID] [int] IDENTITY(1,1) NOT NULL,
	[NationalNo] [nvarchar](20) NOT NULL,
	[FirstName] [nvarchar](20) NOT NULL,
	[SecondName] [nvarchar](20) NOT NULL,
	[ThirdName] [nvarchar](20) NULL,
	[LastName] [nvarchar](20) NOT NULL,
	[DateOfBirth] [datetime] NOT NULL,
	[Gender] [tinyint] NOT NULL,
	[Address] [nvarchar](500) NOT NULL,
	[Phone] [nvarchar](20) NOT NULL,
	[Email] [nvarchar](50) NULL,
	[ImagePath] [nvarchar](250) NULL,
 CONSTRAINT [PK_People] PRIMARY KEY CLUSTERED 
(
	[PersonID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ_People_NationalNo] UNIQUE NONCLUSTERED 
(
	[NationalNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'0 : Male 1: Female' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'People', @level2type=N'COLUMN',@level2name=N'Gender'
GO


