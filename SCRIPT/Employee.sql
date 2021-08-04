CREATE TABLE Employee(

ComId varchar(20) not null default(''),
AutoNo int IDENTITY(1,1),
--------------------------------------------
EmpID varchar(50) not null default(''),

--Personal Info
EmpName varchar(100) not null default(''),
FName varchar(100) not null default(''),
MName varchar(100) not null default(''),
Sex varchar(50) not null default(''),
DOB datetime null,
MStatus varchar(50) not null default(''),
SpName varchar(100) not null default(''),
EmgContact varchar(100) not null default(''),
EmgPhone varchar(50) not null default(''),
Phone varchar(50) not null default(''),
NidNo varchar(50) not null default(''),


--Address Info
Division varchar(100) not null default(''),
Zila varchar(100) not null default(''),
Upzilla varchar(100) not null default(''),
Uneon varchar(100) not null default(''),
PreAddress varchar(200) not null default(''),
PerAddress varchar(200) not null default(''),

-- Company and Salary Info
EmpGroup varchar(100) not null default(''),
DesignationID varchar(50) not null default(''),
SalaryUnit varchar(50) not null default(''),
Salary money not null default(0),
JoinDate datetime null,
ConfirmDate datetime null,
Ref varchar(100) not null default(''),
PayType varchar(50) not null default(''),
AcType varchar(50) not null default(''),
AcNo varchar(50) not null default(''),

SMS varchar(10) not null default('0'),
AttnBonus varchar(10) not null default('0'),
PF varchar(10) not null default('0'),
PFPercent money not null default(0),
OverTime  varchar(10) not null default('0'),
sts varchar(10) not null default('0'),
Resign varchar(10) not null default('0'),
ResignType varchar(50) not null default(''),
ResDate datetime null,
ResReason varchar(100) not null default(''),

--------------------------------------------
ComName varchar(150) not null default(''),
PcName varchar(50) not null default(''),
UserCode varchar(50) not null default(''),
EntryTime datetime not null default(GETDATE()),
UserIP varchar(100) not null default(''),

)