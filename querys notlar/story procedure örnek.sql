create proc sp_SiparisTarih
@BaslangicTarihi datetime,@BitisTarihi date
as
select * from Orders o
inner join Customers c on c.CustomerID=o.CustomerID
where o.OrderDate between @BaslangicTarihi and @BitisTarihi
go


exec sp_SiparisTarih '1997-02-03','1999-02-03'
