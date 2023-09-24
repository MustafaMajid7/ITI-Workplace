use ITI

----------------------------------------- Query 1 -------------------------------------------

select COUNT(*) 
from Student 
where St_Age  is not null

----------------------------------------- Query 2 -------------------------------------------

select distinct ins_Name
from Instructor

----------------------------------------- Query 3 -------------------------------------------

select * from Student
select * from Department

select s.St_Id as [Student ID] , CONCAT(ISNULL(s.St_Fname,'FName'),' ',ISNULL(s.St_Lname,'LName')) as [Student Full Name] , d.Dept_Name as [Department Name]
from student s join Department d 
on s.Dept_Id = d.Dept_Id

----------------------------------------- Query 4 -------------------------------------------

--select top(1) * from Instructor
--select top(1) * from Department

select s.Ins_Name , d.Dept_Name
from Instructor s left join Department d 
on s.Dept_Id = d.Dept_Id

----------------------------------------- Query 5 -------------------------------------------

select  CONCAT(ISNULL(s.St_Fname,'FName'),' ',ISNULL(s.St_Lname,'LName')) as [Student Full Name] , c.Crs_Name
from student s join Stud_Course sc 
on s.St_Id= sc.St_Id
join Course c
on sc.Crs_Id = c.Crs_Id
where sc.Grade is not null

----------------------------------------- Query 6 -------------------------------------------

select c.Crs_Name , COUNT(*) [Number of Courses]
from Course c
group by c.Crs_Name


----------------------------------------- Query 7 -------------------------------------------

select min(i.Salary),max(i.Salary)
from Instructor i

----------------------------------------- Query 8 -------------------------------------------

select * 
from Instructor i
where i.Salary < (select AVG(Salary) from Instructor)

----------------------------------------- Query 9 -------------------------------------------

select d.Dept_Name
from Department d join Instructor i
on d.Dept_Id = i.Dept_Id
where i.Salary = (select MIN(Salary) from Instructor)

----------------------------------------- Query 10 -------------------------------------------

select top(2) * 
from Instructor
order by Salary desc

----------------------------------------- Query 11 -------------------------------------------

select * from Instructor

select i.Ins_Name , coalesce(i.Salary,0)
from Instructor i


----------------------------------------- Query 12 -------------------------------------------

select Avg(Salary) from Instructor

----------------------------------------- Query 13 -------------------------------------------

select * from Student

select s2.St_Fname , s.*
from Student s join Student s2
on s.St_Id = s2.St_super

----------------------------------------- Query 14 -------------------------------------------

select Newtable.Salary ,Newtable.Dept_Id
from (select *,Row_number() over(partition by dept_id order by salary desc) as RN
	  from Instructor) as Newtable
where RN in (1,2) and Newtable.Salary is not null

----------------------------------------- Query 15 -------------------------------------------

select *
from (select *,Row_number() over(partition by dept_id order by random) as RN
	  from (select *,NEWID() as random from Student) as nt1) as Newtable
where RN =1