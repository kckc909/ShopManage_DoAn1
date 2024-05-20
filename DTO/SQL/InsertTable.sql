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

insert into tblKhuyenMai(MaKM, TenKM, PhamTramGiam)
values ('KM00', N'Không khuyến mãi', 0)
insert into tblKhuyenMai(MaKM, TenKM, PhamTramGiam)
values ('KM01', N'Khuyến mãi 30/4-1/5', 30)

insert into tblLoaiHang(MaLoai, TenLoai, MoTa)
values ('LH00',N'Chưa xác định',N'')
,('LH10',N'Giặt Giũ & Chăm Sóc Nhà Cửa',N'')
,('LH11',N'Máy Tính & LapTop',N'')
,('LH12 ',N'Máy Ảnh & Máy Quay Phim',N'')
,('LH13 ',N'Mẹ & Bé	Bỉm sữa quẩn áo trẻ em',N'')
,('LH14',N'Nhà Sách',N'')
,('LH2',N'Thiết bị điện tử',N'tivi, điện thại, tai nghe,...')
,('LH3 ',N'Balo & Túi ví Nam',N'balo, túi, ví')
,('LH4',N'Thực phẩm',N'Thực phẩm, đồ ăn nhanh, đồ ăn vặt')
,('LH6',N'Chăm sóc thú cưng',N'Thức ăn cho thú cưng, phụ kiện thú cưng')
,('LH7',N'Dụng cụ và thiết bị tiện ích',N'Tools')
,('LH8 ',N'Giày Dép Nam',N'')
,('LH9',N'Giày Dép Nữ',N'')


       		
       		
      		 
       		 