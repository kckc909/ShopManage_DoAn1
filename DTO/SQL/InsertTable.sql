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


INSERT INTO tblMatHang (MaMH, TenMH, Mota, LinkHinhAnh, GiaBan, SoLuong, DonViTinh, HanSuDung, MaLoai, MaKM)
VALUES
    ('MH001', N'Máy Giặt Electrolux 8kg', N'Máy giặt cửa trước 8kg', NULL, 5999000, 50, N'Chiếc', '2025-12-31', 'LH10', 'KM00'),
    ('MH002', N'Máy Lạnh LG Inverter 2HP', N'Máy lạnh 2HP, công nghệ Inverter', NULL, 9499000, 30, N'Chiếc', '2026-06-30', 'LH10', 'KM00'),
    ('MH003', N'Laptop Asus VivoBook', N'Laptop 15 inch, Core i5, RAM 8GB', NULL, 15999000, 20, N'Chiếc', '2027-03-31', 'LH11', 'KM00'),
    ('MH004', N'Canon EOS 2000D', N'Máy ảnh DSLR, 24MP, có WiFi', NULL, 9999000, 15, N'Chiếc', '2028-09-30', 'LH12', 'KM00'),
    ('MH005', N'Bỉm Huggies size M', N'Bỉm Huggies size M, gói 64 miếng', NULL, 299000, 100, N'Gói', '2024-11-30', 'LH13', 'KM00'),
    ('MH006', N'Sữa Ensure vani', N'Sữa dinh dưỡng vani, 237ml x48 lon', NULL, 1499000, 80, N'Thùng', '2025-06-30', 'LH13', 'KM00'),
    ('MH007', N'Sách Nghệ Thuật Sống Đẹp', N'Sách tâm lý - kỹ năng sống', NULL, 250000, 30, N'Cuốn', '2025-12-31', 'LH14', 'KM00'),
    ('MH008', N'Tivi Samsung 43 inch', N'Tivi LED Full HD, 43 inch', NULL, 7499000, 25,N'Chiếc', '2026-09-30', 'LH2', 'KM00'),
    ('MH009', N'Điện Thoại Oppo Reno4', N'Điện thoại 5G, camera 48MP', NULL, 6999000, 35,N'Chiếc', '2024-12-31', 'LH2', 'KM00'),
    ('MH010', N'Balo Adidas Originals', N'Balo thời trang, chất liệu bền', NULL, 999000, 40,N'Chiếc', '2027-06-30', 'LH3', 'KM00');
       		
INSERT INTO tblMatHang (MaMH, TenMH, Mota, LinkHinhAnh, GiaBan, SoLuong, DonViTinh, HanSuDung, MaLoai, MaKM)
VALUES
    ('MH011', N'Tủ Lạnh Samsung Inverter 208L', N'Tủ lạnh 2 cửa, công nghệ Inverter', NULL, 6999000, 18,N'Chiếc', '2027-12-31', 'LH10', 'KM00'),
    ('MH012', N'Lò Vi Sóng Panasonic 20L', N'Lò vi sóng 20 lít, công nghệ inverter', NULL, 2499000, 25,N'Chiếc', '2026-06-30', 'LH10', 'KM00'),
    ('MH013', N'Nồi Cơm Điện Toshiba 1.8L', N'Nồi cơm điện dung tích 1.8 lít', NULL, 699000, 35,N'Chiếc', '2025-09-30', 'LH10', 'KM00'),
    ('MH014', N'Bàn Ủi Hơi Nước Philips', N'Bàn ủi hơi nước, công suất 2200W', NULL, 999000, 20,N'Chiếc', '2026-03-31', 'LH10', 'KM00'),
    ('MH015', N'Đầu Đĩa Blu-ray Sony', N'Đầu phát Blu-ray, hỗ trợ 4K', NULL, 3499000, 15,N'Chiếc', '2027-09-30', 'LH11', 'KM00'),
    ('MH016', N'Máy In Đa Năng HP Officejet', N'Máy in, photocopy, scan, fax', NULL, 2999000, 22,N'Chiếc', '2026-12-31', 'LH11', 'KM00'),
    ('MH017', N'Bàn Phím Cơ Logitech G513', N'Bàn phím cơ, kết nối USB', NULL, 1499000, 28,N'Chiếc', '2025-06-30', 'LH11', 'KM00'),
    ('MH018', N'Chuột Không Dây Logitech M185', N'Chuột không dây, pin sử dụng 12 tháng', NULL, 299000, 40,N'Chiếc', '2025-03-31', 'LH11', 'KM00'),
    ('MH019', N'Dàn Âm Thanh Sony HT-X8500', N'Dàn âm thanh soundbar, Dolby Atmos', NULL, 7999000, 12, 'Bộ', '2027-06-30', 'LH12', 'KM00'),
    ('MH020', N'Ống Kính Canon EF 50mm f/1.8', N'Ống kính góc tiêu chuẩn, khẩu độ lớn', NULL, 2199000, 18,N'Chiếc', '2026-09-30', 'LH12', 'KM00');
      		 


INSERT INTO tblKhuyenMai (MaKM, TenKM, MoTa, PhamTramGiam, NgayBatDau, NgayKetThuc)
VALUES
    ('KM6', N'Khuyến mãi Tết Nguyên Đán', N'Giảm giá 15% các sản phẩm', 15, '2024-01-01', '2024-01-31'),
    ('KM2', N'Khuyến mãi lễ Quốc Khánh', N'Giảm giá 10% các sản phẩm', 10, '2024-09-01', '2024-09-10'),
    ('KM3', N'Khuyến mãi Giáng Sinh', N'Giảm giá 12% các sản phẩm', 12, '2023-12-15', '2023-12-31'),
    ('KM4', N'Khuyến mãi dịp Black Friday', N'Giảm giá 20% các sản phẩm', 20, '2023-11-24', '2023-11-26'),
    ('KM5', N'Khuyến mãi lễ 8/3', N'Giảm giá 8% các sản phẩm', 8, '2024-03-01', '2024-03-10');

INSERT INTO tblNCC(MaNCC, TenNCC, DiaChi, SDT, Email)
VALUES
    ('NCC001', N'Công Ty Công Nghệ Sông Đà Lạt', N'Đường Nguyễn Văn Bá Hồ, TP. Đà Lạt', '0123456789', 'ncc001@example.com'),
    ('NCC002', N'Điện Máy Nhật Viei', N'12 Hùng Vương, Quận 1, TP Hồ Chí Minh', '0987654321', 'ncc002@example.com'),
    ('NCC003', N'Phụ Tùng Ô Tô Điện Máy Gia', N'678 Lê Đại Hành, Quận 5, TP Hồ Chí Minh', '0654789123', 'ncc003@example.com'),
    ('NCC004', N'Giá Đặc Sản Vùng Miền Trung', N'123 Trần Phú, TP. Đà Nẵng', '0258741369', 'ncc004@example.com'),
    ('NCC005', N'Vật Liệu Xây Dựng Hồ Bắc', N'456 Lê Văn Sỹ, Quận Bình Tân, TP Hồ Chí Minh', '0147852369', 'ncc005@example.com');
insert into tblNCC
values('NCC0',N'Tự sản xuất',N'Hưng Yên','0835673126', 'chuducminh253261@gmail.com')

INSERT INTO tblVoucher (MaV, TenV, MoTa, GiaTri, DonVi, GTToiThieu, GTToiDa, Loai)
VALUES
    ('V001', N'Voucher Giảm Giá 10%', N'Voucher áp dụng giảm 10% tổng hóa đơn', 10, '%', 1, 1, 0),
    ('V003', N'Voucher Giảm 50.000 VNĐ', N'Voucher giảm trực tiếp 50.000 VNĐ', 50000.00, 'VNĐ', 1, 1, 0),
    ('V005', N'Voucher Giảm 20% Tối Đa 200.000 VNĐ', N'Voucher giảm 20% tối đa 200.000 VNĐ', 20, '%', 1, 200000, 0);

INSERT INTO tblNhanVien (MaNV, TenNV, GioiTinh, NgaySinh, DiaChi, SDT, Email, Avatar, CapQuyen)
VALUES
    ('NV001', N'Nguyễn Văn Anh', 1, '2000-05-15', N'Hà Nội', '0987654321', 'nguyen.van.anh@company.com', NULL, 1),
    ('NV002', N'Trần Thị Bình', 0, '2001-08-22', N'Hải Phòng', '0123456789', 'tran.thi.binh@company.com', NULL, 1),
    ('NV003', N'Lê Văn Cường', 1, '2002-11-30', N'Hải Dương', '0456789123', 'le.van.cuong@company.com', NULL, 1),
    ('NV004', N'Phạm Thị Duyên', 0, '2003-03-07', N'Thái Bình', '0789012345', 'pham.thi.duyen@company.com', NULL, 1),
    ('NV005', N'Hoàng Văn Thái', 1, '2004-09-18', N'Bắc Ninh', '0159753852', 'hoang.van.emile@company.com', NULL, 1);


	INSERT INTO tblVoucher(MaV, TenV, MoTa, GiaTri, DonVi, GTToiThieu, GTToiDa, Loai)
VALUES
  ('V002', N'Voucher Giảm 10%', N'Giảm 10% trên tổng đơn hàng', 10, '%', 100000, 500000, 1),
  ('V004', N'Voucher Giảm 20000 VNĐ', N'Giảm 20000 VNĐ trên tổng đơn hàng', 20000, N'vnđ', 50000, 300000, 1),
  ('V006', N'Voucher Giảm 15%', N'Giảm 15% trên tổng đơn hàng', 15, '%', 150000, 800000,1),
  ('V007', N'Voucher Giảm 30000 VNĐ', N'Giảm 30000 VNĐ trên tổng đơn hàng', 30000, N'vnđ', 80000, 400000, 1);