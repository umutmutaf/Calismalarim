/* SAYISAL FONKS�YONLAR */

 /*  mutlak de�er "abs"  */
select abs(-5.4) as mutlak   


/*	"floor" a�a�� yuvarlama	*/
/*	"ceiling" yukar� yuvarlama	*/
select floor(5.18) as a�a��,	
	   ceiling(5.18) as yukar�	


/*  "power" say�n�n �ss�n� alma  */
select 
power(2,2),		
power(2,30),
power(3,3)


/* karek�k alma */

select sqrt(144)

/* toplam-ortalama-minimum-maksimum-adet */

select
sum(OD.UnitPrice)as toplam,
avg(OD.UnitPrice)as ortalama,
min(OD.UnitPrice)as minimum,
max(OD.UnitPrice)as maksimum,
count(OD.UnitPrice)as Kay�tAdet
from [Order Details] OD

/* kalan(mod alma) */

select 1%3 as kalan




 