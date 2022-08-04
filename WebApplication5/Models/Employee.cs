using System.ComponentModel.DataAnnotations;

namespace WebApplication5.Models
{
    public class Employee
    {
        [Key]
        public int eId { get; set; }
        public string eName { get; set; }
        public int salary { get; set; }
    }
}