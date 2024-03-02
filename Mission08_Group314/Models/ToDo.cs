using Microsoft.Extensions.Options;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Net.Security;

namespace Mission08_Group314.Models
{
    public class ToDo
    {
        //Build an app that allow the users to enter tasks with the following information:
        //Task(Required)
        //Due Date
        //Quadrant(Required)
        //Category(Dropdown containing options: Home, School, Work, Church)
        //Completed(True/False)

        [Key]
        [Required]
        public int TaskId { get; set; } // Primary Key
        
        [Required]
        public string? Task {  get; set; } 
        public string? DueDate { get; set; }

        // [Required]
        public int? Quadrant { get; set; }

        public string? Category { get; set; }

        public bool? Completed { get; set; }
    }
}
