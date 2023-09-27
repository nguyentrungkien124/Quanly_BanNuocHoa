CREATE DATABASE QuanLyCuaHangNuocHoa
GO 
USE  QuanLyCuaHangNuocHoa
GO

-- Tạo bảng Loại hàng
CREATE TABLE TheLoai (
    MaLoai  NCHAR(20) PRIMARY KEY,
    TenLoai NVARCHAR(50) NOT NULL
)
GO

-- Tạo bảng Sản phẩm 
CREATE TABLE SanPham (
    MaSP  NCHAR(20) PRIMARY KEY,
    TenMH NVARCHAR(50) NOT NULL,
	Size CHAR(5),
	GiaBan float,
    MaLoai  NCHAR(20),
    SoLuongTon INT,
    FOREIGN KEY (MaLoai) REFERENCES dbo.TheLoai(MaLoai)
)
GO

-- Tạo bảng Nhà cung cấp 
CREATE TABLE NhaCungCap (
    MaNCC  NCHAR(20) PRIMARY KEY,
    TenNCC NVARCHAR(50) NOT NULL,
    DiaChi NVARCHAR(100),
    SoDienThoai NVARCHAR(15)
)
GO

---Tạo bảng Khách hàng
CREATE TABLE KhachHang (
    MaKH VARCHAR(10) PRIMARY KEY,
	TenKH NVARCHAR(30) NOT NULL,
	MaSoThe varchar(10),
	GioiTinh NVARCHAR(5),
	NgaySinh date,
	Diachi VARCHAR(30),
	Email VARCHAR(50), 
	SDT char(10)
)
GO

---Tạo bảng nhân viên
CREATE TABLE NhanVien (
    MaNV NCHAR(20) PRIMARY KEY,
    TenNV NVARCHAR(50) NOT NULL,
    DiaChi NVARCHAR(100),
    DienThoai NVARCHAR(15),
	NgaySinh DATE
)
GO


-- Tạo bảng Hóa đơn nhập
CREATE TABLE HoaDonNhap (
    MaHD  NCHAR(20) PRIMARY KEY,
    NgayNhap DATE NOT NULL,
    MaNCC  NCHAR(20),
	MaNV NCHAR(20),
    FOREIGN KEY (MaNCC) REFERENCES dbo.NhaCungCap(MaNCC),
	FOREIGN KEY (MaNV) REFERENCES dbo.NhanVien(MaNV)
)
GO

-- Tạo bảng Hóa đơn xuất
CREATE TABLE HoaDonBan (
    MaHD  NCHAR(20) PRIMARY KEY,
    NgayBan DATE NOT NULL,
    MaNV NCHAR(20),
	MaKH VARCHAR(10),
	FOREIGN KEY (MaNV) REFERENCES dbo.NhanVien(MaNV),
    FOREIGN KEY (MaKH) REFERENCES dbo.KhachHang(MaKH)
)
GO

-- Tạo bảng Chi tiết hóa đơn nhập 
CREATE TABLE ChiTietHoaDonNhap(
    MaHD  NCHAR(20),
    MaSP  NCHAR(20),
    SoLuong INT,
    GiaNhap DECIMAL(10,2),
    FOREIGN KEY (MaHD) REFERENCES dbo.HoaDonNhap(MaHD),
    FOREIGN KEY (MaSP) REFERENCES dbo.SanPham(MaSP)
)
GO

-- Tạo bảng Chi tiết hóa đơn bán  
CREATE TABLE ChiTietHoaDonBan (
    MaHD  NCHAR(20),
    MaSP NCHAR(20),
    SoLuong INT,
    GiaBan FLOAT,
    FOREIGN KEY (MaHD) REFERENCES dbo.HoaDonBan(MaHD),
    FOREIGN KEY (MaSP) REFERENCES dbo.SanPham(MaSP)
)
GO



---------------CHÈN DỮ LIỆU-------------------
-- Chèn dữ liệu vào bảng LoaiHang
INSERT INTO TheLoai (MaLoai, TenLoai)
VALUES
('ML01', N'Nước Hoa Gucci'),
('ML02', N'Nước Hoa Dior'),
('ML03', N'Nước hoa Chanel'),
('ML04', N'Nước hoa Dolce & Gabbana'),
('ML05', N'Nước hoa Giorgio Armani'),
('ML06', N'Nước hoa BVLGARI'),
('ML07', N'Nước hoa Calvin Klein'),
('ML08', N'Nước hoa Valentino'),
('ML09', N'Nước hoa Jo Malone'),
('ML10', N'Nước hoa Versace')

-- Chèn dữ liệu vào bảng SanPham
INSERT INTO dbo.SanPham(MaSP, TenMH, MaLoai, soLuongton)
VALUES
('SP01', N'Gucci Guilty Pour Homme Eau de Toilette', 'ML01',20),
('SP02', N'Sauvage Eau de Parfum', 'ML02',20),
('SP03', N'Bleu De Chanel Eau de Toilette', 'ML03',20),
('SP04', N'The One Eau de Parfum For Men', 'ML04',20),
('SP05', N'Acqua Di Gio Pour Homme Eau de Toilette', 'ML05',20),
('SP06', N'AQVA Pour Homme Eau de Toilette', 'ML06',20),
('SP07', N'CK One Eau de Toilette', 'ML07',20),
('SP08', N'Uomo Intense Eau de Parfum', 'ML08',20),
('SP09', N'Wood Sage & Sea Salt Cologne', 'ML09',20),
('SP10', N'Eros Eau de Toilette', 'ML10',20)

-- Chèn dữ liệu vào bảng NhaCungCap
INSERT INTO NhaCungCap (MaNCC, TenNCC, DiaChi, SoDienThoai)
VALUES
('NCC01', N'Huy Dior', N'Hà Nội', '0123456789'),
('NCC02', N'Hưng Gucci', N'Hồ Chí Minh', '0123456789'),
('NCC03', N'Hoàng Chanel', N'Đà Nẵng', '0123456789'),
('NCC04', N'Quảng YSL', N'Nha Trang', '0123456789'),
('NCC05', N'Tùng Versace', N'Huế', '0123456789'),
('NCC06', N'Minh Tom Ford', N'Đồng Nai', '0123456789'),
('NCC07', N'Kiên Paco Rabanne', N'Hải Phòng', '0123456789'),
('NCC08', N'Thắng Givenchy', N'Bình Dương', '0123456789'),
('NCC09', N'Quốc Bvlgari', N'Cần Thơ', '0123456789'),
('NCC10', N'Quyến Hermes', N'Vũng Tàu', '0123456789')

-- Chèn dữ liệu vào bảng KhachHang
INSERT INTO KhachHang (MaKH, TenKH, MaSoThe, GioiTinh, NgaySinh, Diachi, Email, SDT)
VALUES
(N'KH001', N'Nguyễn Thi Xuân Mai', N'TT', N'Nữ', CAST(N'2004-12-24' AS Date), N'Hưng Yên', N'nguyenthixuanmai@gmail.com', N'0123456789'),
(N'KH002', N'Trần Kim Long', N'V', N'Nam', CAST(N'2003-09-05' AS Date), N'Hưng Yên', N'trankimlong@gmail.com', N'0123456788'),
(N'KH003', N'Dương Kim Linh', N'KC', N'Nữ', CAST(N'1999-12-12' AS Date), N'Hà Nội', N'duongkimlinh@gmail.com', N'0123456778'),
(N'KH004', N'Đặng Thanh Sơn', N'KC', N'Nam', CAST(N'2003-05-13' AS Date), N'Hải Dương', N'dangthanhson@gmail.com', N'0123456678'),
(N'KH005', N'Đỗ Tuấn Dương', N'KC', N'Nam', CAST(N'1999-02-16' AS Date), N'Hà Nam', N'dotuanduong@gmail.com', N'0123455678'),
(N'KH006', N'Lê Đức Mạnh', N'KC', N'Nam', CAST(N'2003-06-22' AS Date), N'Hưng Yên', N'leducmanh@gmail.com', N'0123445678'),
(N'KH007', N'Lê Thị Thanh Thảo', N'KC', N'Nữ', CAST(N'2003-04-25' AS Date), N'Hà Nội', N'lethithanhthao@gmail.com', N'0123345678'),
(N'KH008', N'Đỗ Thị Tuyết', N'KC', N'Nữ', CAST(N'2001-08-12' AS Date), N'Hà Nội', N'dothituyet@gmail.com', N'0122345678'),
(N'KH009', N'Võ Thanh Mai', N'KC', N'Nữ', CAST(N'2001-06-29' AS Date), N'Hà Nam', N'vothanhmai@gmail.com', N'0112345678'),
(N'KH010', N'Nguyễn Bình Minh', N'KC', N'Nam', CAST(N'2000-08-09' AS Date), N'Hải Dương', N'nguyenbinhminh@gmail.com', N'0123456798')

-- Chèn dữ liệu vào bảng NhanVien
INSERT INTO NhanVien (MaNV, TenNV, DiaChi, DienThoai, NgaySinh)
VALUES
('NV01', N'Nguyễn Văn Xuân', N'Hà Nội', '0123456789', '1990-01-01'),
('NV02', N'Trần Thị Yến', N'Hồ Chí Minh', '0987654321', '1995-03-15'),
('NV03', N'Lê Văn Đô', N'Đà Nẵng', '0123456789', '1985-06-20'),
('NV04', N'Phạm Thị Bính', N'Hải Phòng', '0987654321', '1992-09-10'),
('NV05', N'Nguyễn Văn Tuấn', N'Huế', '0123456789', '1998-12-05'),
('NV06', N'Hoàng Thị Thảo', N'Hà Nội', '0987654321', '1994-07-30'),
('NV07', N'Vũ Văn Sỹ', N'Hồ Chí Minh', '0123456789', '1991-04-25'),
('NV08', N'Nguyễn Thị Lan Anh', N'Đà Nẵng', '0987654321', '1987-08-12'),
('NV09', N'Lê Văn Quảng', N'Hải Phòng', '0123456789', '1993-11-18'),
('NV10', N'Trần Thị Phương Loan', N'Huế', '0987654321', '1996-02-28')

-- Chèn dữ liệu vào bảng HoaDonNhap
INSERT INTO HoaDonNhap (MaHD, NgayNhap, MaNCC, MaNV)
VALUES
('HDN01', '2023-01-05', 'NCC01', 'NV01'),
('HDN02', '2023-02-10', 'NCC02', 'NV02'),
('HDN03', '2023-03-15', 'NCC03', 'NV03'),
('HDN04', '2023-04-20', 'NCC04', 'NV04'),
('HDN05', '2023-05-25', 'NCC05', 'NV05'),
('HDN06', '2023-06-30', 'NCC06', 'NV06'),
('HDN07', '2023-07-05', 'NCC07', 'NV07'),
('HDN08', '2023-08-10', 'NCC08', 'NV08'),
('HDN09', '2023-09-15', 'NCC09', 'NV09'),
('HDN10', '2023-10-20', 'NCC10', 'NV10'),
('HDN12', '2023-10-20', 'NCC03', 'NV10')


-- Chèn dữ liệu vào bảng HoaDonBan
INSERT INTO HoaDonBan (MaHD, NgayBan, MaNV, MaKH)
VALUES
('HDB01', '2023-01-05', 'NV01', 'KH001'),
('HDB02', '2023-02-10', 'NV02', 'KH002'),
('HDB03', '2023-03-15', 'NV03', 'KH003'),
('HDB04', '2023-04-20', 'NV04', 'KH004'),
('HDB05', '2023-05-25', 'NV05', 'KH005'),
('HDB06', '2023-06-30', 'NV06', 'KH006'),
('HDB07', '2023-07-05', 'NV07', 'KH007'),
('HDB08', '2023-08-10', 'NV08', 'KH008'),
('HDB09', '2023-09-15', 'NV09', 'KH009'),
('HDB10', '2023-10-20', 'NV10', 'KH010')

-- Chèn dữ liệu vào bảng ChiTietHoaDonNhap
INSERT INTO ChiTietHoaDonNhap (MaHD, MaSP, SoLuong, GiaNhap)
VALUES
('HDN01', 'SP01', 2, 2400000),
('HDN02', 'SP02', 3, 2500000),
('HDN03', 'SP03', 4, 3000000),
('HDN04', 'SP04', 5, 3500000),
('HDN05', 'SP05', 6, 4000000),
('HDN06', 'SP06', 7, 4500000),
('HDN07', 'SP07', 8, 5000000),
('HDN08', 'SP08', 9, 5500000),
('HDN09', 'SP09', 10,6000000),
('HDN10', 'SP10', 11,6500000),
('HDN12', 'SP10', 11,6500000)

-- Chèn dữ liệu vào bảng ChiTietHoaDonBan
INSERT INTO ChiTietHoaDonBan (MaHD, MaSP, SoLuong, GiaBan)
VALUES
('HDB01', 'SP01', 2, 2400000),
('HDB02', 'SP02', 3, 2500000),
('HDB03', 'SP03', 4, 2500000),
('HDB04', 'SP04', 5, 3500000),
('HDB05', 'SP05', 6, 4000000),
('HDB06', 'SP06', 7, 4500000),
('HDB07', 'SP07', 8, 5000000),
('HDB08', 'SP08', 9, 6000000),
('HDB09', 'SP09', 10, 6500000),
('HDB10', 'SP10', 11, 7000000)

SELECT * FROM dbo.NhanVien
SELECT * FROM dbo.KhachHang
SELECT * FROM dbo.TheLoai
SELECT * FROM  dbo.NhaCungCap
SELECT * FROM dbo.SanPham
SELECT * FROM  dbo.HoaDonNhap
SELECT * FROM  dbo.ChiTietHoaDonNhap
SELECT * FROM  dbo.HoaDonBan
SELECT * FROM  dbo.ChiTietHoaDonBan

--Thêm Khách hàng
CREATE PROCEDURE [dbo].[sp_khachhang_create]
(	
	@MaKH VARCHAR(10),
	@TenKH NVARCHAR(30),
	@MaSoThe varchar(10),
	@GioiTinh NVARCHAR(5),
	@NgaySinh date,
	@Diachi VARCHAR(30),
	@Email VARCHAR(50), 
	@SDT char(10)
)
AS 
begin
insert into KhachHang(MaKH,TenKH,MaSoThe,GioiTinh,NgaySinh,DiaChi,Email,SDT) values (@MaKH,@TenKH,@MaSoThe,@GioiTinh,@NgaySinh,@DiaChi,@Email,@SDT)
end

-----Tìm kiếm khách hàng theo mã
CREATE PROCEDURE [dbo].[sp_searchKH_by_MaNV]
	@MaKH VARCHAR(10)
AS
BEGIN
	SELECT * FROM KhachHang AS KH WHERE KH.MaKH=@MaKH
END

--Cập nhật thông tin khach hang
CREATE PROC [dbo].[sp_khachhang_update]
	@MaKH VARCHAR(10),
	@TenKH NVARCHAR(30),
	@MaSoThe varchar(10),
	@GioiTinh NVARCHAR(5),
	@NgaySinh date,
	@Diachi VARCHAR(30),
	@Email VARCHAR(50), 
	@SDT char(10)
AS
BEGIN
	UPDATE KhachHang SET MaKH=@MaKH, TenKH=@TenKH, MaSoThe=@MaSoThe, GioiTinh=@GioiTinh, NgaySinh=@NgaySinh, Diachi=@Diachi, Email=@Email, SDT=@SDT WHERE MaKH=@MaKH
END

--Xóa khach hang theo ma
CREATE PROC [dbo].[sp_DeleteKH]	
	@MaKH VARCHAR(10)
AS
BEGIN 
	DELETE KhachHang WHERE @MaKH=MaKH
END

---Thủ tục thêm NHÂN VIÊN
create proc sp_nhanvien_create 
 @MaNV nchar(20),
 @TenNV nvarchar(50),
 @DiaChi nvarchar(100),
 @Dienthoai nvarchar(15),
 @ngaysinh date
 as
 begin
	insert into NhanVien(MaNV,TenNV,DiaChi,DienThoai,ngaysinh) values (@MaNV,@TenNV,@DiaChi,@Dienthoai,@ngaysinh)
 end

 -----Tìm kiếm nhân viên by Mã NV
 create proc sp_searchNV_by_MaNV
 @MaNV nchar(20)
 as
 begin 
 select * From NhanVien as nv where nv.MaNV=@MaNV
 end

 ----Cập nhật thông tin Nhân Viên
create proc sp_nhanvien_update
 @MaNV nchar(20),
 @TenNV nvarchar(50) ,
 @DiaChi nvarchar(100) ,
 @Dienthoai nvarchar(15),
 @ngaysinh date 
 as
 begin
	update NhanVien Set TenNV=@TenNV,DiaChi=@DiaChi,DienThoai=@Dienthoai,ngaysinh=@ngaysinh where MaNV=@MaNV
 end
 
 ----Xóa nhân viên theo mã 
 create proc sp_DeleteNV
 @MaNV nchar(20)
 as
 begin 
 delete NhanVien where @MaNV=MaNV
 end
