CREATE DATABASE QuanLiGara
GO
USE QuanLiGara
GO
ALTER DATABASE QuanLiGara set TRUSTWORTHY ON; 
GO 
EXEC dbo.sp_changedbowner @loginame = N'sa', @map = false 
GO 
sp_configure 'show advanced options', 1; 
GO 
RECONFIGURE; 
GO 
sp_configure 'clr enabled', 1; 
GO 
RECONFIGURE; 
GO
--1.Tao bang nhanvien
CREATE TABLE NHANVIEN
(
Manhanvien int identity(0,1) not null,
Ten nvarchar(45) not null,
CMND char(12) not null,
Tuoi int not null,
Diachi nvarchar(40) not null,
Gioitinh nvarchar(3) not null,
Sodienthoai char(13) not null,
Ngayvaolam datetime not null,
Ngaysinh datetime not null,
constraint PK_NHANVIEN  primary key(Manhanvien)
)

alter table NHANVIEN add constraint NV_GIOITINH check(Gioitinh = N'Nam' OR Gioitinh = N'Nữ' )
GO
--2.Tao bang khach hang sua chua
CREATE TABLE KHACHHANGSUACHUA
(
Makhachhang int identity(0,1) not null,
CMND char(12) not null,
Ten nvarchar(45) not null,
Diachi nvarchar(45) not null,
Gioitinh nvarchar(3) not null,
Sodienthoai char(13) not null,
Ngaysinh datetime not null,
constraint PK_KHACHHANG primary key(Makhachhang)
)
alter table KHACHHANGSUACHUA add constraint KH_GIOITINH check(Gioitinh = N'Nam' OR Gioitinh = N'Nữ' )
GO
--3.Tao bang xe
CREATE TABLE XE
(
IDXe int identity(0,1) not null,
Tenxe nvarchar(45) not null,
Mahangxe char(12) not null,
Mahieuxe char(12) not null,
Bienso char(17) not null,
Makhachhang int not null,
Ngaynhapgara datetime not null,
constraint PK_XE primary key(IDXe)
)
GO
--4.Tao bang Hang xe
CREATE TABLE HANGXE
(
IDHangxe char(12) not null,
Tenhangxe nvarchar(45) not null,
constraint PK_HANGXE primary key(IDHangxe)
)
GO
--5.Tao bang hieu xe
CREATE TABLE HIEUXE
(
IDHieuxe char(12) not null,
Mahangxe char(12) not null,
Tenhieuxe nvarchar(45) not null,
constraint PK_HIEUXE primary key(IDHieuxe)
)
GO
--6.Tao bang vat tu
CREATE TABLE VATTU
(
Mavattu int identity(0,1) not null,
Maloai int not null,
Tenvattu nvarchar(45) not null,
Soluong int not null,
constraint PK_VATTU primary key(Mavattu)
)
GO
--7.Tao bang danh muc vat tu
CREATE TABLE DANHMUCVATTU
(
Maloai int identity(0,1) not null,
Tendanhmuc nvarchar(45) not null,
constraint PK_DMVT primary key (Maloai)
)
GO

--8.Tao bang lich su nhap kho
CREATE TABLE LICHSUNHAPKHO
(
IDLichsunhapkho int identity(0,1) not null,
Mavattu int not null,
Tenvattu nvarchar(45) not null,
Giathanh bigint not null,
Ngaynhapkho datetime not null,
Manhanviennhap int not null,
Soluongnhap int not null,
constraint PK_LSNK primary key (IDLichsunhapkho)
)
GO
--9.Tao bang don hang sua chua
CREATE TABLE DONHANGSUACHUA
(
Madonhang int identity(0,1) not null,
Manhanvienlaphoadon int not null,
Manhanvienphutrachsua int not null,
Makhachhang int not null,
IDXe int not null,
Ngaylapdonhang datetime not null,
Tongtien bigint not null,
constraint PK_DHSC primary key(Madonhang)
)


Go
--10.Tao bang chi tiet don hang
CREATE TABLE CHITIETDONHANG
(
IDChitietdonhang int identity(0,1) not null,
Madonhang int not null,
Mavattu int not null,
Soluong int not null,
Madichvu int not null,
constraint PK_CTDH primary key(IDChitietdonhang)
)
--11. Tao bang loai dich vu
CREATE TABLE LOAIDICHVU
(
Madichvu int identity (0,1) not null,
Tendichvu nvarchar(45) not null,
Giadichvu bigint not null,
constraint PK_GIADV primary key(Madichvu)
)
--12. Tao bang account
CREATE TABLE ACCOUNT
(
IDAccount int identity(0,1) not null,
username nvarchar(45) not null,
pass nvarchar(45) not null,
Loainhanvien int not null,
Manhanvien int not null,
constraint PK_ACC primary key (IDAccount)
)
GO
alter table ACCOUNT add constraint ACC_LOAINV check(Loainhanvien = 0 OR Loainhanvien = 1 )
GO
--13.Tao bang thanh toan
CREATE TABLE THANHTOAN
(
	IDThanhToan int identity(0,1) not null,
	Madonhang int not null,
	Ngayxuat datetime not null
)
GO
--THÊM KHÓA NGOẠI
alter table DONHANGSUACHUA add 
	Constraint FK_DHSC_NVN foreign key (Manhanvienlaphoadon) references NHANVIEN(Manhanvien),
	Constraint FK_DHSC_NVS foreign key (Manhanvienphutrachsua) references NHANVIEN(Manhanvien),
	Constraint FK_DHSC_XE foreign key (IDXe) references XE(IDXe),
	Constraint FK_DHSC_KH foreign key (Makhachhang) references KHACHHANGSUACHUA(Makhachhang)	

alter table XE add 
	Constraint FK_XE_HANG foreign key (Mahangxe) references HANGXE(IDHangxe),
	Constraint FK_XE_HIEUXE foreign key (Mahieuxe) references HIEUXE(IDHieuxe),
	Constraint FK_XE_KH foreign key (Makhachhang) references KHACHHANGSUACHUA(Makhachhang)


alter table HIEUXE add 
	Constraint FK_HIEUXE_HANG foreign key (Mahangxe) references HANGXE(IDHangxe)


alter table CHITIETDONHANG add 
	Constraint FK_CTDH_DH foreign key (Madonhang) references DONHANGSUACHUA(Madonhang),
	Constraint FK_CTDH_VT foreign key (Mavattu) references VATTU(Mavattu),
	Constraint FK_CTDH_DV foreign key (Madichvu) references LOAIDICHVU(Madichvu)


alter table VATTU add 
	Constraint FK_VT_DMVT foreign key (Maloai) references DANHMUCVATTU(Maloai)	


alter table LICHSUNHAPKHO add 
	Constraint FK_LSNK_NV foreign key (Manhanviennhap) references NHANVIEN(Manhanvien),	
	Constraint FK_LSNK_VT foreign key (Mavattu) references VATTU(Mavattu)	

alter table ACCOUNT add 
	Constraint FK_ACC_NV foreign key (Manhanvien) references NHANVIEN(Manhanvien)

alter table THANHTOAN add
	Constraint FK_TT_DH foreign key(Madonhang) references DONHANGSUACHUA(Madonhang)

--Thêm dữ liệu
--Bảng Nhan vien
insert into NHANVIEN values (N'Lê Quốc Dũng','221441683',20,N'Phú Yên',N'Nam','0343698243','03-12-2018','12-29-98')
insert into NHANVIEN values (N'Đỗ Minh Hiếu','221441684',20,N'Quảng Ngãi',N'Nam','0343698244','03-12-2018','08-29-98')
insert into NHANVIEN values (N'Nguyễn Long Hồ','221441685',20,N'Tiền Giang',N'Nam','0343698243','03-12-2018','02-12-98')
insert into NHANVIEN values (N'Hoàng Hùng Đức','221441686',20,N'Quảng Trị',N'Nam','0343698243','03-12-2018','01-02-98')

--Bảng Account
insert into ACCOUNT values ('admin','1234',0,0)
insert into ACCOUNT values ('user1','1234',1,1)
insert into ACCOUNT values ('user2','1234',1,2)
insert into ACCOUNT values ('user3','1234',1,3)

--Bảng Hãng xe
insert into HANGXE values('SUZ',N'Suzuki')
insert into HANGXE values('MERC',N'Mercedes')
insert into HANGXE values('HON',N'Honda')
insert into HANGXE values('TOYO',N'Toyota')
insert into HANGXE values('BWM',N'Bwm')
insert into HANGXE values('HYUN',N'Hyundai')
insert into HANGXE values('RR',N'Rolls Royce')
insert into HANGXE values('FER',N'Ferrari')
insert into HANGXE values('FOR',N'FORD')
insert into HANGXE values('LAM',N'Lamborghini')
insert into HANGXE values('KIA',N'Kia')
insert into HANGXE values('NIS',N'Nissan')
insert into HANGXE values('MIT',N'Mitsubisi')
insert into HANGXE values('VOL',N'Volkswagen')

--Bảng hiệu xe
insert into HIEUXE values('SUZ-VIT','SUZ',N'Suzuki Vitara')
insert into HIEUXE values('SUZ-CEL','SUZ',N'Suzuki Celerio')
insert into HIEUXE values('SUZ-ERT','SUZ',N'Suzuki Ertiga')
insert into HIEUXE values('SUZ-SG','SUZ',N'Suzuki Swift Gl')
insert into HIEUXE values('SUZ-CT','SUZ',N'Suzuki Carry Truck')
insert into HIEUXE values('SUZ-BV','SUZ',N'Suzuki Blind Van')
insert into HIEUXE values('SUZ-CP','SUZ',N'Suzuki Carry Pro')

insert into HIEUXE values('MERC-EC','MERC',N'Mercedes E Coupe')
insert into HIEUXE values('MERC-MB','MERC',N'Mercedes Maybach')
insert into HIEUXE values('MERC-CL','MERC',N'Mercedes C-Class')
insert into HIEUXE values('MERC-SUV','MERC',N'GLC SUV')
insert into HIEUXE values('MERC-SC','MERC',N'Mercedes S-Class')
insert into HIEUXE values('MERC-CLA','MERC',N'Mercedes CLA Coupe')
insert into HIEUXE values('MERC-GLC','MERC',N'Mercedes GLC Coupe')
insert into HIEUXE values('MERC-GLE','MERC',N'GLE SUV Coupe')
insert into HIEUXE values('MERC-GLA','MERC',N'Mercedes GLA SUV')
insert into HIEUXE values('MERC-GLCS','MERC',N'Mercedes GLC SUV')
insert into HIEUXE values('MERC-GLS','MERC',N'Mercedes GLC SUV')
insert into HIEUXE values('MERC-V','MERC',N'Mercedes V-Class MPV')

insert into HIEUXE values('HON-BRI','HON',N'Honda Brio')
insert into HIEUXE values('HON-CITY','HON',N'Honda City')
insert into HIEUXE values('HON-JAZ','HON',N'Honda Jazz')
insert into HIEUXE values('HON-CIV','HON',N'Honda Civic')
insert into HIEUXE values('HON-ACO','HON',N'Honda Accord')
insert into HIEUXE values('HON-HRV','HON',N'Honda HRV')
insert into HIEUXE values('HON-CRV','HON',N'Honda CRV')

insert into HIEUXE values('TOYO-WI','TOYO',N'Toyota Wigo')
insert into HIEUXE values('TOYO-VI','TOYO',N'Toyota Vios')
insert into HIEUXE values('TOYO-ALT','TOYO',N'Toyota Altis')
insert into HIEUXE values('TOYO-YAR','TOYO',N'Toyota Yaris')
insert into HIEUXE values('TOYO-CAM','TOYO',N'Toyota Camry')
insert into HIEUXE values('TOYO-AVZ','TOYO',N'Toyota Avanza')
insert into HIEUXE values('TOYO-RUS','TOYO',N'Toyota Rush')
insert into HIEUXE values('TOYO-INV','TOYO',N'Toyota INNOVA')
insert into HIEUXE values('TOYO-FOR','TOYO',N'Toyota Fortuner')
insert into HIEUXE values('TOYO-ALP','TOYO',N'Toyota Alphard')
insert into HIEUXE values('TOYO-PRD','TOYO',N'Toyota Prado')
insert into HIEUXE values('TOYO-LC','TOYO',N'Toyota Land Cruiser')
insert into HIEUXE values('TOYO-HLX','TOYO',N'Toyota Hilux')
insert into HIEUXE values('TOYO-HAC','TOYO',N'Toyota Hiace')

insert into HIEUXE values('BWM-S1','BWM',N'BWM 118i')
insert into HIEUXE values('BWM-S2','BWM',N'BWM 218i Gran Tourer')
insert into HIEUXE values('BWM-S3','BWM',N'BWM 320i')
insert into HIEUXE values('BWM-S4','BWM',N'BWM 420i')
insert into HIEUXE values('BWM-S5','BWM',N'BWM Series 5')
insert into HIEUXE values('BWM-S6','BWM',N'BWM Series 6')
insert into HIEUXE values('BWM-S7','BWM',N'BWM Series 7')
insert into HIEUXE values('BWM-XS','BWM',N'BWM X-Series')
insert into HIEUXE values('BWM-MS','BWM',N'BWM M-Series')
insert into HIEUXE values('BWM-I8','BWM',N'BWM I8')

insert into HIEUXE values('HYUN-GIH','HYUN',N'Hyundai Grand I10 Hatchback')
insert into HIEUXE values('HYUN-GIS','HYUN',N'Hyundai Grand I10 Sedan')
insert into HIEUXE values('HYUN-ACN','HYUN',N'Hyundai Accent')
insert into HIEUXE values('HYUN-ELT','HYUN',N'Hyundai Elantra')
insert into HIEUXE values('HYUN-KO','HYUN',N'Hyundai Kona')
insert into HIEUXE values('HYUN-SON','HYUN',N'Hyundai Sonata')
insert into HIEUXE values('HYUN-GEN','HYUN',N'Hyundai Genesis')
insert into HIEUXE values('HYUN-TUC','HYUN',N'Hyundai Tucson')
insert into HIEUXE values('HYUN-SAN','HYUN',N'Hyundai Santafe')
insert into HIEUXE values('HYUN-STA','HYUN',N'Hyundai Starex')
insert into HIEUXE values('HYUN-SOL','HYUN',N'Hyundai Solati')

insert into HIEUXE values('RR-PT','RR',N'Rolls Royce Phantom')
insert into HIEUXE values('RR-PTC','RR',N'Rolls Royce Phantom Coupe')
insert into HIEUXE values('RR-WRA','RR',N'Rolls Royce Wraith')
insert into HIEUXE values('RR-GSII','RR',N'Rolls Royce Ghost Series II')
insert into HIEUXE values('RR-DAW','RR',N'Rolls Royce Dawn')
insert into HIEUXE values('RR-CUL','RR',N'Rolls Royce Cullinan')

insert into HIEUXE values('FER-LA','FER',N'Laferrari')
insert into HIEUXE values('FER-F12B','FER',N'Ferrari F12 Berlinetta')
insert into HIEUXE values('FER-812S','FER',N'Ferrari 812 Superfast')
insert into HIEUXE values('FER-488G','FER',N'Ferrari 488GTB')
insert into HIEUXE values('FER-488P','FER',N'Ferrari 488 Pista')
insert into HIEUXE values('FER-CA-T','FER',N'Ferrari California T')
insert into HIEUXE values('FER-POR','FER',N'Ferrari Portofino')
insert into HIEUXE values('FER-GTC4','FER',N'Ferrari GTC4Lusso')

insert into HIEUXE values('FOR-FIE','FOR',N'Ford Fiesta')
insert into HIEUXE values('FOR-FOCU','FOR',N'Ford Focus')
insert into HIEUXE values('FOR-ECOS','FOR',N'Ford Ecosport')
insert into HIEUXE values('FOR-EVR','FOR',N'Ford Everest')
insert into HIEUXE values('FOR-ESC','FOR',N'Ford Escape')
insert into HIEUXE values('FOR-EXPL','FOR',N'Ford Explorer')
insert into HIEUXE values('FOR-RAN','FOR',N'Ford Ranger')
insert into HIEUXE values('FOR-F150','FOR',N'Ford F150')
insert into HIEUXE values('FOR-TRAN','FOR',N'Ford Transit')

insert into HIEUXE values('LAM-AVELP','LAM',N'Lamborghini Aventador LP700-4')
insert into HIEUXE values('LAM-AVES','LAM',N'Lamborghini Aventador S')
insert into HIEUXE values('LAM-HURLP','LAM',N'Lamborghini Huracan LP610-4')
insert into HIEUXE values('LAM-HURLP2','LAM',N'Lamborghini Huracan LP580-2')
insert into HIEUXE values('LAM-HURP','LAM',N'Lamborghini Huracan Performante')
insert into HIEUXE values('LAM-UR','LAM',N'Lamborghini URUS')

insert into HIEUXE values('KIA-MOR','KIA',N'Kia Morning')
insert into HIEUXE values('KIA-RIO','KIA',N'Kia Rio')
insert into HIEUXE values('KIA-CET','KIA',N'Kia Cetaro')
insert into HIEUXE values('KIA-RON','KIA',N'Kia Rondo')
insert into HIEUXE values('KIA-OPT','KIA',N'Kia Optima')
insert into HIEUXE values('KIA-QUO','KIA',N'Kia Quoris')
insert into HIEUXE values('KIA-SOR','KIA',N'Kia Sorento')
insert into HIEUXE values('KIA-GS','KIA',N'Kia Grand Sedona')

insert into HIEUXE values('NIS-SUN','NIS',N'Nissan Sunny')
insert into HIEUXE values('NIS-TEA','NIS',N'Nissan Teana')
insert into HIEUXE values('NIS-JUK','NIS',N'Nissan Juke')
insert into HIEUXE values('NIS-NAV','NIS',N'Nissan Navara')
insert into HIEUXE values('NIS-MUR','NIS',N'Nissan Murano')
insert into HIEUXE values('NIS-NIS','NIS',N'Nissan 370Z Nismo')
insert into HIEUXE values('NIS-XTR','NIS',N'Nissan X-Trail')
insert into HIEUXE values('NIS-TER','NIS',N'Nissan Terra')
insert into HIEUXE values('NIS-URV','NIS',N'Nissan Urvan')

insert into HIEUXE values('MIT-MIR','MIT',N'Mitsubishi Mirage')
insert into HIEUXE values('MIT-ATT','MIT',N'Mitsubishi Attrage')
insert into HIEUXE values('MIT-XPA','MIT',N'Mitsubishi Xpander')
insert into HIEUXE values('MIT-OLD','MIT',N'Mitsubishi Outlander')
insert into HIEUXE values('MIT-OLDS','MIT',N'Mitsubishi Outlander Sport')
insert into HIEUXE values('MIT-PAS','MIT',N'Mitsubishi Pajero Sport')
insert into HIEUXE values('MIT-PAJ','MIT',N'Mitsubishi Pajero')
insert into HIEUXE values('MIT-TRI','MIT',N'Mitsubishi Triton')

insert into HIEUXE values('VOL-NB','VOL',N'Volkswagen New Beetle')
insert into HIEUXE values('VOl-NJ','VOL',N'Volkswagen New Jetta')
insert into HIEUXE values('VOL-POL','VOL',N'Volkswagen Polo')
insert into HIEUXE values('VOl-SCI','VOL',N'Volkswagen Scirocco')
insert into HIEUXE values('VOL-PAS','VOL',N'Volkswagen Passat')
insert into HIEUXE values('VOl-TIG','VOL',N'Volkswagen Tiguan')
insert into HIEUXE values('VOL-TOU','VOL',N'Volkswagen Touareg')
insert into HIEUXE values('VOl-SHA','VOL',N'Volkswagen Sharan')

GO
--Bảng Khách hàng
insert into KHACHHANGSUACHUA values('221441222',N'Đào Thị Như Quỳnh',N'Phú Yên',N'Nữ','0330022015','05-28-00')
insert into KHACHHANGSUACHUA values('221441223',N'Trần Văn Quý',N'Nam Định',N'Nam','0330022016','05-02-94')
insert into KHACHHANGSUACHUA values('221441224',N'Hồ Tuấn Thanh',N'Lạng Sơn',N'Nam','0330022017','06-28-95')
insert into KHACHHANGSUACHUA values('221441225',N'Trần Duy Quang',N'Bạc Liêu',N'Nam','0330022018','03-18-95')
insert into KHACHHANGSUACHUA values('221441226',N'Thái Lê Vinh',N'Cà Mau',N'Nam','0330022019','05-12-94')

GO
--Bảng Xe
insert into XE values(N'Volkswagen Sharan 220','VOL','VOL-SHA','78A-4444',1,'12-12-18')
insert into XE values(N'Lamborghini Aventador LP700-4 Lp2','LAM','LAM-AVELP','58A-6666',2,'12-02-18')
insert into XE values(N'Ferrari F12 Berlinetta','FER','FER-F12B','34A-1444',3,'02-12-18')
insert into XE values(N'Nissan Teana','NIS','NIS-TEA','68A-3444',4,'12-22-18')
insert into XE values(N'Mitsubishi Outlander Sport','MIT','MIT-OLDS','58A-5444',4,'12-21-18')

GO
--Bảng Danh mục vật tư
insert into DANHMUCVATTU values(N'Lốp')
insert into DANHMUCVATTU values(N'Săm')
insert into DANHMUCVATTU values(N'Sơn')
insert into DANHMUCVATTU values(N'Nhớt')
insert into DANHMUCVATTU values(N'Dầu')
insert into DANHMUCVATTU values(N'Xăng')
insert into DANHMUCVATTU values(N'Ắc quy')
insert into DANHMUCVATTU values(N'Kính')
insert into DANHMUCVATTU values(N'Gương')
insert into DANHMUCVATTU values(N'Tấm lót')
insert into DANHMUCVATTU values(N'Đèn')

--Bảng dịch vụ
insert into LOAIDICHVU values(N'Bơm hơi',100000)
insert into LOAIDICHVU values(N'Thay lốp',2000000)
insert into LOAIDICHVU values(N'Thay săm',1300000)
insert into LOAIDICHVU values(N'Sơn xe',3000000)
insert into LOAIDICHVU values(N'Thay nhớt',1500000)
insert into LOAIDICHVU values(N'Thay gương chiếu hậu',1200000)
insert into LOAIDICHVU values(N'Thay kính xe',4000000)
insert into LOAIDICHVU values(N'Thay acquy',5000000)
insert into LOAIDICHVU values(N'Thay tấm lót',400000)
insert into LOAIDICHVU values(N'Thay đèn',1700000)
insert into LOAIDICHVU values(N'Đổ xăng',1000000)
insert into LOAIDICHVU values(N'Đổ dầu',1100000)

--Bảng vật tư
insert into VATTU values(0,N'Lốp Bridgestone',100)
insert into VATTU values(0,N'Lốp Michelin',120)
insert into VATTU values(0,N'Lốp Goodyear Dunlop',200)
insert into VATTU values(0,N'Lốp Pirelli',50)
insert into VATTU values(0,N'Lốp Maxxis',110)

insert into VATTU values(1,N'Săm DRC',200)
insert into VATTU values(1,N'Săm Yokohama',400)
insert into VATTU values(1,N'Săm Chengshin',600)
insert into VATTU values(1,N'Săm Makuro',800)
insert into VATTU values(1,N'Săm Birla',100)

insert into VATTU values(2,N'Sơn R-M',200)
insert into VATTU values(2,N'Sơn Dupont',200)
insert into VATTU values(2,N'Sơn Sikens',200)
insert into VATTU values(2,N'Sơn PPG',200)
insert into VATTU values(2,N'Sơn Nippon',200)
insert into VATTU values(2,N'Sơn Dee Beer',200)
insert into VATTU values(2,N'Sơn Dulux',200)

insert into VATTU values(3,N'Mobil 1 Advanced Fuel Economy',200)
insert into VATTU values(3,N'Castrol GTX Magnatec',200)
insert into VATTU values(3,N'Total Quartz',200)
insert into VATTU values(3,N'Valvoline Full Synthetic MaxLife',200)
insert into VATTU values(3,N'Pennzoil Platinum',200)
insert into VATTU values(3,N'Motul 8100 X-CLEAN',200)

insert into VATTU values (4,N'Dầu Diesel',200)
insert into VATTU values (4,N'Dầu Do',200)
insert into VATTU values (4,N'Dầu Fo',200)
insert into VATTU values (4,N'Dầu D2',200)

insert into VATTU values (5,N'Xăng E5',200)
insert into VATTU values (5,N'Xăng A95',200)
insert into VATTU values (5,N'Xăng A92',200)

insert into VATTU values (6,N'Acquy nước GS NS60LS E',200)
insert into VATTU values (6,N'Acquy nước GS N120E',200)
insert into VATTU values (6,N'Acquy nước GS N100E',200)
insert into VATTU values (6,N'Acquy nước GS NS40Z E',200)
insert into VATTU values (6,N'Acquy nước GS N150 E',200)
insert into VATTU values (6,N'Acquy nước GS N200 E',200)
insert into VATTU values (6,N'Acquy nước GS 95D31R-E',200)
insert into VATTU values (6,N'Acquy khô GS 12V-60AH',200)
insert into VATTU values (6,N'Acquy Rocket GS 12V-200AH',200)

insert into VATTU values (7,N'Hyundai Santafe',200)
insert into VATTU values (7,N'Kia Morning',200)
insert into VATTU values (7,N'Mica KMCXD',200)

insert into VATTU values (8,N'Daewoo Lacetti',200)
insert into VATTU values (8,N'',200)
insert into VATTU values (8,N'Daewoo Lacetti',200)
insert into VATTU values (8,N'Daewoo Lacetti',200)
insert into VATTU values (8,N'Toyota Vios',200)
insert into VATTU values (8,N'Kia Morning P961840-47',200)

insert into VATTU values(9,N'Lót sàn 4D PU',200)
insert into VATTU values(9,N'Lót sàn 4D PU All new',200)
insert into VATTU values(9,N'Lót sàn 5D kẽ ngang',200)

insert into VATTU values(10,N'Đèn pha trái C180k WDB203',200)
insert into VATTU values(10,N'Đèn pha cos Mercedes C200',200)
insert into VATTU values(10,N'Đèn pha bixenon E240',200)
insert into VATTU values(10,N'Đèn pha DS2 Bentley',200)
insert into VATTU values(10,N'Đèn pha Audi TT Coupe',200)







































