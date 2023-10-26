CREATE DATABASE projectLeedo
GO
USE [projectLeedo]
GO
/****** Object:  Table [dbo].[DoanhThu]    Script Date: 10/26/2023 4:27:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DoanhThu](
	[MaDH] [nchar](50) NULL,
	[MaNVL] [nchar](50) NULL,
	[MaSP] [nchar](50) NULL,
	[MaNV] [nchar](50) NULL,
	[TGian] [datetime] NULL,
	[TongThu] [money] NULL,
	[TongChi] [money] NULL,
	[TongLoiNhuan] [money] NULL,
	[ChiPhiKhauHao] [money] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DonHang]    Script Date: 10/26/2023 4:27:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DonHang](
	[MaDH] [nchar](50) NOT NULL,
	[MaKH] [nchar](50) NOT NULL,
	[TG_lapBill] [datetime] NULL,
 CONSTRAINT [PK_DonHang] PRIMARY KEY CLUSTERED 
(
	[MaDH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DonHangChiTiet]    Script Date: 10/26/2023 4:27:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DonHangChiTiet](
	[MaDH] [nchar](50) NULL,
	[MaSP] [nchar](50) NULL,
	[SoLuong] [int] NULL,
	[TongBill] [money] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 10/26/2023 4:27:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [nchar](50) NOT NULL,
	[HotenKH] [nvarchar](max) NULL,
	[GT] [nchar](30) NULL,
	[NgSinh] [date] NULL,
	[SDT] [nchar](20) NULL,
	[Email] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](max) NULL,
	[MatKhau] [nvarchar](50) NULL,
	[TichDiem] [int] NULL,
	[Voucher] [nvarchar](max) NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kho]    Script Date: 10/26/2023 4:27:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kho](
	[MaKho] [nchar](10) NOT NULL,
	[TenKho] [nvarchar](max) NULL,
	[DiaChi] [nvarchar](max) NULL,
 CONSTRAINT [PK_Kho] PRIMARY KEY CLUSTERED 
(
	[MaKho] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhoNVL]    Script Date: 10/26/2023 4:27:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhoNVL](
	[MaKho] [nchar](10) NULL,
	[MaNVL] [nchar](50) NULL,
	[SL_NhapNVL] [int] NULL,
	[SL_XuatNVL] [int] NULL,
	[TG_NhapNVL] [datetime] NULL,
	[TG_XuatNVL] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhoSP]    Script Date: 10/26/2023 4:27:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhoSP](
	[MaKho] [nchar](10) NULL,
	[MaSP] [nchar](50) NULL,
	[SL_NhapSP] [int] NULL,
	[SL_XuatSP] [int] NULL,
	[TG_NhapSP] [datetime] NULL,
	[TG_XuatSP] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NguyenVatLieu]    Script Date: 10/26/2023 4:27:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NguyenVatLieu](
	[MaNVL] [nchar](50) NOT NULL,
	[LoaiNVL] [nvarchar](max) NULL,
	[TenNVL] [nvarchar](max) NULL,
	[GiaNVL] [money] NULL,
	[DonViTinh] [nvarchar](50) NULL,
 CONSTRAINT [PK_NguyenVatLieu] PRIMARY KEY CLUSTERED 
(
	[MaNVL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 10/26/2023 4:27:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [nchar](50) NOT NULL,
	[HotenNV] [nvarchar](max) NOT NULL,
	[CCCD] [nchar](20) NOT NULL,
	[SDT] [nchar](20) NOT NULL,
	[GT] [nvarchar](20) NOT NULL,
	[NgSinh] [date] NOT NULL,
	[PhongBan] [nvarchar](max) NULL,
	[TKBank] [nchar](50) NULL,
	[Email] [nchar](50) NULL,
	[ChucVu] [nvarchar](max) NULL,
	[Luong] [money] NULL,
	[Img_NV] [ntext] NULL,
	[MatKhau] [nchar](100) NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 10/26/2023 4:27:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[MaSP] [nchar](50) NOT NULL,
	[LoaiSP] [nvarchar](max) NULL,
	[TenSP] [nvarchar](max) NULL,
	[GiaSP] [money] NULL,
	[SizeSP] [tinyint] NULL,
	[DonViTinh] [nvarchar](50) NULL,
 CONSTRAINT [PK_SanPham] PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[KhachHang] ADD  CONSTRAINT [DF_KhachHang_TichDiem]  DEFAULT ((0)) FOR [TichDiem]
GO
ALTER TABLE [dbo].[DoanhThu]  WITH CHECK ADD  CONSTRAINT [FK_DoanhThu_DonHang] FOREIGN KEY([MaDH])
REFERENCES [dbo].[DonHang] ([MaDH])
GO
ALTER TABLE [dbo].[DoanhThu] CHECK CONSTRAINT [FK_DoanhThu_DonHang]
GO
ALTER TABLE [dbo].[DoanhThu]  WITH CHECK ADD  CONSTRAINT [FK_DoanhThu_NguyenVatLieu] FOREIGN KEY([MaNVL])
REFERENCES [dbo].[NguyenVatLieu] ([MaNVL])
GO
ALTER TABLE [dbo].[DoanhThu] CHECK CONSTRAINT [FK_DoanhThu_NguyenVatLieu]
GO
ALTER TABLE [dbo].[DoanhThu]  WITH CHECK ADD  CONSTRAINT [FK_DoanhThu_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[DoanhThu] CHECK CONSTRAINT [FK_DoanhThu_NhanVien]
GO
ALTER TABLE [dbo].[DoanhThu]  WITH CHECK ADD  CONSTRAINT [FK_DoanhThu_SanPham] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[DoanhThu] CHECK CONSTRAINT [FK_DoanhThu_SanPham]
GO
ALTER TABLE [dbo].[DonHang]  WITH CHECK ADD  CONSTRAINT [FK_DonHang_KhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[DonHang] CHECK CONSTRAINT [FK_DonHang_KhachHang]
GO
ALTER TABLE [dbo].[DonHangChiTiet]  WITH CHECK ADD  CONSTRAINT [FK_DonHangChiTiet_DonHang] FOREIGN KEY([MaDH])
REFERENCES [dbo].[DonHang] ([MaDH])
GO
ALTER TABLE [dbo].[DonHangChiTiet] CHECK CONSTRAINT [FK_DonHangChiTiet_DonHang]
GO
ALTER TABLE [dbo].[DonHangChiTiet]  WITH CHECK ADD  CONSTRAINT [FK_DonHangChiTiet_SanPham] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[DonHangChiTiet] CHECK CONSTRAINT [FK_DonHangChiTiet_SanPham]
GO
ALTER TABLE [dbo].[KhoNVL]  WITH CHECK ADD  CONSTRAINT [FK_KhoNVL_Kho] FOREIGN KEY([MaKho])
REFERENCES [dbo].[Kho] ([MaKho])
GO
ALTER TABLE [dbo].[KhoNVL] CHECK CONSTRAINT [FK_KhoNVL_Kho]
GO
ALTER TABLE [dbo].[KhoNVL]  WITH CHECK ADD  CONSTRAINT [FK_KhoNVL_NguyenVatLieu] FOREIGN KEY([MaNVL])
REFERENCES [dbo].[NguyenVatLieu] ([MaNVL])
GO
ALTER TABLE [dbo].[KhoNVL] CHECK CONSTRAINT [FK_KhoNVL_NguyenVatLieu]
GO
ALTER TABLE [dbo].[KhoSP]  WITH CHECK ADD  CONSTRAINT [FK_KhoSP_Kho] FOREIGN KEY([MaKho])
REFERENCES [dbo].[Kho] ([MaKho])
GO
ALTER TABLE [dbo].[KhoSP] CHECK CONSTRAINT [FK_KhoSP_Kho]
GO
ALTER TABLE [dbo].[KhoSP]  WITH CHECK ADD  CONSTRAINT [FK_KhoSP_SanPham] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[KhoSP] CHECK CONSTRAINT [FK_KhoSP_SanPham]
GO
/****** Object:  StoredProcedure [dbo].[dangnhap]    Script Date: 10/26/2023 4:27:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[dangnhap]
	@taikhoan varchar(50),
	@matkhau varchar(50)
as
begin
	select *
			from NhanVien
			where MaNV = @taikhoan
			and MatKhau = @matkhau;
end
GO
/****** Object:  StoredProcedure [dbo].[deleteKhachHang]    Script Date: 10/26/2023 4:27:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[deleteKhachHang]
	@maKH nchar(50)
as
	delete from KhachHang where MaKH = @maKH
	if (@@ROWCOUNT >0) return 1
		else return 0
GO
/****** Object:  StoredProcedure [dbo].[deleteKho]    Script Date: 10/26/2023 4:27:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[deleteKho]
	@MaKho nchar(10)
as
delete from Kho where MaKho = @MaKho
 if @@ROWCOUNT > 0 begin return 1 end
	else begin return 0 end;
GO
/****** Object:  StoredProcedure [dbo].[deleteNhanVien]    Script Date: 10/26/2023 4:27:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[deleteNhanVien]
	@maNV nchar(50)
as
	delete from NhanVien where MaNV = @maNV
	if (@@ROWCOUNT >0) return 1
		else return 0
GO
/****** Object:  StoredProcedure [dbo].[deleteNVL]    Script Date: 10/26/2023 4:27:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[deleteNVL]
 @MaNVL nchar(50)
as
delete from NguyenVatLieu where MaNVL = @MaNVL
if @@ROWCOUNT > 0 begin return 1 end
	else begin return 0 end;
GO
/****** Object:  StoredProcedure [dbo].[deleteSanPham]    Script Date: 10/26/2023 4:27:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[deleteSanPham]
 @MaSP nchar(50)
 as
 delete from SanPham where MaSP = @MaSP
 if @@ROWCOUNT > 0 begin return 1 end
	else begin return 0 end;
GO
/****** Object:  StoredProcedure [dbo].[insertDonHang]    Script Date: 10/26/2023 4:27:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[insertDonHang]
	@SDT nchar(20)
as
	declare @maKH nchar(50)
	declare @MaDonHang nchar(50) 
	DECLARE @NextDH INT
	Select @maKH = MaKH from KhachHang where SDT = @SDT

	SELECT @NextDH = COALESCE(MAX(CAST(SUBSTRING(MaDH, 3, LEN(MaDH) - 2) AS INT)), 0) + 1
    FROM DonHang

	SET @MaDonHang = 'DH' + RIGHT('0000' + CAST(@NextDH AS NVARCHAR(4)), 4)


	insert into DonHang 
	(
		MaDH,MaKH,TG_lapBill
	)
	values(
		@MaDonHang, @maKH, GETDATE()
	)

	insert into DonHangChiTiet(
		MaDH,MaSP,SoLuong,TongBill
	)
	values(
		@MaDonHang,null,null,null
	)
	if @@ROWCOUNT > 0 begin return 1 end
	else begin return 0 end;
GO
/****** Object:  StoredProcedure [dbo].[insertKhachHang]    Script Date: 10/26/2023 4:27:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE procedure [dbo].[insertKhachHang]
	@MaKH nchar(50) ,
	@HotenKH nvarchar(MAX),
	@GT nchar(30),
	@NgSinh date ,
	@SDT nchar(20),
	@Email nvarchar(50),
	@DiaChi nvarchar(MAX),
	@MatKhau nvarchar(50),
	@Voucher nvarchar(MAX)
as
 insert into KhachHang(
	MaKH, HotenKH,GT, NgSinh, SDT, Email, DiaChi, MatKhau, Voucher
 )
values(
	@MaKH,@HotenKH,@GT,@NgSinh,@SDT,@Email,@DiaChi,
	CASE 
            WHEN @MatKhau IS NOT NULL AND @MatKhau != '' THEN @MatKhau
            ELSE @SDT -- Thay 'YourDefaultValueHere' bằng giá trị mặc định bạn muốn sử dụng
       END
	,@Voucher
)
	 if @@ROWCOUNT > 0 begin return 1 end
	else begin return 0 end;
GO
/****** Object:  StoredProcedure [dbo].[insertKho]    Script Date: 10/26/2023 4:27:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[insertKho]
	@MaKho nchar(10) ,
	@TenKho nvarchar(MAX),
	@DiaChi nvarchar(MAX)
as
insert into Kho
(
	MaKho, TenKho, DiaChi
)
values(
	@MaKho, @TenKho, @DiaChi
)
 if @@ROWCOUNT > 0 begin return 1 end
	else begin return 0 end;
GO
/****** Object:  StoredProcedure [dbo].[insertNhanVien]    Script Date: 10/26/2023 4:27:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[insertNhanVien]
	@MaNV nchar(50),
	@HotenNV nvarchar(MAX),
	@CCCD nchar(20),
	@SDT nchar(20),
	@GT nvarchar(20),
	@NgSinh date,
	@PhongBan nvarchar(MAX),
	@TKBank nchar(50),
	@Email nchar(50),
	@ChucVu nvarchar(MAX),
	@Luong money,
	@Img_NV ntext,
	@MatKhau nchar(100)
as
insert into NhanVien 
( MaNV,HotenNV,CCCD,SDT,GT,NgSinh,PhongBan,
	TKBank,Email,ChucVu,Luong,Img_NV,MatKhau
)
values
(
	@MaNV,@HotenNV,@CCCD,@SDT,@GT,@NgSinh,@PhongBan,
	@TKBank,@Email,@ChucVu,@Luong,@Img_NV,
	CASE 
            WHEN @MatKhau IS NOT NULL AND @MatKhau != '' THEN @MatKhau
            ELSE @SDT -- Thay 'YourDefaultValueHere' bằng giá trị mặc định bạn muốn sử dụng
       END
)
if @@ROWCOUNT > 0 begin return 1 end
	else begin return 0 end;
GO
/****** Object:  StoredProcedure [dbo].[insertNVL]    Script Date: 10/26/2023 4:27:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[insertNVL]
	@MaNVL nchar(50) ,
	@LoaiNVL nvarchar(MAX),
	@TenNVL nvarchar(MAX),
	@GiaNVL money NULL,
	@DonViTinh nvarchar(50)
as
insert into NguyenVatLieu
(
	MaNVL,LoaiNVL,TenNVL,GiaNVL,DonViTinh
)
values(
	@MaNVL,@LoaiNVL,@TenNVL,@GiaNVL,@DonViTinh
)
if @@ROWCOUNT > 0 begin return 1 end
	else begin return 0 end;
GO
/****** Object:  StoredProcedure [dbo].[insertSanPham]    Script Date: 10/26/2023 4:27:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

 create procedure [dbo].[insertSanPham]
	@MaSP nchar(50) ,
	@LoaiSP nvarchar(MAX),
	@TenSP nvarchar(MAX),
	@GiaSP money,
	@SizeSP tinyint,
	@DonViTinh nvarchar(50)
as
insert into SanPham(
	MaSP, LoaiSP, TenSP, GiaSP, SizeSP, DonViTinh
)
values(
	@MaSP,@LoaiSP,@TenSP,@GiaSP,@SizeSP,@DonViTinh
)
if @@ROWCOUNT > 0 begin return 1 end
	else begin return 0 end;
GO
/****** Object:  StoredProcedure [dbo].[selectAllKhachHang]    Script Date: 10/26/2023 4:27:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[selectAllKhachHang]
@tukhoa nvarchar(50)
 as
 select *
 from KhachHang
 where LOWER(MaKH) like '%' + LOWER(@tukhoa) +'%'
 or LOWER(HotenKH) like '%' + LOWER(@tukhoa) +'%'
 or LOWER(GT) like '%' + LOWER(@tukhoa) +'%'
 or LOWER(NgSinh) like '%' + LOWER(@tukhoa) +'%'
 or LOWER(SDT) like '%' + LOWER(@tukhoa) +'%' 
 or LOWER(Email) like '%' + LOWER(@tukhoa) +'%'
 or LOWER(DiaChi) like '%' + LOWER(@tukhoa) +'%'
 or LOWER(MatKhau) like '%' + LOWER(@tukhoa) +'%'
 or LOWER(Voucher) like '%' + LOWER(@tukhoa) +'%'
GO
/****** Object:  StoredProcedure [dbo].[selectAllNV]    Script Date: 10/26/2023 4:27:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[selectAllNV]
@tukhoa nvarchar(50)
as
	select MaNv,
		HotenNV,
		CCCD,
		SDT,
		GT,
		NgSinh,
		PhongBan,
		TKBank,
		Email,
		ChucVu,
		Luong,
		Img_NV,
		MatKhau
	from NhanVien
	where LOWER(MaNV) like '%' + LOWER(trim(@tukhoa)) + '%'
	or LOWER(HotenNV) like '%' + LOWER(trim(@tukhoa)) + '%'
	or LOWER(CCCD) like '%' + LOWER(trim(@tukhoa)) + '%'
	or LOWER(SDT) like '%' + LOWER(trim(@tukhoa)) + '%'
	or LOWER(GT) like '%' + LOWER(trim(@tukhoa)) + '%'
	or LOWER(PhongBan) like '%' + LOWER(trim(@tukhoa)) + '%'
	or LOWER(TKBank) like '%' + LOWER(trim(@tukhoa)) + '%'
	or LOWER(Email) like '%' + LOWER(trim(@tukhoa)) + '%'
	or LOWER(ChucVu) like '%' + LOWER(trim(@tukhoa)) + '%'
	or LOWER(Luong) like '%' + LOWER(trim(@tukhoa)) + '%'
	or LOWER(CCCD) like '%' + LOWER(trim(@tukhoa)) + '%'
GO
/****** Object:  StoredProcedure [dbo].[selectAllNVL]    Script Date: 10/26/2023 4:27:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[selectAllNVL]
@tukhoa nvarchar(50)
 as
 select *
 from NguyenVatLieu
 where LOWER(MaNVL) like '%' + LOWER(@tukhoa) + '%'
 or LOWER(LoaiNVL) like '%' + LOWER(@tukhoa) + '%'
 or LOWER(TenNVL) like '%' + LOWER(@tukhoa) + '%'
 or LOWER(GiaNVL) like '%' + LOWER(@tukhoa) + '%'
 or LOWER(DonViTinh) like '%' + LOWER(@tukhoa) + '%'
GO
/****** Object:  StoredProcedure [dbo].[selectALlSanPham]    Script Date: 10/26/2023 4:27:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[selectALlSanPham]
@tukhoa nvarchar(50)
 as
 select *
 from SanPham
 where LOWER(MaSP) like '%' + LOWER(@tukhoa) +'%'
 or LOWER(LoaiSP) like '%' + LOWER(@tukhoa) +'%'
 or LOWER(TenSP) like '%' + LOWER(@tukhoa) +'%'
 or LOWER(GiaSP) like '%' + LOWER(@tukhoa) +'%'
 or LOWER(SizeSP) like '%' + LOWER(@tukhoa) +'%'
 or LOWER(DonViTinh) like '%' + LOWER(@tukhoa) +'%'
GO
/****** Object:  StoredProcedure [dbo].[updateKhachHang]    Script Date: 10/26/2023 4:27:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[updateKhachHang]
	@MaKH nchar(50) ,
	@HotenKH nvarchar(MAX),
	@GT nchar(30),
	@NgSinh date ,
	@SDT nchar(20),
	@Email nvarchar(50),
	@DiaChi nvarchar(MAX),
	@MatKhau nvarchar(50),
	@Voucher nvarchar(MAX)
as
 update KhachHang
 set 
	HotenKH = @HotenKH,
	GT = @GT,
	NgSinh = @NgSinh,
	SDT = @SDT,
	Email = @Email,
	DiaChi = @DiaChi,
	MatKhau = @MatKhau,
	Voucher = @Voucher
where MaKH = @MaKH
if @@ROWCOUNT > 0 begin return 1 end
	else begin return 0 end;
GO
/****** Object:  StoredProcedure [dbo].[updateKho]    Script Date: 10/26/2023 4:27:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[updateKho]
	@MaKho nchar(10) ,
	@TenKho nvarchar(MAX),
	@DiaChi nvarchar(MAX)
as
	update Kho
	set TenKho = @TenKho,
		DiaChi = @DiaChi
	where MaKho = @MaKho
	 if @@ROWCOUNT > 0 begin return 1 end
	else begin return 0 end;
GO
/****** Object:  StoredProcedure [dbo].[updateNhanVien]    Script Date: 10/26/2023 4:27:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[updateNhanVien]
	@MaNV nchar(50),
	@HotenNV nvarchar(MAX),
	@CCCD nchar(20),
	@SDT nchar(20),
	@GT nvarchar(20),
	@NgSinh date,
	@PhongBan nvarchar(MAX),
	@TKBank nchar(50),
	@Email nchar(50),
	@ChucVu nvarchar(MAX),
	@Luong money,
	@Img_NV ntext,
	@MatKhau nchar(100)
as
update NhanVien
set 
	HotenNV = @HotenNV,
	CCCD = @CCCD,
	SDT = @SDT,
	GT = @GT,
	NgSinh = @NgSinh,
	PhongBan = @PhongBan,
	TKBank = @TKBank,
	Email = @Email,
	ChucVu = @ChucVu,
	Luong = @Luong,
	Img_NV = @Img_NV,
	MatKhau = @MatKhau
where MaNV = @MaNV
GO
/****** Object:  StoredProcedure [dbo].[updateNVL]    Script Date: 10/26/2023 4:27:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create procedure [dbo].[updateNVL]
	@MaNVL nchar(50) ,
	@LoaiNVL nvarchar(MAX),
	@TenNVL nvarchar(MAX),
	@GiaNVL money NULL,
	@DonViTinh nvarchar(50)
as
update NguyenVatLieu
set LoaiNVL = @LoaiNVL,
	TenNVL = @TenNVL,
	GiaNVL = @GiaNVL,
	DonViTinh = @DonViTinh
where MaNVL = @MaNVL
GO
/****** Object:  StoredProcedure [dbo].[updateSanPham]    Script Date: 10/26/2023 4:27:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[updateSanPham]
	@MaSP nchar(50) ,
	@LoaiSP nvarchar(MAX),
	@TenSP nvarchar(MAX),
	@GiaSP money,
	@SizeSP tinyint,
	@DonViTinh nvarchar(50)
as
update SanPham
set LoaiSP = @LoaiSP,
	TenSP = @TenSP,
	GiaSP = @GiaSP,
	SizeSP = @SizeSP,
	DonViTinh = @DonViTinh
where MaSP = @MaSP
if @@ROWCOUNT > 0 begin return 1 end
	else begin return 0 end;
GO
