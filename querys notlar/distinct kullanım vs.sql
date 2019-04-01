select distinct ShipCountry from Orders /* distinct ayn� olanlar� ay�klamak i�in*/

select [FirstName],[LastName],[ReportsTo] from [dbo].[Employees]


select [CompanyName] from [dbo].[Shippers]

select [CustomerID],[EmployeeID],[ShipRegion],[ShipVia] from  [dbo].[Orders]
where (CustomerID like '%DUMON%' or CustomerID like '%ALFKI%')
	/* CustomerID in ('DUMON','ALFKI') */
	/* CustomerID= 'DUMON' or CustomerID= 'ALFKI' */
and ShipVia=3 
and EmployeeID=1 
and ShipRegion is null

select [ShippedDate],[CustomerID],[EmployeeID] from [dbo].[Orders]
where [ShippedDate] is null
