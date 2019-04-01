/* 1.yol */

create view vw_Speedy
as
select o.* from Customers c
inner join Orders o on o.CustomerID=c.CustomerID
inner join Employees e on e.EmployeeID=o.EmployeeID
inner join Shippers sh on sh.ShipperID=o.ShipVia
where c.CustomerID in ('DUMON','ALFKI') and e.FirstName='Nancy' and sh.CompanyName='Speedy Express'

select* from  vw_Speedy

/******************************************************/
/* 2.yol */ --birden çok tabloyu bu þekilde de inner layabiliriz

select o.* from Customers c,Orders o,Employees e,Shippers sh
where 
o.CustomerID=c.CustomerID
and e.EmployeeID=o.EmployeeID
and sh.ShipperID=o.ShipVia
and c.CustomerID in ('DUMON','ALFKI') 
and e.FirstName='Nancy' 
and sh.CompanyName='Speedy Express'
