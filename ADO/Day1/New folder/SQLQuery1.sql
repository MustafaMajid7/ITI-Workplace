use ITI

select [Crs_Id], [Crs_Name], [Crs_Duration], [Top_Id] from course

select [Top_Id],[Top_Name] from Topic

insert into Course values('hhhh',23,2);

update Course set [Crs_Name] = 'new value', [Crs_Duration] = 2222,[Top_Id] = 1 where Crs_Id = 1202;

delete from Course where Crs_Id= 1202