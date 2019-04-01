select 
	O.OrderID SiparisID,
	C.CustomerID MusteriID,
	C.CompanyName [Musteri Adi],
	S.SupplierID TedarikciID,
	S.CompanyName Tedarikci,
	CAT.CategoryID KategoriID,
	CAT.CategoryName [Kategori Adi],
	O.OrderDate [Siparis Tarihi],
	P.ProductName [Urun Adi],
	OD.Quantity Miktar,
	OD.UnitPrice [Satis Fiyati],
	P.UnitPrice [Guncel Fiyat],
((P.UnitPrice*100)/OD.UnitPrice)-100 Yuzde

from Orders as O
inner join [Order Details] OD on O.OrderID=OD.OrderID
inner join Products P on od.ProductID=P.ProductID
inner join Customers C on C.CustomerID=O.CustomerID
inner join Suppliers S on S.SupplierID=P.SupplierID
right join Categories CAT on CAT.CategoryID=P.CategoryID


/********************************************************************************************/




