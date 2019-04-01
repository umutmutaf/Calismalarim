declare @tabloTipiDegisken table
(
numara tinyint identity,
isim varchar(20)
)
insert into @tabloTipiDegisken values('umut')
insert into @tabloTipiDegisken values('mutaf')

select * from @tabloTipiDegisken