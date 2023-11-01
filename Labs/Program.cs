using Lab_7;

University university = new University("SomeUnik");
Department Fizmat = new Department("FizMat");
try
{
    Full_TimeTeacher tt = new Full_TimeTeacher ( "","",-500, 2000 );
    decimal salary1 = tt.CountSalary();
    Console.WriteLine($"Зарплата викладача 1: {salary1}");
}
catch (PremiyaException ex)
{
    Console.WriteLine(ex.Message);
}

try
{
    Part_TimeTeacher t = new Part_TimeTeacher( "af ", " af", -1000 );
    decimal salary2 = t.CountSalary();
    Console.WriteLine($"Зарплата викладача 2: {salary2}");
}
catch (OkladException ex)
{
    Console.WriteLine(ex.Message);
}
Full_TimeTeacher full_Time = new Full_TimeTeacher("Some Name Some", "Teacher", 12000, 15);
Part_TimeTeacher part_Time = new Part_TimeTeacher("Some some", "Teacher", 6000);
Fizmat.Teachers.Add(full_Time);
Fizmat.Teachers.Add(part_Time);
university.Deps.Add(Fizmat);
