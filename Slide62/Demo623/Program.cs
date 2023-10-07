using Data;
using System.Text;

namespace Demo623
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            var result = from d in DuLieu.departmentList
                         join e in DuLieu.employeeList
                         on d.DeptId equals e.DeptId into empDept
                         select new
                         {
                             DepartmentName = d.DeptName,
                             employees = from emp in DuLieu.employeeList
                                         where emp.DeptId.Equals(d.DeptId)
                                         orderby emp.EmpName
                                         select emp
                         };
            int totalItems;
            foreach (var empGroup in result)
            {
                totalItems = 0;
                Console.WriteLine(empGroup.DepartmentName);
                foreach (var item in empGroup.employees)
                {
                    totalItems++;
                    Console.WriteLine($"{totalItems}    {item.EmpName}");
                }
            }
            Console.ReadKey();
        }
    }
}