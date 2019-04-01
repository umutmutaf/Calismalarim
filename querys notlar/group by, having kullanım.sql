select c.CategoryName,
count(*),
min(p.UnitPrice),
max(p.UnitPrice) as max,
avg(p.UnitPrice)
from Products p
inner join Categories c
on c.CategoryID=p.CategoryID
group by c.CategoryName
having min(UnitPrice)>8
order by max desc