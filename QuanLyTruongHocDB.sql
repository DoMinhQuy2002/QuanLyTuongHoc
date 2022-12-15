USE [QuanLyTruongHocDB]
GO
/****** Object:  Table [dbo].[GiaoVien]    Script Date: 15-12-2022 2:09:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GiaoVien](
	[MaGV] [varchar](10) NOT NULL,
	[TenGV] [nvarchar](50) NOT NULL,
	[NgaySinh] [varchar](10) NOT NULL,
	[GioiTinh] [nvarchar](10) NOT NULL,
	[DienThoai] [varchar](10) NOT NULL,
	[MaGVQuanLi] [varchar](10) NULL,
 CONSTRAINT [PK_GiaoVien] PRIMARY KEY CLUSTERED 
(
	[MaGV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GiaoVien_Day_MonHoc]    Script Date: 15-12-2022 2:09:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GiaoVien_Day_MonHoc](
	[MaGV] [varchar](10) NOT NULL,
	[MaMH] [varchar](10) NOT NULL,
	[ThamNien] [int] NOT NULL,
	[SoLopDaDay] [int] NOT NULL,
 CONSTRAINT [PK_GiaoVien_Day_MonHoc] PRIMARY KEY CLUSTERED 
(
	[MaGV] ASC,
	[MaMH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HocVien]    Script Date: 15-12-2022 2:09:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HocVien](
	[MaHocVien] [varchar](10) NOT NULL,
	[TenHocVien] [nvarchar](50) NOT NULL,
	[NgaySinh] [date] NOT NULL,
	[TinhTrang] [nvarchar](50) NOT NULL,
	[MaLop] [varchar](10) NOT NULL,
 CONSTRAINT [PK_HocVien] PRIMARY KEY CLUSTERED 
(
	[MaHocVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KetQua]    Script Date: 15-12-2022 2:09:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KetQua](
	[MaHV] [varchar](10) NOT NULL,
	[MaMonHoc] [varchar](10) NOT NULL,
	[LanThi] [int] NOT NULL,
	[Diem] [float] NOT NULL,
 CONSTRAINT [PK_KetQua] PRIMARY KEY CLUSTERED 
(
	[MaHV] ASC,
	[MaMonHoc] ASC,
	[LanThi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LopHoc]    Script Date: 15-12-2022 2:09:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LopHoc](
	[MaLop] [varchar](10) NOT NULL,
	[SiSo] [int] NOT NULL,
	[LopTruong] [varchar](10) NOT NULL,
	[GVQuanLi] [varchar](10) NOT NULL,
	[NamBatDau] [int] NOT NULL,
	[NamKetThuc] [int] NOT NULL,
 CONSTRAINT [PK_LopHoc] PRIMARY KEY CLUSTERED 
(
	[MaLop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MonHoc]    Script Date: 15-12-2022 2:09:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MonHoc](
	[MaMonHoc] [varchar](10) NOT NULL,
	[TenMonHoc] [nvarchar](50) NOT NULL,
	[SoChi] [int] NOT NULL,
 CONSTRAINT [PK_MonHoc] PRIMARY KEY CLUSTERED 
(
	[MaMonHoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhanCong]    Script Date: 15-12-2022 2:09:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhanCong](
	[MaGV] [varchar](10) NOT NULL,
	[MaMH] [varchar](10) NOT NULL,
	[MaLop] [varchar](10) NOT NULL,
 CONSTRAINT [PK_PhanCong] PRIMARY KEY CLUSTERED 
(
	[MaGV] ASC,
	[MaMH] ASC,
	[MaLop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 15-12-2022 2:09:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[TenDangNhap] [varchar](10) NULL,
	[MatKhau] [varchar](15) NULL,
	[Loai] [int] NULL
) ON [PRIMARY]
GO
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [NgaySinh], [GioiTinh], [DienThoai], [MaGVQuanLi]) VALUES (N'0123456789', N'Quy', N'0', N'Nam', N'0123456789', N'0123456789')
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [NgaySinh], [GioiTinh], [DienThoai], [MaGVQuanLi]) VALUES (N'0987654321', N'Loi', N'Monday, Oc', N'Nam', N'0987654321', N'0987654321')
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [NgaySinh], [GioiTinh], [DienThoai], [MaGVQuanLi]) VALUES (N'1', N'1', N'1', N'1', N'1', N'1')
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [NgaySinh], [GioiTinh], [DienThoai], [MaGVQuanLi]) VALUES (N'10082002lo', N'Loi', N'20/10/1969', N'Nam', N'0363698191', N'10082002lo')
INSERT [dbo].[GiaoVien] ([MaGV], [TenGV], [NgaySinh], [GioiTinh], [DienThoai], [MaGVQuanLi]) VALUES (N'3333333333', N'Nguyen Huu Loi', N'06/07/1989', N'Nam', N'0123456789', N'0123456789')
GO
INSERT [dbo].[TaiKhoan] ([TenDangNhap], [MatKhau], [Loai]) VALUES (N'admin', N'123456', 0)
INSERT [dbo].[TaiKhoan] ([TenDangNhap], [MatKhau], [Loai]) VALUES (N'chipu', N'123456', 1)
INSERT [dbo].[TaiKhoan] ([TenDangNhap], [MatKhau], [Loai]) VALUES (N'Minh Quy', N'123456', 2)
GO
ALTER TABLE [dbo].[GiaoVien]  WITH CHECK ADD  CONSTRAINT [FK_GiaoVien_GiaoVien] FOREIGN KEY([MaGVQuanLi])
REFERENCES [dbo].[GiaoVien] ([MaGV])
GO
ALTER TABLE [dbo].[GiaoVien] CHECK CONSTRAINT [FK_GiaoVien_GiaoVien]
GO
ALTER TABLE [dbo].[GiaoVien_Day_MonHoc]  WITH CHECK ADD  CONSTRAINT [FK_GiaoVienDayMonHoc_GiaoVien] FOREIGN KEY([MaGV])
REFERENCES [dbo].[GiaoVien] ([MaGV])
GO
ALTER TABLE [dbo].[GiaoVien_Day_MonHoc] CHECK CONSTRAINT [FK_GiaoVienDayMonHoc_GiaoVien]
GO
ALTER TABLE [dbo].[GiaoVien_Day_MonHoc]  WITH CHECK ADD  CONSTRAINT [FK_GiaoVienDayMonHoc_MonHoc] FOREIGN KEY([MaMH])
REFERENCES [dbo].[MonHoc] ([MaMonHoc])
GO
ALTER TABLE [dbo].[GiaoVien_Day_MonHoc] CHECK CONSTRAINT [FK_GiaoVienDayMonHoc_MonHoc]
GO
ALTER TABLE [dbo].[HocVien]  WITH CHECK ADD  CONSTRAINT [FK_HocVien_LopHoc] FOREIGN KEY([MaLop])
REFERENCES [dbo].[LopHoc] ([MaLop])
GO
ALTER TABLE [dbo].[HocVien] CHECK CONSTRAINT [FK_HocVien_LopHoc]
GO
ALTER TABLE [dbo].[HocVien]  WITH CHECK ADD  CONSTRAINT [FK_HocVien_LopHoc1] FOREIGN KEY([MaLop])
REFERENCES [dbo].[LopHoc] ([MaLop])
GO
ALTER TABLE [dbo].[HocVien] CHECK CONSTRAINT [FK_HocVien_LopHoc1]
GO
ALTER TABLE [dbo].[KetQua]  WITH CHECK ADD  CONSTRAINT [FK_KetQua_HocVien] FOREIGN KEY([MaHV])
REFERENCES [dbo].[HocVien] ([MaHocVien])
GO
ALTER TABLE [dbo].[KetQua] CHECK CONSTRAINT [FK_KetQua_HocVien]
GO
ALTER TABLE [dbo].[KetQua]  WITH CHECK ADD  CONSTRAINT [FK_KetQua_MonHoc] FOREIGN KEY([MaMonHoc])
REFERENCES [dbo].[MonHoc] ([MaMonHoc])
GO
ALTER TABLE [dbo].[KetQua] CHECK CONSTRAINT [FK_KetQua_MonHoc]
GO
ALTER TABLE [dbo].[LopHoc]  WITH CHECK ADD  CONSTRAINT [FK_LopHoc_HocVien] FOREIGN KEY([LopTruong])
REFERENCES [dbo].[HocVien] ([MaHocVien])
GO
ALTER TABLE [dbo].[LopHoc] CHECK CONSTRAINT [FK_LopHoc_HocVien]
GO
ALTER TABLE [dbo].[PhanCong]  WITH CHECK ADD  CONSTRAINT [FK_PhanCong_GiaoVien] FOREIGN KEY([MaGV])
REFERENCES [dbo].[GiaoVien] ([MaGV])
GO
ALTER TABLE [dbo].[PhanCong] CHECK CONSTRAINT [FK_PhanCong_GiaoVien]
GO
ALTER TABLE [dbo].[PhanCong]  WITH CHECK ADD  CONSTRAINT [FK_PhanCong_LopHoc] FOREIGN KEY([MaLop])
REFERENCES [dbo].[LopHoc] ([MaLop])
GO
ALTER TABLE [dbo].[PhanCong] CHECK CONSTRAINT [FK_PhanCong_LopHoc]
GO
/****** Object:  StoredProcedure [dbo].[sp_SuaGV]    Script Date: 15-12-2022 2:09:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_SuaGV]
	@magv varchar(10),
	@tengv nvarchar(50),
	@ngaysinh varchar(10),
	@gioitinh nvarchar(10),
	@dienthoai varchar(10),
	@magvquanli varchar(10)

AS

	UPDATE GiaoVien
	SET TenGV = @tengv, NgaySinh = @ngaysinh, GioiTinh = @gioitinh, DienThoai = @dienthoai, MaGVQuanLi = @magvquanli
	WHERE MaGV = @magv
GO
/****** Object:  StoredProcedure [dbo].[sp_SuaTaiKhoan]    Script Date: 15-12-2022 2:09:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_SuaTaiKhoan]
	@ten varchar(10),
	@matkhau varchar(15),
	@loai int

AS
	UPDATE TaiKhoan
	SET MatKhau = @matkhau, Loai = @loai
	WHERE TenDangNhap = @ten
GO
/****** Object:  StoredProcedure [dbo].[sp_TaoGV]    Script Date: 15-12-2022 2:09:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_TaoGV]
	@magv varchar(10),
	@tengv nvarchar(50),
	@ngaysinh varchar(10),
	@gioitinh nvarchar(10),
	@dienthoai varchar(10),
	@magvquanli varchar(10)

AS

	INSERT INTO GiaoVien VALUES(@magv, @tengv, @ngaysinh, @gioitinh, @dienthoai, @magvquanli)
GO
/****** Object:  StoredProcedure [dbo].[sp_TaoTaiKhoan]    Script Date: 15-12-2022 2:09:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_TaoTaiKhoan]
	@TenDangNhap varchar(10),
	@MatKhau varchar(15),
	@Loai int

AS
	INSERT INTO TaiKhoan VALUES(@TenDangNhap, @MatKhau, @Loai)
GO
/****** Object:  StoredProcedure [dbo].[sp_TimGV]    Script Date: 15-12-2022 2:09:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_TimGV]
	@magv varchar(10)

AS

	SELECT * FROM GiaoVien WHERE MaGV LIKE CONCAT('%', @magv, '%')
GO
/****** Object:  StoredProcedure [dbo].[sp_TimTaiKhoan]    Script Date: 15-12-2022 2:09:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_TimTaiKhoan]
	@ten varchar(10)

AS
	SELECT * FROM TaiKhoan WHERE TenDangNhap LIKE CONCAT('%', @ten, '%')
GO
/****** Object:  StoredProcedure [dbo].[sp_XoaGV]    Script Date: 15-12-2022 2:09:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_XoaGV]
	@magv varchar(10)

AS

	DELETE FROM GiaoVien WHERE MaGV = @magv
GO
/****** Object:  StoredProcedure [dbo].[sp_XoaTaiKhoan]    Script Date: 15-12-2022 2:09:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_XoaTaiKhoan]
	@ten varchar(10)
AS
	DELETE FROM TaiKhoan WHERE TenDangNhap = @ten
GO
