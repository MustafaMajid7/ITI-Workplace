

------------------------------------------------------- Query 1 -------------------------------------------------------

alter view SuccessedStudents
as

select CONCAT(s.st_fname,' ',s.st_lname) as [Full Name],c.Crs_Name
from student s join Stud_Course sc
on sc.St_Id = s.st_id
join Course c
on c.Crs_Id=sc.Crs_Id
where sc.Grade >50


select * from SuccessedStudents

------------------------------------------------------- Query 2 -------------------------------------------------------

alter view Instructors_topics
with encryption
as

select distinct i.Ins_Name,t.Top_Name
from Instructor i join Ins_Course ic
on i.Ins_Id = ic.Ins_Id
join Course c
on ic.Crs_Id = c.Crs_Id
join Topic t
on c.Top_Id = t.Top_Id 
join Department d
on d.Dept_Manager=i.Ins_Id


select * from Instructors_topics

------------------------------------------------------- Query 3 -------------------------------------------------------

create view SD_JAVA_DEPT
as

select i.Ins_Name,d.Dept_Name
from Instructor i join Department d
on i.Dept_Id = d.Dept_Id 
where d.Dept_Name in ('SD','JAVA')

select * from SD_JAVA_DEPT

------------------------------------------------------- Query 4 -------------------------------------------------------

alter view STUD_ALEX_CAIRO
as

select s.*
from Student s
where s.St_Address in ('alex','cairo')
with check option

select * from STUD_ALEX_CAIRO

Update STUD_ALEX_CAIRO set st_address='tanta'
Where st_address='alex';


------------------------------------------------------- Query 5 -------------------------------------------------------

use Company

alter view Employees_Project([Project Name],[Number of employees])
as

select p.PName,count(*)
from Employee e join Works_ON w
on e.SSN=w.emp_SSN
join Project p
on w.Pro_Num = p.PNumber
group by p.PName

select * from Employees_Project

------------------------------------------------------- Query 6 -------------------------------------------------------

create schema Company 

create schema [Human Resources]

alter schema Company transfer department

alter schema [Human Resources] transfer employee


------------------------------------------------------- Query 7 -------------------------------------------------------

use iti

create nonclustered index hireDate
on department(Manager_hiredate)

select * from Department

------------------------------------------------------- Query 8 -------------------------------------------------------

create unique index hireDate
on student(st_age)

select * from Student

------------------------------------------------------- Query 9 -------------------------------------------------------

use Company_SD

select * from Employee

Declare C1 Cursor

for select Salary
	from Employee
for update

declare @salary int

open C1
Fetch C1 into @salary
while @@FETCH_STATUS=0
	begin
		if @salary<3000
			update Employee
				set Salary = @salary*1.10
			where current of c1

		else if @salary>=3000
			update Employee
				set Salary = @salary*1.20
			where current of c1
		
		Fetch C1 into @salary
	end
close C1
Deallocate C1


------------------------------------------------------- Query 10 -------------------------------------------------------

use ITI

select * from Department

Declare C1 Cursor

for select d.Dept_Name,i.Ins_Name
	from Department d join Instructor i
	on d.Dept_Manager=i.Ins_Id
for read only

declare @Dept_Name varchar(20),@ins_name varchar(20)

open C1
Fetch C1 into @Dept_Name,@ins_name
while @@FETCH_STATUS=0
	begin
		select @Dept_Name,@ins_name
		Fetch C1 into @Dept_Name,@ins_name
	end
close C1
Deallocate C1

------------------------------------------------------- Query 11 -------------------------------------------------------

Declare C1 Cursor

for select i.Ins_Name
	from Instructor i
for read only

declare @ins_name varchar(20),@All_Names varchar(500)

open C1
Fetch C1 into @ins_name
while @@FETCH_STATUS=0
	begin
		set @All_Names = concat(@All_Names,' ',@ins_name) 
		Fetch C1 into @ins_name
	end
select @All_Names
close C1
Deallocate C1

------------------------------------------------------- Query 12 -------------------------------------------------------

--error due to encrypted view