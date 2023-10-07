using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class DuLieu
    {
        public static List<Department> departmentList = new List<Department>()
            {
                new Department(){DeptId=1, DeptName="Software"},
                new Department(){DeptId=2,DeptName="Finance"},
                new Department(){DeptId=3,DeptName="Health"},
                new Department(){DeptId=4,DeptName="Hành chính"}
            };
        public static List<Employee> employeeList = new List<Employee>()
            {
                new Employee(){EmpId=1, EmpName="Suresh Dasari", DeptId=1},
                new Employee(){EmpId=2, EmpName="Rohini Alavala", DeptId=1},
                new Employee(){EmpId=3, EmpName="Praveen Alavala", DeptId=2},
                new Employee(){EmpId=4, EmpName="Sateesh Alavala", DeptId=2},
                new Employee(){EmpId=5, EmpName="Nguyễn Chí Phèo", DeptId=4},
                new Employee(){EmpId=6, EmpName="Phạm Thị Nở", DeptId=4},
                new Employee(){EmpId=7, EmpName="Madhav Sai"}
            };
        public static List<int> dataSource1 = new List<int>() { 1, 2, 3, 4, 5, 6 };
        public static List<int> dataSource2 = new List<int>() { 1, 3, 5, 7, 5, 8, 9, 10 };
        public static List<int> dataSource3 = new List<int>() { 1, 2, 3, 2, 4, 4, 5, 6, 3, 4, 5 };
    }
}
