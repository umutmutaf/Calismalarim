/*create database GECE*/ 
/* database olu�turma "alter" ile tablo ekleme, silme, tabloya veri giri�i vs */

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

alter table Personel            /*veri t�r� de�i�trime*/
alter column soyad varchar(50)

