use master
create table emplo( empo int primary key, ename varchar(28),job varchar (30),mgr_id int ,hiredate varchar (40),sal int ,comm int ,deptno int)
insert into emplo values(7369,' SMITH','CLERK',7902 ,'17-DEC-80',800, null,20)
insert into emplo values(7499, 'ALLEN', 'SALESMAN', 7698   	,'20-FEB-81',    	 1600,     300,    30)
insert into emplo values(7521, '   WARD',	  ' SALESMAN',      7698,    	'2-FEB-81'  	 ,1250 ,    500,    30)
insert into emplo values(7566 ,   'JONES',     'MANAGER',       7839,   	 '02-APR-81',   	 2975,   null    ,     20)
insert into emplo values(7654 ,   'MARTIN' ,   'SALESMAN'     , 7698,   	 '28-SEP-81',  	 1250,    1400,    30)
insert into emplo values(7698,	   'BLAKE',     'MANAGER', 	    7839, 	     '01-MAY-81',       2850, null,            30)
insert into emplo values(7782,    'CLARK ',    'MANAGER',       7839,    	'09-JUN-81',   	 2450,  null,          10)
insert into emplo values(7788,   'SCOTT',     'ANALYST',       7566,   	 '19-APR-87',     3000 , null,     20)
insert into emplo values(7839,   'KING',      'PRESIDENT',      null,      	 '17-NOV-81',     5000, null,           10)
insert into emplo values(7844,    'TURNER',    'SALESMAN',      7698  ,  	'08-SEP-81' ,   	 1500  ,    0,     30)
insert into emplo values(7876,   'ADAMS',     'CLERK' ,        7788 ,   	'23-MAY-87',      1100   ,null,          20)
insert into emplo values(7900,  'JAMES',     'CLERK',         7698,   	 '03-DEC-81',  	 950   , null,        30)
insert into emplo values(7902, 'FORD'    , 'ANALYST',       7566  , 	 '03-DEC-81',   	 3000        ,null  ,  20)
insert into emplo values(7934,'MILLER '   ,'CLERK   '      ,7782    ,	'23-JAN-82',	      1300        ,null,    10)
insert into emplo values(7935,'CHARAN '   ,'ANALYST   '      ,7784    ,	'22-JAN-82',	      12000        ,null,    10)
select * from emplo
create table depar (DEPTNO int primary key , DNAME varchar(20),LOC varchar(49)) 
insert into depar values(10,     'ACCOUNTING' ,   'NEW YORK')
insert into depar values(20,     'RESEARCH '  ,  ' DALLAS' )
insert into depar values(30 ,    'SALES',         'CHICAGO' ) 
insert into depar values(40 ,    'OPERATIONS',    'BOSTON' )
select * from depar
--1
select * from emplo where ename like 'A%'
--2
select * from emplo where job not like 'MANAGER'
---3
select * from emplo where ename like 'm%' 
---4
select *from emplo where sal between 1200 and 1400
---5 
select COUNT(job) 'NO_OF_CLERKS_E' from  emplo WHERE job='CLERK'
---6
select count (sal) 'salary' from emplo where sal>1000
--7
select *from emplo where mgr_id is null
--8 
select ename ,sal+sal*0.1 from emplo where deptno=20
--9
select avg(sal) 'avarge' ,count(job) 'no of employee' from emplo group by job
--10
select * from emplo where sal=(select max (sal) from emplo) or sal=(select min (sal) from emplo)
--11
select * from depar where deptno not in(select deptno from emplo)
--12 
select ename ,sal from emplo where job ='analyst' and sal >1200 and deptno =20 order by ename
--13
select ename ,sal from emplo where job='salesman' and sal>=1000 and deptno=30 order by ename
---14
select * from emplo where ename in ('miller','FORD')
--15 
select * from emplo where ename='FORD'
--16
select ename from emplo where ename like'[am]%'
--17
select sal*12 as anuvalsalary from emplo where ename='ford'
--18 
select ename, sal from emplo where sal not between 1500 and 2800
---19
--assignment 2---
--20
select * from emplo where job='manager'
--21
select ename ,sal from emplo where ename not in ('james')
--22
select * from emplo where ename like 's%'
--23
select * from emplo where ename like '%a%'
--24
select *from emplo where ename like '___l%'
--25
select sal/12 as monthlysalary ,sal as anuvalsalary from emplo 
--26
select ename,sal from emplo where sal>1000
---27
select ename,sal/30 from emplo where ename='jones'
---28
select sum(sal) as totalmonthlysalary from emplo
---29
select avg(sal*12) as avgaranuvalsalary from emplo
--30
select ename,sal,job,deptno from emplo where deptno!=30
----31
select distinct deptno from emplo
---32
select ename,sal from emplo where sal>1500 and deptno=10 or deptno=30
--33
select ename ,job ,sal from emplo where job in('manager','analyst')and sal not in(1000,3000,5000)
--34
select ename,sal,comm from emplo where comm>(sal+sal*0.1)
--35
select ename from emplo where ename like '%l%l%' and deptno=30 or mgr_id=7782
--36
select ename as employee_table ,dname as department_table from emplo e1 join depar d1 on e1.deptno=d1.Deptno order by dname, ename desc 
--37 
select ename ,dname from emplo e1 join depar d1 on e1.deptno=d1.DEPTNO order by DNAME,ename desc 