select top 5 [ProductID],[ProductName],UnitPrice from Products
--where UnitPrice<=40 and UnitPrice>=20
where unitprice between 20 and 40
order by UnitPrice desc

select  +'AYVANSARAY/'+ EMP.FirstName+''+EMP.LastName as fullname, 
EmployeeID+1 as newEMPID, 
EmployeeID*25 as newEMPID,
title as Unvan
from Employees as EMP
where EmployeeID>5