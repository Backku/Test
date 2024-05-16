Create database QLSanBong
go
use QLSanBong
go
CREATE TABLE [dbo].[Chitiethoadon] (
    [MaChitiethoadon] INT      NOT NULL,
    [MaHoaDon]        INT      NULL,
    [MaSanBong]       INT      NULL,
    [MaDichVu]        INT      NULL,
    [GioBatDau]       TIME (7) NULL,
    [GioKetThuc]      TIME (7) NULL,
    PRIMARY KEY CLUSTERED ([MaChitiethoadon] ASC),
    FOREIGN KEY ([MaHoaDon]) REFERENCES [dbo].[HoaDon] ([MaHoaDon]),
    FOREIGN KEY ([MaSanBong]) REFERENCES [dbo].[SanBong] ([MaSanBong]),
    FOREIGN KEY ([MaDichVu]) REFERENCES [dbo].[DichVu] ([MaDichVu])
);
go
CREATE TABLE [dbo].[DichVu] (
    [MaDichVu]  INT            NOT NULL,
    [TenDichVu] NVARCHAR (100) NULL,
    [GiaBan]    MONEY          NULL,
    [GiaNhap]   MONEY          NULL,
    [SoLuong]   INT            NULL,
    PRIMARY KEY CLUSTERED ([MaDichVu] ASC)
);
go
CREATE TABLE [dbo].[HoaDon] (
    [MaHoaDon]    INT   NOT NULL,
    [MaSanBong]   INT   NULL,
    [MaDichVu]    INT   NULL,
    [MaKhachHang] INT   NULL,
    [NgayXuat]    DATE  NULL,
    [TongTien]    MONEY NULL,
    PRIMARY KEY CLUSTERED ([MaHoaDon] ASC),
    FOREIGN KEY ([MaSanBong]) REFERENCES [dbo].[SanBong] ([MaSanBong]),
    FOREIGN KEY ([MaDichVu]) REFERENCES [dbo].[DichVu] ([MaDichVu]),
    FOREIGN KEY ([MaKhachHang]) REFERENCES [dbo].[KhachHang] ([MaKhachHang])
);
go
CREATE TABLE [dbo].[KhachHang] (
    [MaKhachHang] INT            NOT NULL,
    [HoTen]       NVARCHAR (100) NULL,
    [SoDienThoai] NVARCHAR (20)  NULL,
    [DiaChi]      NVARCHAR (255) NULL,
    PRIMARY KEY CLUSTERED ([MaKhachHang] ASC)
);
go
CREATE TABLE [dbo].[LichDatSan] (
    [MaDatSan]    INT  NOT NULL,
    [MaKhachHang] INT  NULL,
    [MaHoaDon]    INT  NULL,
    [ThoiGian]    DATE NULL,
    PRIMARY KEY CLUSTERED ([MaDatSan] ASC),
    FOREIGN KEY ([MaKhachHang]) REFERENCES [dbo].[KhachHang] ([MaKhachHang]),
    FOREIGN KEY ([MaHoaDon]) REFERENCES [dbo].[HoaDon] ([MaHoaDon])
);
go
CREATE TABLE [dbo].[Quanlyvattu] (
    [Maso]      INT NOT NULL,
    [MaSanBong] INT NULL,
    [Tenvattu]  INT NULL,
    [Soluong]   INT NULL,
    [Bosung]    INT NULL,
    [Mota]      INT NULL,
    [Tinhtrang] INT NULL,
    [Yeucau]    INT NULL,
    PRIMARY KEY CLUSTERED ([Maso] ASC),
    FOREIGN KEY ([MaSanBong]) REFERENCES [dbo].[SanBong] ([MaSanBong])
);
go
CREATE TABLE [dbo].[SanBong] (
    [MaSanBong]    INT            NOT NULL,
    [TenSan]       NVARCHAR (100) NULL,
    [LoaiSan]      NVARCHAR (50)  NULL,
    [TinhTrangSan] NVARCHAR (50)  NULL,
    [DonGia]       MONEY          NULL,
    PRIMARY KEY CLUSTERED ([MaSanBong] ASC)
);
go