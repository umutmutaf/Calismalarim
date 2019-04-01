/*create database GECE*/ 
/* database oluþturma "alter" ile tablo ekleme, silme, tabloya veri giriþi vs */

use gece
create table Personel
(
PersonelID int identity (1,1)
)

alter table Personel
add lisansbolum varchar(30)

alter table Personel add
soyad varchar(20),
telefon char(11)

alter table Personel           /*tablodan column silme*/
drop column lisansbolum

alter table Personel            /*veri türü deðiþtrime*/
alter column soyad varchar(50)

