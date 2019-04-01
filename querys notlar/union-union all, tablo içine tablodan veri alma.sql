select 
EMP.FirstName as[Personelin Ad�],
EMP.LastName as[Personelin Soyad�],
E.FirstName as [Amirin Ad�], 
E.LastName as[Amirin Soyad�]
 from  
Employees E  right join Employees EMP on E.EmployeeID=EMP.ReportsTo
order by EMP.FirstName

/*********************************************************************************/

select (firstname+' '+lastname) as Name,city, postalCode,'Employee' as T�P from Employees
union
select C.CompanyName ,City,PostalCode,'Customer' as T�P from Customers C

/*********************************************************************************/

select CompanyName as �irketADI,Phone as �rtibatTel,ContactName as �rtibatKi�i,'Customer Tablo Kayd�' as Kay�tYeri from Customers
union
select CompanyName,Phone,ContactName,'Suppliers Tablo Kayd�' as Kay�tYeri from Suppliers
union
select CompanyName,Phone,'KONTAK YOK','Shippers Tablo Kayd�' as Kay�tYeri from Shippers
order by CompanyName asc

/*********************************************************************************/

select CategoryID from Categories
union all
select ShipperID from Shippers

/********************************************************************************/
insert into tabloAdi1					/* tablo i�erisine bu �ekilde de veri atabiliriz */
select name,surname from tabloAdi2
union all
select name,surname from tabloAdi3

insert into tabloAdi1					/* tablo1 i�erisine tablo2 deki verileri atma */
select name,surname from tabloAdi2