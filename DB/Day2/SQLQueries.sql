use Company_SD

/* query 1*/
select * from Employee

/* query 2*/
SELECT Fname, Lname, Salary ,Dno FROM Employee;

/* query 3*/

Select * from Project
SELECT Pname, Plocation, Dnum FROM Project;

/* query 4*/

SELECT Fname, Salary*12*.01 as "ANNUAL COMM"  FROM Employee;

/* query 5*/

--SELECT SSN,Fname FROM Employee WHERE SALARY > 1000;

/* query 6*/

--SELECT SSN,Fname FROM Employee WHERE SALARY*12 > 10000;

/* query 7*/

SELECT Fname,Salary FROM Employee WHERE Sex = 'F';

/* query 8*/

--SELECT * FROM Departments;

SELECT Dnum,Dname FROM Departments where MGRSSN=968574;

/* query 9*/

select Pnumber,Pname,Plocation from Project where Dnum = 10