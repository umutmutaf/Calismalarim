Create Database ADOUYGULAMA
go
use ADOUYGULAMA
Create table Uye (
Uye_Id int identity(1,1) primary key,
KullaniciAdi nvarchar(50),
Sifre nvarchar(8)
)

Create table Gunluk(
Gunluk_Id int identity(1,1) primary Key,
Gunluk_Text nvarchar(250),
Uye_Id int foreign Key references Uye(Uye_Id)
)

Insert into Uye(KullaniciAdi,Sifre) values('busra','123456');
Insert into Gunluk(Gunluk_Text,Uye_Id) values('dvkdxvjlx',1)
Insert into Gunluk(Gunluk_Text,Uye_Id) values('fs',1)
Insert into Gunluk(Gunluk_Text,Uye_Id) values('df',1)

Select Uye_Id from Uye Where KullaniciAdi = 'busra' and Sifre = '123456'
select * from Gunluk

