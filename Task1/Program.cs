using Task1;

var std1 = new Student("Sulaymon","Sani");
std1.SetAddress("Zarafshon");
std1.AddCourseGrade("C#",1,20);
std1.AddCourseGrade("JS",2,21);
std1.AddCourseGrade("C++",3,40);
System.Console.WriteLine(std1.GetName());
std1.PrintCourses();
System.Console.WriteLine(std1.GetAverageGrades());
System.Console.WriteLine(std1.ToString());

var tchr1 = new Teacher("Alijon","Mardon 46mkr");
tchr1.AddCourse("C++",2);
tchr1.GetCourses();