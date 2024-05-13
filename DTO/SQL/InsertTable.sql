delete tblTaiKhoanMatKhau
delete tblApDungVoucher
delete tblSoHuuVoucher
delete tblChiTietHDB
delete  tblChiTietHDN
delete tblHoaDonNhap
delete  tblHoaDonBan
delete  tblKhachHang
delete  tblMatHang
delete  tblKhuyenMai
delete  tblNhanVien
delete  tblLoaiHang
delete  tblVoucher
delete  tblQuyen
delete  tblDonVi
delete  tblNCC
go

insert into tblDonVi
Values ('%'),(N'vnđ')

insert into tblQuyen(CapQuyen, Ten, MoTa)
values ('0', 'Admin', N'Quản trị tối cao'),
	('1','Staff',N'Quyền nhân viên')

insert into tblNhanVien(MaNV, TenNV, CapQuyen)
values ('NV000', N'Chủ cửa hàng', '0')

insert into tblTaiKhoanMatKhau(TaiKhoan, MatKhau, MaNV)
Values ('admin','admin','NV000'), ('a', 'a' ,'NV000')

insert into tblLoaiHang (MaLoai,TenLoai)
values ('LH00' ,N'Chưa xác định')

insert into tblKhuyenMai(MaKM, TenKM, PhamTramGiam)
values ('KM00', N'Không khuyến mãi', 0)
insert into tblKhuyenMai(MaKM, TenKM, PhamTramGiam)
values ('KM01', N'Khuyến mãi 30/4-1/5', 30)

insert into tblMatHang(MaMH, TenMH, LinkHinhAnh,MaKM)
values ('MH000', N'MatHangTest', 'C:\Users\admin\Pictures\Icon\icons8-image-50.png', 'KM00')
insert into tblMatHang(MaMH, TenMH, LinkHinhAnh,MaKM)
values ('MH001', N'MatHangTest', 'C:\Users\admin\Pictures\Icon\icons8-image-50.png', 'KM00')
insert into tblMatHang(MaMH, TenMH, LinkHinhAnh,MaKM)
values ('MH002', N'MatHangTest', 'C:\Users\admin\Pictures\Icon\icons8-image-50.png', 'KM00')
insert into tblMatHang(MaMH, TenMH, LinkHinhAnh,MaKM)
values ('MH003', N'MatHangTest', 'C:\Users\admin\Pictures\Icon\icons8-image-50.png', 'KM00')
insert into tblMatHang(MaMH, TenMH, LinkHinhAnh,MaKM)
values ('MH004', N'MatHangTest1', 'C:\Users\admin\Pictures\Icon\icons8-image-50.png', 'KM01')
insert into tblMatHang(MaMH, TenMH, LinkHinhAnh,MaKM)
values ('MH005', N'MatHangTest2', 'C:\Users\admin\Pictures\Icon\icons8-image-50.png', 'KM01')
insert into tblMatHang(MaMH, TenMH, LinkHinhAnh,MaKM, GiaBan)
values ('MH006', N'MatHangTest2', 'C:\Users\admin\Pictures\Icon\icons8-image-50.png', 'KM01', '100000')

