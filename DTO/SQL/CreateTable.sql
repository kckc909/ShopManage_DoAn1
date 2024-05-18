--Create Database
use master
go
drop database ShopDatabase
go
create database ShopDatabase
go
use ShopDatabase
go

-- drop table 
drop table tblTaiKhoanMatKhau
drop table tblApDungVoucher
drop table tblSoHuuVoucher
drop table tblChiTietHDB
drop table tblChiTietHDN
drop table tblHoaDonNhap
drop table tblHoaDonBan
drop table tblKhachHang
drop table tblMatHang
drop table tblKhuyenMai
drop table tblNhanVien
drop table tblLoaiHang
drop table tblVoucher
drop table tblQuyen
drop table tblDonVi
drop table tblNCC
drop table tblGhiChu
go

-- Create table 
create table tblDonVi(
	DonVi nchar(10) primary key
)
create table tblQuyen(
	CapQuyen int primary key,
	Ten nvarchar(50) not null,
	MoTa nvarchar(50)
)
create table tblLoaiHang(
	MaLoai char(10) primary key,
	TenLoai nvarchar(50) not null,
	MoTa nvarchar(max)
)
create table tblNCC(
	MaNCC char(10) primary key,
	TenNCC nvarchar(50) not null,
	DiaChi nvarchar(50),
	SDT char(10),
	Email char(50)
)
create table tblKhuyenMai(
	MaKM char(10) primary key,
	TenKM nvarchar(30),
	MoTa nvarchar(max),
	PhamTramGiam int default 0,
	NgayBatDau date,
	NgayKetThuc date
)
create table tblMatHang(
	MaMH char(10) primary key,
	TenMH nvarchar(50) not null,
	Mota nvarchar(500),
	LinkHinhAnh char(100),
	GiaBan int default 0,
	SoLuong int default 0,
	DonViTinh nvarchar(10),
	HanSuDung Date,
	MaLoai char(10) references tblLoaiHang(MaLoai) on update cascade on delete cascade,
	MaKM char(10) references tblKhuyenMai(MaKM) on update cascade on delete cascade
)
create table tblKhachHang(
	MaKH char(10) primary key,
	TenKH nvarchar(50) not null,
	SDT char(10)
)
create table tblNhanVien(
	MaNV char(10) primary key,
	TenNV nvarchar(50) not null,
	GioiTinh int,
	NgaySinh date,
	DiaChi nvarchar(50),
	SDT char(10),
	Email char(50),
	Avatar nvarchar(max),
	CapQuyen int references tblQuyen(CapQuyen) on update cascade on delete cascade
)
create table tblHoaDonBan(
	MaHDB char(10) primary key,
	NgayBan date,
	MaNV char(10) references tblNhanVien(MaNV) on update cascade on delete cascade,
	MaKH char(10) references tblKhachHang(MaKH) on update cascade on delete cascade,
	TinhTrang int default 0,		-- 0 là đã thanh toán -- 1 là chưa thanh toán
)
create table tblChiTietHDB(
	MaHDB char(10) references tblHoaDonBan(MaHDB) on update cascade on delete cascade,
	MaMH char(10) references tblMatHang(MaMH) on update cascade on delete cascade,
	SoLg int not null,
	MaKM char(10) references tblKhuyenMai(MaKM),
	GiaBan int,
	primary key (MaHDB, MaMH)
)
create table tblHoaDonNhap(
	MaHDN char(10) primary key,
	NgayNhap date,
	MaNV char(10) references tblNhanVien(MaNV) on update cascade on delete cascade,
	MaNCC char(10) references tblNCC(MaNCC) on update cascade on delete cascade,
	TinhTrang int default 0
)
create table tblChiTietHDN(
	MaHDN char(10) references tblHoaDonNhap(MaHDN) on update cascade on delete cascade,
	MaMH char(10) references tblMatHang(MaMH) on update cascade on delete cascade,
	SoLg int not null,
	GiaNhap int default 0,
	primary key (MaHDN, MaMH)
)
create table tblTaiKhoanMatKhau(
	TaiKhoan char(50) primary key,
	MatKhau char(50),
	MaNV char(10) references tblNhanVien(MaNV) on update cascade on delete cascade
)
create table tblVoucher(
	MaV char(10) primary key,
	TenV nvarchar(50),
	MoTa nvarchar(max),
	GiaTri int default 0,
	DonVi nchar(10) references tblDonVi(DonVi) on update cascade on delete cascade,
	GTToiThieu int default 0, -- Tối thiểu để bắt đầu áp dụng voucher 
	GTToiDa int default 0, -- Mức tối đa có thể trừ
)
create table tblSoHuuVoucher(
	MaSHVc nvarchar(10) primary key,
	MaV char(10) references tblVoucher(MaV)on update cascade on delete cascade,
	MaKH char(10) references tblKhachHang(MaKH) on update cascade on delete cascade,
	TinhTrang int, -- 0 : Khả dụng -- 1 : Không khả dụng
	NgayBatDau date,
	NgayKetThuc date,
)
create table tblApDungVoucher(
	MaHDB char(10) references tblHoaDonBan(MaHDB) on update cascade on delete cascade,
	MaV char(10) references tblVoucher(MaV) on update cascade on delete cascade,
	GhiChu char(1) default(null),
	primary key (MaHDB, MaV)
)
create table tblGhiChu(
	MaHD char(10) primary key,
	NoiDung nvarchar (max)
)


--alter table tblNhanVien
--add GioiTinh int

--alter table tblNhanVien
--add Avatar nvarchar(max)

--alter table tblChiTietHDB
--add GiaBan int


alter table tblVoucher
alter column TenV nvarchar (max)

alter table tblsohuuVoucher
drop Constraint PK__tblSoHuu__35E527539231D7B2

exec sp_help tblsohuuvoucher

alter table tblVoucher
add Loai int
