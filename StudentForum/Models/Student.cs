using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace StudentForum.Models
{
    public class Student
    {
        public Student()
        {
            CreationDate = DateTime.Today;
            LastUpdateDate = DateTime.Now;
        }
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        public string Department { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }
        public decimal Height { get; set; }
        public decimal Weight { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public int Age
        {
            get
            {
                DateTime now = DateTime.Today;
                int age = now.Year - BirthDate.Year;
                return age;
            }
        }
    }
}
