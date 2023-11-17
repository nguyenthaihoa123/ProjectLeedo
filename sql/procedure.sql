CREATE PROCEDURE SelectAllSanPhamWithTonKho
@tukhoa nvarchar(50)
AS
BEGIN
    SELECT SP.MaSP, SP.LoaiSP, SP.TenSP, SP.GiaSP, SP.SizeSP, SP.DonViTinh,
           ISNULL(SUM(KS.SL_NhapSP) - SUM(KS.SL_XuatSP), 0) AS SL_Ton
    FROM SanPham SP
    LEFT JOIN KhoSP KS ON SP.MaSP = KS.MaSP
	WHERE LOWER(SP.MaSP) like '%' + LOWER(@tukhoa) +'%'
	 or LOWER(SP.LoaiSP) like '%' + LOWER(@tukhoa) +'%'
	 or LOWER(SP.TenSP) like '%' + LOWER(@tukhoa) +'%'
	 or LOWER(SP.GiaSP) like '%' + LOWER(@tukhoa) +'%'
	 or LOWER(SP.SizeSP) like '%' + LOWER(@tukhoa) +'%'
	 or LOWER(SP.DonViTinh) like '%' + LOWER(@tukhoa) +'%'
    GROUP BY SP.MaSP, SP.LoaiSP, SP.TenSP, SP.GiaSP, SP.SizeSP, SP.DonViTinh;
END

USE [projectLeedo]
GO
/****** Object:  StoredProcedure [dbo].[SelectAllNVLWithTonKho]    Script Date: 11/17/2023 2:11:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SelectAllNVLWithTonKho]
@tukhoa nvarchar(50)
AS
BEGIN
    SELECT NVL.MaNVL, NVL.LoaiNVL, NVL.TenNVL, NVL.GiaNVL, NVL.DonViTinh, 
           ISNULL(SUM(KNVL.SL_NhapNVL) - SUM(KNVL.SL_XuatNVL), 0) AS SL_Ton
    FROM NguyenVatLieu NVL
    LEFT JOIN KhoNVL KNVL ON NVL.MaNVL = KNVL.MaNVL
	WHERE LOWER(NVL.MaNVL) like '%' + LOWER(@tukhoa) +'%'
	 or LOWER(NVL.LoaiNVL) like '%' + LOWER(@tukhoa) +'%'
	 or LOWER(NVL.TenNVL) like '%' + LOWER(@tukhoa) +'%'
	 or LOWER(NVL.GiaNVL) like '%' + LOWER(@tukhoa) +'%'
	 or LOWER(NVL.DonViTinh) like '%' + LOWER(@tukhoa) +'%'
    GROUP BY NVL.MaNVL, NVL.LoaiNVL, NVL.TenNVL, NVL.GiaNVL, NVL.DonViTinh;
END

create proc [dbo].[selectAllKhoNVL]
as
select * from KhoNVL

create proc [dbo].[selectNhapKhoNVL]
as
select * from KhoNVL where SL_NhapNVL != 0 and TG_NhapNVL is not null

create proc [dbo].[selectXuatKhoNVL]
as
select * from KhoNVL where SL_XuatNVL != 0 and TG_XuatNVL is not null

create proc [dbo].[selectMaKho]
as
select MaKho from Kho

create proc [dbo].[selectMaNVL]
as
select MaNVL from NguyenVatLieu

create proc [dbo].[insertNhapKhoNVL]
	@MaKho nchar(10),
	@MaNVL nchar(50),
	@SL_NhapNVL int,
	@SL_XuatNVL int,
	@TG_NhapNVL datetime,
	@TG_XuatNVL datetime
as
set @SL_XuatNVL = 0
set @TG_XuatNVL = null
insert into KhoNVL
(
	MaKho, MaNVL, SL_NhapNVL, SL_XuatNVL, TG_NhapNVL, TG_XuatNVL
)
values(
	@MaKho, @MaNVL, @SL_NhapNVL, @SL_XuatNVL, @TG_NhapNVL, @TG_XuatNVL
)
if @@ROWCOUNT > 0 begin return 1 end
	else begin return 0 end;

create proc [dbo].[insertXuatKhoNVL]
	@MaKho nchar(10),
	@MaNVL nchar(50),
	@SL_NhapNVL int,
	@SL_XuatNVL int,
	@TG_NhapNVL datetime,
	@TG_XuatNVL datetime
as
set @SL_NhapNVL = 0
set @TG_NhapNVL = null
insert into KhoNVL
(
	MaKho, MaNVL, SL_NhapNVL, SL_XuatNVL, TG_NhapNVL, TG_XuatNVL
)
values(
	@MaKho, @MaNVL, @SL_NhapNVL, @SL_XuatNVL, @TG_NhapNVL, @TG_XuatNVL
)
if @@ROWCOUNT > 0 begin return 1 end
	else begin return 0 end;