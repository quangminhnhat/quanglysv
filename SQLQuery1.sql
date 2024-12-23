
CREATE TABLE SinhVien (
    MaSinhVien CHAR(10) PRIMARY KEY,
    HoTen NVARCHAR(100),
	LienHe CHAR(12),
    NgaySinh DATE,
    GioiTinh NVARCHAR(10),
    TenLop NVARCHAR(100),
    MaKhoa CHAR(10),
	DiemQT int CHECK (DiemQT BETWEEN 0 AND 100),
	DiemTK int CHECK (DiemQT BETWEEN 0 AND 100),
    FOREIGN KEY (MaKhoa) REFERENCES Khoa(MaKhoa)
);

-- Bảng Khoa
CREATE TABLE Khoa (
    MaKhoa CHAR(10) PRIMARY KEY,
    TenKhoa NVARCHAR(100)
);

CREATE TABLE TAIKHOAN(
	TEN NVARCHAR(100),
	MK CHAR(50),
	MATK CHAR(10),
		FOREIGN KEY (MaTK) REFERENCES LOAITTAIKHOAN(MaTK)
);
CREATE TABLE LOAITTAIKHOAN(
MATK CHAR(10) PRIMARY KEY,
TENTK NVARCHAR(100)
);



-- Thêm dữ liệu vào bảng Khoa
INSERT INTO Khoa (MaKhoa, TenKhoa)
VALUES
    ('K001', N'Công nghệ thông tin'),
    ('K002', N'Kinh tế'),
    ('K003', N'Luật');



-- Thêm dữ liệu vào bảng SinhVien
INSERT INTO SinhVien (MaSinhVien, HoTen, LienHe, NgaySinh, GioiTinh, TenLop, MaKhoa, DiemQT, DiemTK)
VALUES
    ('SV001', N'Nguyễn Văn A', '0987654321', '2002-05-10', N'Nam', N'Lớp CNTT01', 'K001', 85, 90),
    ('SV002', N'Trần Thị B', '0976543210', '2003-03-22', N'Nữ', N'Lớp CNTT02', 'K001', 78, 88),
    ('SV003', N'Lê Văn C', '0912345678', '2001-09-12', N'Nam', N'Lớp KT01', 'K002', 92, 87);



-- Thêm dữ liệu vào bảng LOAITTAIKHOAN
INSERT INTO LOAITTAIKHOAN (MaTK, TenTK)
VALUES
    ('TK001', N'Quản trị viên'),
    ('TK002', N'Giáo viên'),
    ('TK003', N'Sinh viên');

-- Thêm dữ liệu vào bảng TAIKHOAN
INSERT INTO TAIKHOAN (MaTaiKhoan, Ten, MatKhau, MaTK)
VALUES
    ('TK001A', N'Admin1', '123456', 'TK001'),
    ('TK002B', N'GV_NguyenVanA', 'password', 'TK002'),
    ('TK003C', N'SV_TranThiB', '123456', 'TK003');