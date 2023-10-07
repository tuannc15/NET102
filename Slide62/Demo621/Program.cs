using System.Text;

namespace Demo621
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            List<Department> departmentList = new List<Department>()
            {
                new Department(){DeptId=1, DeptName="Software"},
                new Department(){DeptId=2,DeptName="Finance"},
                new Department(){DeptId=3,DeptName="Health"}
            };
            List<Employee> employeeList = new List<Employee>()
            {
                new Employee(){EmpId=1, EmpName="Suresh Dasari", DeptId=1},
                new Employee(){EmpId=2, EmpName="Rohini Alavala", DeptId=1},
                new Employee(){EmpId=3, EmpName="Praveen Alavala", DeptId=2},
                new Employee(){EmpId=4, EmpName="Sateesh Alavala", DeptId=2},
                new Employee(){EmpId=5, EmpName="Chí Phèo", DeptId=3},
                new Employee(){EmpId=5, EmpName="Madhav Sai"}
            };

            var result = from d in departmentList
                         join e in employeeList
                         on d.DeptId equals e.DeptId
                         select new
                         {
                             DeptName = d.DeptName,
                             EmpName = e.EmpName,
                         };
            foreach (var d in result)
            {
                Console.WriteLine(d.EmpName + "\t| " + d.DeptName);
            }
            Console.WriteLine();
            //var result2 = from emp in employeeList
            //              join dept in departmentList
            //              on emp.DeptId equals dept.DeptId into empDept
            //              from ed in empDept.DefaultIfEmpty()
            //              select new
            //              {
            //                  EmployeeName = emp.EmpName,
            //                  DepartmentName = ed == null ? "No Department" : ed.DeptName
            //              };
            //foreach (var item in result2)
            //{
            //    Console.WriteLine(item.EmployeeName + "\t" + item.DepartmentName);
            //}

            Console.ReadKey();
        }
    }
}