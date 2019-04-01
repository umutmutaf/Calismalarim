create table deneme
(
yazNo tinyint identity,
metin varchar(25)
)

declare @sayac int=1
while (@sayac<=5)
begin
	insert deneme(metin) values(cast(@sayac as varchar(5))+' numaralý düzce eklendi')
	select @sayac=@sayac+1
end

select * from deneme