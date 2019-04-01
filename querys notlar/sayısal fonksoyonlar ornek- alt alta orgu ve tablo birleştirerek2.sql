select 
avg(pro.UnitPrice) [ortalama birim fiyatý],
sum(pro.UnitsInStock) [toplam stok],
sum(pro.UnitPrice*pro.UnitsInStock)[toplam satýþ fiyat],
min(pro.UnitPrice) [minimum fiyat],
max(pro.UnitPrice) [maksimum fiyat],
count(*)[urun adedi]
--cat.CategoryName,pro.UnitsInStock
from Categories cat
inner join Products pro on pro.CategoryID=cat.CategoryID

where CategoryName='Beverages'