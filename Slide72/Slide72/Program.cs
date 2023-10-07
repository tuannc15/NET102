using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slide72
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            using (Asm_C_2DataContext db = new Asm_C_2DataContext(@"Data Source = TUANNC15\SQLEXPRESS; Initial Catalog = Asm_C#2;Persist Security Info=True;User ID=sa;Password=sa"))
            {
                var students = db.Students.ToList();
                foreach (var item in students)
                {
                    Console.WriteLine(item.Name
                        );
                }

            }

            using (var db = new Asm_C_2DataContext(@"Data Source = TUANNC15\SQLEXPRESS; Initial Catalog = Asm_C#2;Persist Security Info=True;User ID=sa;Password=sa"))
            {
                var lop = new Class()
                {
                    NameClass = "Lớp 4"
                };
                db.Classes.InsertOnSubmit(lop);
                db.SubmitChanges();
                Console.WriteLine("Inserted");
            }

            //using (var db = new ASM1_C2DataContext(@"Data Source = TUANNC15\SQLEXPRESS; Initial Catalog = Asm_C#2;Persist Security Info=True;User ID=sa;Password=sa"))
            //{
            //    var lop = db.Classes
            //        .Where(x => x.IdClass == 7)
            //        .FirstOrDefault();
            //    if (lop != null)
            //    {
            //        lop.NameClass = "Lớp 2A0";
            //        db.SubmitChanges();
            //        Console.WriteLine("Updated");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Khong co lop");
            //    }

            //}

            //using (var db = new ASM1_C2DataContext(@"Data Source = TUANNC15\SQLEXPRESS; Initial Catalog = Asm_C#2;Persist Security Info=True;User ID=sa;Password=sa"))
            //{
            //    var lop = db.Classes
            //        .Where(x => x.IdClass == 4)
            //        .FirstOrDefault();
            //    if (lop != null)
            //    {
            //        db.Classes.DeleteOnSubmit(lop);
            //        db.SubmitChanges();
            //        Console.WriteLine("Deleted");
            //    } else
            //    {
            //        Console.WriteLine("Khong xoa");
            //    }
            //}

            using (var db = new Asm_C_2DataContext(@"Data Source = TUANNC15\SQLEXPRESS; Initial Catalog = Asm_C#2;Persist Security Info=True;User ID=sa;Password=sa"))
            {
                var classes = db.Classes.ToList();
                foreach (var c in classes)
                {
                    Console.WriteLine(c.NameClass);
                }
            }

            using (var db = new Asm_C_2DataContext(@"Data Source = TUANNC15\SQLEXPRESS; Initial Catalog = Asm_C#2;Persist Security Info=True;User ID=sa;Password=sa"))
            {
                var ketQua = from c in db.Classes
                             join s in db.Students
                             on c.IdClass equals s.IdClass
                             select new
                             {
                                 StudentName = s.Name,
                                 ClassName = c.NameClass
                             };

                foreach (var kq in ketQua)
                {
                    Console.WriteLine(kq);
                }
            }

            Console.ReadLine();
        }
    }
}
