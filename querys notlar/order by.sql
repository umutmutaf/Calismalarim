/****** Script for SelectTopNRows command from SSMS  ******/
SELECT *
  FROM [Northwind].[dbo].[Orders]
  --order by OrderDate desc 
  order by CustomerID asc,OrderDate asc

  select distinct [ShipCity], [ShipCountry] from Orders
  order by ShipCountry  asc,ShipCity asc
  

