using DependencyInjectionBasic.Abstract;
using DependencyInjectionBasic.Concrete;
using System.Reflection.Metadata;

namespace DependencyInjectionBasic.Data
{
    public class Teacher : ITeacher
    {
        // Teacher sınıfı        

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string GetInfo()
        {
            return (FirstName + " " + LastName);
        }
    }
}
