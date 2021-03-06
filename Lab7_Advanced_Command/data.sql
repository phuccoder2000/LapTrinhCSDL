CREATE DATABASE [RestaurantManagement]
GO
USE [RestaurantManagement]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 6/4/2020 9:31:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[AccountName] [nvarchar](100) NOT NULL,
	[Password] [nvarchar](200) NOT NULL,
	[FullName] [nvarchar](1000) NOT NULL,
	[Email] [nvarchar](1000) NULL,
	[Tell] [nvarchar](200) NULL,
	[DateCreated] [smalldatetime] NULL,
 CONSTRAINT [PK_Account_1] PRIMARY KEY CLUSTERED 
(
	[AccountName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BillDetails]    Script Date: 6/4/2020 9:31:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BillDetails](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[InvoiceID] [int] NOT NULL,
	[FoodID] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
 CONSTRAINT [PK_InvoiceInfo] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bills]    Script Date: 6/4/2020 9:31:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bills](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](1000) NOT NULL,
	[TableID] [int] NOT NULL,
	[Amount] [int] NOT NULL,
	[Discount] [float] NULL,
	[Tax] [float] NULL,
	[Status] [bit] NOT NULL,
	[CheckoutDate] [smalldatetime] NULL,
	[Account] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Invoice] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 6/4/2020 9:31:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](1000) NOT NULL,
	[Type] [int] NOT NULL,
 CONSTRAINT [PK_FoodCategory] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Food]    Script Date: 6/4/2020 9:31:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Food](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](1000) NOT NULL,
	[Unit] [nvarchar](100) NOT NULL,
	[FoodCategoryID] [int] NOT NULL,
	[Price] [int] NOT NULL,
	[Notes] [nvarchar](3000) NULL,
 CONSTRAINT [PK_FoodStuffs] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 6/4/2020 9:31:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[RoleName] [nvarchar](1000) NOT NULL,
	[Path] [nvarchar](3000) NULL,
	[Notes] [nvarchar](3000) NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RoleAccount]    Script Date: 6/4/2020 9:31:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RoleAccount](
	[RoleID] [int] NOT NULL,
	[AccountName] [nvarchar](100) NOT NULL,
	[Actived] [bit] NOT NULL,
	[Notes] [nvarchar](3000) NULL,
 CONSTRAINT [PK_RoleAccount] PRIMARY KEY CLUSTERED 
(
	[RoleID] ASC,
	[AccountName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Table]    Script Date: 6/4/2020 9:31:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Table](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](1000) NULL,
	[Status] [int] NOT NULL,
	[Capacity] [int] NULL,
 CONSTRAINT [PK_Table] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Account] ([AccountName], [Password], [FullName], [Email], [Tell], [DateCreated]) VALUES (N'lgcong', N'legiacong', N'L?? Gia C??ng', N'conglg@dlu.edu.vn', NULL, NULL)
INSERT [dbo].[Account] ([AccountName], [Password], [FullName], [Email], [Tell], [DateCreated]) VALUES (N'pttnga', N'phanthithanhnga', N'Phan Th??? Thanh Nga', N'ngaptt@dlu.edu.vn', NULL, CAST(N'2020-06-04T00:00:00' AS SmallDateTime))
INSERT [dbo].[Account] ([AccountName], [Password], [FullName], [Email], [Tell], [DateCreated]) VALUES (N'tdquy', N'thaiduyquy', N'Th??i Duy Qu??', N'quytd@dlu.edu.vn', NULL, NULL)
INSERT [dbo].[Account] ([AccountName], [Password], [FullName], [Email], [Tell], [DateCreated]) VALUES (N'ttplinh', N'tranthiphuonglinh', N'Tr???n Th??? Ph????ng Linh', N'linhttp@dlu.edu.vn', NULL, NULL)
SET IDENTITY_INSERT [dbo].[BillDetails] ON 

INSERT [dbo].[BillDetails] ([ID], [InvoiceID], [FoodID], [Quantity]) VALUES (1, 1, 3, 2)
INSERT [dbo].[BillDetails] ([ID], [InvoiceID], [FoodID], [Quantity]) VALUES (2, 1, 4, 1)
SET IDENTITY_INSERT [dbo].[BillDetails] OFF
SET IDENTITY_INSERT [dbo].[Bills] ON 

INSERT [dbo].[Bills] ([ID], [Name], [TableID], [Amount], [Discount], [Tax], [Status], [CheckoutDate], [Account]) VALUES (1, N'H??a ????n thanh to??n', 5, 150000, 0.05, 0, 1, NULL, N'tdquy')
SET IDENTITY_INSERT [dbo].[Bills] OFF
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([ID], [Name], [Type]) VALUES (1, N'Khai v???', 1)
INSERT [dbo].[Category] ([ID], [Name], [Type]) VALUES (2, N'H???i s???n', 1)
INSERT [dbo].[Category] ([ID], [Name], [Type]) VALUES (3, N'G??', 1)
INSERT [dbo].[Category] ([ID], [Name], [Type]) VALUES (4, N'C??m', 1)
INSERT [dbo].[Category] ([ID], [Name], [Type]) VALUES (5, N'Th???t', 1)
INSERT [dbo].[Category] ([ID], [Name], [Type]) VALUES (6, N'Rau', 1)
INSERT [dbo].[Category] ([ID], [Name], [Type]) VALUES (8, N'Canh', 1)
INSERT [dbo].[Category] ([ID], [Name], [Type]) VALUES (9, N'L???u', 1)
INSERT [dbo].[Category] ([ID], [Name], [Type]) VALUES (10, N'Bia', 0)
INSERT [dbo].[Category] ([ID], [Name], [Type]) VALUES (11, N'N?????c ng???t', 0)
INSERT [dbo].[Category] ([ID], [Name], [Type]) VALUES (12, N'C?? ph??', 0)
INSERT [dbo].[Category] ([ID], [Name], [Type]) VALUES (13, N'Tr?? ????', 0)
SET IDENTITY_INSERT [dbo].[Category] OFF
SET IDENTITY_INSERT [dbo].[Food] ON 

INSERT [dbo].[Food] ([ID], [Name], [Unit], [FoodCategoryID], [Price], [Notes]) VALUES (1, N'Rau mu???ng x??o t???i', N'????a', 6, 20000, NULL)
INSERT [dbo].[Food] ([ID], [Name], [Unit], [FoodCategoryID], [Price], [Notes]) VALUES (2, N'C??m chi??n D????ng ch??u', N'????a nh???', 4, 35000, N'3 ng?????i ??n')
INSERT [dbo].[Food] ([ID], [Name], [Unit], [FoodCategoryID], [Price], [Notes]) VALUES (3, N'C??m chi??n D????ng ch??u', N'????a l???n', 4, 40000, N'4 ng?????i ??n')
INSERT [dbo].[Food] ([ID], [Name], [Unit], [FoodCategoryID], [Price], [Notes]) VALUES (4, N'???ch thui r??m', N'????a', 2, 70000, NULL)
INSERT [dbo].[Food] ([ID], [Name], [Unit], [FoodCategoryID], [Price], [Notes]) VALUES (5, N'S?? l??ng n?????ng m??? h??nh', N'????a', 2, 80000, NULL)
INSERT [dbo].[Food] ([ID], [Name], [Unit], [FoodCategoryID], [Price], [Notes]) VALUES (6, N'C??ng cua h???p', N'????a', 2, 100000, NULL)
INSERT [dbo].[Food] ([ID], [Name], [Unit], [FoodCategoryID], [Price], [Notes]) VALUES (7, N'Canh c???i', N'T??', 8, 20000, NULL)
INSERT [dbo].[Food] ([ID], [Name], [Unit], [FoodCategoryID], [Price], [Notes]) VALUES (8, N'G?? n?????ng mu???i ???t', N'Con', 3, 180000, NULL)
INSERT [dbo].[Food] ([ID], [Name], [Unit], [FoodCategoryID], [Price], [Notes]) VALUES (9, N'Bia 333', N'Chai', 10, 12000, NULL)
INSERT [dbo].[Food] ([ID], [Name], [Unit], [FoodCategoryID], [Price], [Notes]) VALUES (10, N'Bia Heniken', N'Chai', 10, 20000, NULL)
INSERT [dbo].[Food] ([ID], [Name], [Unit], [FoodCategoryID], [Price], [Notes]) VALUES (11, N'S??p cua', N'T??', 1, 15000, NULL)
INSERT [dbo].[Food] ([ID], [Name], [Unit], [FoodCategoryID], [Price], [Notes]) VALUES (12, N'Th???t kho', N'????a', 5, 25000, N'Theo th???i gi??')
SET IDENTITY_INSERT [dbo].[Food] OFF
SET IDENTITY_INSERT [dbo].[Role] ON 

INSERT [dbo].[Role] ([ID], [RoleName], [Path], [Notes]) VALUES (1, N'Adminstrator', NULL, NULL)
INSERT [dbo].[Role] ([ID], [RoleName], [Path], [Notes]) VALUES (2, N'K??? to??n', NULL, NULL)
INSERT [dbo].[Role] ([ID], [RoleName], [Path], [Notes]) VALUES (3, N'Nh??n vi??n thanh to??n', NULL, NULL)
INSERT [dbo].[Role] ([ID], [RoleName], [Path], [Notes]) VALUES (4, N'Nh??n vi??n ph???c v???', NULL, NULL)
SET IDENTITY_INSERT [dbo].[Role] OFF
INSERT [dbo].[RoleAccount] ([RoleID], [AccountName], [Actived], [Notes]) VALUES (1, N'lgcong', 1, NULL)
INSERT [dbo].[RoleAccount] ([RoleID], [AccountName], [Actived], [Notes]) VALUES (1, N'pttnga', 1, NULL)
INSERT [dbo].[RoleAccount] ([RoleID], [AccountName], [Actived], [Notes]) VALUES (1, N'tdquy', 1, NULL)
INSERT [dbo].[RoleAccount] ([RoleID], [AccountName], [Actived], [Notes]) VALUES (1, N'ttplinh', 1, NULL)
INSERT [dbo].[RoleAccount] ([RoleID], [AccountName], [Actived], [Notes]) VALUES (3, N'lgcong', 0, NULL)
INSERT [dbo].[RoleAccount] ([RoleID], [AccountName], [Actived], [Notes]) VALUES (3, N'pttnga', 0, NULL)
INSERT [dbo].[RoleAccount] ([RoleID], [AccountName], [Actived], [Notes]) VALUES (3, N'tdquy', 1, NULL)
INSERT [dbo].[RoleAccount] ([RoleID], [AccountName], [Actived], [Notes]) VALUES (3, N'ttplinh', 1, NULL)
SET IDENTITY_INSERT [dbo].[Table] ON 

INSERT [dbo].[Table] ([ID], [Name], [Status], [Capacity]) VALUES (1, N'01', 0, 4)
INSERT [dbo].[Table] ([ID], [Name], [Status], [Capacity]) VALUES (2, N'02', 0, 4)
INSERT [dbo].[Table] ([ID], [Name], [Status], [Capacity]) VALUES (4, N'03', 0, 4)
INSERT [dbo].[Table] ([ID], [Name], [Status], [Capacity]) VALUES (5, N'04', 0, 6)
INSERT [dbo].[Table] ([ID], [Name], [Status], [Capacity]) VALUES (6, N'05', 0, 8)
INSERT [dbo].[Table] ([ID], [Name], [Status], [Capacity]) VALUES (8, N'06', 0, 8)
INSERT [dbo].[Table] ([ID], [Name], [Status], [Capacity]) VALUES (1002, N'07', 0, 8)
INSERT [dbo].[Table] ([ID], [Name], [Status], [Capacity]) VALUES (1003, N'08', 0, 12)
INSERT [dbo].[Table] ([ID], [Name], [Status], [Capacity]) VALUES (1004, N'09', 0, 12)
INSERT [dbo].[Table] ([ID], [Name], [Status], [Capacity]) VALUES (1005, N'10', 0, 15)
INSERT [dbo].[Table] ([ID], [Name], [Status], [Capacity]) VALUES (1006, N'VIP.1', 0, 20)
INSERT [dbo].[Table] ([ID], [Name], [Status], [Capacity]) VALUES (1007, N'VIP.2', 0, 20)
INSERT [dbo].[Table] ([ID], [Name], [Status], [Capacity]) VALUES (1008, N'VIP.3', 0, 10)
SET IDENTITY_INSERT [dbo].[Table] OFF
ALTER TABLE [dbo].[BillDetails] ADD  CONSTRAINT [DF_InvoiceDetails_Amount]  DEFAULT ((0)) FOR [Quantity]
GO
ALTER TABLE [dbo].[Food] ADD  CONSTRAINT [DF_Food_Price]  DEFAULT ((0)) FOR [Price]
GO
ALTER TABLE [dbo].[BillDetails]  WITH CHECK ADD  CONSTRAINT [FK_InvoiceInfo_FoodStuffs] FOREIGN KEY([FoodID])
REFERENCES [dbo].[Food] ([ID])
GO
ALTER TABLE [dbo].[BillDetails] CHECK CONSTRAINT [FK_InvoiceInfo_FoodStuffs]
GO
ALTER TABLE [dbo].[BillDetails]  WITH CHECK ADD  CONSTRAINT [FK_InvoiceInfo_Invoice] FOREIGN KEY([InvoiceID])
REFERENCES [dbo].[Bills] ([ID])
GO
ALTER TABLE [dbo].[BillDetails] CHECK CONSTRAINT [FK_InvoiceInfo_Invoice]
GO
ALTER TABLE [dbo].[Bills]  WITH CHECK ADD  CONSTRAINT [FK_Invoice_Table] FOREIGN KEY([TableID])
REFERENCES [dbo].[Table] ([ID])
GO
ALTER TABLE [dbo].[Bills] CHECK CONSTRAINT [FK_Invoice_Table]
GO
ALTER TABLE [dbo].[Food]  WITH CHECK ADD  CONSTRAINT [FK_FoodStuffs_FoodCategory] FOREIGN KEY([FoodCategoryID])
REFERENCES [dbo].[Category] ([ID])
GO
ALTER TABLE [dbo].[Food] CHECK CONSTRAINT [FK_FoodStuffs_FoodCategory]
GO
ALTER TABLE [dbo].[RoleAccount]  WITH CHECK ADD  CONSTRAINT [FK_RoleAccount_Account] FOREIGN KEY([AccountName])
REFERENCES [dbo].[Account] ([AccountName])
GO
ALTER TABLE [dbo].[RoleAccount] CHECK CONSTRAINT [FK_RoleAccount_Account]
GO
ALTER TABLE [dbo].[RoleAccount]  WITH CHECK ADD  CONSTRAINT [FK_RoleAccount_Role] FOREIGN KEY([RoleID])
REFERENCES [dbo].[Role] ([ID])
GO
ALTER TABLE [dbo].[RoleAccount] CHECK CONSTRAINT [FK_RoleAccount_Role]
GO


CREATE PROCEDURE InsertFood
@ID int output,
@Name nvarchar(3000), 
@Unit nvarchar(3000), 
@FoodCategoryID int, 
@Price int,  
@Notes nvarchar(3000)
AS
	INSERT INTO Food (Name, Unit, FoodCategoryID, Price,  Notes)
	VALUES ( @Name, @Unit, @FoodCategoryID, @Price,  @Notes)

	SELECT @ID = SCOPE_IDENTITY()

go

select f.Name, f.Price, bd.Quantity, f.Price * bd.Quantity as Amount from Food f, BillDetails bd, Bills b
where bd.FoodID = f.ID and bd.InvoiceID = b.ID and bd.InvoiceID = 1

select sum(f.Price * bd.Quantity) from Food f, BillDetails bd, Bills b
where bd.FoodID = f.ID and bd.InvoiceID = b.ID and bd.InvoiceID = 1

go
UPDATE Bills SET CheckoutDate = GETDATE() WHERE ID = 1
go
INSERT [dbo].[Bills] ([Name], [TableID], [Amount], [Discount], [Tax], [Status], [CheckoutDate], [Account]) VALUES (N'H??a ????n thanh to??n', 5, 150000, 0.05, 0, 1, GETDATE() - 2, N'pttnga')
--select * from Bills where CheckoutDate between '@datefrom' and '@dateto'
go
create proc USP_InsertFood
@ID int output,
@Name nvarchar(100),
@Unit nvarchar(100),
@FoodCategoryId int,
@Price nvarchar(100),
@Notes nvarchar(100)
as
begin
	insert into Food(Name,Unit,FoodCategoryID,Price,Notes) values (@Name,@Unit,@FoodCategoryId,@Price,@Notes)

	select @ID = SCOPE_IDENTITY();
end
go

select * From Category

go
create proc UpdateFood
@ID int,
@Name nvarchar(100),
@Unit nvarchar(100),
@FoodCategoryId int,
@Price nvarchar(100),
@Notes nvarchar(100)
as
update Food set	Name = @Name , Unit = @Unit , FoodCategoryID = @FoodCategoryId , Price = @Price , Notes = @Notes
where ID = @ID
if	@@error <> 0
return 0
else
return 1
go