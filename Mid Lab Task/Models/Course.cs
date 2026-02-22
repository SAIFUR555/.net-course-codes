using Microsoft.AspNetCore.Mvc;

namespace Mid_Lab_Task.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Credit { get; set; }
        public int Semester { get; set; }
    }
}
