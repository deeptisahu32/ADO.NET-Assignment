select * from Employeeclasses; --from empdb
select * from iplclasses;--from sportdb 
select * from Students; --from sportdb

--//2. Create procedure which accepts department Name as a parameter and 
        --//display all employee of that department

create procedure sp1(@dname varchar(20))
as
begin
select * from Employeeclasses where DepartmentName=@dname
end;

