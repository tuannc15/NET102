using Data;
using System.Text;


namespace Demo622
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;
            var result2 = from emp in DuLieu.employeeList
                          join dept in DuLieu.departmentList
                          on emp.DeptId equals dept.DeptId into empDept
                          from ed in empDept.DefaultIfEmpty()
                          select new
                          {
                              EmployeeName = emp.EmpName,
                              DepartmentName = ed == null ? "No Department" : ed.DeptName
                          };
            foreach (var item in result2)
            {
                Console.WriteLine(item.EmployeeName + "\t" + item.DepartmentName);
            }
            Console.ReadKey();
        }
    }
}