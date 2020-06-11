create table HOCSINH (
	MaHocSinh decimal(10,0) primary key,
	HoTen nvarchar(30),
	GioiTinh bit,
	NgaySinh smalldatetime,
	DiaChi nvarchar(50),
	Email nvarchar(40)
)

create table KHOILOP (
	MaKhoiLop decimal(10,0) primary key,
	TenKhoiLop nvarchar(10)
)

create table DANHSACHLOP (
	MaLop decimal(10,0) primary key,
	TenLop nvarchar(10),
	SiSo tinyint,
	MaKhoiLop decimal(10,0) foreign key references KHOILOP(MaKhoiLop) 
)

create table CHITIETDSLOP (
	MaChiTietDSLop decimal(10,0) primary key,
	MaHocSinh decimal(10,0) foreign key references HOCSINH(MaHocSinh),
	MaLop decimal(10,0) foreign key references DANHSACHLOP(MaLop)
)

create table MONHOC (
	MaMonHoc decimal(10,0) primary key,
	TenMonHoc nvarchar(20)
)

create table HOCKY (
	MaHocKy decimal(10,0) primary key,
	TenHocKy nvarchar(10),
	HocKy nvarchar(10)
)

create table BANGDIEMMON (
	MaBangDiemMH decimal(10,0) primary key,
	MaHocSinh decimal(10,0) foreign key references HOCSINH(MaHocSinh),
	MaMonHoc decimal(10, 0) foreign key references MONHOC(MaMonHoc),
	MaHocKy decimal(10, 0) foreign key references HOCKY(MaHocKy),
	MaLop decimal(10,0) foreign key references DANHSACHLOP(MaLop),
	DiemTB float
)

create table LOAIKT (
	MaLoaiKT decimal(10,0) primary key,
	TenLoaiKT nvarchar(20)
)

create table DIEM (
	MaBangDiemMH decimal(10,0) foreign key references BANGDIEMMON(MaBangDiemMH),
	MaLoaiKT decimal(10,0) foreign key references LOAIKT(MaLoaiKT),
	DiemSo float,
	primary key(MaBangDiemMH, MaLoaiKT)
)

create table BCMON (
	MaBCMon decimal(10,0) primary key,
	MaHocKy decimal(10,0) foreign key references HOCKY(MaHocKy),
	MaMonHoc decimal(10,0) foreign key references MONHOC(MaMonHoc)
)

create table CTBCMON (
	MaBCMon decimal(10,0) foreign key references BCMON(MaBCMon),
	MaLop decimal(10,0) foreign key references DANHSACHLOP(MaLop),
	SLDatMon tinyint,
	TLDatMon float,
	primary key(MaBCMon, MaLop)
)

create table BCHOCKY (
	MaBCHocKy decimal(10,0) primary key,
	MaHocKy decimal(10,0) foreign key references HOCKY(MaHocKy)
)

create table CTBCHOCKY (
	MaBCHocKy decimal(10,0) foreign key references BCHOCKY(MaBCHocKy),
	MaLop decimal(10,0) foreign key references DANHSACHLOP(MaLop),
	SLDat tinyint,
	TLDat float,
	primary key(MaBCHocKy, MaLop)
)

create table THAMSO (
	TuoiToiThieu tinyint,
	TuoiToiDa tinyint,
	SiSoToiDa tinyint,
	DiemToiThieu float,
	DiemToiDa float,
	DiemDat float
)