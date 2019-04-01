create trigger trg_urunSatis on [dbo].[Order Details]
after insert
as
begin
declare @Quantity int, @ProductID int
select @Quantity=Quantity,@ProductID=ProductID from inserted -- inserted veya deleted i kullanmak bu þekilde
 update Products set UnitsInStock=UnitsInStock-@Quantity
 where ProductID=@ProductID 
end

