using Microsoft.Extensions.Options;
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
        public string Task {  get; set; } //primary key 

        public int DueDate { get; set; }

        public int Quadrant { get; set; }

        public string Category { get; set; }

        public bool Completed { get; set; }
    }
}
