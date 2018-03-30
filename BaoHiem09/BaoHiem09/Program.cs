using System;
using System.Linq;

namespace BaoHiem09
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Một Công ty bảo hiểm cần quản lý thông tin về các nhân viên cũng như các bảo hiểm mà các nhân viên bán được. 
             Với nhân viên, cần quản lý : tên, hệ số lương, các bảo hiểm bán được. 
             Với bảo hiểm ngắn hạn cần quản lý : tên người mua, thời hạn(mấy tháng), số tiền phải đóng. 
             Nhân viên sẽ được hưởng tiền hoa hồng bằng 5% số tiền.
             Với loại bảo hiểm dài hạn cần quản lý: tên người mua, thời hạn(trên 12 tháng), số tiền phải đóng, số tiền đóng hàng tháng.
             Nhân viên sẽ được hưởng 50% số tiền đóng 1 tháng.

             Ngoài ra công ty quy định:

             -Thuởng 100USD cho những nhân viên bán ít nhất một bảo hiểm trên 10000USD.
             -Nhân viên nào có tổng số tiền bán <10000USD sẽ bị phạt 30USD.
             -Lương nhân viên được tính theo công thức:
             40*hệ số lương + 1%(tổng tiền các bảo hiểm của nhân viên đó - tiền hoa hồng).
             Hãy xây dựng các lớp đối tượng tương ứng để quản lý cho công ty trên và viết một ứng dụng có nhiệm vụ như sau:

             +Nhập danh sách các nhân viên và các bảo hiểm họ bán được.
             +Xuất Thông tin các nhân viên ( Gồm cả lương) và các bảo hiểm họ bán được.
             +Xuất danh sách các nhân viên có tiền hoa hồng > 50USD.
             +Xuất danh sách các nhân viên bị phạt tiền.
             +Xuất danh sách các nhân viên được thưởng 100USD.

                Lớp nhân viên : Id, Name, SalaryRatio, Commission,
             */

            
            Company company = new Company();

            
            company.DSEmployee.Add(new Employee(001, "Tran Van Huu", 2000));
            company.DSEmployee.Add(new Employee(002, "Tran", 3000));
            company.DSEmployee.Add(new Employee(003, "Tran Nhuan", 400));
            company.DSEmployee.Add(new Employee(004, "Tran Ly", 1000));
            company.DSEmployee.Add(new Employee(005, "Tran Van", 20000));

            //company.AddInCo();
            company.AddInCo(1, 1, "Lan", 12, 1200);
            company.AddInCo(1, 2, "Minh", 20, 10000);
            company.AddInCo(1, 3, "Hong", 4, 700);
            company.AddInCo(2, 1, "Xinh", 12, 1200);
            company.AddInCo(3, 1, "Minh", 12, 1200);
            //company.DSEmployee[0].SaleInCo();

            company.Display();

            company.DisplayEmployeeCommissionOver(50);

            company.DisplayEmployeeIsPunish();

            company.DisplayEmployeeIsBonus();

            Console.ReadLine();

        }
    }
}
