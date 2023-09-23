use ITI

-------------------------------------------------- Query 1 --------------------------------------------------

CREATE FUNCTION [dbo].[GetMonth] (@date datetime)
RETURNS nvarchar(10)
AS
BEGIN
    DECLARE @x nvarchar(10)
    
    SELECT @x = format(@date,'MMMM')
    
    RETURN @x
END

select dbo.GetMonth(getdate())


-------------------------------------------------- Query 2 --------------------------------------------------

create function dbo.RangeFunc(@num1 int , @num2 int)
returns @t table
			(
			 Numbers int
			)
as
	begin
		declare @count int
		select @count = iif(@num1<=@num2,@num1,@num2)
		select @num1 = iif(@num1>=@num2,@num1,@num2)
		while @count <=@num1
		begin 
			insert into @t
			values(@count)
			select @count += 1
		end
		return 
	end

select * from dbo.RangeFunc(5,10)

-------------------------------------------------- Query 3 --------------------------------------------------

Create function getData(@st_id int)
returns table
	as
	return
	(
	 select CONCAT(s.St_Fname,' ',s.St_Lname) as [Full Name],d.Dept_Name
	 from Student s join Department d
	 on s.Dept_Id = d.Dept_Id
	 where s.St_Id = @st_id
	)

select * from dbo.getData(10)

-------------------------------------------------- Query 4 --------------------------------------------------

alter function checkNull(@st_id int)
returns varchar(50)
as
begin 
	declare @res varchar(50)
	declare @t1 varchar(25)
	declare @t2 varchar(25)
	select @t1 = s.St_Fname,@t2=s.St_Lname 
	from Student s
	where s.St_Id = @st_id
	select @res = case 
		when @t1 is null and @t2 is null then  'First name & last name are null'
		when @t1 is null then  'first name is null'
		when @t2 is null then 'last name is null'
		when @t1 is not null and @t2 is not null then 'First name & last name are not null'
	end
	return @res
end

select dbo.checkNull(4)

select *
from Student s


-------------------------------------------------- Query 5 --------------------------------------------------


alter function getDepart(@mang_id int)
returns table
as
return(
	select i.Ins_Name , d.Dept_Name , d.Manager_hiredate
	from Instructor i join Department d
	on i.Ins_Id = d.Dept_Manager
	where Ins_Id = @mang_id
)

select * from dbo.getDepart(9)

-------------------------------------------------- Query 6 --------------------------------------------------

alter function getName (@req varchar(20))
returns @t table (
					Required_name varchar(60)
				)
as 
	begin 
		insert into @t
		select case
				when @req = 'first name' then ISNULL (s.st_fname,s.st_lname)
				when @req = 'last name' then ISNULL (s.st_lname,s.st_fname)
				else concat(ISNULL(s.st_fname,''),case when s.st_fname is null then '' else ' ' end,ISNULL(s.st_lname,''))
				end
		from iti.dbo.student s
		return
	end


select *
from getName('full name')

-------------------------------------------------- Query 7 --------------------------------------------------

select s.St_Id, SUBSTRING(s.St_Fname,1,LEN(s.St_Fname)-1)
from Student s

-------------------------------------------------- Query 8 --------------------------------------------------

declare @t table  (
crsid int,
stid int,
grade int
)

insert into @t
select sc.*
from Stud_Course sc join Student s
on sc.St_Id = s.St_Id
where s.Dept_Id=10

update Stud_Course 
set grade = null
where exists (select * from @t where crs_id = crsid and st_id = stid) 

select * from Stud_Course

-------------------------------------------------- Query 9 --------------------------------------------------

create table DailyTransaction (

	id int,
	amount money
)

create table LastTransaction (

	id int,
	amount money
)

merge into dailytransaction d
using lasttransaction l
on d.id=l.id
when matched then
update 
	set d.amount = l.amount
when not matched then
	insert
		values(l.id,l.amount);

select * from DailyTransaction
select * from LastTransaction

-------------------------------------------------- Query 10 --------------------------------------------------

create schema itistud

alter schema ITIStud transfer dbo.student
alter schema ITIStud transfer dbo.course

select * from itistud.Student
