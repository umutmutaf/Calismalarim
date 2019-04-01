/* tarih saat fonksiyonları */

select 
getdate()as [tarih ve saat],
datepart(year,getdate()) as yıl,
datepart(month,getdate()) as ay,
datepart(day,getdate()) as gün,
datepart(hour,getdate()) as saat,
datepart(minute,getdate()) as dakika,
datepart(second,getdate()) as saniye,
datepart(millisecond,getdate()) as milisaniye,
datepart(nanosecond,getdate()) as nanosaniye,
datepart(quarter,getdate()) as çeyrek,
datepart(weekday,getdate()) as haftanıngunu,
datepart(week,getdate()) as hafta
