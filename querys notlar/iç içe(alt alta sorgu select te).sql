select * from Employees where HireDate<
	(select HireDate from Employees where Title='Sales Manager')

/******************************************************************************/

select * from Employees where Title in
	(select Title from Employees where LastName='Davolio'
	and FirstName='Nancy')

/*****************************************************************************/

select * from Employees where TitleOfCourtesy in
	(select TitleOfCourtesy from Employees where Title='Sales Representative')
