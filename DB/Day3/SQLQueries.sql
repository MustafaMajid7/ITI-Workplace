use Company_SD

--select * from Departments
/* Query 1 */

select Departments.Dnum , Departments.Dname , Employee.SSN ,
CONCAT( Employee.Fname,' ',Employee.Lname) as fullname
from Departments inner Join Employee on Departments.MGRSSN = Employee.SSN;

/* Query 2 */

select D.Dname,P.Pname
from Departments D inner Join Project P
on D.Dnum = P.Dnum

/* Query 3 */

select DP.Dependent_name,DP.Bdate,DP.Sex
from Employee E inner Join Dependent DP
on E.SSN = DP.ESSN

/* Query 4 */

select P.Dnum,P.Pname,P.Plocation
from Project P
where P.City in ('Cairo','Alex')

/* Query 5 */

select * from Project
where Project.Pname like 'a%'

/* Query 6 */

select *
from Employee E
where E.Dno = 30 and E.Salary between 1000 and 2000

/* Query 7 */

select CONCAT(E.Fname,' ',E.Lname) as [Full Name]
from Employee E inner join Works_for W
on E.SSN = W.ESSn
inner join Project P 
on W.Pno = P.Pnumber
where E.Dno = 10 and W.Hours >= 10 and P.Pname = 'AL Rabwah'

/* Query 8 */

select CONCAT(E1.Fname,' ',E1.Lname) as [Full Name]
from Employee E1 , Employee E2
where E2.SSN = E1.Superssn 
and E2.Fname = 'Kamel' and E2.Lname = 'mohamed'

/* Query 9 */

select CONCAT(E.Fname,' ',E.Lname) as [Full Name],P.Pname
from Employee E inner join Works_for W
on E.SSN = W.ESSn
inner join Project P 
on W.Pno = P.Pnumber
order by P.Pname


/* Query 10 */

select P.Pnumber,D.Dname,E.Lname,E.Address,E.Bdate
from Employee E inner join Departments D
on E.SSN = D.MGRSSN
inner join Project P 
on D.Dnum = P.Dnum
where P.City ='cairo'

/* Query 11 */

select E.*
from Employee E inner join Departments D
on E.SSN = D.MGRSSN	

/* Query 12 */

select E.*,DP.*
from Employee E left join Dependent DP
on E.SSN = DP.ESSN

/* Query 13 */

insert into Employee (Dno,SSN,Superssn,Salary)
values (30,102672,112233,3000)

--select * from Employee

/* Query 14 */

insert into Employee (Dno,SSN)
values (30,102660)

--select * from Employee

/* Query 15 */

--select * from Employee

update Employee
set Salary+=Salary*.2
where SSN = 102672

--select * from Employee
