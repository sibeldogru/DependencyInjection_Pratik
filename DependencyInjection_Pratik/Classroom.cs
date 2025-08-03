using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection_Pratik
{
    public class Classroom
    {

        private readonly ITeacher _teacher;

        public Classroom(ITeacher teacher)
        {
            _teacher = teacher; 
        }

        public void GetTeacherInfo()
        {
            _teacher.GetInfo();
        }

    }
}
