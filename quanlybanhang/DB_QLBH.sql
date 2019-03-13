/*=====================Create DataBase======================*/
use master
drop database QLBH
Create Database QLBH
go
use QLBH
go
/*=============DANH MUC khachhang=============*/

Create table KhachHang
( 
	KHId int primary key identity,
	KHName nvarchar(50), 
    Contact nvarchar(20),
    KHAddress nvarchar(100),

	
);
/*===================loaithietbi========================*/

create table LoaiThietBi
(
	LTBId int not null primary key identity,
	LTBName nvarchar (25),

)


/*==============DANH MUC thietbi============*/

Create table ThietBi
(
	TBId int not null primary key identity,
	TBName nvarchar(15),
	LTBId int not null,
	Price int,
	Qty int,

	Constraint LTB_ID_fk foreign key (LTBId) References LoaiThietBi (LTBId),
)




/*=====================hoadon===================*/

Create table HoaDon
(
	HDId int not null primary key identity,
	KHId int,
	DateCreate datetime,
	SaleOff float,
	TotalPrice float,


	Constraint KH_ID_fk foreign key (KHId) References KhachHang (KHId),
)
/*=====================giaohang===================*/

Create table GiaoHang
(
	GHId int not null primary key identity,
	HDId int,
	TotalPrice int,
	DateDelivery datetime,
	CustomerName nvarchar(20),
	DeliveryContact nvarchar(20),
	DeliveryAddress nvarchar(100)

	Constraint HD_ID_fk foreign key (HDId) References HoaDon (HDId),
)

/*=====================cthd===================*/

Create table CTHD
(
	HDId int ,
	TBId int,
	Qty int,
	SubTotal int,

	Primary key (HDId,TBId),
	Constraint HDId_fk foreign key (HDId) References HoaDon (HDId),
	Constraint TBId_fk foreign key (TBId) References ThietBi (TBId),
)

/*===========THÊM DỮ LIỆU===================*/
/*=====================khachhang===================*/
INSERT INTO KhachHang VALUES (N'Nguyễn Văn An','0988946720',N'59-61 Xóm Củi, Q.8, TP.HCM');
INSERT INTO KhachHang VALUES (N'Nguyễn Đình Bình','0345056238',N'87 Phan Đình Phùng, Thuận An, Bình Dương');
INSERT INTO KhachHang VALUES (N'Mai Thị Thủy','0948425784',N'Quốc Lộ 1, P. Tân Biên, TP. Biên Hòa, Đồng Nai');
INSERT INTO KhachHang VALUES (N'Nguyễn Thanh Hòa','0923534464',N'59-61 Xóm Củi, Q.8, TP.HCM');
INSERT INTO KhachHang VALUES (N'Đào Nhất Minh','0882453560',N'Khu phố 5, Quốc Lộ 22, TT Củ Chi, TP.HCM');
INSERT INTO KhachHang VALUES (N'Thái Thị Hà','0892354325',N'71 Nguyễn Tất Thành, P. Tân An, TP. Buôn Ma Thuột');

/*=====================loaithietbi===================*/
INSERT INTO LoaiThietBi VALUES (N'Điện Thoại');
INSERT INTO LoaiThietBi VALUES (N'Laptop');
INSERT INTO LoaiThietBi VALUES (N'Tai nghe');
INSERT INTO LoaiThietBi VALUES (N'Đồ chơi');


/*=====================thietbi===================*/
INSERT INTO ThietBi VALUES (N'Iphone X',1,1,10);
INSERT INTO ThietBi VALUES (N'Iphone Y',1,2,20);
INSERT INTO ThietBi VALUES (N'Laptop X',2,5,15);
INSERT INTO ThietBi VALUES (N'Laptop Y',2,10,14);
INSERT INTO ThietBi VALUES (N'Tai nghe X',3,2,20);
INSERT INTO ThietBi VALUES (N'Tai nghe T',3,4,100);
INSERT INTO ThietBi VALUES (N'Máy rung X',4,1,50);
INSERT INTO ThietBi VALUES (N'Máy rung XL',4,2,20);
INSERT INTO ThietBi VALUES (N'Máy rung XXL',4,5,30);
INSERT INTO ThietBi VALUES (N'Roi da',4,10,20);

/*=====================hoadon===================*/
INSERT INTO HoaDon VALUES (2,'2018-01-01 09:00:02',0,1);
INSERT INTO HoaDon VALUES (1,'2018-02-02 10:12:12',0.1,2);
INSERT INTO HoaDon VALUES (2,'2018-03-03 13:13:14',0.1,3);
INSERT INTO HoaDon VALUES (3,'2018-04-04 13:22:12',0.1,5);
INSERT INTO HoaDon VALUES (6,'2018-04-05 11:11:11',0.1,12);
INSERT INTO HoaDon VALUES (5,'2018-09-01 18:22:22',0.1,7);
INSERT INTO HoaDon VALUES (4,'2018-12-12 11:12:13',0.1,6);
INSERT INTO HoaDon VALUES (4,'2018-08-08 08:08:08',0,8);
INSERT INTO HoaDon VALUES (6,'2018-02-01 07:07:07',0,5);

/*=====================giaohang===================*/
INSERT INTO GiaoHang VALUES (1,1,'2018-01-02',N'Nguyễn Đình Bình','0988946720',N'87 Phan Đình Phùng, Thuận An, Bình Dương');
INSERT INTO GiaoHang VALUES (2,2,'2018-02-06',N'Nguyễn Văn An','0345056238',N'59-61 Xóm Củi, Q.8, TP.HCM');
INSERT INTO GiaoHang VALUES (3,3,'2018-03-04',N'Nguyễn Đình Bình','0948425784',N'87 Phan Đình Phùng, Thuận An, Bình Dương');
INSERT INTO GiaoHang VALUES (4,5,'2018-05-04',N'Mai Thị Thủy','0923534464',N'Quốc Lộ 1, P. Tân Biên, TP. Biên Hòa, Đồng Nai');
INSERT INTO GiaoHang VALUES (5,12,'2018-04-06',N'Nguyễn Thanh Hòa','0882453560',N'59-61 Xóm Củi, Q.8, TP.HCM');
INSERT INTO GiaoHang VALUES (6,7,'2019-09-01',N'Đào Nhất Minh','0892354325',N'Khu phố 5, Quốc Lộ 22, TT Củ Chi, TP.HCM');
INSERT INTO GiaoHang VALUES (7,6,'2018-12-26',N'Nguyễn Đình Bình','0988946720',N'71 Nguyễn Tất Thành, P. Tân An, TP. Buôn Ma Thuột');
INSERT INTO GiaoHang VALUES (8,8,'2018-08-10',N'Mai Thị Thủy','0345056238',N'Quốc Lộ 1, P. Tân Biên, TP. Biên Hòa, Đồng Nai');
INSERT INTO GiaoHang VALUES (9,5,'2018-02-03',N'Thái Thị Hà','0948425784',N'Khu phố 5, Quốc Lộ 22, TT Củ Chi, TP.HCM');

/*=====================CTHD===================*/
INSERT INTO CTHD VALUES (1,1,1,1);
INSERT INTO CTHD VALUES (2,1,1,1);
INSERT INTO CTHD VALUES (2,7,1,1);
INSERT INTO CTHD VALUES (3,8,1,2);
INSERT INTO CTHD VALUES (3,1,1,1);
INSERT INTO CTHD VALUES (4,8,2,4);
INSERT INTO CTHD VALUES (4,7,1,1);
INSERT INTO CTHD VALUES (5,3,1,5);
INSERT INTO CTHD VALUES (5,7,6,6);
INSERT INTO CTHD VALUES (5,1,1,1);
INSERT INTO CTHD VALUES (6,2,1,2);
INSERT INTO CTHD VALUES (6,3,1,5);
INSERT INTO CTHD VALUES (7,1,1,1);
INSERT INTO CTHD VALUES (7,9,1,5);
INSERT INTO CTHD VALUES (8,6,2,8);
INSERT INTO CTHD VALUES (9,9,1,5);

select * from GiaoHang