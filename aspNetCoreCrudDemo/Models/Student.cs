using System.ComponentModel.DataAnnotations;
namespace aspNetCoreCrudDemo.Models
{
    public class Student
    {
        [Key]
        [Display(Name="Student ID")]
        public int StudentID { get; set; }
        
        [Required]
        [Display(Name="Student Name")]
        public string Name { get; set; }
  
        public string Email { get; set; }
        
        public string Course { get; set; }
        
        [Required]
        [Display(Name = "Student Name")]
        public DateTime EnrollmentDate { get; set; }
    }
}
