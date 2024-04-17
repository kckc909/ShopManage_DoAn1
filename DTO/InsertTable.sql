delete table tblTaiKhoanMatKhau
delete table tblApDungVoucher
delete table tblSoHuuVoucher
delete table tblChiTietHDB
delete table tblChiTietHDN
delete table tblHoaDonNhap
delete table tblHoaDonBan
delete table tblKhachHang
delete table tblMatHang
delete table tblKhuyenMai
delete table tblNhanVien
delete table tblLoaiHang
delete table tblVoucher
delete table tblQuyen
delete table tblDonVi
delete table tblNCC
go

insert into tblDonVi
Values ('%'),(N'vnđ')

insert into tblQuyen(CapQuyen, Ten, MoTa)
values ('0', 'Admin', N'Quản trị tối cao'),
	('1','Staff',N'Quyền nhân viên')

insert into tblNhanVien(MaNV, TenNV, CapQuyen)
values ('NV000', N'Chu Đức Minh', '0')

insert into tblTaiKhoanMatKhau(TaiKhoan, MatKhau, MaNV)
Values ('admin','admin','NV000')
