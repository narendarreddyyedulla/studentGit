using System.ComponentModel.DataAnnotations;

namespace studentGitApi.Model
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public string Email { get; set; }
    }
}
