
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
	MaLoai varchar(10) primary key,
	TenLoai nvarchar(50) not null,
	MoTa nvarchar(max)
)
create table tblNCC(
	MaNCC varchar(10) primary key,
	TenNCC nvarchar(max) not null,
	DiaChi nvarchar(50),
	SDT varchar(10),
	Email varchar(50)
)
create table tblKhuyenMai(
	MaKM varchar(10) primary key,
	TenKM nvarchar(30),
	MoTa nvarchar(max),
	PhamTramGiam int default 0,
	NgayBatDau date,
	NgayKetThuc date
)
create table tblMatHang(
	MaMH varchar(10) primary key,
	TenMH nvarchar(50) not null,
	Mota nvarchar(500),
	LinkHinhAnh varchar(100),
	GiaBan int default 0,
	GiaNhap int default 0,
	SoLuong int default 0,
	DonViTinh nvarchar(10),
	HanSuDung Date,
	MaLoai varchar(10) references tblLoaiHang(MaLoai) on update cascade on delete cascade,
	MaKM varchar(10) references tblKhuyenMai(MaKM) on update cascade on delete cascade
)
create table tblKhachHang(
	MaKH varchar(10) primary key,
	TenKH nvarchar(50) not null,
	SDT varchar(10)
)
create table tblNhanVien(
	MaNV varchar(10) primary key,
	TenNV nvarchar(50) not null,
	GioiTinh int,
	NgaySinh date,
	DiaChi nvarchar(50),
	SDT varchar(10),
	Email varchar(50),
	Avatar nvarchar(max),
	CapQuyen int references tblQuyen(CapQuyen) on update cascade on delete cascade
)
create table tblHoaDonBan(
	MaHDB varchar(16) primary key,
	NgayBan date,
	MaNV varchar(10) references tblNhanVien(MaNV) on update cascade on delete cascade,
	MaKH varchar(10) references tblKhachHang(MaKH) on update cascade on delete cascade,
	TinhTrang int default 0,		-- 0 là đã thanh toán -- 1 là chưa thanh toán
)
create table tblChiTietHDB(
	MaHDB varchar(16) references tblHoaDonBan(MaHDB) on update cascade on delete cascade,
	MaMH varchar(10) references tblMatHang(MaMH) on update cascade on delete cascade,
	SoLg int not null,
	MaKM varchar(10) references tblKhuyenMai(MaKM),
	GiaBan int,
	primary key (MaHDB, MaMH)
)
create table tblHoaDonNhap(
	MaHDN varchar(16) primary key,
	NgayNhap date,
	MaNV varchar(10) references tblNhanVien(MaNV) on update cascade on delete cascade,
	MaNCC varchar(10) references tblNCC(MaNCC) on update cascade on delete cascade,
	TinhTrang int default 0
)
create table tblChiTietHDN(
	MaHDN varchar(16) references tblHoaDonNhap(MaHDN) on update cascade on delete cascade,
	MaMH varchar(10) references tblMatHang(MaMH) on update cascade on delete cascade,
	SoLg int not null,
	GiaNhap int default 0,
	primary key (MaHDN, MaMH)
)
create table tblTaiKhoanMatKhau(
	TaiKhoan varchar(50) primary key,
	MatKhau varchar(50),
	MaNV varchar(10) references tblNhanVien(MaNV) on update cascade on delete cascade
)
create table tblVoucher(
	MaV varchar(10) primary key,
	TenV nvarchar(50),
	MoTa nvarchar(max),
	GiaTri int default 0,
	DonVi nchar(10) references tblDonVi(DonVi) on update cascade on delete cascade,
	GTToiThieu int default 0, -- Tối thiểu để bắt đầu áp dụng voucher 
	GTToiDa int default 0, -- Mức tối đa có thể trừ
	Loai int
)
create table tblSoHuuVoucher(
	MaSHVc nvarchar(10) primary key,
	MaV varchar(10) references tblVoucher(MaV)on update cascade on delete cascade,
	MaKH varchar(10) references tblKhachHang(MaKH) on update cascade on delete cascade,
	TinhTrang int, -- 0 : Khả dụng -- 1 : Không khả dụng
	NgayBatDau date,
	NgayKetThuc date,
)
create table tblApDungVoucher(
	MaHDB varchar(16) references tblHoaDonBan(MaHDB) on update cascade on delete cascade,
	MaV varchar(10) references tblVoucher(MaV) on update cascade on delete cascade,
	GhiChu varchar(1) default(null),
	primary key (MaHDB, MaV)
)
create table tblGhiChu(
	MaHD varchar(16) primary key,
	NoiDung nvarchar (max)
)

