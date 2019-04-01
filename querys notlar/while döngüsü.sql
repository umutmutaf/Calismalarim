declare @sayac int
select @sayac=1

while (@sayac<15)
begin
	select @sayac=@sayac+1
end
	select 'sayac=',@sayac as sayacýn_Son_deðeri
