if not exists(select*from Categories)
begin
	print 'kategori yok'

end
else
begin
	print'tanýmlý kategoriler var'

end