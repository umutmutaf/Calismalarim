/* SAYISAL FONKSÝYONLAR */

 /*  mutlak deðer "abs"  */
select abs(-5.4) as mutlak   


/*	"floor" aþaðý yuvarlama	*/
/*	"ceiling" yukarý yuvarlama	*/
select floor(5.18) as aþaðý,	
	   ceiling(5.18) as yukarý	


/*  "power" sayýnýn üssünü alma  */
select 
power(2,2),		
power(2,30),
power(3,3)


/* karekök alma */

select sqrt(144)

/* toplam-ortalama-minimum-maksimum-adet */

select
sum(OD.UnitPrice)as toplam,
avg(OD.UnitPrice)as ortalama,
min(OD.UnitPrice)as minimum,
max(OD.UnitPrice)as maksimum,
count(OD.UnitPrice)as KayýtAdet
from [Order Details] OD

/* kalan(mod alma) */

select 1%3 as kalan




 