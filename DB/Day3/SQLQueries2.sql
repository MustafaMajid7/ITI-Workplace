use PrivateCenter;


create table Instructor(
ID int identity(1,1),
Salary int default 3000,
Overtime int ,
BD date,
age as (year(getdate())-year(BD)),
NetSalary as Salary -Overtime,
HireDate date default getdate(),
address varchar(30),
Fname varchar(20),
Lname varchar(20)

constraint c1 primary key (ID),

constraint c2 check(address in ('Alex','Cairo')),

constraint c3 check (Salary between 1000 and 5000),

constraint c4 unique (Overtime),

);

create table Course(
CRS_ID int identity(1,1),
Cname varchar(30),
Duration int

constraint c5 primary key (CRS_ID),
constraint c6 unique (Duration),

);

create table Teaching(
INS_ID int ,
CRS_ID int ,

constraint c7 primary key (INS_ID,CRS_ID),

constraint c8 foreign key(INS_ID) references Instructor(ID)
			on delete cascade on update cascade,

constraint c9 foreign key(CRS_ID) references Course(CRS_ID)
			on delete cascade on update cascade
);



create table Lab(
LID int identity(1,1),
Lab_Location varchar(30),
Capacity int,
CID int

constraint c10 primary key (LID,CID),
constraint c11 check(Capacity <20),
constraint c12 foreign key(CID) references Course(CRS_ID)
			on delete cascade on update cascade

)