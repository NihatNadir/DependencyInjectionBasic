using DependencyInjectionBasic.Concrete;
using DependencyInjectionBasic.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjectionBasic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        [HttpGet]
        public IActionResult Get()
        {
            Teacher teacher = new Teacher();
            teacher.FirstName = "Sertan";
            teacher.LastName = "Bozkuş";

            Classroom classroom = new Classroom(teacher); // Her iki sınıfın metotlarını kullanarak bir Classroom nesnesi oluşturun ve öğretmenin bilgilerini ekrana yazdırın.

            return Ok($"{classroom.GetTeacherInfo()}");

        }

        [HttpGet("/teacher")]
        public IActionResult Teacher(Teacher teacher) // api kısmında oluşturulan teacher nesnesi request
        {
            
            Classroom classroom = new Classroom(teacher); // Her iki sınıfın metotlarını kullanarak bir Classroom nesnesi oluşturun ve öğretmenin bilgilerini ekrana yazdırın.
            return Ok($"{classroom.GetTeacherInfo()}");
        }

        

    }
}
