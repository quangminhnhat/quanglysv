create database doanDB
go

use doanDB
go

-- Table: Khoa
CREATE TABLE Khoa (
    MaKhoa VARCHAR(10) PRIMARY KEY,
    TenKhoa NVARCHAR(100) NOT NULL
);

-- Table: LOAITTAIKHOAN
CREATE TABLE LOAITTAIKHOAN (
    MaTK VARCHAR(10) PRIMARY KEY,
    TenTK NVARCHAR(100) NOT NULL
);

-- Table: SinhVien
CREATE TABLE SinhVien (
    MaSinhVien VARCHAR(10) PRIMARY KEY,
    HoTen NVARCHAR(100) NOT NULL,
    sdt VARCHAR(12),
    NgaySinh DATE,
    GioiTinh NVARCHAR(10),
    TenLop NVARCHAR(100),
    MaKhoa VARCHAR(10),
    DiemQT INT CHECK (DiemQT BETWEEN 0 AND 100),
    DiemTK INT CHECK (DiemTK BETWEEN 0 AND 100),
    FOREIGN KEY (MaKhoa) REFERENCES Khoa(MaKhoa)
);

-- Table: TAIKHOAN
CREATE TABLE TAIKHOAN (
    TEN NVARCHAR(100) PRIMARY KEY NOT NULL,
    MK VARCHAR(50) NOT NULL,
    MaTK VARCHAR(10),
    FOREIGN KEY (MaTK) REFERENCES LOAITTAIKHOAN(MaTK)
);




-- Thêm dữ liệu vào bảng Khoa
INSERT INTO Khoa (MaKhoa, TenKhoa)
VALUES
    ('K001', N'Công nghệ thông tin'),
    ('K002', N'Kinh tế'),
    ('K003', N'Luật');



-- Thêm dữ liệu vào bảng SinhVien
INSERT INTO SinhVien (MaSinhVien, HoTen, sdt, NgaySinh, GioiTinh, TenLop, MaKhoa, DiemQT, DiemTK)
VALUES
    ('SV001', N'Nguyễn Văn A', '0987654321', '2002-05-10', N'Nam', N'Lớp CNTT01', 'K001', 85, 90),
    ('SV002', N'Trần Thị B', '0976543210', '2003-03-22', N'Nữ', N'Lớp CNTT02', 'K001', 78, 88),
    ('SV003', N'Lê Văn C', '0912345678', '2001-09-12', N'Nam', N'Lớp KT01', 'K002', 92, 87);



-- Thêm dữ liệu vào bảng LOAITTAIKHOAN
INSERT INTO LOAITTAIKHOAN (MaTK, TenTK)
VALUES
    ('TK001', N'Quản trị viên'),
    ('TK002', N'Giáo viên');

-- Thêm dữ liệu vào bảng TAIKHOAN
INSERT INTO TAIKHOAN (TEN, MK, MATK)
VALUES
    (N'Admin1', '123456', 'TK001'),
    (N'GV_NguyenVanA', 'password', 'TK002');
