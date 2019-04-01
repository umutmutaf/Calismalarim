/* tarih saat fonksiyonlar� */

select 
getdate()as [tarih ve saat],
datepart(year,getdate()) as y�l,
datepart(month,getdate()) as ay,
datepart(day,getdate()) as g�n,
datepart(hour,getdate()) as saat,
datepart(minute,getdate()) as dakika,
datepart(second,getdate()) as saniye,
datepart(millisecond,getdate()) as milisaniye,
datepart(nanosecond,getdate()) as nanosaniye,
datepart(quarter,getdate()) as �eyrek,
datepart(weekday,getdate()) as haftan�ngunu,
datepart(week,getdate()) as hafta
