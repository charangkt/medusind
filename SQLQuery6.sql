use master
create table clients2 (Client_ID int  Primary Key,

Cname VARCHAR(40) Not Null,

 Address1 VARCHAR(30),

Email VARCHAR(30) Unique,

Phone varchar(50) ,

Business VARCHAR (20) Not Null
)
Insert into clients2 
(CLIENT_ID,Cname,Address1,Email,Phone,Business) 
values (1001,'ACME 
Utilities','Noida','contact@acmeutil.com',9567880032,'Manufacturing');Insert into CLIENTS2 
(CLIENT_ID,CNAME,ADDRESS1,EMAIL,PHONE,BUSINESS) 
values (1002,'Trackon 
Consultants','Mumbai','consult@trackon.com',8734210090,'Consultant');
Insert into CLIENTS2 
(CLIENT_ID,CNAME,ADDRESS1,EMAIL,PHONE,BUSINESS) 
values (1003,'MoneySaver 
Distributors','Bangalore','save@moneysaver.com',7799886655,'Reseller');Insert into CLIENTS2 
(CLIENT_ID,CNAME,ADDRESS1,EMAIL,PHONE,BUSINESS) 
values (1004,'Lawful 
Corp','Chennai','justice@lawful.com',9210342219,'Professional');
select * from clients2
CREATE TABLE DEPARTMENTS(
DEPTNO int PRIMARY KEY,
DNAME VARCHAR(15) NOT NULL,
LOC VARCHAR(20));
Insert into DEPARTMENTS (DEPTNO,DNAME,LOC) values 
(10,'Design','Pune');
Insert into DEPARTMENTS (DEPTNO,DNAME,LOC) values 
(20,'Development','Pune');
Insert into DEPARTMENTS (DEPTNO,DNAME,LOC) values 
(30,'Testing','Mumbai');
Insert into DEPARTMENTS (DEPTNO,DNAME,LOC) values 
(40,'Document','Mumbai');
select * from DEPARTMENTS
CREATE TABLE EMPLOYEES(
EMPNO int PRIMARY KEY,
ENAME VARCHAR(20) NOT NULL,
JOB VARCHAR(15),
SALARY int  CHECK (SALARY > 0),
DEPTNO int REFERENCES 
DEPARTMENTS(DEPTNO));
Insert into EMPLOYEES 
(EMPNO,ENAME,JOB,SALARY,DEPTNO) values 
(7001,'Sandeep','Analyst',25000,10);
Insert into EMPLOYEES 
(EMPNO,ENAME,JOB,SALARY,DEPTNO) values 
(7002,'Rajesh','Designer',30000,10);
Insert into EMPLOYEES 
(EMPNO,ENAME,JOB,SALARY,DEPTNO) values 
(7003,'Madhav','Developer',40000,20);
Insert into EMPLOYEES 
(EMPNO,ENAME,JOB,SALARY,DEPTNO) values 
(7004,'Manoj','Developer',40000,20);
Insert into EMPLOYEES 
(EMPNO,ENAME,JOB,SALARY,DEPTNO) values 
(7005,'Abhay','Designer',35000,10);
Insert into EMPLOYEES 
(EMPNO,ENAME,JOB,SALARY,DEPTNO) values 
(7006,'Uma','Tester',30000,30);
Insert into EMPLOYEES 
(EMPNO,ENAME,JOB,SALARY,DEPTNO) values 
(7007,'Gita','Tech. Writer',30000,40);
Insert into EMPLOYEES 
(EMPNO,ENAME,JOB,SALARY,DEPTNO) values 
(7008,'Priya','Tester',35000,30);
Insert into EMPLOYEES 
(EMPNO,ENAME,JOB,SALARY,DEPTNO) values 
(7009,'Nutan','Developer',45000,20);
Insert into EMPLOYEES 
(EMPNO,ENAME,JOB,SALARY,DEPTNO) values 
(7010,'Smita','Analyst',20000,10);
Insert into EMPLOYEES 
(EMPNO,ENAME,JOB,SALARY,DEPTNO) values 
(7011,'Anand','Project Mgr',65000,10)
select *from EMPLOYEES
CREATE TABLE PROJECTS(
PROJECT_ID int PRIMARY KEY,
DESCR VARCHAR (30) NOT NULL,
START_DATE1 DATE,
PLANNED_END DATE ,
ACTUAL_END_DATE DATE,
BUDGET int CHECK(BUDGET > 0),
CLIENT_ID int REFERENCES 
CLIENTS2(CLIENT_ID));Insert into PROJECTS 
(PROJECT_ID,DESCR,START_DATE1,PLANNED_END,ACTUAL_END_DATE,BUDGET,CLIENT_ID) values 
(401,'Inventory','01-APR-11 DD-MONRR','01-OCT-11 DD-MON-RR','31-OCT11 DD-MON-RR',150000,1001);
