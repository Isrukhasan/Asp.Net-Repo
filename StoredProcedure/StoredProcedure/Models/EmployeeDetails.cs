using System.ComponentModel.DataAnnotations;

namespace StoredProcedure.Models
{
    public class EmployeeDetails
    {
        [Key]
        public int EmployeeId { get; set; }        
        public string EmpFullName { get; set; }
        public string EmpGender { get; set; }
        //public DateTime? EmpBirthDate { get; set; }
        public DateTime? EmpJoiningDate { get; set; }
        public string EmpMobileNumber { get; set; }
        public string EmpEmailAddress { get; set; }
        public string EmpPicture { get; set; }
        public string BranchName { get; set; }
        public string DepartmentName { get; set; }
    }
}
