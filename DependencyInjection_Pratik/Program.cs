using DependencyInjection_Pratik;

ITeacher teacher = new Teacher { FirstName = "Ali", LastName = "Yılmaz" };
Classroom classroom = new Classroom(teacher);

classroom.GetTeacherInfo();