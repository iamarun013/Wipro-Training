using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class StudentController : Controller
    {
        public string Index()
        {
            return "This is the Index Action";
        }

        // GET: /Student/GetStudentName
        public string GetStudentName()
        {
            return "Student Name: John Doe";
        }

        // GET: /Student/GetStudentPhone
        public string GetStudentPhone()
        {
            return "Student Phone: 123-456-7890";
        }
    }
}
