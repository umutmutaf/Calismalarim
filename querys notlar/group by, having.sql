select s.CompanyName,count(*),min(p.UnitPrice) minimum,max(p.UnitPrice) maksimum,
sum(p.UnitPrice) as toplam from Suppliers s
inner join Products p on p.SupplierID=s.SupplierID
group by CompanyName
having sum(UnitPrice)>=35 and count(*)=2