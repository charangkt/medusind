use master
create table employe( empo int primary key, ename varchar(28),job varchar (30),mgr_id int ,hiredate varchar (40),sal int ,comm int ,deptno int)
insert into employe values(7369,' SMITH','CLERK',7902 ,'17-DEC-80',800, null,20)
insert into employe values(7499, 'ALLEN', 'SALESMAN', 7698   	,'20-FEB-81',    	 1600,     300,    30)
insert into employe values(7521, '   WARD',	  ' SALESMAN',      7698,    	'2-FEB-81'  	 ,1250 ,    500,    30)
insert into employe values(7566 ,   'JONES',     'MANAGER',       7839,   	 '02-APR-81',   	 2975,   null    ,     20)
insert into employe values(7654 ,   'MARTIN' ,   'SALESMAN'     , 7698,   	 '28-SEP-81',  	 1250,    1400,    30)
insert into employe values(7698,	   'BLAKE',     'MANAGER', 	    7839, 	     '01-MAY-81',       2850, null,            30)
insert into employe values(7782,    'CLARK ',    'MANAGER',       7839,    	'09-JUN-81',   	 2450,  null,          10)
insert into employe values(7788,   'SCOTT',     'ANALYST',       7566,   	 '19-APR-87',     3000 , null,     20)
insert into employe values(7839,   'KING',      'PRESIDENT',      null,      	 '17-NOV-81',     5000, null,           10)
insert into employe values(7844,    'TURNER',    'SALESMAN',      7698  ,  	'08-SEP-81' ,   	 1500  ,    0,     30)
insert into employe values(7876,   'ADAMS',     'CLERK' ,        7788 ,   	'23-MAY-87',      1100   ,null,          20)
insert into employe values(7900,  'JAMES',     'CLERK',         7698,   	 '03-DEC-81',  	 950   , null,        30)
insert into employe values(7902, 'FORD'    , 'ANALYST',       7566  , 	 '03-DEC-81',   	 3000        ,null  ,  20)
insert into employe values(7934,'MILLER '   ,'CLERK   '      ,7782    ,	'23-JAN-82',	      1300        ,null,    10)
select * from employe
create table department (DEPTNO int primary key , DNAME varchar(20),LOC varchar(49)) 
insert into department values(10,     'ACCOUNTING' ,   'NEW YORK')
insert into department values(20,     'RESEARCH '  ,  ' DALLAS' )
insert into department values(30 ,    'SALES',         'CHICAGO' ) 
insert into department values(40 ,    'OPERATIONS',    'BOSTON' )
select * from department
--1
select * from employe where ename like 'A%'
--2
select * from employe where job not like 'MANAGER'
---3
select * from employe where ename like 'm%' 
---4
select *from employe where sal between 1200 and 1400
---5 
select COUNT(job) 'NO_OF_CLERKS_E' from  employe WHERE job='CLERK'