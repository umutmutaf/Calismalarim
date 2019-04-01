select EmployeeID, LastName, FirstName, Country,
case Country when 'USA' then 'Amerika'
			 when 'UK' then '�ngiltere'
			 when 'TR' then 'T�rkiye'
			 else 'Bilinmiyor' end as �lke
from Employees

update Employees set Country='USA'
where EmployeeID=4

/*********************************************************************************/

select * from Orders

select distinct CustomerID,
case CustomerID when 'BLONP' then 'Blondesddsl p�re et fils'
				when 'BOLID' then 'B�lido Comidas preparadas'
				when 'BONAP' then 'Bon app'''
				when 'BOTTM' then 'Bottom-Dollar Markets'
				else 'N/A' end as ��RKET				
 from Orders
 where CustomerID in('BLONP','BOLID','BONAP','BOTTM')

/****************************************************************************************/

 select [TerritoryDescription],RegionID,
 case [RegionID] 
 when 1 then 'Eastern'
 when 2 then 'Western'
 when 3 then 'Northern' 
 when 4 then 'Southern'
 end as B�lge
 from Territories

/************************************************************************************/
 select ProductID,ProductName,SupplierID,CategoryID,
 case 
 when CategoryID in (1,3,5) then 'x maddesi'
 when CategoryID = 6 then 'y maddesi'
 when CategoryID like '%2%' then 'z maddesi'
 when CategoryID between 7 and 8 then 'j maddesi'
 else 'bilinmiyor' end as Yap�ld���Madde
 from Products
 where CategoryID in (1,3,5,6,2,7,8)

 /*************************************************************************************/
 select case
 when SupplierID>CategoryID then CategoryID
 else SupplierID
 end as newSupplierID,SupplierID,CategoryID
 from Products
 where CategoryID in(1,3,5,6,2,7,8)