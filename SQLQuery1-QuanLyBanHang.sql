﻿-- Phần mềm quản lí bán hàng đơn giản - Howkteam 16/10/2021


CREATE DATABASE QUANLIBANHANG

USE QUANLIBANHANG

CREATE TABLE BAN
(
	ID INT IDENTITY PRIMARY KEY NOT NULL,
	TENBAN NVARCHAR(50) NOT NULL,
	TRANGTHAI NVARCHAR(50) NOT NULL DEFAULT N'Trống',
)
GO
CREATE TABLE TAIKHOAN
(
	TK NVARCHAR(50) NOT NULL PRIMARY KEY,
	MK NVARCHAR(50) NOT NULL,
	TENDN NVARCHAR(50) NOT NULL,
	LOAITK INT NOT NULL
)
GO
CREATE TABLE LOAISP
(	
	ID INT IDENTITY PRIMARY KEY NOT NULL,
	TENSP NVARCHAR(50) NOT NULL,
)

GO
CREATE TABLE SANPHAM
(	
	ID INT IDENTITY PRIMARY KEY NOT NULL,
	TENSP NVARCHAR(50) NOT NULL,
	IDLSP INT NOT NULL,
	DONGIA FLOAT NOT NULL DEFAULT 0
	
	FOREIGN KEY (IDLSP) REFERENCES LOAISP(ID),
)
CREATE TABLE HOADON
(
	ID INT IDENTITY PRIMARY KEY NOT NULL,
	IDBAN INT NOT NULL,
	NGAYDEN DATE NOT NULL DEFAULT GETDATE(),
	NGAYDI DATE ,
	TRANGTHAI INT NOT NULL DEFAULT 0 -- THANH TOAN HAY CHUA 1/0
	
	FOREIGN KEY (IDBAN) REFERENCES BAN(ID),
)
GO
CREATE TABLE CHITIETHOADON
(
	ID INT IDENTITY PRIMARY KEY NOT NULL,	
	IDHOADON INT NOT NULL,
	IDSP INT NOT NULL,
	COUNT SMALLINT NOT NULL DEFAULT 0

	FOREIGN KEY (IDHOADON) REFERENCES HOADON(ID),
	FOREIGN KEY (IDSP) REFERENCES SANPHAM(ID),
)
