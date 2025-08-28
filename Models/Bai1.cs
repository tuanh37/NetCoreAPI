using System;

namespace DemoMVC.Models
{
    public class Bai1
    {
        public string FullName { get; set; }
        public string Address { get; set; }
        public int BirthYear { get; set; }

        public int Age => DateTime.Now.Year - BirthYear;
    }
}
