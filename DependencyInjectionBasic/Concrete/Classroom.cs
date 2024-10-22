using DependencyInjectionBasic.Abstract;
using DependencyInjectionBasic.Data;
using System.Reflection.Metadata;

namespace DependencyInjectionBasic.Concrete
{
    public class Classroom
    {
        // Classroom sınıfı
        

        

        private Teacher _teacher { get; set; }

        public Classroom(Teacher teacher) // ClassRoom sınıfının yapıcısına(constructor) Teacher sınıfının bir örneğini parametre olarak geçin. (Constructor Injection)
        {
            _teacher = teacher;
        }

        public string GetTeacherInfo() 
        {
            return _teacher.GetInfo(); 
        }

        

    }
}
