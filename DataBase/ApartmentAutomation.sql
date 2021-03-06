USE [ApartmentAutomation]
GO
/****** Object:  Table [dbo].[Expenses]    Script Date: 8.1.2019 14:18:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Expenses](
	[ExpenseID] [int] IDENTITY(1,1) NOT NULL,
	[Date] [date] NOT NULL,
	[Amount] [decimal](18, 2) NOT NULL,
	[ExpenseType] [int] NULL,
 CONSTRAINT [PK_Expenses] PRIMARY KEY CLUSTERED 
(
	[ExpenseID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ExpenseTypes]    Script Date: 8.1.2019 14:18:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ExpenseTypes](
	[TypeID] [int] IDENTITY(1,1) NOT NULL,
	[TypeName] [nvarchar](50) NULL,
 CONSTRAINT [PK_ExpenseTypes] PRIMARY KEY CLUSTERED 
(
	[TypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Incomes]    Script Date: 8.1.2019 14:18:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Incomes](
	[IncomeID] [int] IDENTITY(1,1) NOT NULL,
	[Amount] [decimal](18, 2) NOT NULL,
	[Date] [date] NOT NULL,
	[RoomNo] [int] NOT NULL,
 CONSTRAINT [PK_Gelirler] PRIMARY KEY CLUSTERED 
(
	[IncomeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rooms]    Script Date: 8.1.2019 14:18:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rooms](
	[RoomID] [int] IDENTITY(1,1) NOT NULL,
	[Floor] [int] NOT NULL,
	[RoomOwner] [nvarchar](50) NULL,
 CONSTRAINT [PK_Daireler] PRIMARY KEY CLUSTERED 
(
	[RoomID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Expenses] ON 

INSERT [dbo].[Expenses] ([ExpenseID], [Date], [Amount], [ExpenseType]) VALUES (1, CAST(N'2019-01-08' AS Date), CAST(50.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[Expenses] ([ExpenseID], [Date], [Amount], [ExpenseType]) VALUES (2, CAST(N'2019-01-23' AS Date), CAST(25.00 AS Decimal(18, 2)), 3)
INSERT [dbo].[Expenses] ([ExpenseID], [Date], [Amount], [ExpenseType]) VALUES (3, CAST(N'2019-01-16' AS Date), CAST(25.00 AS Decimal(18, 2)), 2)
SET IDENTITY_INSERT [dbo].[Expenses] OFF
SET IDENTITY_INSERT [dbo].[ExpenseTypes] ON 

INSERT [dbo].[ExpenseTypes] ([TypeID], [TypeName]) VALUES (1, N'Elektrik')
INSERT [dbo].[ExpenseTypes] ([TypeID], [TypeName]) VALUES (2, N'Su')
INSERT [dbo].[ExpenseTypes] ([TypeID], [TypeName]) VALUES (3, N'Asansör')
INSERT [dbo].[ExpenseTypes] ([TypeID], [TypeName]) VALUES (4, N'Temizlik')
SET IDENTITY_INSERT [dbo].[ExpenseTypes] OFF
SET IDENTITY_INSERT [dbo].[Incomes] ON 

INSERT [dbo].[Incomes] ([IncomeID], [Amount], [Date], [RoomNo]) VALUES (2, CAST(120.00 AS Decimal(18, 2)), CAST(N'2019-01-08' AS Date), 1)
INSERT [dbo].[Incomes] ([IncomeID], [Amount], [Date], [RoomNo]) VALUES (3, CAST(300.00 AS Decimal(18, 2)), CAST(N'2019-01-16' AS Date), 7)
SET IDENTITY_INSERT [dbo].[Incomes] OFF
SET IDENTITY_INSERT [dbo].[Rooms] ON 

INSERT [dbo].[Rooms] ([RoomID], [Floor], [RoomOwner]) VALUES (1, 1, NULL)
INSERT [dbo].[Rooms] ([RoomID], [Floor], [RoomOwner]) VALUES (2, 1, NULL)
INSERT [dbo].[Rooms] ([RoomID], [Floor], [RoomOwner]) VALUES (3, 1, NULL)
INSERT [dbo].[Rooms] ([RoomID], [Floor], [RoomOwner]) VALUES (4, 1, NULL)
INSERT [dbo].[Rooms] ([RoomID], [Floor], [RoomOwner]) VALUES (5, 2, NULL)
INSERT [dbo].[Rooms] ([RoomID], [Floor], [RoomOwner]) VALUES (6, 2, NULL)
INSERT [dbo].[Rooms] ([RoomID], [Floor], [RoomOwner]) VALUES (7, 2, NULL)
INSERT [dbo].[Rooms] ([RoomID], [Floor], [RoomOwner]) VALUES (8, 2, NULL)
INSERT [dbo].[Rooms] ([RoomID], [Floor], [RoomOwner]) VALUES (9, 3, NULL)
INSERT [dbo].[Rooms] ([RoomID], [Floor], [RoomOwner]) VALUES (10, 3, NULL)
INSERT [dbo].[Rooms] ([RoomID], [Floor], [RoomOwner]) VALUES (11, 3, NULL)
INSERT [dbo].[Rooms] ([RoomID], [Floor], [RoomOwner]) VALUES (12, 3, NULL)
SET IDENTITY_INSERT [dbo].[Rooms] OFF
ALTER TABLE [dbo].[Expenses] ADD  CONSTRAINT [DF_Expenses_Date]  DEFAULT (getdate()) FOR [Date]
GO
ALTER TABLE [dbo].[Incomes] ADD  CONSTRAINT [DF_Gelirler_Tarih]  DEFAULT (getdate()) FOR [Date]
GO
ALTER TABLE [dbo].[Expenses]  WITH CHECK ADD  CONSTRAINT [FK_Expenses_ExpenseTypes] FOREIGN KEY([ExpenseType])
REFERENCES [dbo].[ExpenseTypes] ([TypeID])
GO
ALTER TABLE [dbo].[Expenses] CHECK CONSTRAINT [FK_Expenses_ExpenseTypes]
GO
ALTER TABLE [dbo].[Incomes]  WITH CHECK ADD  CONSTRAINT [FK_Incomes_Rooms] FOREIGN KEY([RoomNo])
REFERENCES [dbo].[Rooms] ([RoomID])
GO
ALTER TABLE [dbo].[Incomes] CHECK CONSTRAINT [FK_Incomes_Rooms]
GO
