CREATE DATABASE projectLeedo
GO
USE projectLeedo
GO
/*
   Tuesday, September 26, 20238:28:53 PM
   User: 
   Server: DESKTOP-S91JM4I\SQLEXPRESS2012
   Database: projectLeedo
   Application: 
*/

/* To prevent any potential data loss issues, you should review this script in detail before running it outside the context of the database designer.*/
BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.KhachHang
	(
	MaKH nchar(50) NOT NULL,
	HotenKH nvarchar(MAX) NULL,
	GT nchar(30) NULL,
	NgSinh date NULL,
	SDT nchar(20) NULL,
	Email nvarchar(50) NULL,
	DiaChi nvarchar(MAX) NULL,
	MatKhau nvarchar(50) NULL,
	TichDiem int NULL,
	Voucher nvarchar(MAX) NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE dbo.KhachHang ADD CONSTRAINT
	PK_KhachHang PRIMARY KEY CLUSTERED 
	(
	MaKH
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.KhachHang SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.DonHang
	(
	MaDH nchar(50) NOT NULL,
	MaKH nchar(50) NOT NULL,
	TG_lapBill datetime NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.DonHang ADD CONSTRAINT
	PK_DonHang PRIMARY KEY CLUSTERED 
	(
	MaDH
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.DonHang ADD CONSTRAINT
	FK_DonHang_KhachHang FOREIGN KEY
	(
	MaKH
	) REFERENCES dbo.KhachHang
	(
	MaKH
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.DonHang SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.Kho
	(
	MaKho nchar(10) NOT NULL,
	TenKho nvarchar(MAX) NULL,
	DiaChi nvarchar(MAX) NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE dbo.Kho ADD CONSTRAINT
	PK_Kho PRIMARY KEY CLUSTERED 
	(
	MaKho
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.Kho SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.SanPham
	(
	MaSP nchar(50) NOT NULL,
	LoaiSP nvarchar(MAX) NULL,
	TenSP nvarchar(MAX) NULL,
	GiaSP money NULL,
	SizeSP tinyint NULL,
	DonViTinh nvarchar(50) NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE dbo.SanPham ADD CONSTRAINT
	PK_SanPham PRIMARY KEY CLUSTERED 
	(
	MaSP
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.SanPham SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.DonHangChiTiet
	(
	MaDH nchar(50) NULL,
	MaSP nchar(50) NULL,
	SoLuong int NULL,
	TongBill money NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.DonHangChiTiet ADD CONSTRAINT
	FK_DonHangChiTiet_DonHang FOREIGN KEY
	(
	MaDH
	) REFERENCES dbo.DonHang
	(
	MaDH
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.DonHangChiTiet ADD CONSTRAINT
	FK_DonHangChiTiet_SanPham FOREIGN KEY
	(
	MaSP
	) REFERENCES dbo.SanPham
	(
	MaSP
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.DonHangChiTiet SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.KhoSP
	(
	MaKho nchar(10) NULL,
	MaSP nchar(50) NULL,
	SL_NhapSP int NULL,
	SL_XuatSP int NULL,
	TG_NhapSP datetime NULL,
	TG_XuatSP datetime NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.KhoSP ADD CONSTRAINT
	FK_KhoSP_Kho FOREIGN KEY
	(
	MaKho
	) REFERENCES dbo.Kho
	(
	MaKho
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.KhoSP ADD CONSTRAINT
	FK_KhoSP_SanPham FOREIGN KEY
	(
	MaSP
	) REFERENCES dbo.SanPham
	(
	MaSP
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.KhoSP SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.NguyenVatLieu
	(
	MaNVL nchar(50) NOT NULL,
	LoaiNVL nvarchar(MAX) NULL,
	TenNVL nvarchar(MAX) NULL,
	GiaNVL money NULL,
	DonViTinh nvarchar(50) NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE dbo.NguyenVatLieu ADD CONSTRAINT
	PK_NguyenVatLieu PRIMARY KEY CLUSTERED 
	(
	MaNVL
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.NguyenVatLieu SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.KhoNVL
	(
	MaKho nchar(10) NULL,
	MaNVL nchar(50) NULL,
	SL_NhapNVL int NULL,
	SL_XuatNVL int NULL,
	TG_NhapNVL datetime NULL,
	TG_XuatNVL datetime NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.KhoNVL ADD CONSTRAINT
	FK_KhoNVL_Kho FOREIGN KEY
	(
	MaKho
	) REFERENCES dbo.Kho
	(
	MaKho
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.KhoNVL ADD CONSTRAINT
	FK_KhoNVL_NguyenVatLieu FOREIGN KEY
	(
	MaNVL
	) REFERENCES dbo.NguyenVatLieu
	(
	MaNVL
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.KhoNVL SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.NhanVien
	(
	MaNV nchar(50) NOT NULL,
	HotenNV nvarchar(MAX) NOT NULL,
	CCCD nchar(20) NOT NULL,
	SDT nchar(20) NOT NULL,
	GT nvarchar(20) NOT NULL,
	NgSinh date NOT NULL,
	PhongBan nvarchar(MAX) NULL,
	TKBank nchar(50) NULL,
	Email nchar(50) NULL,
	ChucVu nvarchar(MAX) NULL,
	Luong money NULL,
	Img_NV ntext NULL,
	MatKhau nchar(100) NULL
	)  ON [PRIMARY]
	 TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE dbo.NhanVien ADD CONSTRAINT
	PK_NhanVien PRIMARY KEY CLUSTERED 
	(
	MaNV
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.NhanVien SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.DoanhThu
	(
	MaDH nchar(50) NULL,
	MaNVL nchar(50) NULL,
	MaSP nchar(50) NULL,
	MaNV nchar(50) NULL,
	TGian datetime NULL,
	TongThu money NULL,
	TongChi money NULL,
	TongLoiNhuan money NULL,
	ChiPhiKhauHao money NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.DoanhThu ADD CONSTRAINT
	FK_DoanhThu_DonHang FOREIGN KEY
	(
	MaDH
	) REFERENCES dbo.DonHang
	(
	MaDH
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.DoanhThu ADD CONSTRAINT
	FK_DoanhThu_NguyenVatLieu FOREIGN KEY
	(
	MaNVL
	) REFERENCES dbo.NguyenVatLieu
	(
	MaNVL
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.DoanhThu ADD CONSTRAINT
	FK_DoanhThu_SanPham FOREIGN KEY
	(
	MaSP
	) REFERENCES dbo.SanPham
	(
	MaSP
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.DoanhThu ADD CONSTRAINT
	FK_DoanhThu_NhanVien FOREIGN KEY
	(
	MaNV
	) REFERENCES dbo.NhanVien
	(
	MaNV
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.DoanhThu SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
