insert into [dbo].[DersBilgileri](DersTuru,DersKodu,DersAdi,Fakulte,Donem,S�n�f,DersinKredisi,AKTS)
values 
(0,'A1001','matematik','Fen edebiyat','bahar',1,3,6),
(1,'A1002','tarih','e�itim bilimleri','bahar',3,5,10),
(0,'A1003','yaz�l�m','Muhendislik','bahar',2,3,6)

select * from [dbo].[DersBilgileri]
where DersKodu='DS101' and DersAdi='Ilk ders' and Fakulte='Fakulte1' and Donem='G�z'

update [dbo].[DersBilgileri] 
set Fakulte='Fen Edebiyat',Donem='Bahar'
where DersKodu='DS101' and DersAdi='Ilk ders' and Fakulte='Fakulte1' and Donem='G�z'