create view vw_GetCustomerOrders(M��teriID,[Sipari� Say�s�])
as
select Customers.CustomerID, count(Orders.OrderID)
from Customers
inner join Orders on Customers.CustomerID=Orders.CustomerID
group by Customers.CustomerID

select * from vw_GetCustomerOrders

/****************************************************************************/
 create view vw_GetProducts     -- with encryption de�i�iklik yap�lmas�n� engellemek i�in
 with encryption
 as
 select p.ProductID,p.ProductName,p.UnitPrice,c.CategoryName 
 from Products p, Categories c
 where c.CategoryID=p.CategoryID
 and c.CategoryName='Beverages'

 select * from vw_GetProducts

 /************************************************************************/

 create view vw_Products    --olu�turma
 as
 select * from Products
 /********************************************************************/

 alter view vw_Products      --g�ncelleme//-- with schemabinding de�i�iklik yap�lmas�n� engellemek i�in
 with schemabinding
 as
 select p.ProductID,p.ProductName from dbo.Products p

 select * from vw_Products
 /*******************************************************/

 alter table Products
 alter column ProductName varchar(40) not null
