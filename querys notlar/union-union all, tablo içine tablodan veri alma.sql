select 
EMP.FirstName as[Personelin Adý],
EMP.LastName as[Personelin Soyadý],
E.FirstName as [Amirin Adý], 
E.LastName as[Amirin Soyadý]
 from  
Employees E  right join Employees EMP on E.EmployeeID=EMP.ReportsTo
order by EMP.FirstName

/*********************************************************************************/

select (firstname+' '+lastname) as Name,city, postalCode,'Employee' as TÝP from Employees
union
select C.CompanyName ,City,PostalCode,'Customer' as TÝP from Customers C

/*********************************************************************************/

select CompanyName as ÞirketADI,Phone as ÝrtibatTel,ContactName as ÝrtibatKiþi,'Customer Tablo Kaydý' as KayýtYeri from Customers
union
select CompanyName,Phone,ContactName,'Suppliers Tablo Kaydý' as KayýtYeri from Suppliers
union
select CompanyName,Phone,'KONTAK YOK','Shippers Tablo Kaydý' as KayýtYeri from Shippers
order by CompanyName asc

/*********************************************************************************/

select CategoryID from Categories
union all
select ShipperID from Shippers

/********************************************************************************/
insert into tabloAdi1					/* tablo içerisine bu þekilde de veri atabiliriz */
select name,surname from tabloAdi2
union all
select name,surname from tabloAdi3

insert into tabloAdi1					/* tablo1 içerisine tablo2 deki verileri atma */
select name,surname from tabloAdi2