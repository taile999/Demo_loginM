USE [CAP2021]
GO
/****** Object:  Table [dbo].[SINHVIEN]    Script Date: 6/15/21 4:42:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SINHVIEN](
	[IDSinhVien] [int] IDENTITY(1,1) NOT NULL,
	[IDLopHoc] [int] NULL,
	[IDKhoaDaoTao] [int] NULL,
	[MaSV] [varchar](50) NULL,
	[HoTenSV] [nvarchar](50) NULL,
	[GioiTinh] [nvarchar](3) NULL,
	[NgaySinh] [datetime] NULL,
	[SDT] [varchar](11) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[CMND] [varchar](50) NULL,
	[TenKhoaDaoTao] [nvarchar](50) NULL,
	[Email] [varchar](50) NULL,
	[TenLop] [nvarchar](50) NULL,
	[TenCN] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[IDSinhVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
