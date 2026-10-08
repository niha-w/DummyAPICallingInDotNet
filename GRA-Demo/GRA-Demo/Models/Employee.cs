namespace GRA_Demo.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmpName { get; set; }
        public Designation EmpDesignation { get; set; }
    
        public enum Designation
        {
            JrITHelp,
            SrITHelp,
            HeadOfIT
        }
    }
}
