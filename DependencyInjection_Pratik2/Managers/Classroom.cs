using DependencyInjection_Pratik2.Services;

namespace DependencyInjection_Pratik2.Managers
{
    public class Classroom
    {

            private readonly ITeacher _teacher;

            public Classroom(ITeacher teacher)
            {
                _teacher = teacher;
            }

            public string GetTeacherInfo()
            {
                _teacher.GetInfo();
            }

        }
    }

