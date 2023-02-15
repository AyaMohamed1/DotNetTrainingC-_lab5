using lab5;

Employee e1= new Employee() { EmployeeID = 123, BirthDate = new DateTime(1997,5,1), VacationStock = 0};
Employee e2 = new Employee() { EmployeeID = 345, BirthDate = new DateTime(1963, 4, 2), VacationStock = 5 };
Employee e3 = new Employee() { EmployeeID = 678, BirthDate = new DateTime(1990, 7, 12), VacationStock = 1 };
SalesPerson s1 = new() { EmployeeID = 999, BirthDate = new DateTime(1963, 4, 2), VacationStock = 5, AchievedTarget = 18 };
SalesPerson s2 = new() { EmployeeID = 333, BirthDate = new DateTime(1997, 5, 1), VacationStock = 0, AchievedTarget = 18 };
SalesPerson s3 = new() { EmployeeID = 919, BirthDate = new DateTime(1997, 10, 1), VacationStock = 3, AchievedTarget = 4 };


Department d1 = new Department() { DeptID = 1, DeptName = "dept1"};
Department d2 = new Department() { DeptID = 2, DeptName = "dept2" };

Club c1 = new Club() { ClubID = 4, ClubName = "chess"};
Club c2 = new Club() { ClubID = 5, ClubName = "flowers" };

d1.AddStaff(e1);
d1.AddStaff(e2);
d2.AddStaff(e3);

d1.AddStaff(s1);
d1.AddStaff(s2);
d2.AddStaff(s3);

c1.AddMember(e1);
c2.AddMember(e2);
c1.AddMember(e3);
c2.AddMember(e3);

c1.AddMember(s1);
c1.AddMember(s2);
c1.AddMember(s3);
c2.AddMember(s3);



e1.EmployeeLayOff += d1.RemoveStaff;
e2.EmployeeLayOff += d1.RemoveStaff;
e3.EmployeeLayOff += d2.RemoveStaff;

s1.EmployeeLayOff += d1.RemoveStaff;
s2.EmployeeLayOff += d1.RemoveStaff;
s3.EmployeeLayOff += d2.RemoveStaff;

e1.EmployeeLayOff += c1.RemoveMember;
e2.EmployeeLayOff += c2.RemoveMember;
e3.EmployeeLayOff += c1.RemoveMember;
e3.EmployeeLayOff += c2.RemoveMember;

s1.EmployeeLayOff += c1.RemoveMember;
s2.EmployeeLayOff += c1.RemoveMember;
s3.EmployeeLayOff += c1.RemoveMember;
s3.EmployeeLayOff += c2.RemoveMember;


e1.RequestVacation(new DateTime(2023,2,13), new DateTime(2023, 2, 15));
e2.RequestVacation(new DateTime(2023, 2, 13), new DateTime(2023, 2, 15));
e3.RequestVacation(new DateTime(2023, 2, 13), new DateTime(2023, 2, 15));

e1.EndOfYearOperation();
e2.EndOfYearOperation();
e3.EndOfYearOperation();

s1.CheckTarget(18);
s2.CheckTarget(15);
s3.CheckTarget(18);

s1.RequestVacation(new DateTime(2023, 2, 13), new DateTime(2023, 2, 15));
s2.RequestVacation(new DateTime(2023, 2, 13), new DateTime(2023, 2, 15));
s3.RequestVacation(new DateTime(2023, 2, 13), new DateTime(2023, 2, 15));

s1.EndOfYearOperation();
s2.EndOfYearOperation();
s3.EndOfYearOperation();