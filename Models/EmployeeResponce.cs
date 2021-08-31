using System.Collections.Generic;

namespace WebApplication.Models
{
    public class EmployeeResponce
    {
        public List<sbyte> employeesData { get; set; }
        public string year { get; set; }
    
        public EmployeeResponce(List<sbyte> numberList, int year)
        {
            employeesData = numberList;
            this.year = year.ToString();
        }
    }
}
