alter proc spUpdate
@CategoryID int,@categoryName nvarchar(50),@description ntext
as
if(@categoryName is null)
	begin
		raiserror(15600,-1,-1,'Kategori ad� bo� ge�ilemez olamaz')
	end
if(len(@categoryName)>15)
	begin
		raiserror(15600,-1,-1,'Kategori ad� 15 harften b�y�k olamaz')
	end
if(@CategoryID>IDENT_CURRENT('Categories'))
	begin
		raiserror(15600,-1,-1,'bu ID de kategori yok')
	end
if(@CategoryID<0)
	begin
		raiserror(15600,-1,-1,'ID 0 dan k���k olamaz')
	end

update Categories
set CategoryName=@categoryName,[Description]=@description
where CategoryID=@CategoryID

exec spUpdate -12,null,'hophop'