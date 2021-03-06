USE [blogpostTest]
GO
/****** Object:  Table [dbo].[comments]    Script Date: 08/06/2021 20:07:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[comments](
	[comment_Id] [int] IDENTITY(1,1) NOT NULL,
	[post_Id] [int] NOT NULL,
	[comment] [text] NOT NULL,
	[commentDate] [datetime] NOT NULL,
	[commentUsr] [int] NULL,
 CONSTRAINT [PK_comments] PRIMARY KEY CLUSTERED 
(
	[comment_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[permissionByProfile]    Script Date: 08/06/2021 20:07:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[permissionByProfile](
	[pbp_id] [int] IDENTITY(1,1) NOT NULL,
	[pbp_permId] [int] NOT NULL,
	[pbp_profId] [int] NOT NULL,
 CONSTRAINT [PK_permissionByProfile] PRIMARY KEY CLUSTERED 
(
	[pbp_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[permissions]    Script Date: 08/06/2021 20:07:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[permissions](
	[perms_id] [int] IDENTITY(1,1) NOT NULL,
	[perms_action] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_permissions] PRIMARY KEY CLUSTERED 
(
	[perms_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[posts]    Script Date: 08/06/2021 20:07:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[posts](
	[post_id] [int] IDENTITY(1,1) NOT NULL,
	[post_usrId] [int] NOT NULL,
	[post_title] [nvarchar](500) NOT NULL,
	[post_content] [text] NOT NULL,
	[post_summary] [nvarchar](500) NOT NULL,
	[post_created] [datetime] NOT NULL,
	[post_published] [datetime] NULL,
	[post_updated] [datetime] NULL,
	[post_status] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_posts] PRIMARY KEY CLUSTERED 
(
	[post_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[profiles]    Script Date: 08/06/2021 20:07:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[profiles](
	[prof_id] [int] IDENTITY(1,1) NOT NULL,
	[prof_name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_profiles] PRIMARY KEY CLUSTERED 
(
	[prof_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[users]    Script Date: 08/06/2021 20:07:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[users](
	[usr_id] [int] IDENTITY(1,1) NOT NULL,
	[usr_login] [nvarchar](50) NOT NULL,
	[usr_password] [nvarchar](250) NOT NULL,
	[usr_firstname] [nvarchar](100) NOT NULL,
	[usr_lastname] [nvarchar](100) NOT NULL,
	[usr_mobile] [nvarchar](50) NOT NULL,
	[usr_registerDate] [datetime] NOT NULL,
	[usr_profId] [int] NOT NULL,
 CONSTRAINT [PK_users] PRIMARY KEY CLUSTERED 
(
	[usr_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[permissionByProfile] ON 

INSERT [dbo].[permissionByProfile] ([pbp_id], [pbp_permId], [pbp_profId]) VALUES (1, 1, 1)
INSERT [dbo].[permissionByProfile] ([pbp_id], [pbp_permId], [pbp_profId]) VALUES (2, 1, 2)
INSERT [dbo].[permissionByProfile] ([pbp_id], [pbp_permId], [pbp_profId]) VALUES (3, 2, 1)
INSERT [dbo].[permissionByProfile] ([pbp_id], [pbp_permId], [pbp_profId]) VALUES (4, 2, 2)
INSERT [dbo].[permissionByProfile] ([pbp_id], [pbp_permId], [pbp_profId]) VALUES (5, 3, 2)
INSERT [dbo].[permissionByProfile] ([pbp_id], [pbp_permId], [pbp_profId]) VALUES (6, 4, 1)
INSERT [dbo].[permissionByProfile] ([pbp_id], [pbp_permId], [pbp_profId]) VALUES (7, 5, 1)
INSERT [dbo].[permissionByProfile] ([pbp_id], [pbp_permId], [pbp_profId]) VALUES (8, 6, 1)
SET IDENTITY_INSERT [dbo].[permissionByProfile] OFF
SET IDENTITY_INSERT [dbo].[permissions] ON 

INSERT [dbo].[permissions] ([perms_id], [perms_action]) VALUES (1, N'Create')
INSERT [dbo].[permissions] ([perms_id], [perms_action]) VALUES (2, N'Edit')
INSERT [dbo].[permissions] ([perms_id], [perms_action]) VALUES (3, N'Submit Pending')
INSERT [dbo].[permissions] ([perms_id], [perms_action]) VALUES (4, N'Reject')
INSERT [dbo].[permissions] ([perms_id], [perms_action]) VALUES (5, N'Publish')
INSERT [dbo].[permissions] ([perms_id], [perms_action]) VALUES (6, N'Delete')
SET IDENTITY_INSERT [dbo].[permissions] OFF
SET IDENTITY_INSERT [dbo].[posts] ON 

INSERT [dbo].[posts] ([post_id], [post_usrId], [post_title], [post_content], [post_summary], [post_created], [post_published], [post_updated], [post_status]) VALUES (1, 1, N'First Post', N'Test post "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam"', N'Test Post', CAST(N'2021-06-07T17:25:00.000' AS DateTime), CAST(N'2021-06-07T17:25:00.000' AS DateTime), NULL, N'3')
INSERT [dbo].[posts] ([post_id], [post_usrId], [post_title], [post_content], [post_summary], [post_created], [post_published], [post_updated], [post_status]) VALUES (2, 1, N'Second post', N'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.', N'Test Post', CAST(N'2021-06-08T15:52:00.000' AS DateTime), CAST(N'2021-06-08T15:53:00.000' AS DateTime), NULL, N'1')
SET IDENTITY_INSERT [dbo].[posts] OFF
SET IDENTITY_INSERT [dbo].[profiles] ON 

INSERT [dbo].[profiles] ([prof_id], [prof_name]) VALUES (1, N'Editor')
INSERT [dbo].[profiles] ([prof_id], [prof_name]) VALUES (2, N'Writer')
INSERT [dbo].[profiles] ([prof_id], [prof_name]) VALUES (3, N'Visitor')
INSERT [dbo].[profiles] ([prof_id], [prof_name]) VALUES (4, N'Admin')
SET IDENTITY_INSERT [dbo].[profiles] OFF
SET IDENTITY_INSERT [dbo].[users] ON 

INSERT [dbo].[users] ([usr_id], [usr_login], [usr_password], [usr_firstname], [usr_lastname], [usr_mobile], [usr_registerDate], [usr_profId]) VALUES (1, N'admin', N'admin', N'admin', N'admin', N'3164072828', CAST(N'2021-06-07T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[users] ([usr_id], [usr_login], [usr_password], [usr_firstname], [usr_lastname], [usr_mobile], [usr_registerDate], [usr_profId]) VALUES (2, N'editor', N'editor123$A', N'Editor', N'Post', N'3164072828', CAST(N'2021-06-08T15:53:00.000' AS DateTime), 1)
INSERT [dbo].[users] ([usr_id], [usr_login], [usr_password], [usr_firstname], [usr_lastname], [usr_mobile], [usr_registerDate], [usr_profId]) VALUES (3, N'writer', N'writer123$A', N'Writer', N'Post', N'3164072828', CAST(N'2021-06-08T15:54:00.000' AS DateTime), 2)
SET IDENTITY_INSERT [dbo].[users] OFF
ALTER TABLE [dbo].[comments]  WITH CHECK ADD  CONSTRAINT [FK_comments_posts] FOREIGN KEY([post_Id])
REFERENCES [dbo].[posts] ([post_id])
GO
ALTER TABLE [dbo].[comments] CHECK CONSTRAINT [FK_comments_posts]
GO
ALTER TABLE [dbo].[permissionByProfile]  WITH CHECK ADD  CONSTRAINT [FK_permissionByProfile_permissions] FOREIGN KEY([pbp_permId])
REFERENCES [dbo].[permissions] ([perms_id])
GO
ALTER TABLE [dbo].[permissionByProfile] CHECK CONSTRAINT [FK_permissionByProfile_permissions]
GO
ALTER TABLE [dbo].[permissionByProfile]  WITH CHECK ADD  CONSTRAINT [FK_permissionByProfile_profiles] FOREIGN KEY([pbp_profId])
REFERENCES [dbo].[profiles] ([prof_id])
GO
ALTER TABLE [dbo].[permissionByProfile] CHECK CONSTRAINT [FK_permissionByProfile_profiles]
GO
ALTER TABLE [dbo].[posts]  WITH CHECK ADD  CONSTRAINT [FK_posts_users] FOREIGN KEY([post_usrId])
REFERENCES [dbo].[users] ([usr_id])
GO
ALTER TABLE [dbo].[posts] CHECK CONSTRAINT [FK_posts_users]
GO
ALTER TABLE [dbo].[users]  WITH CHECK ADD  CONSTRAINT [FK_users_profiles] FOREIGN KEY([usr_profId])
REFERENCES [dbo].[profiles] ([prof_id])
GO
ALTER TABLE [dbo].[users] CHECK CONSTRAINT [FK_users_profiles]
GO
