select * from [dbo].[Employees]  /*e�ittir*/
where [TitleOfCourtesy]='Mr.'

select * from [dbo].[Employees]  /*e�it de�ildir*/
where [TitleOfCourtesy]!='Mr.'

select * from [dbo].[Employees]  /*  "<>"  e�it de�ildir*/
where [TitleOfCourtesy]<>'Mr.'

select * from [dbo].[Employees]   /*ya da*/
where HireDate>'1992' 
and title='Sales Representative' 
--and BirthDate<'1950'
and Country='USA'