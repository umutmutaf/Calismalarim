create table personel4
(
Perno smallint identity(100,1),
Ad varchar(10),
Kayittar datetime constraint df_Kayittar default(getdate())   /*constraint ile default deðer girilmesini saðlamak*/
)

insert into personel4(ad) values('UMUT')

/******************************************************************************************/

create table personle5
(
ad varchar(10),
Cins char constraint ck_cins check(cins in('E','K')),
Dept char(3) constraint ck_dept check(dept in('MUH','ARG','SAT'))
)
alter table personle5 add kilo tinyint

insert into personle5(ad,Cins,Dept) values('umut','E','MUH')

/**********************************************************************************/

create table urunler
(
urunkodu varchar(3) constraint ck_urunkodu check(urunkodu like'[A-K][0-9][0-9]'),
maliyet smallmoney constraint df_maliyet default(0)
				   constraint ch_maliyet check(maliyet>=0)
)
insert into urunler(urunkodu,maliyet) values('A50',8)

update urunler set urunkodu='C12' where urunkodu='Ý50'

/****************************************************************************/

create table customer			/*unique kullaným*/
(
customerID int unique,
lastName varchar(20),
firstName varchar(20)
)

insert into customer values(1,'mahmut','ali')