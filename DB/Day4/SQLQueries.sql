use Company_SD

/* Query 1*/

select * from Employee
select * from Dependent

select CONCAT(Fname,' ',Lname) [Full Name],e.Sex
from Employee e join Dependent d
on e.SSN = d.ESSN and e.Sex='F' and d.Sex = 'F'
Union
select CONCAT(Fname,' ',Lname) [Full Name],e.Sex
from Employee e join Dependent d
on e.SSN = d.ESSN and e.Sex='M' and d.Sex = 'M'


/* Query 2*/

select * from Project
select * from Works_for

select sum(w.Hours) [Total Hours],p.Pname
from Project p join Works_for w
on p.Pnumber = w.Pno
group by p.Pname

/* Query 3*/

select d.*
from Departments d 
where d.Dnum = (select e.Dno from Employee e where e.SSN = (select min(ee.SSN) from Employee ee))

/* Query 4*/

select min(e.Salary) minmium,max(e.Salary) maximum ,avg(e.Salary) average,d.Dname
from Departments d join Employee e
on d.Dnum=e.Dno
group by d.Dname


select min(isnull(e.Salary,0)) minmium,max(isnull(e.Salary,0)) maximum ,avg(isnull(e.Salary,0)) average,d.Dname
from Departments d join Employee e
on d.Dnum=e.Dno
group by d.Dname

/* Query 5*/

select distinct CONCAT(Fname,' ',Lname) [Full Name]
from Departments d join Employee e
on d.MGRSSN=e.SSN
join Dependent dp on dp.ESSN = e.SSN


/* Query 6*/

select d.Dname , d.Dnum , (select count(*) from Employee e where e.Dno = d.Dnum) as noOfEmp
from Departments d
where d.Dnum in (select averageTable.Dno
from (select AVG(e.Salary) as average,e.Dno from Employee e group by e.Dno) as averageTable
where (select AVG(Salary) from Employee)> averageTable.average)

/* Query 7*/

select distinct e.Dno, e.Lname , e.Fname
from Employee e join Works_for w
on e.SSN=w.ESSn
join Project p on w.Pno = p.Pnumber
order by e.Dno, e.Lname , e.Fname 

/* Query 8*/

select * from Employee

select max (e.Salary) [2nd max], (select MAX(e.Salary)from Employee e ) [1st max]
from Employee e
where e.Salary<(select max (e.Salary) from Employee e)

/* Query 9*/

select CONCAT(Fname,' ',Lname) [Full Name]
from Employee e
where CONCAT(Fname,' ',Lname) in (select Dependent_name from Dependent)

/* Query 10*/

select e.SSN,e.Fname
from Employee e
where exists (select * from Dependent d where e.SSN = d.ESSN)

/* Query 11*/

insert into Departments(Dname,Dnum,MGRSSN,[MGRStart Date])
values ('DEPT IT',100,112233,'1-11-2006')

select * from Departments

/* Query 12*/

update Departments
set MGRSSN = (select e.SSN from Employee e where e.SSN = 968574)
where Dname = 'DEPT IT'

update Departments
set MGRSSN = (select e.SSN from Employee e where e.SSN = 102672)
where Dnum = 20


update Employee
set Superssn = (select e.SSN from Employee e where e.SSN = 102672)
where SSN = 102660

select * from Employee


/* Query 13*/

update Employee
set Superssn = 102672
where Superssn = 223344

update Works_for
set ESSn = 102672
where ESSn = 223344

update Departments
set MGRSSN = 102672
where MGRSSN = 223344

delete from Employee
where SSN = 223344

select * from Employee


/* Query 14*/

update Employee
set Salary +=.3*Salary
where SSN in(select e.SSN from Employee e join Works_for w on e.SSN= w.ESSn 
		join Project p on p.Pnumber = w.Pno where p.Pname = 'Al Rabwah')



