using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace CRUD.Models
{
    public class EmployeeModel
    {
        public int EmpID { get; set; }
        [DisplayName("Dept Name")]

        public string DeptName { get; set; }
        [DisplayName("Employee Name")]

        public string EmployeeName { get; set; }

        public decimal Salary { get; set; }
    }
}