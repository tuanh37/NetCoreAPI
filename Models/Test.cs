
namespace DemoMVC.Models
{
    public class Test
    {
        public string FullName { get; set; }

        public int BirthYear { get; set; }


        public int Age()
        { return DateTime.Now.Year - BirthYear; }
}
}