use ITI

------------------------------------------------ Query 1 -----------------------------------------------------------

alter proc students 
as

	select d.Dept_Name,COUNT(*)
	from Department d join Student s
	on d.Dept_Id=s.Dept_Id
	group by d.Dept_Name


students

------------------------------------------------ Query 2 -----------------------------------------------------------

use Company_SD

select * from Project

alter proc employees 
as
	
	declare @num int
	select @num = count(*)
	from Employee e join Works_for w
	on e.SSN = w.ESSn
	join Project p
	on p.Pnumber=w.Pno
	where p.Pnumber = 100
	
	if @num>3
		begin
		select 'The number of employees in the project p1 is 3 or more'
		end

	else 
		begin

		Declare C1 Cursor

		for select CONCAT(e.Fname,' ',e.Lname) as [Full Name]
			from Employee e join Works_for w
			on e.SSN = w.ESSn
			join Project p
			on p.Pnumber=w.Pno
			where p.Pnumber = 100
		for read only

		declare @full_name varchar(40),@all varchar(1000)

		open C1
		Fetch C1 into @full_name
		while @@FETCH_STATUS=0
			begin
				set @all = concat(@all,', ',@full_name) 
				Fetch C1 into @full_name
			end
		select 'The following employees work for the project p1'+@all
		close C1
		Deallocate C1

		end


employees


------------------------------------------------ Query 3 -----------------------------------------------------------

alter proc new_emp @oldNum int,@newNum int ,@projNumber int
as
	update Works_for
	set ESSn = @newNum
	where ESSn = @oldNum and Pno = @projNumber

	
select * from Works_for

new_emp 112233,102672,30



------------------------------------------------ Query 4 -----------------------------------------------------------

create trigger auditing
on project
for update
as
	if update(budget)
		begin
			declare @old int,@new int,@projName varchar(20)
			select @old=budget,@projName=Pnumber from deleted
			select @new=budget from inserted
			insert into auditTable
			values(@projName,suser_name(),getdate(),@old,@new)
		end

update Project
set budget = 6000
where Pnumber = 200

------------------------------------------------ Query 5 -----------------------------------------------------------

use iti

alter trigger prevention
on department
instead of insert
as
	select 'you can’t insert a new record in that table'


insert into Department
values(10,'dep1','System Development','cairo',4,'2000-01-01')

select * from Department

------------------------------------------------ Query 6 -----------------------------------------------------------

use Company_SD

create trigger prevention
on employee
instead of insert
as
	if LOWER(FORMAT(GETDATE(),'MMMM')) = 'march'
		select 'you can’t insert a new record in march'
	else
		insert into Employee
		select * from inserted

insert into Employee
values (null,null,1111111,null,null,null,null,512463,20)

select * from Employee

------------------------------------------------ Query 7 -----------------------------------------------------------

create trigger auditingStudent
on student
for insert
as
	insert into auditStudent
	values (@@SERVERNAME,GETDATE(),SUSER_NAME())


insert into Student

values(52,'Amr','Magdy','Cairo',	21	,10,	1)

select * from auditStudent


------------------------------------------------ Query 8 -----------------------------------------------------------

alter trigger deleteStudent
on student
instead of delete
as
	declare @id int 
	select @id= d.St_Id from deleted d
	insert into auditStudent
	values (@@SERVERNAME,GETDATE(),concat('try to delete Row with Key ',convert(nvarchar(20),@id)) )

delete from Student
where St_Id = 4

select * from Student
select * from auditStudent


------------------------------------------------ Query 1 -----------------------------------------------------------



------------------------------------------------ Query 1 -----------------------------------------------------------



------------------------------------------------ Query 1 -----------------------------------------------------------


------------------------------------------------ Query 1 -----------------------------------------------------------

