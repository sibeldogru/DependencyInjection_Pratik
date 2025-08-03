namespace DependencyInjection_Pratik2.Managers;
using DependencyInjection_Pratik2.Services;

    public class Teacher : ITeacher
    {
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public string GetInfo()
    {
        return $"Öğretmenin adı {FirstName} {LastName}";
    }

    }

